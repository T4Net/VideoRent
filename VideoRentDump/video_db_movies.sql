CREATE DATABASE  IF NOT EXISTS `video_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `video_db`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: video_db
-- ------------------------------------------------------
-- Server version	5.7.12-log

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
-- Table structure for table `movies`
--

DROP TABLE IF EXISTS `movies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movies` (
  `movieID` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `category` varchar(45) DEFAULT NULL,
  `year` int(11) DEFAULT NULL,
  `language` varchar(30) DEFAULT NULL,
  `country` varchar(30) DEFAULT NULL,
  `availableCopies` int(11) NOT NULL,
  PRIMARY KEY (`movieID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movies`
--

LOCK TABLES `movies` WRITE;
/*!40000 ALTER TABLE `movies` DISABLE KEYS */;
INSERT INTO `movies` VALUES (1,'The Godfather',NULL,1972,'English','England',2),(2,'The Godfather: Part I',NULL,1974,'English','England',3),(3,'The Dark Knight',NULL,2008,'English','England',2),(4,'Schindler\'s List',NULL,1993,'Danish','Denmark',3),(5,'Twelve Angry Men',NULL,1957,'Spanish','Spain',2),(6,'Pulp Fiction',NULL,1994,'English','England',3),(7,'The Lord of the Rings: The Return of the King',NULL,2003,'English','USA',2),(8,' The Good, the Bad and the Ugly',NULL,1966,'French','France',3),(9,'Fight Club',NULL,1999,'English','England',2),(10,'The Lord of the Rings: The Fellowship of the Ring',NULL,2001,'Russian','Russia',3),(11,'Star Wars: Episode V - The Empire Strikes Back',NULL,1980,'English','England',2),(12,'Forest Gump ',NULL,1994,'German','Germany',3),(13,'Inception',NULL,2010,'German','Germany',2),(14,'The Lord of the Rings: The Two Towers',NULL,2002,'English','England',3),(15,'Flew Over the Cuckoo\'s Nest',NULL,1975,'Spanish','Spain',2),(16,'Goodfellas',NULL,1990,'Swedish','Sweden',3),(17,'The Matrix',NULL,1999,'English','England',2),(18,'The Seven Samurai',NULL,1954,'Italian','Italy',3),(19,'Star Wars',NULL,1977,'Swedish','Sweden',2),(20,'City of God',NULL,2002,'Romanian','Romania',3);
/*!40000 ALTER TABLE `movies` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-17 21:57:12
