CREATE TABLE [articulos] (
	id int(6) NOT NULL,
	etiqueta nvarchar(100) NOT NULL UNIQUE,
	cantidad int(5) NOT NULL,
	precio float(5) NOT NULL,
  CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

