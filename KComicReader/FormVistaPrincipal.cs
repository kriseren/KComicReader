using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Formulario que contiene la vista principal del programa.
    /// </summary>
    public partial class FormVistaPrincipal : Form
    {
        /// <summary>
        /// El control personalizado del cómic seleccionado por el usuario.
        /// </summary>
        private Comic comicSeleccionado;

        /// <summary>
        /// Constructor sin parámetros que inicializa el componente.
        /// </summary>
        public FormVistaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void PbBtnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarComic formAgregar = new FormAgregarComic();
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                //Obtengo el comic, defino un controlador de eventos click y lo agrego al flowLayout.
                Comic comic = formAgregar.comic;
                comic.EventoClick += new EventHandler(Comic_Click);
                comic.EventoDobleClick += new EventHandler(BtnLeer_Click);
                //Almaceno el comic en la base de datos.
                comic.Guarda();
                //Agrego el cómic al fwp.
                this.fwpComics.Controls.Add(comic);
                //Ordeno los cómics por título.
                OrdenaComicsPorTitulo();
                //Cargo todas las categorías.
                CargaCategorias();
                //Cargo todas las series.
                CargaSeries();
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa encima de un cómic.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Comic_Click(object sender, EventArgs e)
        {
            //Creo el objeto cómic y defino todas las etiquetas de información.
            comicSeleccionado = (Comic)sender;

            //Obtengo los valores del nombre de las claves ajenas.
            if (Config.CompruebaConexion())
            {
                using (MySqlConnection connection = DataBaseConnectivity.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = @"SELECT EDITORIALES.nombre as editorial, SERIES.nombre as serie, CATEGORIAS.nombre as categoria, IDIOMAS.nombre as idioma FROM COMICS
                                            JOIN EDITORIALES ON EDITORIALES.id = COMICS.editorial_id
                                            JOIN SERIES ON SERIES.id = COMICS.serie_id
                                            JOIN CATEGORIAS ON CATEGORIAS.id = COMICS.categoria_id
                                            JOIN IDIOMAS ON IDIOMAS.id = COMICS.idioma_id
                                            WHERE COMICS.id = @id;";
                        command.Parameters.AddWithValue("@id", comicSeleccionado.Id);
                        command.Prepare();
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comicSeleccionado.Editorial = reader.GetString("editorial");
                            comicSeleccionado.Idioma = reader.GetString("idioma");
                            comicSeleccionado.Serie = reader.GetString("serie");
                            comicSeleccionado.Categoria = reader.GetString("categoria");
                        }
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se ha podido recuperar la información de los campos categoría, editorial, idioma y serie.\nPrueba a iniciar el servidor de MYSQL.", "Error al conectar a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            //Defino las propiedades del cómic en el panel de la derecha.
            DefineInfoPanel();

            //Cambio el color del fondo para todos los cómics.
            foreach (Control c in fwpComics.Controls.OfType<Comic>().ToList())
            {
                Comic co = (Comic)c;
                co.BackColor = Color.Transparent;
                co.ForeColor = Color.Black;
                co.QuitaNegrita();
            }
            //Defino el color del fondo y la fuente negrita para el cómic seleccionado dependiendo del tema.
            comicSeleccionado.BackColor = ColorTranslator.FromHtml(Config.Tema[1]);
            comicSeleccionado.PoneNegrita();
            if(Config.Tema_id==8 || Config.Tema_id==11)
                comicSeleccionado.ForeColor = ColorTranslator.FromHtml(Config.Tema[2]);

            //Activo o desactivo los botones de acciones.
            DefineBotonesAcciones();
        }

        /// <summary>
        /// Método que define las propiedades del panel de información de la derecha.
        /// </summary>
        private void DefineInfoPanel()
        {
            //Defino las propiedades en el panel de información.
            lblInfoTituloValue.Text = comicSeleccionado.Titulo;
            lblInfoGuionistaValue.Text = comicSeleccionado.Guionista;
            lblInfoDibujanteValue.Text = comicSeleccionado.Dibujante;
            lblInfoEditorialValue.Text = comicSeleccionado.Editorial;
            lblInfoCategoriaValue.Text = comicSeleccionado.Categoria;
            lblInfoIdiomaValue.Text = comicSeleccionado.Idioma;
            lblInfoSerieValue.Text = comicSeleccionado.Serie;
            lblInfoNumeroValue.Text = comicSeleccionado.Numero.ToString();
            lblInfoNumPaginasValue.Text = comicSeleccionado.NumPaginasTotales.ToString();

            //Muevo el panel al frente para ocultar el de vista vacía.
            panelRightVacia.Visible = false;
            panelRightInfo.BringToFront();
        }

        /// <summary>
        /// Método que define los botones del panel de acciones.
        /// </summary>
        private void DefineBotonesAcciones()
        {
            if(comicSeleccionado!=null)
            {
                //Activo los botones de acciones.
                pbBtnEditar.Visible = true;
                pbBtnLeer.Visible = true;
                pbBtnEliminar.Visible = true;
                pbBtnAyuda.Visible = true;
                lblAgregar.Visible = true;
                lblEditar.Visible = true;
                lblEliminar.Visible = true;
                lblLeer.Visible = true;
                lblAyuda.Visible = true;
            }
            else
            {
                //Activo los botones de acciones.
                pbBtnEditar.Visible = false;
                pbBtnLeer.Visible = false;
                pbBtnEliminar.Visible = false;
                pbBtnAyuda.Visible = true;
                lblEditar.Visible = false;
                lblEliminar.Visible = false;
                lblLeer.Visible = false;
                lblAgregar.Visible = true;
                lblAyuda.Visible = true;
            }
        }

        /// <summary>
        /// Método que ordena los cómics del FlowLayoutPanel por título, para ello almaceno.
        /// </summary>
        private void OrdenaComicsPorTitulo()
        {
            //Creo una variable que almacena los cómics ordenados por título.
            var comics = fwpComics.Controls.OfType<Comic>().OrderBy(x => x.Titulo).ToList();

            //Elimino únicamente los controles del fwp que sean cómics.
            foreach (Comic comic in fwpComics.Controls.OfType<Comic>().ToList())
                fwpComics.Controls.Remove(comic);

            //Agrego de nuevo todos los cómics ordenados por título.
            fwpComics.Controls.AddRange(comics.ToArray());

            //Si hay cómics se muestra la ayuda para agrear el primer comic, sino no.
            if (fwpComics.Controls.OfType<Comic>().Count() > 0)
                fwpComics.Controls[1].Visible = false;
            else
                fwpComics.Controls[1].Visible = true;
        }


        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormVistaPrincipal_Load(object sender, EventArgs e)
        {
            //Defino la configuración y el eventHandler.
            Config.DefineConfiguracion();
            //Obtengo todos los comics dados de alta en la base de datos.
            CargaTodosComics();
            //Los ordeno por título.
            OrdenaComicsPorTitulo();
            //Cargo todas las categorías.
            CargaCategorias();
            //Cargo todas las series.
            CargaSeries();

            //Muestro la vista vacía.
            panelRightVacia.BringToFront();
            panelRightVacia.Visible = true;

            //Agrego un eventHandler al botón de agregar cómic dentro del fwp.
            agregarComicBtn.EventoClick += PbBtnAgregar_Click;

            //Muestro la ventana de bienvenida.
            if (Config.MostrarBienvenida)
            {
                FormBienvenida formBienvenida = new FormBienvenida();
                formBienvenida.ShowDialog();
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de leer cómic.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnLeer_Click(object sender, EventArgs e)
        {
            //Creo un formulario con el cómic seleccionado.
            if (File.Exists(comicSeleccionado.ArchivoURL))
            {
                FormLeer formLeer = new FormLeer(comicSeleccionado);
                formLeer.Show();
            }
            else
            {
                MessageBox.Show("No se encuentra el archivo del cómic.\nPrueba a eliminar el cómic y agregarlo de nuevo a la colección", "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de editar un cómic.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //Creo el formulario y defino sus propiedades.
            FormAgregarComic formEditar = new FormAgregarComic(comicSeleccionado);
            formEditar.lblTituloFormulario.Text = "EDITAR UN CÓMIC EXISTENTE";
            formEditar.Text = "Editar un cómic existente";
            formEditar.btnAgregar.Text = "Guardar";

            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                //Obtengo el comic con los nuevos atributos y lo actualizo en la base de datos.
                comicSeleccionado.Actualiza(formEditar.comic);
                comicSeleccionado = formEditar.comic;

                //Actualizo la información en el panel de info.
                DefineInfoPanel();

                //Elimino el cómic seleccionado del fwp y agrego el nuevo.
                fwpComics.Controls.Remove(comicSeleccionado);
                fwpComics.Controls.Add(formEditar.comic);

                //Cargo las categorías y las series.
                CargaCategorias();
                CargaSeries();

                //Recargo los valores del filtro de categorías o series.
                LbCategorias_Click(sender, e);
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuaro pulsa el botón de eliminar cómic.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void PbBtnEliminar_Click(object sender, EventArgs e)
        {
            
            //Si no se está leyendo se elimina.
            if (!Config.LeyendoComic)
            {
                if (MessageBox.Show("¿Estás segurx de querer eliminar el cómic " + comicSeleccionado.Titulo + "?", "Confirmación de eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (Config.CompruebaConexion())
                    {
                        using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                        {
                            try
                            {
                                con.Open();
                                MySqlCommand cmd = con.CreateCommand();
                                cmd.CommandText = "DELETE FROM comics WHERE titulo = @titulo and serie_id=@serie and editorial_id=@editorial";
                                cmd.Parameters.AddWithValue("@titulo", comicSeleccionado.Titulo);
                                cmd.Parameters.AddWithValue("@serie", comicSeleccionado.SerieID);
                                cmd.Parameters.AddWithValue("@editorial", comicSeleccionado.EditorialID);
                                cmd.Prepare();
                                cmd.ExecuteNonQuery();
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("No se ha podido eliminar el comic. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Console.Write(ex.Message);
                            }
                        }
                    }
                    //Elimino el cómic del fwp.
                    fwpComics.Controls.Remove(comicSeleccionado);
                    

                    //Elimino el fichero del cómic relizando 5 intentos de medio segundo cada uno.
                    if (comicSeleccionado.ArchivoURL != "")
                    {
                        int intentos = 0;
                        bool exito = false;
                        while (!exito && intentos < 5)
                        {
                            try
                            {
                                File.Delete(comicSeleccionado.ArchivoURL);
                                exito = true;
                            }
                            catch (Exception)
                            {
                                intentos++;
                                Thread.Sleep(500);
                            }
                        }
                        if (intentos == 5)
                            MessageBox.Show("No se ha podido eliminar el archivo del cómic. Prueba a eliminarlo a mano desde el directorio de instalación", "Error al eliminar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    //Ordeno los cómics por título.
                    OrdenaComicsPorTitulo();
                    //Cargo las categorías y las series.
                    CargaCategorias();
                    CargaSeries();
                    //Muevo el panel al frente para mostrar el de vista vacía.
                    panelRightVacia.Visible = true;
                    panelRightInfo.SendToBack();
                    //Defino los botones de acciones.
                    comicSeleccionado = null;
                    DefineBotonesAcciones();
                }
            }
            else
            {
                MessageBox.Show("Para poder eliminar un cómic, primero cierra la ventana de leer.", "Error al eliminar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Método que carga en el fwp todos los cómics dados de alta en la base de datos.
        /// </summary>
        private void CargaTodosComics()
        {
            //Elimino los comics que haya en el fwp.
            foreach (Control c in fwpComics.Controls.OfType<Comic>().ToList())
                fwpComics.Controls.Remove(c);

            if (Config.CompruebaConexion())
            {
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    try
                    {
                        //Obtengo la conexión y los objetos necesarios.
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();

                        //Creo la query.
                        cmd.CommandText = "SELECT * FROM COMICS";
                        var reader = cmd.ExecuteReader();

                        Comic c;
                        while (reader.Read())
                        {
                            fwpComics.Controls[1].Visible = false;
                            //Creo el cómic.
                            c = new Comic();
                            //Defino las propiedades.
                            c.Id = reader.GetInt32("id");
                            c.Titulo = reader.GetString("titulo");
                            c.Dibujante = reader.GetString("dibujante");
                            c.Guionista = reader.GetString("guionista");
                            c.Portada = Image.FromStream(reader.GetStream(4));
                            c.ArchivoURL = reader.GetString("archivoURL");
                            c.NumPaginaActual = (uint)reader.GetInt32("numPagina");
                            c.NumPaginasTotales = (uint)reader.GetInt32("numPaginasTotales");
                            c.CategoriaID = reader.GetInt32("categoria_id");
                            c.IdiomaID = reader.GetInt32("idioma_id");
                            c.EditorialID = reader.GetInt32("editorial_id");
                            c.SerieID = reader.GetInt32("serie_id");
                            c.Numero = (uint)reader.GetInt32("numero");

                            //Defino los controladores de los eventos.
                            c.EventoClick += new EventHandler(Comic_Click);
                            c.EventoDobleClick += new EventHandler(BtnLeer_Click);

                            //Lo agrego al fwp.
                            fwpComics.Controls.Add(c);
                        }  
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se han podido recuperar los cómcis dados de alta. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que carga en el listBox todas las categorías dadas de alta.
        /// </summary>
        private void CargaCategorias()
        {
            if (Config.CompruebaConexion())
            {
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        //Categoría.
                        string query = @"SELECT id, nombre 
                                        FROM (
                                            SELECT DISTINCT ca.id, ca.nombre 
                                            FROM CATEGORIAS ca  
                                            INNER JOIN comics c ON c.categoria_id = ca.id
                                            UNION
                                            SELECT cat.id, cat.nombre 
                                            FROM CATEGORIAS cat 
                                            WHERE cat.id = 1
                                        ) AS CATEGORIA
                                        WHERE id = 1
                                        OR id <> 1
                                        ORDER BY id <> 1, nombre;";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        lbCategorias.DataSource = ds.Tables[0];
                        lbCategorias.DisplayMember = "nombre";
                        lbCategorias.ValueMember = "id";
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se han podido recuperar las categorías dadas de alta. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que carga en el listBox todas las series dadas de alta.
        /// </summary>
        private void CargaSeries()
        {
            if (Config.CompruebaConexion())
            {
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        string query = @"SELECT id, nombre 
                                        FROM (
                                            SELECT DISTINCT s.id, s.nombre 
                                            FROM SERIES s  
                                            INNER JOIN comics c ON c.serie_id = s.id
                                            UNION
                                            SELECT se.id, se.nombre 
                                            FROM SERIES se 
                                            WHERE se.id = 1
                                        ) AS SERIE
                                        WHERE id = 1
                                        OR id <> 1
                                        ORDER BY id <> 1, nombre;";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        lbSeries.DataSource = ds.Tables[0];
                        lbSeries.DisplayMember = "nombre";
                        lbSeries.ValueMember = "id";
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se han podido recuperar las series dadas de alta. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el ratón entra en el área visible del botón.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = Config.Hover;
        }

        /// <summary>
        /// Método que se ejecuta cuando el ratón sale del área visible del botón.s
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = null;
        }

        /// <summary>
        /// Método que se ejecuta cuando se hace click encima del ListBox de categorías.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void LbCategorias_Click(object sender, EventArgs e)
        {
            //Si la categoría seleccionada no es nula y es igual a 1 se muestran todos los cómics.
            if (lbCategorias.SelectedValue != null && (int)lbCategorias.SelectedValue == 1)
            {
                CargaTodosComics();
            }
            else
            {
                try
                {
                    //Hago no visibles todos los comics del fwp.
                    foreach (Control co in fwpComics.Controls.OfType<Comic>().ToList())
                        co.Visible = false;
                    //Obtengo todos los cómics con esa categoría y los muestro.
                    foreach (Control co in fwpComics.Controls.OfType<Comic>().ToList())
                    {
                        Comic c = (Comic)co;
                        if (c.CategoriaID == (int)lbCategorias.SelectedValue)
                            c.Visible = true;
                    }

                    //Ordeno los cómics agregados por título.
                    OrdenaComicsPorTitulo();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se han podido recuperar las series dadas de alta. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario hace doble click en el listBox de Series.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void LbSeries_Click(object sender, EventArgs e)
        {
            //Si la serie seleccionada es igual a 1 se muestran todos los cómics.
            if (lbSeries.SelectedValue != null && (int)lbSeries.SelectedValue == 1)
            {
                CargaTodosComics();
            }
            else
            {
                if (Config.CompruebaConexion())
                {
                    using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                    {
                        try
                        {
                            //Hago no visibles todos los comics del fwp.
                            foreach (Control co in fwpComics.Controls.OfType<Comic>().ToList())
                                co.Visible = false;
                            //Obtengo todos los cómics con esa categoría y los muestro.
                            foreach (Control co in fwpComics.Controls.OfType<Comic>().ToList())
                            {
                                Comic c = (Comic)co;
                                if (c.SerieID == (int)lbSeries.SelectedValue)
                                    c.Visible = true;
                            }

                            //Ordeno los cómics agregados por título.
                            OrdenaComicsPorTitulo();
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("No se han podido recuperar las series dadas de alta. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario hace click en el botón de Viñetas Favoritas.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void PbBtnFavoritos_Click(object sender, EventArgs e)
        {
            FormFavoritos formFavoritos = new FormFavoritos();
            formFavoritos.Show();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de Ajustes.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void PbBtnConfig_Click(object sender, EventArgs e)
        {
            //Creo un nuevo formulario Config.
            FormConfig formConfig = new FormConfig();
            //Si el usuario acepta, se actualiza la información en la base de datos.
            if (formConfig.ShowDialog() == DialogResult.OK)
            {
                //Si e directorio no es nulo se define.
                Config.DirectorioInstalacion = formConfig.DirectorioInstalacion;
                Config.Tema_id = formConfig.Tema_id;
                Config.MostrarBienvenida = formConfig.MostrarBienvenida;
                Config.GuardaConfiguracion();
                //Defino los colores de nuevo.
                this.Refresh();
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormVistaPrincipal_Paint(object sender, PaintEventArgs e)
        {
            Config.DefineTema();
            pbThemeIcon.Image = Config.ThemeIcon;
            pbThemeIcon.Enabled = false;

            String[] Tema = Config.Tema;

            if (this.ClientRectangle.Width != 0 || this.ClientRectangle.Height != 0)
            {
                //El fondo se establece como un degradado entre el color 1 y el color 2.
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                    ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
                //Por cada control de tipo panel se define el color 2.
                foreach (Control c in this.Controls.OfType<Panel>().ToList())
                {
                    c.BackColor = ColorTranslator.FromHtml(Tema[2]);
                    //Si el panel contiene elementos label dentro, se define el color 1.
                    if (c.Controls.OfType<Label>().ToList().Count > 0)
                    {
                        //Por cada control que su nombre comience por lblSpec, su color de fondo es el 4.
                        foreach (Control co in c.Controls.OfType<Label>().Where(co => co.Name.StartsWith("lblSpec")))
                        {
                            co.BackColor = ColorTranslator.FromHtml(Tema[1]);

                            //Si el tema es alguno oscuro.
                            if(Config.Tema_id == 8 || Config.Tema_id == 11)
                            {
                                co.ForeColor = ColorTranslator.FromHtml(Tema[2]);
                            }
                            else
                            {
                                co.ForeColor = Color.Black;
                            }
                        }
                    }
                }
                //Cambio el color del fondo para todos los cómics.
                foreach (Control c in fwpComics.Controls)
                    c.BackColor = Color.Transparent;

                //Defino el color del fondo para el cómic seleccionado si éste no es nulo.
                if (comicSeleccionado != null)
                {
                    comicSeleccionado.BackColor = ColorTranslator.FromHtml(Config.Tema[1]);
                    //Si el tema es alguno oscuro.
                    if (Config.Tema_id == 8 || Config.Tema_id == 11)
                        comicSeleccionado.ForeColor = ColorTranslator.FromHtml(Config.Tema[2]);
                    else
                        comicSeleccionado.ForeColor = Color.Black;
                }
            }

            //Si hay cómics se muestra la ayuda, sino no.
            if(fwpComics.Controls.OfType<Comic>().Count()>0)
                fwpComics.Controls[1].Visible = false;
            else
                fwpComics.Controls[1].Visible = true;
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de ayuda.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void PbBtnAyuda_Click(object sender, EventArgs e)
        {
            FormAyuda formAyuda = new FormAyuda();
            formAyuda.Show();
        }
    }
}
