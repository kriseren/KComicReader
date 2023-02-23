
using MySql.Data.MySqlClient;
using SharpCompress.Archives;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Formulario que permite agregar un cómic a la base de datos.
    /// </summary>
    public partial class FormAgregarComic : Form
    {
        /// <summary>
        /// Es un control personalizad de tipo cómic.
        /// </summary>
        public Comic comic = new Comic();

        /// <summary>
        /// El control que permite abrir el diálogo de selección de fichero.
        /// </summary>
        private OpenFileDialog ofd_FicheroComic;
        private static bool Comprobando = false;

        /// <summary>
        /// Constructor sin parámetros que inicializa el componente.
        /// </summary>
        public FormAgregarComic()
        {
            InitializeComponent();
            this.CenterToParent();
            ofd_FicheroComic = new OpenFileDialog();
        }

        /// <summary>
        /// Constructor con parámetros que carga los valores de un cómic.
        /// </summary>
        /// <param name="c">El objeto cómic del cual se extraerán los datos para rellenar el formulario.</param>
        public FormAgregarComic(Comic c)
        {
            InitializeComponent();
            this.CenterToParent();
            this.comic = c;
            ofd_FicheroComic = new OpenFileDialog();
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormAgregarComic_Load(object sender, EventArgs e)
        {
            //Defino las opciones de todos los campos de combo Box.
            DefineOpciones();

            //Defino todas las propiedades según los datos del cómic.
            tbTitulo.Text = comic.Titulo;
            cbEditorial.SelectedValue = comic.EditorialID;
            nbNumero.Value = comic.Numero;
            cbSerie.SelectedValue = comic.SerieID;
            tbGuionista.Text = comic.Guionista;
            tbDibujante.Text = comic.Dibujante;
            cbCategoria.Text = comic.Categoria;
            cbIdioma.Text = comic.Idioma;
            pbPortada.Image = comic.Portada;
            ofd_FicheroComic.FileName = comic.ArchivoURL;
        }

        /// <summary>
        /// Método que se activa cuando se pulsa el botón de seleccionar archivo.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnArchivo_Click(object sender, EventArgs e)
        {
            //Creo un OpenFileDialog y le defino las propiedades.
            ofd_FicheroComic.Filter = "Fichero CBR (*.cbr)|*.cbr";
            ofd_FicheroComic.Title = "Selecciona el archivo del cómic a importar.";

            if (ofd_FicheroComic.ShowDialog() == DialogResult.OK)
            {
                //Almaceno la url del fichero en las variables.
                comic.ArchivoURL = ofd_FicheroComic.FileName;

                //Extraigo la portada y la muestro. 
                pbPortada.Image = ExtraePortada(comic.ArchivoURL);

                //Defino el título del cómic para ayudar al usuario si éste no ha definido un título.
                if(tbTitulo.Text.Length < 1)
                    tbTitulo.Text = ofd_FicheroComic.SafeFileName.Split('.')[0];
            }
        }

        /// <summary>
        /// Método que se activa cuando el usuario pulsa el botón de agregar el cómic.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Comprobando = true;
            //Si todos los campos obligatorios han sido rellenados, sino se informa al usuario y se cambia su color para mayor claridad.
            if (tbTitulo.Text != "" && cbIdioma.Text != "" && ofd_FicheroComic.FileName != "" && cbEditorial.Text != "" && cbSerie.Text != "")
            {
                //Ruta del directorio donde se guardará el cómic.
                string rutaDirectorio = Path.Combine(Config.DirectorioInstalacion,"comics");

                //Crea el directorio si no existe.
                if (!Directory.Exists(rutaDirectorio))
                    Directory.CreateDirectory(rutaDirectorio);

                //Copio el archivo de cómic al directorio especificado si no existe ya.
                if (!File.Exists(Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL))))
                    File.Copy(comic.ArchivoURL, Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL)));

                //Defino las propiedades del cómic si los valores no son nulos.
                comic.Titulo = tbTitulo.Text;
                comic.Editorial = cbEditorial.Text; 
                comic.EditorialID = (int)cbEditorial.SelectedValue;
                comic.Serie = cbSerie.Text;
                comic.SerieID = (int)cbSerie.SelectedValue;
                comic.Portada = pbPortada.Image;
                comic.Guionista = tbGuionista.Text;
                comic.Dibujante = tbDibujante.Text;
                comic.Categoria = cbCategoria.Text;
                comic.CategoriaID = (int)cbCategoria.SelectedValue;
                comic.Idioma = cbIdioma.Text;
                comic.IdiomaID = (int)cbIdioma.SelectedValue;
                comic.ArchivoURL = Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL));
                comic.NumPaginasTotales = (uint)ArchiveFactory.Open(comic.ArchivoURL).Entries.Count();
                comic.Numero = (uint)nbNumero.Value;

                //Defino el dialogresult del botón.
                btnAgregar.DialogResult = DialogResult.OK;
                //Dejo de comprobar.
                Comprobando = false;
            }
            else
            {
                //Se cambia la fuente, el color y se agrega un asterisco a todos los controles que sean requeridos.
                foreach(Control c in this.Controls.OfType<Label>().ToList())
                {
                    Label l = (Label)c;

                    if(l.Tag!=null && l.Tag.Equals("Required"))
                    {
                        l.ForeColor = Color.DarkRed;
                        l.Font = new Font(l.Font, FontStyle.Bold);
                        l.Text = l.Text + "*";
                    }
                }
                MessageBox.Show(this, "Los campos marcados con un asterisco son obligatorios.\nPor favor rellénalos antes de agregar un nuevo cómic.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Método que extrae la primera imagen de un archivo .CBR y la devuelve.
        /// </summary>
        /// <param name="archivoURL">La ruta al archivo CBR del que se va a extraer la portada.</param>
        /// <returns>La imagen de la portada.</returns>
        private Image ExtraePortada(string archivoURL)
        {
            Image imagen = null;
            try
            {
                //Abro el arhivo.
                IArchive archive = ArchiveFactory.Open(archivoURL);
                //Obtengo el primer elemento y lo almaceno en la variable imagen.
                IArchiveEntry portada = archive.Entries.First();
                //Intento definir la imagen, si da error se informa al usuario.
                try
                {
                    imagen = Image.FromStream(portada.OpenEntryStream());
                }
                catch (ArgumentException)
                {
                    imagen = Image.FromFile(Path.Combine(Config.Recursos, "imgs", "icons", "comicCover.png"));
                    MessageBox.Show("Ha ocurrido un error al abrir el archivo. Por favor, selecciona otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el archivo. Por favor, selecciona otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return imagen;
        }



        /// <summary>
        /// Método que se ejecuta cuando se pulsa el botón de agregar una nueva editorial.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnAgregarEditorial_Click(object sender, EventArgs e)
        {
            //Creo el formulario en modo agregar una editorial.
            FormAgregarEditorial formAgregarEditorial = new FormAgregarEditorial();
            //Si el usuario acepta, se inserta la editorial.
            if (formAgregarEditorial.ShowDialog() == DialogResult.OK)
            {
                if (Config.CompruebaConexion())
                {
                    //Creo la conexión y los objetos necesarios.
                    using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                    {
                        try
                        {
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();

                            //Defino la consulta para insertar la editorial.
                            cmd.CommandText = "INSERT INTO EDITORIALES (nombre) VALUES (@nombre)";
                            cmd.Parameters.AddWithValue("@nombre", formAgregarEditorial.tbNombre.Text);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("No se ha podido insertar la nueva editorial.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //Actualizo los campos del comboBox de las editoriales.
                DefineOpciones();
            }
        }

        /// <summary>
        /// Método que se conecta a la base de datos para definir las diferentes opciones de los comboBox.
        /// </summary>
        private void DefineOpciones()
        {
            if (Config.CompruebaConexion())
            {
                //Defino las opciones de los comboBox haciendo una consulta a la base de datos.
                try
                {
                    DefineEditoriales();
                    DefineSeries();
                    DefineCategorias();
                    DefineIdiomas();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al conectar a la base de datos y obtener las categorías, editoriales e idiomas. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método que define las opciones del comboBox de series.
        /// </summary>
        private void DefineSeries()
        {
            if (Config.CompruebaConexion())
            {
                //Obtengo la conexión y los objetos necesarios.
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    //Defino las opciones de los comboBox haciendo una consulta a la base de datos.
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT id, nombre FROM SERIES WHERE editorial_id = @editorial_id AND id>1 ORDER BY nombre";
                        cmd.Parameters.AddWithValue("@editorial_id", (int)cbEditorial.SelectedValue);
                        cmd.Prepare();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cbSerie.DataSource = ds.Tables[0];
                        cbSerie.DisplayMember = "nombre";
                        cbSerie.ValueMember = "id";
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se han podido obtener las series. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que define las opciones del comboBox de editoriales.
        /// </summary>
        private void DefineEditoriales()
        {
            if (Config.CompruebaConexion())
            {
                //Obtengo la conexión y los objetos necesarios.
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    //Defino las opciones de los comboBox haciendo una consulta a la base de datos.
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        //Editoriales.
                        string query = "SELECT id, nombre FROM EDITORIALES ORDER BY nombre";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cbEditorial.DataSource = ds.Tables[0];
                        cbEditorial.DisplayMember = "nombre";
                        cbEditorial.ValueMember = "id";

                        //Defino el valor seleccionado de la Editorial para que el campo Serie pueda seleccionar su valor.
                        if (comic.EditorialID != 0)
                            cbEditorial.SelectedValue = comic.EditorialID;
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se han podido obtener las editoriales. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que define las opciones del comboBox de categorías.
        /// </summary>
        private void DefineCategorias()
        {
            if (Config.CompruebaConexion())
            {
                //Obtengo la conexión y los objetos necesarios.
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    //Defino las opciones de los comboBox haciendo una consulta a la base de datos.
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        //Categoría.
                        string query = "SELECT id, nombre FROM CATEGORIAS WHERE id>1 ORDER BY nombre";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cbCategoria.DataSource = ds.Tables[0];
                        cbCategoria.DisplayMember = "nombre";
                        cbCategoria.ValueMember = "id";
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se han podido obtener las categorías. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que define las opciones del comboBox de idiomas.
        /// </summary>
        private void DefineIdiomas()
        {
            if (Config.CompruebaConexion())
            {
                //Obtengo la conexión y los objetos necesarios.
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    //Defino las opciones de los comboBox haciendo una consulta a la base de datos.
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        //Idiomas.
                        string query = "SELECT id, nombre FROM IDIOMAS ORDER BY nombre";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        cbIdioma.DataSource = ds.Tables[0];
                        cbIdioma.DisplayMember = "nombre";
                        cbIdioma.ValueMember = "id";
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se han podido obtener los idiomas. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de agregar Serie.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnAgregarSerie_Click(object sender, EventArgs e)
        {
            //Creo el formulario en modo agregar una serie.
            FormAgregarSerie formAgregarSerie = new FormAgregarSerie((int)cbEditorial.SelectedValue);
            //Si el usuario acepta, se inserta la serie.
            if (formAgregarSerie.ShowDialog() == DialogResult.OK)
            {
                if (Config.CompruebaConexion())
                {
                    //Creo la conexión y los objetos necesarios.
                    using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                    {
                        try
                        {
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();

                            //Defino la consulta para insertar la serie.
                            cmd.CommandText = "INSERT INTO SERIES (nombre,editorial_id) VALUES (@nombre,@editorial_id)";
                            cmd.Parameters.AddWithValue("@nombre", formAgregarSerie.tbNombre.Text);
                            cmd.Parameters.AddWithValue("@editorial_id", (int)cbEditorial.SelectedValue);
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("No se ha podido insertar la nueva serie.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //Actualizo los campos del combobox de las series.
                DefineSeries();
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario escoge una opción del comboBox de Editorial.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void CbEditorial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Config.CompruebaConexion())
                DefineSeries();

            //Si el valor es distinto a "Sin asignar", se activan los botones de Serie.
            if (cbEditorial.SelectedValue != null && (int)cbEditorial.SelectedValue != 1)
            {
                btnAgregarSerie.Enabled = true;
                btnAgregarSerie.Visible = true;
            }
            else
            {
                btnAgregarSerie.Enabled = false;
                btnAgregarSerie.Visible = false;
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
        /// Método que se ejecuta cuando el ratón sale del área visible del botón.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = null;
        }

        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormAgregarComic_Paint(object sender, PaintEventArgs e)
        {
            //Si tiene conexión, se define el tema.
            Config.DefineTema();

            String[] Tema = Config.Tema;

            if (this.ClientRectangle.Width != 0 || this.ClientRectangle.Height != 0)
            {
                //El fondo se establece como un degradado entre el color 1 y el color 2.
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                    ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
                //Si el tema es oscuro se cambia el color de la fuente.
                if (Config.Tema_id == 8 || Config.Tema_id == 11)
                {
                    foreach (Control c in this.Controls.OfType<Label>().ToList())
                        c.ForeColor = ColorTranslator.FromHtml(Tema[2]);
                }
                else
                {
                    if (!Comprobando)
                        foreach (Control c in this.Controls.OfType<Label>().ToList())
                            c.ForeColor = Color.Black;
                }
            }
        }
    }
}
