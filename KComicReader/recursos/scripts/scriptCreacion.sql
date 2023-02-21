/*CREACIÓN DE LA BASE DE DATOS*/
CREATE DATABASE kcomicreader;
USE kcomicreader;


/*CREACIÓN DE LAS TABLAS*/
CREATE TABLE CATEGORIAS (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nombre VARCHAR(255) NOT NULL
);

CREATE TABLE IDIOMAS (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nombre VARCHAR(255) NOT NULL
);

CREATE TABLE EDITORIALES (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nombre VARCHAR(255) NOT NULL
);

CREATE TABLE SERIES (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nombre VARCHAR(255) NOT NULL,
  editorial_id INT(11) NOT NULL,
  FOREIGN KEY (editorial_id) REFERENCES EDITORIALES(id)
);

CREATE TABLE COMICS (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  titulo VARCHAR(255) NOT NULL,
  dibujante VARCHAR(255),
  guionista VARCHAR(255),
  portada LONGBLOB,
  archivoURL VARCHAR(255) NOT NULL,
  numPagina INT(11) UNSIGNED NOT NULL,
  numPaginasTotales INT(11) UNSIGNED NOT NULL,
  numero INT(11) UNSIGNED NOT NULL,
  categoria_id INT(11) NOT NULL,
  idioma_id INT(11) NOT NULL,
  editorial_id INT(11) NOT NULL,
  serie_id INT(11) NOT NULL,
  FOREIGN KEY (categoria_id) REFERENCES CATEGORIAS(id),
  FOREIGN KEY (idioma_id) REFERENCES IDIOMAS(id),
  FOREIGN KEY (editorial_id) REFERENCES EDITORIALES(id),
  FOREIGN KEY (serie_id) REFERENCES SERIES(id)
);

CREATE TABLE FAVORITOS (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  titulo VARCHAR(255) NOT NULL,
  vinyeta LONGBLOB,
  comic_id INT(11) NOT NULL,
  FOREIGN KEY (comic_id) REFERENCES COMICS(id)
);

CREATE TABLE TEMAS(
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nombre VARCHAR(255) NOT NULL,
  color1 VARCHAR(255) NOT NULL,
  color2 VARCHAR(255) NOT NULL,
  color3 VARCHAR(255) NOT NULL,
  seleccionador VARCHAR(50) NOT NULL,
  icono VARCHAR(50) NOT NULL
);

CREATE TABLE AJUSTES (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  directorio_instalacion VARCHAR(255) NOT NULL,
  tema_id INT(11) NOT NULL,
  mostrar_bienvenida TINYINT(1) NOT NULL,
  FOREIGN KEY (tema_id) REFERENCES TEMAS(id)
);



/*INSERCIÓN DE LAS EDITORIALES*/
INSERT INTO EDITORIALES (nombre) VALUES ('Sin asignar'),('Marvel Comics'), ('Detective Comics (DC)'), ('IDW Publishing'), ('Image Comics'), ('Dark Horse Comics'), ('Boom'), ('Norma Editorial');

/*INSERCIÓN DE LOS IDIOMAS*/
INSERT INTO IDIOMAS (nombre) VALUES
('Afrikáans'),
('Árabe'),
('Bengalí'),
('Bielorruso'),
('Birmano'),
('Chino mandarín'),
('Coreano'),
('Croata'),
('Danes'),
('Español'),
('Estonio'),
('Feroés'),
('Finlandés'),
('Francés'),
('Griego'),
('Hindi'),
('Holandés'),
('Húngaro'),
('Indonesio'),
('Inglés'),
('Italiano'),
('Japonés'),
('Latvio'),
('Lituania'),
('Macedonio'),
('Malayo'),
('Noruego'),
('Polaco'),
('Portugués'),
('Ruso'),
('Sueco'),
('Tamil'),
('Turco'),
('Ucraniano'),
('Urdu'),
('Vietnamita'),
('Xhosa'),
('Yidis'),
('Zulú');

/*INSERCIÓN DE CATEGORÍAS*/
INSERT INTO CATEGORIAS (nombre) VALUES ('Todas las categorías'),('Sin asignar'),('Superhéroes'),('Manga'),('Novela gráfica'),('Humor'),('Otros');

/*INSERCIÓN DE LAS SERIES*/
INSERT INTO series (nombre, editorial_id) VALUES ('Todas las series', 1);


/*INSERCIÓN DE LOS TEMAS*/
INSERT INTO TEMAS (nombre, color1, color2, color3,seleccionador,icono) VALUES
('Predeterminado', '#b18cd9', '#E2C6FF', '#ece0f8', '1.png', '1.png'),
('Marvel', '#EE2128', '#F1484E', '#FFFFFF', '2.png', '2.png'),
('Detective Comics', '#263EB6', '#7F8FE2', '#FFFDFA', '3.png', '3.png'),
('Manga', '#5F5F5F', '#B3B3B2', '#FEFFFE', '4.png', '4.png'),
('Dragon Ball', '#FB7130', '#FCAB50', '#FFFFCF', '5.png', '5.png'),
('Groot', '#779BDC', '#9DBBEB', '#AB8F69', '6.png', '6.png'),
('Lobezno', '#074562', '#1985AD', '#FBC543', '7.png', '7.png'),
('Batman', '#000000', '#200D08', '#FBF0A3', '8.png', '8.png'),
('One Piece', '#0563B1', '#00B6EE', '#DC7B47', '9.png', '9.png'),
('Joker', '#554278', '#9E66B1', '#95CE60', '10.png', '10.png'),
('Flash', '#AD062B', '#C10834', '#FAF0B8', '11.png', '11.png');


/*INSERCIÓN DE LOS AJUSTES*/
INSERT INTO AJUSTES (directorio_instalacion,tema_id,mostrar_bienvenida) VALUES ('C:\\KComicReader\\Comics',1,1);


