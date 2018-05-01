CREATE DATABASE  IF NOT EXISTS `escuela` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `escuela`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: escuela
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistencia` (
  `codMateria` int(4) NOT NULL,
  `codProfesor` int(4) NOT NULL,
  `asistencia` int(3) DEFAULT NULL,
  PRIMARY KEY (`codMateria`,`codProfesor`),
  CONSTRAINT `asistencia_ibfk_1` FOREIGN KEY (`codMateria`, `codProfesor`) REFERENCES `impartido` (`codMateria`, `codProfesor`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dia`
--

DROP TABLE IF EXISTS `dia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dia` (
  `codDia` int(1) NOT NULL,
  `nombre` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`codDia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dia`
--

LOCK TABLES `dia` WRITE;
/*!40000 ALTER TABLE `dia` DISABLE KEYS */;
INSERT INTO `dia` VALUES (1,'Lunes'),(2,'Martes'),(3,'Miercoles'),(4,'Jueves'),(5,'Viernes');
/*!40000 ALTER TABLE `dia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario`
--

DROP TABLE IF EXISTS `horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horario` (
  `codHora` int(2) NOT NULL,
  `nombre` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`codHora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario`
--

LOCK TABLES `horario` WRITE;
/*!40000 ALTER TABLE `horario` DISABLE KEYS */;
INSERT INTO `horario` VALUES (7,'07:00'),(8,'08:00'),(9,'09:00'),(10,'10:00'),(11,'11:00'),(12,'12:00'),(13,'13:00'),(14,'14:00'),(15,'15:00'),(16,'16:00'),(17,'17:00'),(18,'18:00'),(19,'19:00'),(20,'20:00'),(21,'21:00'),(22,'22:00');
/*!40000 ALTER TABLE `horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `impartido`
--

DROP TABLE IF EXISTS `impartido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `impartido` (
  `codMateria` int(4) NOT NULL,
  `codProfesor` int(4) NOT NULL,
  PRIMARY KEY (`codMateria`,`codProfesor`),
  KEY `codProfesor` (`codProfesor`),
  CONSTRAINT `impartido_ibfk_1` FOREIGN KEY (`codMateria`) REFERENCES `materia` (`codMateria`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `impartido_ibfk_2` FOREIGN KEY (`codProfesor`) REFERENCES `profesor` (`codProfesor`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `impartido`
--

LOCK TABLES `impartido` WRITE;
/*!40000 ALTER TABLE `impartido` DISABLE KEYS */;
/*!40000 ALTER TABLE `impartido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materia`
--

DROP TABLE IF EXISTS `materia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `materia` (
  `codMateria` int(4) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codMateria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materia`
--

LOCK TABLES `materia` WRITE;
/*!40000 ALTER TABLE `materia` DISABLE KEYS */;
INSERT INTO `materia` VALUES (1,'Ingenieria de Software'),(2,'Taller de Investigacion I'),(3,'Taller de Investigacion II'),(4,'Fundamentos de Investigacion'),(5,'Simulacion'),(6,'Administracion de Base de datos');
/*!40000 ALTER TABLE `materia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesor`
--

DROP TABLE IF EXISTS `profesor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `profesor` (
  `codProfesor` int(4) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`codProfesor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesor`
--

LOCK TABLES `profesor` WRITE;
/*!40000 ALTER TABLE `profesor` DISABLE KEYS */;
INSERT INTO `profesor` VALUES (1,'Ana Victoria Cavazos Argot'),(3,'300000000'),(5,'5'),(6,'6'),(8,'8'),(9,'000'),(10,'Javier'),(11,'11'),(12,'12'),(13,'13'),(14,'14'),(15,'15'),(16,'16'),(17,'17'),(19,'19'),(22,'owo');
/*!40000 ALTER TABLE `profesor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salon`
--

DROP TABLE IF EXISTS `salon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salon` (
  `codSalon` varchar(3) NOT NULL,
  PRIMARY KEY (`codSalon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salon`
--

LOCK TABLES `salon` WRITE;
/*!40000 ALTER TABLE `salon` DISABLE KEYS */;
INSERT INTO `salon` VALUES ('AUD'),('FF1'),('FF2'),('FF3'),('FF4'),('FF5'),('FF6'),('FF7'),('FF8'),('FF9'),('FFA'),('FFB'),('FFC'),('FFD'),('TIT');
/*!40000 ALTER TABLE `salon` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-04-08 19:57:08
