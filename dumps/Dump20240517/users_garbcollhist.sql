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
-- Table structure for table `garbcollhist`
--

DROP TABLE IF EXISTS `garbcollhist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `garbcollhist` (
  `transNum` int NOT NULL AUTO_INCREMENT,
  `dateTimeStamp` datetime DEFAULT NULL,
  `fName` varchar(45) DEFAULT NULL,
  `amPaid` varchar(45) DEFAULT NULL,
  `transDate` datetime DEFAULT NULL,
  `payRem` varchar(100) DEFAULT NULL,
  `colRem` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`transNum`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `garbcollhist`
--

LOCK TABLES `garbcollhist` WRITE;
/*!40000 ALTER TABLE `garbcollhist` DISABLE KEYS */;
INSERT INTO `garbcollhist` VALUES (1,'2024-03-05 06:57:00','Cagoco,Edwin','400','2024-03-05 00:00:00','PAID','For Collection'),(2,'2024-03-06 14:25:00','Cagoco,Edwin','200','2024-03-06 00:00:00','PAID','Not For Collection'),(3,'2024-03-06 14:58:00','Cagoco,Edwin','200','2024-03-06 00:00:00','PAID','Not For Collection'),(4,'2024-03-06 14:39:00','Cagoco,Edwin','200','2024-03-06 00:00:00','PAID','Not For Collection'),(5,'2024-03-22 14:39:00','Boja,CJ','500','2024-03-22 00:00:00','PAID','For Collection'),(6,'2024-03-29 16:38:00','Tampus,Ryan','500','2024-03-29 00:00:00','PAID','Not For Collection'),(7,'2024-04-06 15:40:00','Cagoco,Edwin','200000','2024-04-06 00:00:00','NOT PAID','Not For Collection');
/*!40000 ALTER TABLE `garbcollhist` ENABLE KEYS */;
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
