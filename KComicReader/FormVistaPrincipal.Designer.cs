﻿
namespace KComicReader
{
    partial class FormVistaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaPrincipal));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pbBtnEliminar = new System.Windows.Forms.PictureBox();
            this.pbBtnLeer = new System.Windows.Forms.PictureBox();
            this.pbBtnEditar = new System.Windows.Forms.PictureBox();
            this.pbBtnAgregar = new System.Windows.Forms.PictureBox();
            this.fwpComics = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLeftCategorias = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblPanelLeftCategoriasTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelRightInfo = new System.Windows.Forms.Panel();
            this.lblInfoIdiomaValue = new System.Windows.Forms.Label();
            this.lblInfoIdioma = new System.Windows.Forms.Label();
            this.lblInfoCategoriaValue = new System.Windows.Forms.Label();
            this.lblInfoCategoria = new System.Windows.Forms.Label();
            this.lblInfoGuionista = new System.Windows.Forms.Label();
            this.lblInfoGuionistaValue = new System.Windows.Forms.Label();
            this.lblInfoDibujanteValue = new System.Windows.Forms.Label();
            this.lblInfoDibujante = new System.Windows.Forms.Label();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.lblInfoTituloValue = new System.Windows.Forms.Label();
            this.lblInfoEditorialValue = new System.Windows.Forms.Label();
            this.lblInfoEditorial = new System.Windows.Forms.Label();
            this.panelRightVacia = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLeftSeries = new System.Windows.Forms.Panel();
            this.lblPanelLeftSeriesTitle = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblInfoSerie = new System.Windows.Forms.Label();
            this.lblInfoSerieValue = new System.Windows.Forms.Label();
            this.agregarComicBtn = new KComicReader.AgregarComicBtn();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnLeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAgregar)).BeginInit();
            this.fwpComics.SuspendLayout();
            this.panelLeftCategorias.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelRightInfo.SuspendLayout();
            this.panelRightVacia.SuspendLayout();
            this.panelLeftSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Location = new System.Drawing.Point(12, 12);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1025, 43);
            this.panelTop.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.AccessibleDescription = "Agregar cómic";
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Controls.Add(this.pbBtnEliminar);
            this.panelCenter.Controls.Add(this.pbBtnLeer);
            this.panelCenter.Controls.Add(this.pbBtnEditar);
            this.panelCenter.Controls.Add(this.pbBtnAgregar);
            this.panelCenter.Controls.Add(this.fwpComics);
            this.panelCenter.Location = new System.Drawing.Point(187, 68);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(633, 540);
            this.panelCenter.TabIndex = 1;
            this.panelCenter.Tag = "Agregar producto";
            // 
            // pbBtnEliminar
            // 
            this.pbBtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnEliminar.Enabled = false;
            this.pbBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnEliminar.Image")));
            this.pbBtnEliminar.Location = new System.Drawing.Point(582, 153);
            this.pbBtnEliminar.Margin = new System.Windows.Forms.Padding(2, 24, 2, 2);
            this.pbBtnEliminar.Name = "pbBtnEliminar";
            this.pbBtnEliminar.Size = new System.Drawing.Size(45, 49);
            this.pbBtnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnEliminar.TabIndex = 4;
            this.pbBtnEliminar.TabStop = false;
            this.pbBtnEliminar.Tag = "Editar comic";
            this.pbBtnEliminar.Visible = false;
            this.pbBtnEliminar.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.pbBtnEliminar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // pbBtnLeer
            // 
            this.pbBtnLeer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnLeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBtnLeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnLeer.Enabled = false;
            this.pbBtnLeer.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnLeer.Image")));
            this.pbBtnLeer.Location = new System.Drawing.Point(582, 228);
            this.pbBtnLeer.Margin = new System.Windows.Forms.Padding(2, 24, 2, 2);
            this.pbBtnLeer.Name = "pbBtnLeer";
            this.pbBtnLeer.Size = new System.Drawing.Size(45, 49);
            this.pbBtnLeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnLeer.TabIndex = 3;
            this.pbBtnLeer.TabStop = false;
            this.pbBtnLeer.Tag = "Editar comic";
            this.pbBtnLeer.Visible = false;
            this.pbBtnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            this.pbBtnLeer.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.pbBtnLeer.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // pbBtnEditar
            // 
            this.pbBtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnEditar.Enabled = false;
            this.pbBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnEditar.Image")));
            this.pbBtnEditar.Location = new System.Drawing.Point(582, 78);
            this.pbBtnEditar.Margin = new System.Windows.Forms.Padding(2, 24, 2, 2);
            this.pbBtnEditar.Name = "pbBtnEditar";
            this.pbBtnEditar.Size = new System.Drawing.Size(45, 49);
            this.pbBtnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnEditar.TabIndex = 2;
            this.pbBtnEditar.TabStop = false;
            this.pbBtnEditar.Tag = "Editar comic";
            this.pbBtnEditar.Visible = false;
            this.pbBtnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.pbBtnEditar.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.pbBtnEditar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // pbBtnAgregar
            // 
            this.pbBtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnAgregar.Image")));
            this.pbBtnAgregar.Location = new System.Drawing.Point(582, 3);
            this.pbBtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBtnAgregar.Name = "pbBtnAgregar";
            this.pbBtnAgregar.Size = new System.Drawing.Size(45, 49);
            this.pbBtnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnAgregar.TabIndex = 1;
            this.pbBtnAgregar.TabStop = false;
            this.pbBtnAgregar.Click += new System.EventHandler(this.pbBtnAgregar_Click);
            this.pbBtnAgregar.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.pbBtnAgregar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // fwpComics
            // 
            this.fwpComics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fwpComics.AutoScroll = true;
            this.fwpComics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fwpComics.BackColor = System.Drawing.Color.White;
            this.fwpComics.Controls.Add(this.agregarComicBtn);
            this.fwpComics.Location = new System.Drawing.Point(3, 3);
            this.fwpComics.Name = "fwpComics";
            this.fwpComics.Size = new System.Drawing.Size(574, 531);
            this.fwpComics.TabIndex = 0;
            // 
            // panelLeftCategorias
            // 
            this.panelLeftCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelLeftCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftCategorias.Controls.Add(this.checkedListBox1);
            this.panelLeftCategorias.Controls.Add(this.lblPanelLeftCategoriasTitle);
            this.panelLeftCategorias.Location = new System.Drawing.Point(12, 68);
            this.panelLeftCategorias.Name = "panelLeftCategorias";
            this.panelLeftCategorias.Size = new System.Drawing.Size(166, 255);
            this.panelLeftCategorias.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Todas las categorías",
            "Superhéroes",
            "Novelas Gráficas"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 32);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(158, 202);
            this.checkedListBox1.TabIndex = 1;
            // 
            // lblPanelLeftCategoriasTitle
            // 
            this.lblPanelLeftCategoriasTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblPanelLeftCategoriasTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelLeftCategoriasTitle.Location = new System.Drawing.Point(3, 3);
            this.lblPanelLeftCategoriasTitle.Name = "lblPanelLeftCategoriasTitle";
            this.lblPanelLeftCategoriasTitle.Size = new System.Drawing.Size(158, 25);
            this.lblPanelLeftCategoriasTitle.TabIndex = 0;
            this.lblPanelLeftCategoriasTitle.Text = "CATEGORÍAS";
            this.lblPanelLeftCategoriasTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.panelRightInfo);
            this.panelRight.Controls.Add(this.panelRightVacia);
            this.panelRight.Controls.Add(this.lblTitulo);
            this.panelRight.Location = new System.Drawing.Point(832, 68);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(204, 540);
            this.panelRight.TabIndex = 3;
            // 
            // panelRightInfo
            // 
            this.panelRightInfo.Controls.Add(this.lblInfoSerie);
            this.panelRightInfo.Controls.Add(this.lblInfoSerieValue);
            this.panelRightInfo.Controls.Add(this.lblInfoIdiomaValue);
            this.panelRightInfo.Controls.Add(this.lblInfoIdioma);
            this.panelRightInfo.Controls.Add(this.lblInfoCategoriaValue);
            this.panelRightInfo.Controls.Add(this.lblInfoCategoria);
            this.panelRightInfo.Controls.Add(this.lblInfoGuionista);
            this.panelRightInfo.Controls.Add(this.lblInfoGuionistaValue);
            this.panelRightInfo.Controls.Add(this.lblInfoDibujanteValue);
            this.panelRightInfo.Controls.Add(this.lblInfoDibujante);
            this.panelRightInfo.Controls.Add(this.lblInfoTitulo);
            this.panelRightInfo.Controls.Add(this.lblInfoTituloValue);
            this.panelRightInfo.Controls.Add(this.lblInfoEditorialValue);
            this.panelRightInfo.Controls.Add(this.lblInfoEditorial);
            this.panelRightInfo.Location = new System.Drawing.Point(3, 31);
            this.panelRightInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRightInfo.Name = "panelRightInfo";
            this.panelRightInfo.Size = new System.Drawing.Size(196, 503);
            this.panelRightInfo.TabIndex = 1;
            // 
            // lblInfoIdiomaValue
            // 
            this.lblInfoIdiomaValue.AutoEllipsis = true;
            this.lblInfoIdiomaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIdiomaValue.Location = new System.Drawing.Point(-4, 375);
            this.lblInfoIdiomaValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblInfoIdiomaValue.Name = "lblInfoIdiomaValue";
            this.lblInfoIdiomaValue.Size = new System.Drawing.Size(200, 22);
            this.lblInfoIdiomaValue.TabIndex = 24;
            this.lblInfoIdiomaValue.Text = "Idioma del cómic";
            this.lblInfoIdiomaValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoIdioma
            // 
            this.lblInfoIdioma.AutoEllipsis = true;
            this.lblInfoIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIdioma.Location = new System.Drawing.Point(-4, 349);
            this.lblInfoIdioma.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblInfoIdioma.Name = "lblInfoIdioma";
            this.lblInfoIdioma.Size = new System.Drawing.Size(200, 22);
            this.lblInfoIdioma.TabIndex = 23;
            this.lblInfoIdioma.Text = "[IDIOMA]";
            this.lblInfoIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoCategoriaValue
            // 
            this.lblInfoCategoriaValue.AutoEllipsis = true;
            this.lblInfoCategoriaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCategoriaValue.Location = new System.Drawing.Point(-4, 319);
            this.lblInfoCategoriaValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblInfoCategoriaValue.Name = "lblInfoCategoriaValue";
            this.lblInfoCategoriaValue.Size = new System.Drawing.Size(200, 22);
            this.lblInfoCategoriaValue.TabIndex = 22;
            this.lblInfoCategoriaValue.Text = "Categoría del cómic";
            this.lblInfoCategoriaValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoCategoria
            // 
            this.lblInfoCategoria.AutoEllipsis = true;
            this.lblInfoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCategoria.Location = new System.Drawing.Point(-4, 293);
            this.lblInfoCategoria.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblInfoCategoria.Name = "lblInfoCategoria";
            this.lblInfoCategoria.Size = new System.Drawing.Size(200, 22);
            this.lblInfoCategoria.TabIndex = 21;
            this.lblInfoCategoria.Text = "[CATEGORÍA]";
            this.lblInfoCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoGuionista
            // 
            this.lblInfoGuionista.AutoEllipsis = true;
            this.lblInfoGuionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoGuionista.Location = new System.Drawing.Point(-6, 177);
            this.lblInfoGuionista.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblInfoGuionista.Name = "lblInfoGuionista";
            this.lblInfoGuionista.Size = new System.Drawing.Size(200, 22);
            this.lblInfoGuionista.TabIndex = 18;
            this.lblInfoGuionista.Text = "[GUIONISTA]";
            this.lblInfoGuionista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoGuionistaValue
            // 
            this.lblInfoGuionistaValue.AutoEllipsis = true;
            this.lblInfoGuionistaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoGuionistaValue.Location = new System.Drawing.Point(-3, 203);
            this.lblInfoGuionistaValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblInfoGuionistaValue.Name = "lblInfoGuionistaValue";
            this.lblInfoGuionistaValue.Size = new System.Drawing.Size(200, 22);
            this.lblInfoGuionistaValue.TabIndex = 17;
            this.lblInfoGuionistaValue.Text = "Guionista del cómic";
            this.lblInfoGuionistaValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoDibujanteValue
            // 
            this.lblInfoDibujanteValue.AutoEllipsis = true;
            this.lblInfoDibujanteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDibujanteValue.Location = new System.Drawing.Point(-3, 263);
            this.lblInfoDibujanteValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblInfoDibujanteValue.Name = "lblInfoDibujanteValue";
            this.lblInfoDibujanteValue.Size = new System.Drawing.Size(200, 22);
            this.lblInfoDibujanteValue.TabIndex = 16;
            this.lblInfoDibujanteValue.Text = "Dibujante del cómic";
            this.lblInfoDibujanteValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoDibujante
            // 
            this.lblInfoDibujante.AutoEllipsis = true;
            this.lblInfoDibujante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDibujante.Location = new System.Drawing.Point(-3, 237);
            this.lblInfoDibujante.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblInfoDibujante.Name = "lblInfoDibujante";
            this.lblInfoDibujante.Size = new System.Drawing.Size(200, 22);
            this.lblInfoDibujante.TabIndex = 15;
            this.lblInfoDibujante.Text = "[DIBUJANTE]";
            this.lblInfoDibujante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoTitulo
            // 
            this.lblInfoTitulo.AutoEllipsis = true;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitulo.Location = new System.Drawing.Point(-3, 57);
            this.lblInfoTitulo.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblInfoTitulo.Name = "lblInfoTitulo";
            this.lblInfoTitulo.Size = new System.Drawing.Size(200, 22);
            this.lblInfoTitulo.TabIndex = 14;
            this.lblInfoTitulo.Text = "[TÍTULO]";
            this.lblInfoTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoTituloValue
            // 
            this.lblInfoTituloValue.AutoEllipsis = true;
            this.lblInfoTituloValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTituloValue.Location = new System.Drawing.Point(-3, 83);
            this.lblInfoTituloValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblInfoTituloValue.Name = "lblInfoTituloValue";
            this.lblInfoTituloValue.Size = new System.Drawing.Size(200, 22);
            this.lblInfoTituloValue.TabIndex = 13;
            this.lblInfoTituloValue.Text = "Título del cómic";
            this.lblInfoTituloValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoEditorialValue
            // 
            this.lblInfoEditorialValue.AutoEllipsis = true;
            this.lblInfoEditorialValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEditorialValue.Location = new System.Drawing.Point(-3, 143);
            this.lblInfoEditorialValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblInfoEditorialValue.Name = "lblInfoEditorialValue";
            this.lblInfoEditorialValue.Size = new System.Drawing.Size(200, 22);
            this.lblInfoEditorialValue.TabIndex = 12;
            this.lblInfoEditorialValue.Text = "Editorial del cómic";
            this.lblInfoEditorialValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoEditorial
            // 
            this.lblInfoEditorial.AutoEllipsis = true;
            this.lblInfoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEditorial.Location = new System.Drawing.Point(-3, 117);
            this.lblInfoEditorial.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblInfoEditorial.Name = "lblInfoEditorial";
            this.lblInfoEditorial.Size = new System.Drawing.Size(200, 22);
            this.lblInfoEditorial.TabIndex = 11;
            this.lblInfoEditorial.Text = "[EDITORIAL]";
            this.lblInfoEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelRightVacia
            // 
            this.panelRightVacia.Controls.Add(this.lblInfo);
            this.panelRightVacia.Location = new System.Drawing.Point(3, 31);
            this.panelRightVacia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRightVacia.Name = "panelRightVacia";
            this.panelRightVacia.Size = new System.Drawing.Size(196, 461);
            this.panelRightVacia.TabIndex = 11;
            this.panelRightVacia.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(2, 6);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(170, 151);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Aquí se mostrará la información de los cómics que selecciones.\r\n";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INFORMACIÓN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeftSeries
            // 
            this.panelLeftSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeftSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelLeftSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftSeries.Controls.Add(this.lblPanelLeftSeriesTitle);
            this.panelLeftSeries.Controls.Add(this.treeView1);
            this.panelLeftSeries.Location = new System.Drawing.Point(12, 329);
            this.panelLeftSeries.Name = "panelLeftSeries";
            this.panelLeftSeries.Size = new System.Drawing.Size(166, 279);
            this.panelLeftSeries.TabIndex = 4;
            // 
            // lblPanelLeftSeriesTitle
            // 
            this.lblPanelLeftSeriesTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblPanelLeftSeriesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelLeftSeriesTitle.Location = new System.Drawing.Point(4, 3);
            this.lblPanelLeftSeriesTitle.Name = "lblPanelLeftSeriesTitle";
            this.lblPanelLeftSeriesTitle.Size = new System.Drawing.Size(157, 25);
            this.lblPanelLeftSeriesTitle.TabIndex = 0;
            this.lblPanelLeftSeriesTitle.Text = "MIS SERIES";
            this.lblPanelLeftSeriesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(158, 243);
            this.treeView1.TabIndex = 2;
            // 
            // lblInfoSerie
            // 
            this.lblInfoSerie.AutoEllipsis = true;
            this.lblInfoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSerie.Location = new System.Drawing.Point(-3, 1);
            this.lblInfoSerie.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblInfoSerie.Name = "lblInfoSerie";
            this.lblInfoSerie.Size = new System.Drawing.Size(200, 22);
            this.lblInfoSerie.TabIndex = 26;
            this.lblInfoSerie.Text = "[SERIE]";
            this.lblInfoSerie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoSerieValue
            // 
            this.lblInfoSerieValue.AutoEllipsis = true;
            this.lblInfoSerieValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSerieValue.Location = new System.Drawing.Point(-3, 27);
            this.lblInfoSerieValue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblInfoSerieValue.Name = "lblInfoSerieValue";
            this.lblInfoSerieValue.Size = new System.Drawing.Size(200, 22);
            this.lblInfoSerieValue.TabIndex = 25;
            this.lblInfoSerieValue.Text = "Serie del cómic";
            this.lblInfoSerieValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // agregarComicBtn
            // 
            this.agregarComicBtn.ArchivoURL = null;
            this.agregarComicBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarComicBtn.BackColor = System.Drawing.Color.Transparent;
            this.agregarComicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarComicBtn.Dibujante = null;
            this.agregarComicBtn.Editorial = null;
            this.agregarComicBtn.eventoClick = null;
            this.agregarComicBtn.Guionista = null;
            this.agregarComicBtn.Id = 0;
            this.agregarComicBtn.Location = new System.Drawing.Point(3, 3);
            this.agregarComicBtn.Name = "agregarComicBtn";
            this.agregarComicBtn.Portada = ((System.Drawing.Image)(resources.GetObject("agregarComicBtn.Portada")));
            this.agregarComicBtn.PortadaURL = null;
            this.agregarComicBtn.Size = new System.Drawing.Size(153, 281);
            this.agregarComicBtn.TabIndex = 0;
            this.agregarComicBtn.Titulo = "Agregar un nuevo cómic";
            // 
            // FormVistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 620);
            this.Controls.Add(this.panelLeftSeries);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeftCategorias);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVistaPrincipal";
            this.Text = "KComicReader";
            this.Load += new System.EventHandler(this.FormVistaPrincipal_Load);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnLeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAgregar)).EndInit();
            this.fwpComics.ResumeLayout(false);
            this.panelLeftCategorias.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRightInfo.ResumeLayout(false);
            this.panelRightVacia.ResumeLayout(false);
            this.panelLeftSeries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.FlowLayoutPanel fwpComics;
        private System.Windows.Forms.Panel panelLeftCategorias;
        private System.Windows.Forms.Label lblPanelLeftCategoriasTitle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbBtnAgregar;
        private System.Windows.Forms.Panel panelRightVacia;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelRightInfo;
        private System.Windows.Forms.Label lblInfoGuionista;
        private System.Windows.Forms.Label lblInfoGuionistaValue;
        private System.Windows.Forms.Label lblInfoDibujanteValue;
        private System.Windows.Forms.Label lblInfoDibujante;
        private System.Windows.Forms.Label lblInfoTitulo;
        private System.Windows.Forms.Label lblInfoTituloValue;
        private System.Windows.Forms.Label lblInfoEditorialValue;
        private System.Windows.Forms.Label lblInfoEditorial;
        private System.Windows.Forms.Panel panelLeftSeries;
        private System.Windows.Forms.Label lblPanelLeftSeriesTitle;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblInfoCategoriaValue;
        private System.Windows.Forms.Label lblInfoCategoria;
        private System.Windows.Forms.PictureBox pbBtnEditar;
        private System.Windows.Forms.Label lblInfoIdiomaValue;
        private System.Windows.Forms.Label lblInfoIdioma;
        private System.Windows.Forms.PictureBox pbBtnLeer;
        private System.Windows.Forms.PictureBox pbBtnEliminar;
        private AgregarComicBtn agregarComicBtn;
        private System.Windows.Forms.Label lblInfoSerie;
        private System.Windows.Forms.Label lblInfoSerieValue;
    }
}

