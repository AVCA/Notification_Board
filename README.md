# Notification_Board

## CapaDatos
### CD_Conexion
Clase que permite la conexion de la BD MYSQL a C#.

**En caso de error**, verifiquen en la variable Conexion que su contraseña y usuario esten correctos:
```csharp
private MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=escuela; Uid=root; pwd=root;");
```
**Variables:**

- private MySqlConnection Conexion;

**Metodos:**

- public MySqlConnection AbrirConexion()
- public MySqlConnection CerrarConexion()

### CD_Operaciones
Clase que permite ejecutar consultas SQL y obtener los registros correspondientes a las tablas ocupadas.

**Variables:**

- private CD_Conexion conexion; // Objeto para la conexion.
- MySqlDataReader leer; // Variabble que almacena los registros obtenidos de las consultas a tablas.
- DataTable tabla; // Objeto Tabla que almacena los registros obtenidos en Leer.
- MySqlCommand comando; // Objeto Comando manejar la conexion a la BD y de ejecutar las instruccions SQL.

**Metodos:**

Metodo encargado de obtener los registros obtenidos de una consulta y almacenarlos dentro de un Objeto tabla para retornar la tabla.
Recibe:
String tabla : Titulo de la seccion que solicita la tabla.
- public DataTable Mostrar(string titulo);

Metodo encargado de ejecutar instrucciones SQL para INSERT, DELETE y UPDATE
mediante funciones o procedimientos. 
Recibe:
String tabla : Titulo de la seccion que solicita la operacion.
String operacion: Nombre de la operacion que se solicita ejecutar.
