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