CREATE DATABASE kcomicreader;

USE kcomicreader;

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


CREATE TABLE COMICS (
  id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  titulo VARCHAR(255) NOT NULL,
  dibujante VARCHAR(255),
  guionista VARCHAR(255),
  portada BLOB,
  archivoURL VARCHAR(255) NOT NULL,
  numPagina INT(11) NOT NULL,
  numPaginasTotales INT(11) NOT NULL,
  categoria_id INT(11) NOT NULL,
  idioma_id INT(11) NOT NULL,
  editorial_id INT(11) NOT NULL,
  FOREIGN KEY (categoria_id) REFERENCES CATEGORIAS(id),
  FOREIGN KEY (idioma_id) REFERENCES IDIOMAS(id),
  FOREIGN KEY (editorial_id) REFERENCES EDITORIALES(id)
);

/*INSERCIÓN DE LAS EDITORIALES*/
INSERT INTO EDITORIALES (nombre) VALUES ('Marvel Comics'), ('Detective Comics (DC)'), ('IDW Publishing'), ('Image Comics'), ('Dark Horse Comics'), ('Boom'), ('Norma Editorial');

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
INSERT INTO CATEGORIAS (nombre) VALUES ('Sin asignar'),('Superhéroes'),('Manga'),('Novela gráfica'),('Humor'),('Otros');
