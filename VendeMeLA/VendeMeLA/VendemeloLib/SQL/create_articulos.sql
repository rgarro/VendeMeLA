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

--SELECT * FROM articulos

--SELECT count(*) FROM articulos WHERE etiqueta = 'Meneitos'

  --DROP TABLE [articulos]

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

--SELECT * FROM clientes


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

--SELECT * FROM usuarios

CREATE TABLE [factura] (
	id int NOT NULL IDENTITY (1, 1),
	usuario_id int NOT NULL,
	cliente_id int NOT NULL,
	fecha timestamp NOT NULL,
  CONSTRAINT [PK_FACTURA] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [detalles] (
	id int NOT NULL IDENTITY (1, 1),
	factura_id int NOT NULL,
	articulo_id int NOT NULL,
	precio float(5) NOT NULL,
  CONSTRAINT [PK_DETALLES] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO


ALTER TABLE [factura] WITH CHECK ADD CONSTRAINT [factura_fk0] FOREIGN KEY ([usuario_id]) REFERENCES [usuarios]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [factura] CHECK CONSTRAINT [factura_fk0]
GO
ALTER TABLE [factura] WITH CHECK ADD CONSTRAINT [factura_fk1] FOREIGN KEY ([cliente_id]) REFERENCES [clientes]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [factura] CHECK CONSTRAINT [factura_fk1]
GO

ALTER TABLE [detalles] WITH CHECK ADD CONSTRAINT [detalles_fk0] FOREIGN KEY ([factura_id]) REFERENCES [factura]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [detalles] CHECK CONSTRAINT [detalles_fk0]
GO
ALTER TABLE [detalles] WITH CHECK ADD CONSTRAINT [detalles_fk1] FOREIGN KEY ([articulo_id]) REFERENCES [articulos]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [detalles] CHECK CONSTRAINT [detalles_fk1]
GO


select current_timestamp
SELECT * FROM factura
SELECT SCOPE_IDENTITY()

SELECT IDENT_CURRENT('factura') as total

SELECT * FROM detalles