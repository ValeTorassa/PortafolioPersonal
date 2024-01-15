using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using static System.Net.WebRequestMethods;

namespace Portfolio.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 1,
                Name = "Creador de Torneos de Counter Strike",
                Description = " <p>\r\n El Sistema de Gestión de Torneos de Counter Strike es una aplicación diseñada para facilitar la organización y administración de torneos de este videojuego. </p>\r\n              <p>La aplicación está diseñada para facilitar la creación de torneos casuales y profesionales, la incorporación de jugadores, y la generación aleatoria de equipos y enfrentamientos. </p>\r\n              <p>Se puede, a su vez, cargar los resultados de los partidos y determinar un ganador y analizar todos los datos.</p>\r\n              <p>El sistema cuenta con diversas entidades que interactúan para lograr un proceso eficiente y estructurado en la creación y gestión de torneos y jugadores.\r\n              </p> <p>Se puede, a su vez, cargar los resultados de los partidos y determinar un ganador y analizar todos los datos.</p>\r\n              <p>El sistema cuenta ademas con una base de datos creada con entity framework code first y un sistema de reportes en html que imprime los datos precisos de las estadisticas de cada equipo.\r\n              </p>",
                Technologies = new string[] { "C#", "Entity Framework Code First", "Windows Forms", "MVC", "Aplicacion de escritorio" },
                CoverImageUrl = "https://i.imgur.com/5q1BrTl.png",
                ImagesUrl = new string[] { "https://i.imgur.com/ww0SRja.png", "https://i.imgur.com/poRfoIs.png", "https://i.imgur.com/jrsUcJI.png", "https://i.imgur.com/WizeHOS.png", "https://i.imgur.com/3MWIwBD.png" , "https://i.imgur.com/C3lXmH4.png" },
                Link = "<a href='https://github.com/ValeTorassa/CreadorTorneoCS-EntityFramework'>Link Proyecto Con entity</a> <br> <a href='https://github.com/ValeTorassa/Creador-de-TorneosCS'>Link Proyecto Solo POO</a>",
                Author = "Valentin Torassa Y Juan Pablo Estelles",
                Category = "Aplicacion de Escritorio"
            }) ;

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 2,
                Name = "Mango Sabores Online: Restaurante en línea",
                Description = "<p>El Sistema de Gestión de Restaurantes en Línea es una aplicación basada en microservicios que simplifica la operación de un restaurante ofreciendo servicios en línea.</p>\r\n <p>La aplicación se compone de diversos microservicios diseñados para manejar tareas específicas, como la gestión de pedidos, el catálogo de productos, la autenticación de usuarios, entre otros.</p> \r\n <p>La aplicación se compone de diversos microservicios diseñados para manejar tareas específicas, como la gestión de pedidos, el catálogo de productos, la autenticación de usuarios, entre otros.</p>\" +\r\n                       \"<p>ASP.NET Core MVC se utiliza para construir la interfaz web que permite a los clientes realizar pedidos en línea y explorar el menú del restaurante.</p>\" +\r\n                       \"<p>ASP.NET Core Web API facilita la comunicación entre los microservicios, permitiendo que cada servicio se ejecute de manera independiente y se comunique con otros servicios según sea necesario.</p> +\r\n                       \"<p>Entity Framework Core se emplea para interactuar con la base de datos, proporcionando una capa de abstracción sobre el almacenamiento de datos y permitiendo el acceso a través de los microservicios.</p> +\r\n                       \"<p>La arquitectura en microservicios permite la escalabilidad, mantenimiento y despliegue independiente de cada componente del sistema, mejorando la flexibilidad y robustez del sistema.</p>",
                Technologies = new string[] { "C#", "ASP.NET Core MVC", "ASP.NET Core Web API", "Entity Framework Code First", "Microservicios", "SQL Server" },
                CoverImageUrl = "https://i.imgur.com/iIgb8qi.jpg",
                ImagesUrl = new string[] { "https://i.imgur.com/4hZxmiK.png", "https://i.imgur.com/oxFtabz.png", "https://i.imgur.com/zTDZugh.png", "https://i.imgur.com/WizeHOS.png", "https://i.imgur.com/4LvBYag.png" },
                Link = "<a href='https://github.com/ValeTorassa/SaboresOnline-Microservicios/tree/main'>Link Proyecto (En desarrollo)</a>",
                Author = "Valentin Torassa",
                Category = "Aplicacion Web"
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 3,
                Name = "Funkoshop Ecommerce",
                Description = "<p>Aplicación web desarrollada con Javascript, Node.js, EJS y CSS para Funkoshop, una tienda especializada en la venta de figuras de colección Funko.</p>",
                Technologies = new string[] { "Node.JS", "Javascript", "EJS", "CSS", "MVC" },
                CoverImageUrl = "https://i.imgur.com/hFkyEho.jpg",
                ImagesUrl = new string[] { "https://i.imgur.com/PfSAyGE.png", "https://i.imgur.com/Voe9Odh.png", "https://i.imgur.com/wpEulPb.png", "https://i.imgur.com/0CUN7cV.png", "https://i.imgur.com/4CIQTkZ.png" },
                Link = "<a href='https://github.com/ValeTorassa/FunkoShop'>Link Proyecto</a>",
                Author = "Valentin Torassa",
                Category = "Aplicacion de Escritorio"
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 4,
                Name = "Gestor de Usuarios, Roles y Configuracion Linux",
                Description = "<p>\r\n                El Gestor de Usuarios, Roles y Configuración Linux es una aplicación diseñada para facilitar la administración de usuarios, sus roles y sus configuraciones en sistemas Linux.\r\n              </p>\r\n              <p>\r\n                La aplicación utiliza una base de datos SQL personalizada para almacenar información, y sigue una arquitectura MVC de tres capas para garantizar la persistencia de datos y una interfaz de usuario intuitiva.\r\n              </p>",
                Technologies = new string[] { "C#", "POO", "Base de datos SQL", "MVC", "Windows Forms" },
                CoverImageUrl = "https://i.imgur.com/NpqJ01w.jpg",
                ImagesUrl = new string[] { "https://i.imgur.com/KnJYPeG.png", "https://i.imgur.com/mrqUhYj.png", "https://i.imgur.com/9X4jQK1.png", "https://i.imgur.com/syE1PjO.png", "https://i.imgur.com/txrcQI5.png" },
                Link = "<a href='https://github.com/ValeTorassa/Gestor-De-Usuarios-Linux'>Link Proyecto</a>",
                Author = "Valentin Torassa",
                Category = "Aplicacion de Escritorio"
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 5,
                Name = "Usuarios y Roles Code First",
                Description = "<p>\r\nEste es un proyecto para gestionar usuarios y grupos de permisos de un SO basado en .NET 8 y Entity Framework</p><p>\r\nEste proyecto representa un sistema de administración de usuarios y roles desarrollado utilizando C#, con una arquitectura en cuatro capas y el enfoque Code First de Entity Framework. La aplicación está diseñada para gestionar de manera eficiente y estructurada la autenticación y autorización de usuarios, así como la asignación y administración de roles en una base de datos SQL</p>",
                Technologies = new string[] { "C#", "Entity Framework Code First", "SQL Server", "MVC", "Windows Forms" },
                CoverImageUrl = "https://i.imgur.com/gWewMiG.png",
                ImagesUrl = new string[] { "https://i.imgur.com/gtLbgqd.png", "https://i.imgur.com/Y7CRSKR.png", "https://i.imgur.com/vqXPL2W.png", "https://i.imgur.com/LfUD8f1.png"},
                Link = "<a href='https://github.com/ValeTorassa/Usuario-Grupo-Entity-Framework'>Link Proyecto</a>",
                Author = "Valentin Torassa",
                Category = "Aplicacion de Escritorio"
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 6,
                Name = "Sistema de Tickets Aéreos",
                Description = "<p>\r\n                El \"Sistema de Tickets Aéreos, Vuelos y Pasajeros\" es una aplicación desarrollada en C# utilizando Windows Forms. Este sistema está diseñado para gestionar de manera eficiente la reserva de vuelos, la información de pasajeros y la gestión de boletos aéreos.\r\n              </p>\r\n              <p>\r\n                Utiliza una base de datos SQL personalizada para almacenar la información de vuelos y pasajeros, siguiendo una arquitectura MVC de tres capas para garantizar la persistencia de datos y una interfaz de usuario intuitiva.\r\n              </p>\r\n              <p>\r\n                Posee, ademas, un visualizer de boletos aereos en base al pasajero y al vuelo cargado en el ticket.\r\n              </p>",
                Technologies = new string[] { "C#", "POO", "Base de datos SQL", "MVC", "Windows Forms" },
                CoverImageUrl = "https://i.imgur.com/9bEIc4u.jpg",
                ImagesUrl = new string[] { "https://i.imgur.com/6vDm6u4.png", "https://i.imgur.com/LqCEe3B.png", "https://i.imgur.com/mfC16KC.png", "https://i.imgur.com/Iovt1aL.png" },
                Link = "<a href='https://github.com/ValeTorassa/Sistema-Tickets-Aereos'>Link Proyecto</a>",
                Author = "Valentin Torassa",
                Category = "Aplicacion de Escritorio"
            });


            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 7,
                Name = "Administra Tu Aula",
                Description = "<p>\r\n                \"Administra tu Aula\" es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Esta aplicación tiene como objetivo facilitar la gestión y administración de alumnos y profesores. \r\n              </p>\r\n              <p>\r\n                La interfaz de usuario es intuitiva, amigable y agradable a la vista, lo que permite a los usuarios administrar eficientemente el espacio del aula y los cursos. Esta herramienta es ideal para instituciones educativas.\r\n              </p>",
                Technologies = new string[] { "C#", "Windows Forms", "UI" },
                CoverImageUrl = "https://i.imgur.com/iIfOae0.jpg",
                ImagesUrl = new string[] { "https://i.imgur.com/7dx4KHb.png", "https://i.imgur.com/VP3hhN1.png", "https://i.imgur.com/WCLOiq1.png", "https://i.imgur.com/aUpPTvo.png" },
                Link = "<a href='https://github.com/ValeTorassa/Administra-Tu-Aula'>Link Proyecto</a>",
                Author = "Marcos Lodato, Fernando Jaime y Valentín Torassa Colombero",
                Category = "Aplicacion de Escritorio"
            });

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
    }
}
