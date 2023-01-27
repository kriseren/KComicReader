﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormVistaPrincipal : Form
    {
        //Definición de atributos.
        private Comic comicSeleccionado = new Comic();

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
            }
        }

        //Método que se ejecuta cuando el usuario pulsa encima de un cómic.
        private void Comic_Click(object sender, EventArgs e)
        {
            //Creo el objeto cómic y defino todas las etiquetas de información.
            comicSeleccionado = (Comic)sender;
            lblInfoTituloValue.Text = comicSeleccionado.Titulo;
            lblInfoEditorialValue.Text = comicSeleccionado.Editorial;
            lblInfoGuionistaValue.Text = comicSeleccionado.Guionista;
            lblInfoDibujanteValue.Text = comicSeleccionado.Dibujante;
            lblInfoCategoriaValue.Text = comicSeleccionado.Categoria;
            lblInfoIdiomaValue.Text = comicSeleccionado.Idioma;

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
            //Obtengo todos los comics dados de alta en la base de datos.
            cargaTodosComics();

            //Muestro la vista vacía.
            panelRightVacia.BringToFront();
            panelRightVacia.Visible = true;

            //Agrego un eventHandler al botón de agregar cómic dentro del fwp.
            agregarComicBtn.eventoClick += pbBtnAgregar_Click;
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

        //Método que se ejecuta cuando se agrega un control al fwpComics.
        private void fwpComics_ControlAdded(object sender, ControlEventArgs e)
        {
            //Si el número de cómics es mayor de 0, se activa el botón de editar.
            if (fwpComics.Controls.OfType<Comic>().Count() > 0)
            {
                btnEditar.Visible = true;
                btnEditar.Enabled = true;
            }
            else
            {
                btnEditar.Visible = false;
                btnEditar.Enabled = false;
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
                //Obtengo el comic, defino un controlador de eventos click y lo agrego al flowLayout.
                comicSeleccionado.Titulo = formEditar.comic.Titulo;
                comicSeleccionado.Dibujante = formEditar.comic.Dibujante;

                //Ordeno los cómics por título.
                ordenaComicsPorTitulo();
            }
        }

        //Método que carga en el fwp todos los cómics dados de alta en la base de datos.
        private void cargaTodosComics()
        {
            try
            {
                //Obtengo la conexión y los objetos necesarios.
                MySqlConnection con = DataBaseConnectivity.getConnection();
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                //Creo la query.
                cmd.CommandText = "SELECT * FROM COMICS";
                var reader = cmd.ExecuteReader();

                Comic c;
                while(reader.Read())
                {
                    //Creo el cómic.
                    c = new Comic();
                    //Defino las propiedades.
                    c.Titulo = reader.GetString("titulo");
                    c.Dibujante = reader.GetString("dibujante");
                    c.Guionista = reader.GetString("guionista");
                    c.Portada = Image.FromStream(reader.GetStream("portada"));
                    c.ArchivoURL = reader.GetString("archivoURL");
                    c.NumPaginaActual = (uint)reader.GetInt32("numPagina");
                    c.NumPaginasTotales = (uint)reader.GetInt32("numPaginasTotales");
                    c.CategoriaID = reader.GetInt32("categoria_id");
                    c.IdiomaID = reader.GetInt32("idioma_id");
                    c.EditorialID = reader.GetInt32("editorial_id");

                    //Defino los controladores de los eventos.
                    c.eventoClick += new EventHandler(Comic_Click);
                    c.eventoDobleClick += new EventHandler(btnLeer_Click);

                    //Lo agrego al fwp.
                    fwpComics.Controls.Add(c);
                }

                //Cierro la conexión.
                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error al conectar a la base de datos. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
