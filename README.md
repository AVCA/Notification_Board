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

---

### CD_Operaciones
Clase que permite ejecutar consultas SQL y obtener los registros correspondientes a las tablas ocupadas.

**Variables:**

- private CD_Conexion conexion; // Objeto para la conexion.
- MySqlDataReader leer; // Variabble que almacena los registros obtenidos de las consultas a tablas.
- DataTable tabla; // Objeto Tabla que almacena los registros obtenidos en Leer.
- MySqlCommand comando; // Objeto Comando manejar la conexion a la BD y de ejecutar las instruccions SQL.

**Metodos:**

- public DataTable Mostrar(string titulo);

Metodo encargado de obtener los registros obtenidos de una consulta y almacenarlos dentro de un Objeto tabla para retornar la tabla.

__Recibe:__

- [ ] String tabla : Titulo de la seccion que solicita la tabla.

__Retorna:__

- [ ] DataTable tabla: Tabla generada que contiene los registros de la consulta solicitada. Esta se cargara dentro de la interfaz que solicito la consulta.

---

- public void Operaciones(string tabla,string operacion, string v1, string v2, string v3, string v4, string v5)

Metodo encargado de ejecutar instrucciones SQL para INSERT, DELETE y UPDATE
mediante funciones o procedimientos.
Dependiendo de la tabla y la operacion ejecuta la instruccion correspondiente mediante un switch.

__Recibe:__

- [ ] String tabla : Titulo de la seccion que solicita la operacion.
- [ ] String operacion: Nombre de la operacion que se solicita ejecutar.
- [ ] String v1,v2,v3,v4,v5: Variables generales que reciben los valores a insertar.

**Nota:**
El metodo esta generalizado, es por esto que recibe 5 variables.
Si la inserccion solo ocupa dos valores los demas se dejan en blanco con "".

### CN_Operaciones
Clase que interviene entre la interfaz y CD_Operaciones. Se encarga de crear la tabla correspondiente a la interfaz y ademas se encarga enviar los valores necesarios para realizar alguna operacion de INSERT,DELETE,UPDATE.

**Variables:**

- CD_Operaciones objetoCD; // Objeto CD_Operaciones que recibira los valores necesarios para realizar alguna operacion.

**Metodos:**

- public DataTable Mostrar(string titulo)

Metodo encargado de obtener los registros obtenidos de una consulta y almacenarlos dentro de un Objeto tabla para retornar la tabla.

__Recibe:__

- [ ] String titulo : Titulo de la seccion que solicita la tabla.

__Retorna:__

- [ ] DataTable tabla: Tabla generada que contiene los registros de la consulta solicitada. Esta se cargara dentro de la interfaz que solicito la consulta.

---

- public void Operaciones(string tabla,string ope, string v1, string v2, string v3, string v4, string v5)

Metodo encargado de obtener los valores necesarios para realizar una operacion SQL ademas del titutlo de la seccion y la operacion a realizar.

__Recibe:__

- [ ] String tabla : Titulo de la seccion que solicita la operacion.
- [ ] String ope: Nombre de la operacion que se solicita ejecutar.
- [ ] String v1,v2,v3,v4,v5: Variables generales que reciben los valores a insertar.

