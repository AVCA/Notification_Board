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
    foreign key (codDia, codHora, codSalon) references Imparte (codDia, codHora, codSalon)
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
                                           (22,"22:00"),
                                           (24,"24:00"),
                                           (00,"00:00");

insert into Dia(codDia, nombre) values (1,"Lunes"),
									   (2,"Martes"),
                                       (3,"Miercoles"),
                                       (4,"Jueves"),
                                       (5,"Viernes");

insert into Profesor(codProfesor,nombre) values (1000,"Laura Taide Contreras Alvarez"),
												(1001,"Luis Francisco Cruces Alcantar"),
                                                (1002,"Graciela Mora Otero"),
                                                (1003,"Andres Berlanga Tellez Giron"),
                                                (1004,"Guadalupe Castilla Vazquez"),
                                                (1005,"Armando Becerra del Angel"),
                                                (1006,"Emilio Rocha Castan"),
                                                (1007,"Laura Cruz Reyes"),
                                                (1008,"Maria del Carmen de la Cruz Perez"),
                                                (1009,"Martha Bernanda Mojica Mata"),
                                                (1010,"Paula Araceli Aguilar Alcala");

insert into Materia(codMateria,nombre) values (2000,"Taller de Investigacion 1"),
											  (2001,"Ingenieria de Software"),
                                              (2002,"Simulacion"),
                                              (2003,"Administracion de Base de Datos"),
                                              (2004,"Modelos Matematicos y Algoritmos"),
                                              (2005,"Lenguajes y Automatas 1"),
                                              (2006,"Lenguajes de Interfaz"),
                                              (2007,"Mineria de Datos"),
                                              (2008,"Fundamentos de Base de Datos"),
                                              (2009,"Redes de Computadoras"),
                                              (2010,"Lenguajes y Automatas 2");

insert into Impartido(codMateria, codProfesor) values (2000,1001),
													  (2001,1000),
                                                      (2002,1002),
                                                      (2003,1003),
                                                      (2004,1004),
                                                      (2005,1005),
                                                      (2005,1010),
                                                      (2006,1006),
                                                      (2007,1007),
                                                      (2008,1008),
                                                      (2009,1009),
                                                      (2010,1010);

insert into Imparte(codDia, codHora, codSalon, codMateria, codProfesor) values (1,08,"FF6",2001,1000),
																			   (1,09,"FF1",2000,1001),
                                                                               (1,10,"FFC",2002,1002),
                                                                               (1,11,"FF6",2003,1003),
                                                                               (1,14,"FFD",2004,1004),
                                                                               (1,16,"FF3",2005,1005),
                                                                               (1,09,"FF4",2008,1008),
                                                                               (1,13,"FFD",2005,1010),
                                                                               (1,11,"FF2",2009,1009),
                                                                               (1,16,"FF5",2007,1007),
                                                                               (1,00,"FF6",2002,1002),
                                                                               (1,00,"FF7",2008,1008);

insert into Imparte(codDia, codHora, codSalon, codMateria, codProfesor) values (5,08,"FF6",2001,1000),
																			   (5,09,"FF1",2000,1001),
                                                                               (5,10,"FFC",2002,1002),
                                                                               (5,11,"FF6",2003,1003),
                                                                               (5,14,"FFD",2004,1004),
                                                                               (5,16,"FF3",2005,1005),
                                                                               (5,09,"FF4",2008,1008),
                                                                               (5,13,"FFD",2005,1010),
                                                                               (5,11,"FF2",2009,1009),
                                                                               (5,16,"FF5",2007,1007);

insert into Asistencia(codDia, codHora, codSalon, codProfesor, fecha) values (5,08,"FF6",1000,'2016-04-25'),
																			 (1,00,"FF6",1002,'2016-05-07');

-- ================================== Son todos los Select (Estan por orden) ===============================================
delimiter $$
create procedure VerProfesor()
begin
  Select Profesor.codProfesor as Codigo, Profesor.nombre as Nombre from Profesor;
end$$

delimiter $$
create procedure VerMateria()
begin
	Select Materia.codMateria as Codigo, Materia.nombre as Nombre from Materia;
end$$

drop procedure if exists VerMateria_Impartidas;
delimiter $$
create procedure VerMateria_Impartidas()
begin
	Select DISTINCT Materia.codMateria as Codigo, Materia.nombre as Nombre from Materia, impartido
	where Materia.codMateria = impartido.codMateria;
end$$
call VerMateria_Impartidas();

delimiter $$
create procedure VerImpartido()
begin
	Select Profesor.codProfesor as Codigo_Profesor, Profesor.nombre as Nombre_Profesor, 
    Materia.codMateria as Codigo_Materia, Materia.nombre as Materia_Nombre 
    from Profesor join Materia join Impartido
    on Impartido.codMateria=Materia.codMateria and Impartido.codProfesor=Profesor.codProfesor;
end$$
call VerImpartido();

delimiter $$
create procedure VerMateria_Imparte_Profesor(in codMateria int(4))
begin
	Select impartido.codProfesor as Codigo_Profesor, profesor.nombre as Nombre_Profesor
    from impartido,profesor where impartido.codMateria = codMateria and profesor.codProfesor=impartido.codProfesor;
end$$
call VerMateria_Imparte_Profesor(2000);

delimiter $$
create procedure VerSalon()
begin
	Select Salon.codSalon as Codigo_Salon from Salon;
end$$

create procedure VerSalonesLibres(in codD int(1), codH int(2))	
begin
	select Salon.codSalon as Salon
    from Salon
    where codSalon not in( Select codSalon from Imparte 
		  Where codDia=codD and codHora=codH);
	
end$$

delimiter $$
create procedure VerHorario()
begin
	Select Horario.codHora as Codigo, Horario.nombre as Nombre from Horario;
end$$

delimiter $$
create procedure VerDia()
begin
	Select Dia.codDia as Codigo, Dia.nombre as Nombre from Dia;
end$$

delimiter $$
create procedure VerImparte()
begin
	Select Dia.codDia, Horario.codHora, Profesor.nombre as Profesor, Materia.nombre as Materia, 
    Dia.nombre as Dia, Horario.nombre as Hora, Salon.codSalon as Salon
    from Imparte join Profesor join Materia join Salon join Horario join Dia
    on Imparte.codProfesor=Profesor.codProfesor
    and Imparte.codMateria=Materia.codMateria
    and Imparte.codDia=Dia.codDia
    and Imparte.codHora=Horario.codHora
    and Imparte.codSalon=Salon.codSalon
    order by Imparte.codDia;
end$$

delimiter $$
create procedure VerArchivos()
begin
	Select codArchivo as Codigo, nombre as Direccion_Archivo, duracion as Duracion from Archivos;
end$$

delimiter $$
create procedure VerAsistencia()
begin
	Select Profesor.nombre as Profesor, Dia.nombre as Dia, Horario.nombre as Hora, 
    Salon.codSalon as Salon, Asistencia.fecha as Fecha 
    from Asistencia join Profesor join Salon join Horario join Dia
    on Asistencia.codProfesor=Profesor.codProfesor
    and Asistencia.codDia=Dia.codDia
    and Asistencia.codHora=Horario.codHora
    and Asistencia.codSalon=Salon.codSalon
    order by Profesor.nombre;
end$$

delimiter $$
create procedure VerPorHora(in codD int(1), codH int(2))
begin
	Select Dia.nombre as Dia, Horario.nombre as Hora, Salon.codSalon as Salon,
    Profesor.nombre as Profesor, Materia.nombre as Materia, Dia.codDia, Horario.codHora, 
    Salon.codSalon, Profesor.codProfesor
    from Imparte join Materia join Profesor join Salon join Horario join Dia
    on Imparte.codDia=Dia.codDia
    and Imparte.codHora=Horario.codHora
    and Imparte.codSalon=Salon.codSalon
    and Imparte.codProfesor=Profesor.codProfesor
    and Imparte.codMateria=Materia.codMateria
    and Imparte.codDia=codD
    and Imparte.codHora=codH
    order by Imparte.codSalon;
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
create procedure EliminarImpartido(in codProf int(4), codMat int(4))
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
	insert into Impartido values(codMat,codProf);
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
    if not exists(select * from Imparte where codDia=codD and codHora=codHor and codSalon=codSal) then
		if exists(select * from Impartido where codMateria=codMat and codProfesor=codProf) then
			insert into Imparte values(codD,codHor,codSal,codMat,codProf);
			set respuesta=1; -- Insercion Exitosa en Materia
		else
			set respuesta=2; -- No existe esa combinacion en Impartido
		end if;
	else
		set respuesta=0; -- Ya existe ese registro
	end if;
    return respuesta;
end$$

delimiter $$
create function InsertarArchivo(codArch int(4), nomb varchar(500), dur int) returns varchar(4)
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
  if not exists(select * from Asistencia where codDia=codD and codHora=codHor and codSalon=codSal) then
	if exists(select * from Imparte where codDia=codD and codHora=codHor and codSalon=codSal) then
		insert into Asistencia values(codD,codHor,codSal,codProf,fech);
		set respuesta=1; -- Insercion Exitosa en Asistencia
	else
		set respuesta=-1; -- No existe registro de ese horario
	end if;
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
create function ActualizarImpartido(codMat int(4), codMatAct int(4), codProf int(4), codProfAct int(4)) returns varchar(4)
begin
	declare respuesta varchar(4);
	if exists(select * from Impartido where codMateria=codMat and codProfesor=codProf) then
        if ((codMat=codMatAct and codProf=codProfAct) or not exists(select * from Impartido where Impartido.codMateria=codMatAct and Impartido.codProfesor=codProfAct)) then
            update Impartido set Impartido.codMateria=codMatAct,
								Impartido.codProfesor=codProfAct
            where Impartido.codMateria=codMat and Impartido.codProfesor=codProf;
            set respuesta=1; -- ¡Actualizacion exitosa!
        else
            set respuesta= -2; -- [ERROR] La combinacion Profesor/Materia ya existe
        end if;
    else
        set respuesta= -1; -- [ERROR] No existe la Materia
    end if;
    return respuesta; 
end $$

delimiter $$
create function ActualizarArchivo(codArch int(4), codArchAct int(4), nomb varchar(500), dur int) returns varchar(4)
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

delimiter $$
create function ActualizarHorario(codD int(1), codH int(2), codS varchar(3), codDAct int(1), 
	codHAct int(2), codSAct varchar(3), codMAct int(4), codPAct int(4)) returns varchar(4)
begin
	declare respuesta varchar(4);
    if exists(select * from Imparte where codDia=codD and codHora=codH and codSalon=codS) then
		if exists(select * from Impartido where codMateria=codMAct and codProfesor=codPAct) then
			if ((codM=codMAct and codP=codPAct) or not exists(select * from Imparte where codDia=codDAct and codHora=codHAct and codSalon=codSAct)) then
				update Imparte set codDia=codDAct,
								   codHora=codHAct,
                                   codSalon=codSAct,
                                   codMateria=codMAct,
                                   codProfesor=codPAct
				where codDia=codD and codHora=codH and codSalon=codS;
				set respuesta=1; -- ¡Actualizacion exitosa!
			else
				set respuesta= -3; -- [ERROR] La clave del archivo ya existe
			end if;
		else
			set respuesta=-2; -- No existe la combinacion Materia/Profesor
        end if;
    else
        set respuesta= -1; -- [ERROR] No existe el registro del Horario
    end if;
    return respuesta; 
end $$