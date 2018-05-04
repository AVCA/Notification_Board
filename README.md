# Notification_Board

## CapaDatos
### CD_Conexion
Clase que permite la conexion de la BD MYSQL a C#.
En caso de error, verifiquen en la variable Conexion que su contraseña y usuario esten correctos:
```
private MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1; database=escuela; Uid=root; pwd=root;");
```
*Variables:*
_private MySqlConnection Conexion;

*Metodos:*
_public MySqlConnection AbrirConexion()
_public MySqlConnection CerrarConexion()
