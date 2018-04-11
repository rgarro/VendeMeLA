CREATE TABLE [articulos] (
	id int NOT NULL  IDENTITY (1, 1),
	etiqueta nvarchar(100) NOT NULL UNIQUE,
	cantidad int NOT NULL,
	precio float(5) NOT NULL,
  CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

INSERT INTO articulos (etiqueta,cantidad,precio) VALUES 
('meneitos',10,10) , ('tronaditas',10,10), ('papiondas',10,10)

SELECT * FROM articulos

SELECT count(*) FROM articulos WHERE etiqueta = 'Meneitos'

  DROP TABLE [articulos]

GO

CREATE TABLE [clientes] (
	id int NOT NULL IDENTITY (1, 1),
	nombre nvarchar(100) NOT NULL UNIQUE,
	descuento float NOT NULL DEFAULT '0.0',
  CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

INSERT INTO clientes (nombre,descuento) VALUES 
('Adam Baker',0.01) , ('Chiricuto',0.05), ('NelsonHofman',0.06)

SELECT * FROM clientes


CREATE TABLE [usuarios] (
	id int NOT NULL IDENTITY (1, 1),
	usuario nvarchar(100) NOT NULL UNIQUE,
	clave nvarchar(100) NOT NULL,
	es_cajero bit NOT NULL DEFAULT '1',
	es_admin bit NOT NULL DEFAULT '1',
  CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

INSERT INTO usuarios (usuario,clave,es_cajero,es_admin) VALUES 
('admin','8ac6b0daa930f428f9e79a662123beedec453e15',1,1) 
GO

SELECT * FROM usuarios