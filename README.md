# JugueteriApp
Aplicacion web de jugueteria con .NET Core 5.0 y MVC

# Primeros pasos

Modificar appsettings.json con usuario y contraseña de base de datos, solo debe mantenerse el nombre de la conexion "JugueteriaConnection"

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    //"JugueteriaConnection": "Server=NOMBRE DEL SERVIDOR;Initial Catalog=BASE DE DATOS;User Id=USUARIO;Password=CONTRASEÑA;"
  }
}

```

En una instancia de SQL ejecutar el siguiente Query

```

USE [JugueteriAppDb]
GO

/****** Object:  Table [dbo].[productos]    Script Date: 12/03/2021 01:21:38 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[RestriccionEdad] [int] NOT NULL,
	[Compania] [nvarchar](50) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

```
Alternativamente se puede ingresar a la aplicacion por medio de Visual Studio y generar la migracion ya que se realizo con Code First, en la consola del Package Manager Console con los comandos

```
1.- add-migration NombreMigracion
2.- update-database
```


# Aplicacion Web
Para ejecutar la aplicacion ingresa a la ruta donde descargaste el proyecto y ingresa a la carpeta /JugeteriApp/JugueteriApp

y en la ruta ingresa cmd y enter

![imagen](https://user-images.githubusercontent.com/36839234/110905438-1611b600-82d0-11eb-845b-1deec940efcf.png)

En la consola ingresa dotnet run para ejecutar la aplicacion
![imagen](https://user-images.githubusercontent.com/36839234/110905520-36417500-82d0-11eb-93f2-2d73d1580116.png)

Abrir el navegador de preferencia y ingresar a la URL marcada en la consola
![imagen](https://user-images.githubusercontent.com/36839234/110905665-73a60280-82d0-11eb-9432-ae6016e83d95.png)

# ApiJugeteria
Para ingresar a la API de la aplicacion se ingresa a la misma URL de la aplicacion y despues del puerto se agrega "swagger", automaticamente redireccionara a la API
![imagen](https://user-images.githubusercontent.com/36839234/110905875-ced7f500-82d0-11eb-9b01-d3212d23f3bb.png)

Alternativamente se pueden hacer pruebas en Postman

![imagen](https://user-images.githubusercontent.com/36839234/110907865-a3a2d500-82d3-11eb-9550-a004e7821ec3.png)
