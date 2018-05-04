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


