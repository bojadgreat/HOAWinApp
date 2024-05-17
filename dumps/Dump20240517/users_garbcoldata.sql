-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: users
-- ------------------------------------------------------
-- Server version	8.0.37

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `garbcoldata`
--

DROP TABLE IF EXISTS `garbcoldata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `garbcoldata` (
  `clientID` int NOT NULL AUTO_INCREMENT,
  `blockNum` int DEFAULT NULL,
  `lotNum` int DEFAULT NULL,
  `fName` varchar(45) DEFAULT NULL,
  `lName` varchar(45) DEFAULT NULL,
  `pDue` double DEFAULT NULL,
  `cDue` double DEFAULT NULL,
  `totPaid` double DEFAULT NULL,
  `dueDate` date DEFAULT NULL,
  `colRemarks` varchar(45) DEFAULT NULL,
  `payRemarks` varchar(45) DEFAULT NULL,
  `promRemarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`clientID`)
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `garbcoldata`
--

LOCK TABLES `garbcoldata` WRITE;
/*!40000 ALTER TABLE `garbcoldata` DISABLE KEYS */;
INSERT INTO `garbcoldata` VALUES (1,1,1,'Edwin','Cagoco',212000,12000,200000,'2024-10-01','Not for collection','Paid','NO'),(2,1,11,'Alberto','Cortes',237846.77000000002,238246.77000000002,0,'2024-09-01','Not for collection','Not Paid','NO'),(3,1,21,'Kae','Emad',210000,210400,0,'2024-09-01','Not for collection','Not Paid','NO'),(4,1,26,'Ronito','Nastor',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(5,1,33,'Irene','Jucom',211200,211600,0,'2024-09-01','Not for collection','Not Paid','NO'),(6,1,36,'Ephraimeen','Guadalquiver',215200,215600,0,'2024-09-01','Not for collection','Not Paid','NO'),(7,1,37,'Glen','Golle',212600,213000,0,'2024-09-01','Not for collection','Not Paid','NO'),(8,1,38,'Maryconne','Pitogo',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(9,2,6,'Luzmilyn','Maglasang',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(10,2,9,'Joseph Franz','Lanzaderas',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(11,2,11,'Wendell','Navarra',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(12,2,12,'Juanito','Abangan',213600,214000,0,'2024-09-01','Not for collection','Not Paid','NO'),(13,3,5,'Arlen','Padilla',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(14,3,11,'Renelito','Tangkay',209600,210000,0,'2024-09-01','Not for collection','Not Paid','NO'),(15,3,12,'Norman','Comaingking',210800,211200,0,'2024-09-01','Not for collection','Not Paid','NO'),(16,3,14,'Jhoanne','Borlasa',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(17,4,4,'Matronie','Alonso',209600,210000,0,'2024-09-01','Not for collection','Not Paid','NO'),(18,4,13,'Rosemarie','Alimpolos',233341.14,233741.14,0,'2024-09-01','Not for collection','Not Paid','NO'),(19,5,4,'Joanah Jean','Dianon',210000,210400,0,'2024-09-01','Not for collection','Not Paid','NO'),(20,5,10,'Jerlindo','Fuego',209600,210000,0,'2024-09-01','Not for collection','Not Paid','NO'),(21,6,8,'Edward','Francisco',216200,216600,0,'2024-09-01','Not for collection','Not Paid','NO'),(22,7,21,'Wella','Fernandez',213500,213900,0,'2024-09-01','Not for collection','Not Paid','NO'),(23,8,2,'Dexter','Amores',221600,222000,0,'2024-09-01','Not for collection','Not Paid','NO'),(24,8,9,'Rhaymund','Duterte',212000,212400,0,'2024-09-01','Not for collection','Not Paid','NO'),(25,8,10,'Merneil','Cabahug',213200,213600,0,'2024-09-01','Not for collection','Not Paid','NO'),(26,8,15,'Dunhill Johari','Talpis',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(27,8,18,'Ethel Marie','Roy',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(28,8,20,'Ramilo','Corbeta',232541.14,232941.14,0,'2024-09-01','Not for collection','Not Paid','NO'),(29,8,29,'Alrvin','Mecate',215700,216100,0,'2024-09-01','Not for collection','Not Paid','NO'),(30,8,30,'Gracele','Jumawan',209800,210200,0,'2024-09-01','Not for collection','Not Paid','NO'),(31,8,42,'Stephanie Kara','Emata',210000,210400,0,'2024-09-01','Not for collection','Not Paid','NO'),(32,9,1,'Julius','Quijano',213200,213600,0,'2024-09-01','Not for collection','Not Paid','NO'),(33,9,4,'Arvynn','Apilado',211600,212000,0,'2024-09-01','Not for collection','Not Paid','NO'),(34,9,5,'John Rey','Durias',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(35,9,7,'Vincent','Raotraot',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(36,9,21,'Clyde','Ybañez',211600,212000,0,'2024-09-01','Not for collection','Not Paid','NO'),(37,9,32,'Allan','Paracuellas',226500,226900,0,'2024-09-01','Not for collection','Not Paid','NO'),(38,9,40,'Vanessa','Rosolada',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(39,9,44,'Raymund','Devera',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(40,9,45,'Jaime','Gloria Jr.',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(41,10,19,'Herminia','Baculao',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(42,10,23,'Lave Larever','Pongase',214800,215200,0,'2024-09-01','Not for collection','Not Paid','NO'),(43,10,27,'Fitz Giuseppe','Masecampo',232551.14,232951.14,0,'2024-09-01','Not for collection','Not Paid','NO'),(44,10,31,'Archie','Lumayag',231409.32,231809.32,0,'2024-09-01','Not for collection','Not Paid','NO'),(45,11,2,'Alain','Gamutan',216625,217025,0,'2024-09-01','Not for collection','Not Paid','NO'),(46,11,16,'Llauder','Deogracias',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(47,11,18,'Rizaldo','Vilagonzalo',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(48,11,20,'Jhomer','Eclarino',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(49,11,21,'Angelica','Pilatan',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(50,11,23,'Jose','Nerves',228020,228420,0,'2024-09-01','Not for collection','Not Paid','NO'),(51,11,34,'Dulce','Pejante',212600,213000,0,'2024-09-01','Not for collection','Not Paid','NO'),(52,12,2,'Jessie','Romero',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(53,12,9,'Diane','Cimafranca',220575.14,220975.14,0,'2024-09-01','Not for collection','Not Paid','NO'),(54,12,13,'Filemon','Ordeniza Jr.',215500,215900,0,'2024-09-01','Not for collection','Not Paid','NO'),(55,12,14,'Julifel','Tapan',209000,209400,0,'2024-09-01','Not for collection','Not Paid','NO'),(56,12,19,'Cheryl','Orbiso',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(57,12,25,'Cindy Grace','Puschmann',221566.34,221966.34,0,'2024-09-01','Not for collection','Not Paid','NO'),(58,12,32,'Sunshine','Pardinan',212000,212400,0,'2024-09-01','Not for collection','Not Paid','NO'),(59,12,33,'Jerson','Saut',209600,210000,0,'2024-09-01','Not for collection','Not Paid','NO'),(60,12,38,'Jeric','Caluag',209600,210000,0,'2024-09-01','Not for collection','Not Paid','NO'),(61,12,43,'Abundio','Libres',215500,215900,0,'2024-09-01','Not for collection','Not Paid','NO'),(62,13,2,'Gay Audille','Ang',209400,209800,0,'2024-09-01','Not for collection','Not Paid','NO'),(63,13,4,'Silver Ryan','Subido',211600,212000,0,'2024-09-01','Not for collection','Not Paid','NO'),(64,13,6,'Ryan','Tampus',210000,209500,500,'2024-10-01','Not for collection','Paid','YES'),(65,13,19,'Rubie','Tunacao',209250,209650,0,'2024-09-01','Not for collection','Not Paid','NO'),(66,13,20,'Mary Sochin','Tunacao',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(67,14,6,'John Rey','Romorosa',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(68,14,7,'Rolan','Dahuya',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(69,14,12,'Emily','Pacana',221200,221600,0,'2024-09-01','Not for collection','Not Paid','NO'),(70,14,15,'April Rose','Flores',220500,220900,0,'2024-09-01','Not for collection','Not Paid','NO'),(71,15,3,'Freddie','Pino',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(72,15,5,'Mariecon','Pacuribot',213950.8,214350.8,0,'2024-09-01','Not for collection','Not Paid','NO'),(73,15,6,'Margareth','Ang',212400,212800,0,'2024-09-01','Not for collection','Not Paid','NO'),(74,15,19,'Dexter','Espinosa',209600,210000,0,'2024-09-01','Not for collection','Not Paid','NO'),(75,16,14,'Voltaire','Caminero',211600,212000,0,'2024-09-01','Not for collection','Not Paid','NO'),(76,16,16,'Evelyn Joy','Labuntig',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(77,16,17,'Mella','Nuenay',214909.25,215309.25,0,'2024-09-01','Not for collection','Not Paid','NO'),(78,16,18,'Vanessa Dawn','Silot',209800,210200,0,'2024-09-01','Not for collection','Not Paid','NO'),(79,17,2,'Gina','Natad',229830.25,230230.25,0,'2024-09-01','Not for collection','Not Paid','NO'),(80,17,19,'Ronald','Coyoca',208800,209200,0,'2024-09-01','Not for collection','Not Paid','NO'),(81,17,20,'Jaymark','Turado',226346.34,226746.34,0,'2024-09-01','Not for collection','Not Paid','NO'),(82,18,6,'Jorge','Paragile',209400,209800,0,'2024-09-01','Not for collection','Not Paid','NO'),(83,18,7,'Vincent Joel','Gagno',209400,209800,0,'2024-09-01','Not for collection','Not Paid','NO'),(84,18,19,'Margareth','Ang',211200,211600,0,'2024-09-01','Not for collection','Not Paid','NO'),(85,18,20,'Kristine Anne','Enriquez',209200,209600,0,'2024-09-01','Not for collection','Not Paid','NO'),(86,18,25,'Virgilio','Gonzaga',238169.37,238569.37,0,'2024-09-01','Not for collection','Not Paid','NO');
/*!40000 ALTER TABLE `garbcoldata` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-17 19:33:43
