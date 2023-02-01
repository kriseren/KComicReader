﻿using MySql.Data.MySqlClient;
//using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormVistaPrincipal : Form
    {
        //Definición de atributos.
        private Comic comicSeleccionado;

        public FormVistaPrincipal()
        {
            InitializeComponent();
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        private void pbBtnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarComic formAgregar = new FormAgregarComic();
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                //Obtengo el comic, defino un controlador de eventos click y lo agrego al flowLayout.
                Comic comic = formAgregar.comic;
                comic.eventoClick += new EventHandler(Comic_Click);
                comic.eventoDobleClick += new EventHandler(btnLeer_Click);
                //Almaceno el comic en la base de datos.
                comic.guarda();
                //Agrego el cómic al fwp.
                this.fwpComics.Controls.Add(comic);
                //Ordeno los cómics por título.
                ordenaComicsPorTitulo();
                //Cargo todas las categorías.
                cargaCategorias();
                //Cargo todas las series.
                cargaSeries();
            }
        }

        //Método que se ejecuta cuando el usuario pulsa encima de un cómic.
        private void Comic_Click(object sender, EventArgs e)
        {
            //Creo el objeto cómic y defino todas las etiquetas de información.
            comicSeleccionado = (Comic)sender;

            //Obtengo los valores del nombre de las claves ajenas.
            using (MySqlConnection connection = DataBaseConnectivity.getConnection())
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
            

            //Defino las propiedades en el panel de información.
            lblInfoTituloValue.Text = comicSeleccionado.Titulo;
            lblInfoGuionistaValue.Text = comicSeleccionado.Guionista;
            lblInfoDibujanteValue.Text = comicSeleccionado.Dibujante;
            lblInfoEditorialValue.Text = comicSeleccionado.Editorial;
            lblInfoCategoriaValue.Text = comicSeleccionado.Categoria;
            lblInfoIdiomaValue.Text = comicSeleccionado.Idioma;
            lblInfoSerieValue.Text = comicSeleccionado.Serie;

            //Muevo el panel al frente para ocultar el de vista vacía.
            panelRightVacia.Visible = false;
            panelRightInfo.BringToFront();

            //Cambio el color del fondo para todos los cómics.
            foreach( Control c in fwpComics.Controls)
            {
                c.BackColor = Color.Transparent;
            }
            //Defino el color del fondo para el cómic seleccionado.
            comicSeleccionado.BackColor = Color.FromArgb(177, 140, 217);

            //Activo los botones de acciones.
            pbBtnEditar.Visible = true;
            pbBtnEditar.Enabled = true;
            pbBtnLeer.Visible = true;
            pbBtnLeer.Enabled = true;
            pbBtnEliminar.Visible = true;
            pbBtnEliminar.Enabled = true;
            lblAgregar.Visible = true;
            lblAgregar.Enabled = true;
            lblEditar.Visible = true;
            lblEditar.Enabled = true;
            lblEliminar.Visible = true;
            lblEliminar.Enabled = true;
            lblLeer.Visible = true;
            lblLeer.Enabled = true;
        }

        //Método que ordena los cómics del FlowLayoutPanel por título, para ello almaceno.
        private void ordenaComicsPorTitulo()
        {
            //Creo una variable que almacena los cómics ordenados por título.
            var comics = fwpComics.Controls.OfType<Comic>().OrderBy(x => x.Titulo).ToList();

            //Elimino únicamente los controles del fwp que sean cómics.
            foreach (Comic comic in fwpComics.Controls.OfType<Comic>().ToList())
                fwpComics.Controls.Remove(comic);

            //Agrego de nuevo todos los cómics ordenados por título.
            fwpComics.Controls.AddRange(comics.ToArray());
        }


        //Método que se ejecuta cuando se carga el formulario.
        private void FormVistaPrincipal_Load(object sender, EventArgs e)
        {
            //Se comprueba que la base de datos exista En caso contrario se crea mediante un script.
            if(existeDB())
            {
                //Carga la configuración de la base de datos.
                Config.DefineConfiguracion();
                //Obtengo todos los comics dados de alta en la base de datos.
                cargaTodosComics();
                //Los ordeno por título.
                ordenaComicsPorTitulo();
                //Cargo todas las categorías.
                cargaCategorias();
                //Cargo todas las series.
                cargaSeries();
            }
            else
            {
                string connectionString = "server=localhost;user=root;password=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        //Creo el script cargando el fichero y lo ejecuto.
                        MySqlScript script = new MySqlScript(connection, File.ReadAllText(@"..\..\scripts\scriptCreacion.sql"));
                        script.Execute();
                    }
                    catch(MySqlException)
                    {
                        MessageBox.Show("No se ha podido crear la base de datos","Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            //Muestro la vista vacía.
            panelRightVacia.BringToFront();
            panelRightVacia.Visible = true;

            //Agrego un eventHandler al botón de agregar cómic dentro del fwp.
            agregarComicBtn.eventoClick += pbBtnAgregar_Click;
        }

        //Método que comprueba si la base de datos existe, de lo contrario se crea.
        private bool existeDB()
        {
            bool existe = false;
            string connectionString = "Server=localhost;Database=information_schema;Uid=root;Pwd=;";
            string db = "kcomicreader";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) FROM information_schema.schemata WHERE schema_name = '{db}'", connection);
                    existe = Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos.\nPrueba a iniciar el servidor de MYSQL.", "Error al conectar a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return existe;
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de leer cómic.
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Creo un formulario con el cómic seleccionado.
            if(File.Exists(comicSeleccionado.ArchivoURL))
            {
                FormLeer formLeer = new FormLeer(comicSeleccionado);
                formLeer.Show();
            }
            else
            {
                MessageBox.Show("No se encuentra el archivo del cómic.\nPrueba a eliminar el cómic y agregarlo de nuevo a la colección", "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de editar un cómic.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Creo el formulario y defino sus propiedades.
            FormAgregarComic formEditar = new FormAgregarComic(comicSeleccionado);
            formEditar.lblTituloFormulario.Text = "EDITAR UN CÓMIC EXISTENTE";
            formEditar.Text = "Editar un cómic existente";
            formEditar.btnAgregar.Text = "Guardar";

            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                //Obtengo el comic con los nuevos atributos y lo actualizo en la base de datos.
                comicSeleccionado.actualiza(formEditar.comic);

                //Elimino el cómic seleccionado del fwp y agrego el nuevo.
                fwpComics.Controls.Remove(comicSeleccionado);
                fwpComics.Controls.Add(formEditar.comic);

                //Ordeno los cómics por título.
                ordenaComicsPorTitulo();
            }
        }

        //Método que carga en el fwp todos los cómics dados de alta en la base de datos.
        private void cargaTodosComics()
        {
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
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
                        c.eventoClick += new EventHandler(Comic_Click);
                        c.eventoDobleClick += new EventHandler(btnLeer_Click);

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

        //Método que carga en el listBox todas las categorías dadas de alta.
        private void cargaCategorias()
        {
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    //Categoría.
                    string query = "SELECT id, nombre FROM CATEGORIAS ORDER BY nombre";
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

        //Método que carga en el listBox todas las series dadas de alta.
        private void cargaSeries()
        {
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    string query = "SELECT id, nombre FROM SERIES ORDER BY nombre";
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

        //Método que se ejecuta cuando el ratón entra en el área visible del botón.
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = Image.FromFile(@"..\..\imgs\icons\hover.png");
        }

        //Método que se ejecuta cuando el ratón sale del área visible del botón.
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = null;
        }

        //Método que se ejecuta cuando se hace doble click encima del ListBox de categorías.
        private void lbCategorias_DoubleClick(object sender, EventArgs e)
        {
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
            {
                try
                {
                    //Elimino los cómics actuales del fwp.
                    fwpComics.Controls.Clear();
                    //Obtengo todos los cómics con esa categoría.
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM COMICS WHERE categoria_id = @categoria_id";
                    cmd.Parameters.AddWithValue("@categoria_id", lbCategorias.SelectedValue);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    Comic c;
                    while (reader.Read())
                    {
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
                        c.eventoClick += new EventHandler(Comic_Click);
                        c.eventoDobleClick += new EventHandler(btnLeer_Click);

                        //Lo agrego al fwp.
                        fwpComics.Controls.Add(c);
                    }

                    //Ordeno los cómics agregados por título.
                    ordenaComicsPorTitulo();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se han podido recuperar las series dadas de alta. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Método que se ejecuta cuando el usuario hace doble click en el listBox de Series.
        private void lbSeries_DoubleClick(object sender, EventArgs e)
        {
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
            {
                try
                {
                    //Elimino los cómics actuales del fwp.
                    fwpComics.Controls.Clear();
                    //Obtengo todos los cómics con esa categoría.
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM COMICS WHERE serie_id = @serie_id";
                    cmd.Parameters.AddWithValue("@serie_id", lbSeries.SelectedValue);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    Comic c;
                    while (reader.Read())
                    {
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
                        c.eventoClick += new EventHandler(Comic_Click);
                        c.eventoDobleClick += new EventHandler(btnLeer_Click);

                        //Lo agrego al fwp.
                        fwpComics.Controls.Add(c);
                    }

                    //Ordeno los cómics agregados por título.
                    ordenaComicsPorTitulo();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se han podido recuperar las series dadas de alta. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de Ajustes.
        private void pbBtnConfig_Click(object sender, EventArgs e)
        {
            //Creo un nuevo formulario Config.
            FormConfig formConfig = new FormConfig();
            //Si el usuario acepta, se actualiza la información en la base de datos.
            if(formConfig.ShowDialog()==DialogResult.OK)
            {
                //Si e directorio no es nulo se define.
                Config.DirectorioInstalacion = formConfig.DirectorioInstalacion;
                Config.ColorFondo1 = formConfig.ColorFondo1;
                Config.ColorFondo2 = formConfig.ColorFondo2;
                Config.GuardaConfiguracion();
                //Defino los colores de nuevo.
                this.Refresh();
            }
        }

        //Método que se ejecuta cuando se pinta el formulario.
        private void FormVistaPrincipal_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml(Config.ColorFondo1),
                ColorTranslator.FromHtml(Config.ColorFondo2), 90f);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }
    }
}
