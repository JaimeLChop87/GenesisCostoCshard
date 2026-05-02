¿Qué es Génesis Costos?: Un sistema de gestión de costos

Tecnologías: .NET 8, Entity Framework Core, SQLite, BCrypt.Net.

Ciudad: Bello, Antioquia Colombia
Estado del proyecto: En Desarrollo
Fecha Actualizacion: 02 Mayo 2026

📑 Génesis Costos
Génesis Costos es una solución para la gestión y análisis de costos, construida bajo estándares de arquitectura limpia (Clean Architecture) y con un enfoque riguroso en la seguridad de la información.

🚀 Características Principales
Arquitectura Desacoplada: Separación estricta entre entidades de dominio, lógica de fábrica y utilitarios.

Seguridad de Grado Industrial: Implementación de BCrypt para el hashing de contraseñas, garantizando protección contra ataques de fuerza bruta y diccionarios.

Validación de Datos: Motor de estandarización de texto y validación de correos electrónicos bajo normativas RFC.

Persistencia Ligera: Integración optimizada con SQLite para un manejo de datos ágil y portátil.

🛠️ Tecnologías Utilizadas
C# / .NET 8: El núcleo del sistema.

Entity Framework Core: Como ORM para la gestión de la base de datos.

BCrypt.Net-Next: Para el manejo seguro de credenciales.

SQLite: Motor de base de datos embebido.

🏗️ Arquitectura de Seguridad
Génesis implementa un flujo de datos seguro desde la captura en consola hasta el almacenamiento:

Captura Segura: Entrada de contraseñas con enmascaramiento de caracteres (*).

Factory Pattern: Centralización de la creación de usuarios (UsuarioFactory) para asegurar que cada rol reciba los permisos y configuraciones correctas desde su nacimiento.

One-Way Hashing: Las contraseñas nunca se almacenan en texto plano; solo su representación hash es persistida.

📦 Instalación y Configuración