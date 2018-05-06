create database escuela;
use escuela;

create table Profesor(
	codProfesor int(4),
    nombre varchar(60),
    primary key (codProfesor)
); 

create table Materia(
	codMateria int(4),
    nombre varchar(50),
    primary key (codMateria)
);

create table Impartido(
	codMateria int(4),
    codProfesor int(4),
    primary key (codMateria,codProfesor),
    foreign key (codMateria) references Materia (codMateria)
    on delete cascade on update cascade,
    foreign key (codProfesor) references Profesor (codProfesor)
    on delete cascade on update cascade
);

create table Salon(
	codSalon varchar(3),
    primary key (codSalon)
);

create table Horario(
	codHora int(2),
    nombre varchar(10),
    primary key (codHora)
);

create table Dia(
	codDia int(1),
    nombre varchar(10),
    primary key (codDia)
);

create table Imparte(
	codDia int(1),
    codHora int(2),
    codSalon varchar(3),
    codMateria int(4),
    codProfesor int(4),
    primary key (codDia, codHora, codSalon),
    foreign key (codDia) references Dia (codDia)
    on delete cascade on update cascade,
    foreign key (codHora) references Horario (codHora)
    on delete cascade on update cascade,
    foreign key (codSalon) references Salon (codSalon)
    on delete cascade on update cascade,
    foreign key (codMateria, codProfesor) references Impartido (codMateria, codProfesor)
    on delete cascade on update cascade
);

create table Asistencia(
	codDia int(1),
    codHora int(2),
    codSalon varchar(3),
    codProfesor int(4),
    fecha date,
    primary key (codDia, codHora, codSalon),
    foreign key (codDia) references Dia (codDia)
    on delete cascade on update cascade,
    foreign key (codHora) references Horario (codHora)
    on delete cascade on update cascade,
    foreign key (codSalon) references Salon (codSalon)
    on delete cascade on update cascade,
    foreign key (codProfesor) references Profesor (codProfesor)
    on delete cascade on update cascade
);

create table Archivos(
	codArchivo int(4),
    nombre varchar(500),
    duracion int,
    primary key (codArchivo)
);

insert into Salon(codSalon) values("FF1"), 
								  ("FF2"), 
                                  ("FF3"), 
                                  ("FF4"), 
                                  ("FF5"), 
                                  ("FF6"), 
                                  ("FF7"), 
                                  ("FF8"), 
                                  ("FF9"), 
                                  ("FFA"), 
                                  ("FFB"), 
                                  ("FFC"), 
                                  ("FFD"), 
                                  ("AUD"), 
                                  ("TIT");

insert into Horario(codHora, nombre) values(07,"07:00"),
										   (08,"08:00"),
                                           (09,"09:00"),
                                           (10,"10:00"),
                                           (11,"11:00"),
                                           (12,"12:00"),
                                           (13,"13:00"),
                                           (14,"14:00"),
                                           (15,"15:00"),
                                           (16,"16:00"),
                                           (17,"17:00"),
                                           (18,"18:00"),
                                           (19,"19:00"),
                                           (20,"20:00"),
                                           (21,"21:00"),
                                           (22,"22:00");

insert into Dia(codDia, nombre) values (1,"Lunes"),
									   (2,"Martes"),
                                       (3,"Miercoles"),
                                       (4,"Jueves"),
                                       (5,"Viernes");
                                       
insert into Archivos(codArchivo,nombre,duracion) values(1,"01.jpg",3),
													   (2,"02.png",3),
                                                       (3,"03.png",3);

-- ================================== Son todos los Select (Estan por orden) ===============================================
delimiter $$
create procedure VerProfesor()
begin
  Select * from Profesor;
end$$

delimiter $$
create procedure VerMateria()
begin
	Select * from Materia;
end$$

delimiter $$
create procedure VerImpartido()
begin
	Select Profesor.codProfesor, Profesor.nombre, Materia.codMateria, Materia.nombre 
    from Profesor join Materia join Impartido
    on Impartido.codMateria=Materia.codMateria and Impartido.codProfesor=Profesor.codProfesor;
end$$

delimiter $$
create procedure VerSalon()
begin
	Select * from Salon;
end$$

delimiter $$
create procedure VerHorario()
begin
	Select * from Horario;
end$$

delimiter $$
create procedure VerDia()
begin
	Select * from Dia;
end$$

delimiter $$
create procedure VerImparte()
begin
	Select Profesor.nombre, Materia.nombre, Dia.nombre, Horario.nombre, Salon.codSalon
    from Imparte join Profesor join Materia join Salon join Horario join Dia
    on Imparte.codProfesor=Profesor.codProfesor
    and Imparte.codMateria=Materia.codMateria
    and Imparte.codDia=Dia.codDia
    and Imparte.codHora=Horario.codHora
    and Imparte.codSalon=Salon.codSalon
    order by Profesor.nombre;
end$$

delimiter $$
create procedure VerArchivos()
begin
	Select * from Archivos;
end$$

delimiter $$
create procedure VerAsistencia()
begin
	Select Profesor.nombre, Dia.nombre, Horario.nombre, Salon.codSalon, Asistencia.fecha 
    from Asistencia join Profesor join Salon join Horario join Dia
    on Asistencia.codProfesor=Profesor.codProfesor
    and Asistencia.codDia=Dia.codDia
    and Asistencia.codHora=Horario.codHora
    and Asistencia.codSalon=Salon.codSalon
    order by Profesor.nombre;
end$$


-- ================================== Son todos los Delete (Estan por orden) ===============================================
delimiter $$
create procedure EliminarProfesor(in codProf int(4))
begin
	Delete from Profesor where codProfesor=codProf;
end$$

delimiter $$
create procedure EliminarMateria(in codMat int(4))
begin
	Delete from Materia where codMateria=codMat;
end$$

delimiter $$
create procedure EliminarImpartido(codMat int(4), in codProf int(4) )
begin
	Delete from Impartido where codProfesor=codProf and codMateria=codMat;
end$$

delimiter $$
create procedure EliminarSalon(in codSal varchar(3))
begin
	Delete from Salon where codSalon=codSal;
end$$

delimiter $$
create procedure EliminarHorario(in codHor int(2))
begin
	Delete from Horario where codHora=codHor;
end$$

delimiter $$
create procedure EliminarDia(in codD int(1))
begin
	Delete from Dia where codDia=codD;
end$$

delimiter $$
create procedure EliminarImparte(in codD int(1), codHor int(2), codSal varchar(3))
begin
	Delete from Imparte where codDia=codD and codHora=codHor and codSalon=codSal;
end$$

delimiter $$
create procedure LimpiarAsistencia()
begin
	Delete from Asistencia;
end$$

delimiter $$
create procedure EliminarArchivo(in codArch int(4))
begin
	Delete from Archivos where codArchivo=codArch;
end$$

delimiter $$
create procedure EliminarAsistencia(in codD int(1), codHor int(2), codSal varchar(3))
begin
	Delete from Asistencia where codDia=codD and codHora=codHor and codSalon=codSal;
end$$

-- ============================================= Son todos los Insert (Estan por orden) =============================================
delimiter $$
create function InsertarProfesor(codProf int(4), nomb varchar(60)) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Profesor where codProfesor=codProf) then
	insert into Profesor values(codProf, nomb);
    set respuesta=1; -- Insercion Exitosa en Profesor
else
	set respuesta=0; -- Ya existe el profesor
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarMateria(codMat int(4), nomb varchar(50)) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Materia where codMateria=codMat) then
	insert into Materia values(codMat, nomb);
    set respuesta=1; -- Insercion Exitosa en Materia
else
	set respuesta=0; -- Ya existe la Materia
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarImpartido(codMat int(4), codProf int(4)) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Impartido where codMateria=codMat and codProfesor=codProf) then
	insert into Impartido values(codMateria,codProfesor);
    set respuesta=1; -- Insercion Exitosa en Impartido
else
	set respuesta=0; -- Esa combinacion de Profesor y Materia ya existe
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarSalon(codSal varchar(3)) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Salon where codSalon=codSal) then
	insert into Salon values(codSal);
    set respuesta=1; -- Insercion Exitosa en Salon
else
	set respuesta=0; -- Ya existe el Salon
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarHora(codHor int(2), nomb varchar(10)) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Horario where codHora=codHor) then
	insert into Horario values(codHor, nomb);
    set respuesta=1; -- Insercion Exitosa en Horario
else
	set respuesta=0; -- Ya existe la Hora
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarDia(codd int(1), nomb varchar(10)) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Dia where codDia=codD) then
	insert into Dia values(codD, nomb);
    set respuesta=1; -- Insercion Exitosa en Dia
else
	set respuesta=0; -- Ya existe el Dia
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarImparte(codD int(1), codHor int(2), codSal varchar(3), codMat int(4), codProf int(4)) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Imparte where codDia=codD and codHors=codHor and codSalon=codSal) then
	insert into Imparte values(codD,codHor,codSal,codMat,codProf);
    set respuesta=1; -- Insercion Exitosa en Materia
else
	set respuesta=0; -- Ya existe esa combinacion
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarArchivo(codArch int(4), nomb char, dur int) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Archivos where codArchivo=codArch) then
	insert into Archivos values(codArch, nomb, dur);
    set respuesta=1; -- Insercion Exitosa en Archivo
else
	set respuesta=0; -- Ya existe el archivo
end if;
    return respuesta;
end$$

delimiter $$
create function InsertarAsistencia(codD int(1), codHor int(2), codSal varchar(3), codProf int(4), fech date) returns varchar(4)
begin
  declare respuesta varchar(4);
  if not exists(select * from Asistencia where codDia=codD and codHors=codHor and codSalon=codSal) then
	insert into Asistencia values(codD,codHor,codSal,codProf,fech);
    set respuesta=1; -- Insercion Exitosa en Asistencia
else
	set respuesta=0; -- Ya existe esa combinacion
end if;
    return respuesta;
end$$

-- ============================================= Son todos los Update (Estan por orden) =============================================
delimiter $$
create function ActualizarProfesor(codProf int(4), codProfAct int(4), nombre varchar(60)) returns varchar(4)
begin
	declare respuesta varchar(4);
	if exists(select * from Profesor where Profesor.codProfesor=codProf) then
        if (codProf=codProfAct or not exists(select * from Profesor where Profesor.codProfesor=codProfAct)) then
            update Profesor set Profesor.codProfesor=codProfAct,
								Profesor.nombre=nombre
            where Profesor.codProfesor=codProf;
            set respuesta=1; -- ¡Actualizacion exitosa!
        else
            set respuesta= -2; -- [ERROR] La clave del Profesor ya existe
        end if;
    else
        set respuesta= -1; -- [ERROR] No existe el Profesor
    end if;
    return respuesta; 
end $$

delimiter $$
create function ActualizarMateria(codMat int(4), codMatAct int(4), nombre varchar(50)) returns varchar(4)
begin
	declare respuesta varchar(4);
	if exists(select * from Materia where Materia.codMateria = codMat) then
        if (codMat=codMatAct or not exists(select * from Materia where Materia.codMateria = codMatAct)) then
            update Materia set Materia.codMateria=codMatAct,
							   Materia.nombre=nombre
            where Materia.codMateria=codMat;
            set respuesta=1; -- ¡Actualizacion exitosa!
        else
            set respuesta= -2; -- [ERROR] La clave de la Materia ya existe
        end if;
    else
        set respuesta= -1; -- [ERROR] No existe la Materia
    end if;
    return respuesta; 
end $$

delimiter $$
create function ActualizarTrabajador(dni varchar(9),dniAct varchar(9), nombre varchar(40), telefono varchar(15)) returns varchar(4)
begin
	declare respuesta varchar(4);
	if exists(select * from Trabajador where Trabajador.dni = dni) then
        if (dni=dniAct or not exists(select * from Trabajador where Trabajador.dni = dniAct)) then
            update Trabajador set Trabajador.dni=dniAct,
                                  Trabajador.nombre=nombre,
                                  Trabajador.telefono=telefono
            where Trabajador.dni=dni;
            set respuesta=1; -- ¡Actualizacion exitosa!
        else
            set respuesta= -2; -- [ERROR] La PK actualizada ya existe
        end if;
    else
        set respuesta= -1; -- [ERROR] No existe el registro que se desea actualizar
    end if;
    return respuesta; 
end $$

delimiter $$
create function ActualizarArchivo(codArch int(4), codArchAct int(4), nomb char, dur int) returns varchar(4)
begin
	declare respuesta varchar(4);
	if exists(select * from Archivos where Archivos.codArchivo = codArch) then
        if (codArch=codArchAct or not exists(select * from Archivos where Archivos.codArchivo = codArchAct)) then
            update Archivos set Archivos.codArchivo=codArchAct,
								Archivos.nombre=nomb,
								Archivos.duracion=dur
            where Archivos.codArchivo=codArch;
            set respuesta=1; -- ¡Actualizacion exitosa!
        else
            set respuesta= -2; -- [ERROR] La clave del archivo ya existe
        end if;
    else
        set respuesta= -1; -- [ERROR] No existe el archivo
    end if;
    return respuesta; 
end $$