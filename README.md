# FlickerApp

**Descripción:**
Este repositorio contiene el código fuente de FlickerApp, una red social desarrollada en ASP.NET Core MVC con el objetivo de permitir a los usuarios crear publicaciones, interactuar con amigos y compartir contenido de manera segura y sencilla. FlickerApp se basa en la arquitectura Onion y utiliza Entity Framework Code First para la persistencia de datos, garantizando un enfoque modular y una estructura sólida. La aplicación también hace uso de AutoMapper para mapear objetos y Shared para el servicio de correo.

**Características Principales:**
- **Inicio de Sesión y Registro:** FlickerApp permite a los usuarios registrarse en la plataforma de forma segura y fácil. La autenticación y el registro se gestionan de manera eficiente, y se envía un correo de activación a los usuarios para habilitar sus cuentas.

- **Publicaciones y Comentarios:** Los usuarios pueden crear publicaciones con texto y/o imágenes, y estas pueden ser comentadas por sus amigos. Además, los comentarios y las publicaciones muestran miniaturas de las fotos de perfil de los usuarios involucrados.

- **Gestión de Amigos:** La aplicación permite a los usuarios agregar, eliminar y gestionar su lista de amigos. Pueden ver las publicaciones más recientes de sus amigos y participar en la conversación mediante comentarios.

- **Seguridad:** FlickerApp garantiza la seguridad de los datos y la privacidad de los usuarios. Las páginas de publicaciones y amigos solo son accesibles para usuarios autenticados. Se implementa un sistema de redirección y mensajes de error para proteger la información.

**Estructura del Repositorio:**
- `src`: Contiene el código fuente de la aplicación FlickerApp.
- `tests`: Incluye pruebas unitarias y de integración para garantizar la calidad del código.
- `docs`: Documentación relacionada con el proyecto, incluyendo este README.

**Requisitos de Desarrollo:**
- ASP.NET Core 5.0
- Entity Framework Core
- AutoMapper
- Bootstrap (para el diseño visual)
- Onion Architecture
- Repositorios y Servicios Genéricos

**Instrucciones de Uso:**
1. Clona este repositorio en tu entorno de desarrollo local.
2. Abre el proyecto en Visual Studio o tu IDE preferido.
3. Configura la base de datos utilizando Entity Framework Code First.
4. Ejecuta la aplicación.
5. Accede a la URL de la aplicación y comienza a disfrutar de FlickerApp.

**Contribuciones:**
¡Agradecemos las contribuciones de la comunidad! Si deseas contribuir al desarrollo de FlickerApp, te invitamos a realizar un fork del repositorio, realizar tus cambios y enviar un pull request.

**Licencia:**
Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo `LICENSE` para obtener más información.

**Contacto:**
Si tienes preguntas o necesitas asistencia, no dudes en ponerte en contacto con el equipo de desarrollo de FlickerApp.

¡Esperamos que disfrutes de FlickerApp y encuentres esta red social útil y entretenida para conectar con amigos y compartir contenido en línea!
