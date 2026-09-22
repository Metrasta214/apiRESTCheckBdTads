<div align="center">

# Tecnológico Nacional de México
## Instituto Tecnológico de Pachuca

### Ingeniería en Tecnologías de la Información y Comunicaciones

---

# apiRESTCheckBd

### Taller Avanzado de Desarrollo de Software

**Alumno:** Álvaro Madrid Morales  
**Práctica:** apiRESTCheckBd  
**Fecha:** 22 de septiembre de 2026

---

</div>

## 📌 Descripción

`apiRESTCheckBd` es una práctica desarrollada en **ASP.NET Web API con C#**, cuya finalidad es implementar y comprobar la conexión entre una API REST y una base de datos **MySQL**.

Durante la práctica se configuró la cadena de conexión, se crearon los modelos necesarios y se implementó un controlador encargado de realizar una prueba de conexión con la base de datos `CONTROL_ACCESO`.

Finalmente, el funcionamiento del endpoint fue comprobado mediante **Postman**.

## 🎯 Objetivo

Desarrollar una Web API en **Visual Studio Community** que permita verificar la comunicación con una base de datos MySQL, utilizando una estructura basada en modelos, controladores y una cadena de conexión configurada en `Web.config`.

## 🛠️ Actividades realizadas

1. Creación del proyecto Web API `apiRESTCheckBd`.
2. Creación del modelo `clsApiStatus`.
3. Creación del modelo `clsCheckBd`.
4. Instalación de las librerías necesarias.
5. Configuración de la conexión a MySQL mediante `Web.config`.
6. Creación del controlador `CheckBdController`.
7. Implementación del endpoint para comprobar la conexión.
8. Ejecución y prueba de la API mediante Postman.
9. Verificación de la conexión con la base de datos `CONTROL_ACCESO`.

## 📂 Estructura principal

```text
apiRESTCheckBd/
│
├── Controllers/
│   └── CheckBdController.cs
│
├── Models/
│   ├── clsApiStatus.cs
│   └── clsCheckBd.cs
│
├── Web.config
│
├── apiRESTCheckBd.sln
│
└── README.md
```

## 🔌 Prueba de conexión

La API cuenta con un endpoint encargado de ejecutar el método de comprobación de conexión con MySQL.

Ejemplo:

```http
GET /check/checkbd/mysqlconectioncheckbd
```

La prueba fue realizada mediante **Postman**.

## 📤 Respuesta obtenida

Cuando la conexión con MySQL se realiza correctamente, la API devuelve una respuesta JSON similar a la siguiente:

```json
{
    "statusExec": true,
    "msg": "Conexion exitosa (MySql) control_acceso",
    "ban": 1,
    "datos": {
        "msgData": "Conexion exitosa (MySql) control_acceso"
    }
}
```

El valor:

```json
"statusExec": true
```

indica que la ejecución fue correcta, mientras que:

```json
"ban": 1
```

indica que la conexión con la base de datos fue establecida exitosamente.

## 🗄️ Base de datos

La práctica utiliza la base de datos:

```text
CONTROL_ACCESO
```

La conexión se realiza desde la Web API utilizando **MySQL** y la cadena de conexión configurada en:

```text
Web.config
```

> **Nota:** Por seguridad, las contraseñas reales de la base de datos no deben publicarse en repositorios públicos.

## 💻 Tecnologías utilizadas

| Tecnología | Uso |
|---|---|
| C# | Desarrollo de la API |
| ASP.NET Web API | Creación del servicio REST |
| .NET Framework | Plataforma de desarrollo |
| Visual Studio Community | Entorno de desarrollo |
| MySQL | Base de datos |
| MySql.Data | Conexión entre C# y MySQL |
| Newtonsoft.Json | Manejo de objetos JSON |
| Postman | Pruebas del endpoint |
| Git / GitHub | Control de versiones |

## ✅ Resultado

Se obtuvo una **Web API funcional capaz de establecer comunicación con una base de datos MySQL**.

El endpoint desarrollado permite comprobar el estado de la conexión y devolver el resultado mediante un objeto JSON, verificando su funcionamiento mediante Postman.

---

<div align="center">

### Instituto Tecnológico de Pachuca

**Taller Avanzado de Desarrollo de Software**

*“Excelencia en Educación Tecnológica®”*

**2026**

</div>
