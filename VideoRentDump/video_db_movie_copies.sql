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
-- Table structure for table `movie_copies`
--

DROP TABLE IF EXISTS `movie_copies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movie_copies` (
  `movieID` int(11) NOT NULL,
  `movieIDCopy` int(11) NOT NULL,
  `currentlyHired` char(1) DEFAULT NULL,
  `memberID` int(11) DEFAULT NULL,
  `noOfCopies` int(2) NOT NULL,
  PRIMARY KEY (`movieIDCopy`),
  UNIQUE KEY `movieIDCopy_UNIQUE` (`movieIDCopy`),
  UNIQUE KEY `memberID_UNIQUE` (`memberID`),
  KEY `movieID_idx` (`movieID`),
  CONSTRAINT `memberID` FOREIGN KEY (`memberID`) REFERENCES `members` (`memberID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `movieIDs` FOREIGN KEY (`movieID`) REFERENCES `movies` (`movieID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movie_copies`
--

LOCK TABLES `movie_copies` WRITE;
/*!40000 ALTER TABLE `movie_copies` DISABLE KEYS */;
INSERT INTO `movie_copies` VALUES (1,10,'N',NULL,0),(1,11,'N',NULL,0),(2,20,'N',NULL,0),(2,21,'N',NULL,0),(2,22,'N',NULL,0),(3,30,'N',NULL,0),(3,31,'N',NULL,0),(4,40,'N',NULL,0),(4,41,'N',NULL,0),(4,42,'N',NULL,0),(5,50,'N',NULL,0),(5,51,'N',NULL,0),(6,60,'N',NULL,0),(6,61,'N',NULL,0),(6,62,'N',NULL,0),(7,70,'N',NULL,0),(7,71,'N',NULL,0),(8,80,'N',NULL,0),(8,81,'N',NULL,0),(8,82,'N',NULL,0),(9,90,'N',NULL,0),(9,91,'N',NULL,0),(10,100,'N',NULL,0),(10,101,'N',NULL,0),(10,102,'N',NULL,0),(11,110,'N',NULL,0),(11,111,'N',NULL,0),(12,120,'N',NULL,0),(12,121,'N',NULL,0),(12,122,'N',NULL,0),(13,130,'N',NULL,0),(13,131,'N',NULL,0),(14,140,'N',NULL,0),(14,141,'N',NULL,0),(14,142,'N',NULL,0),(15,150,'N',NULL,0),(15,151,'N',NULL,0),(16,160,'N',NULL,0),(16,161,'N',NULL,0),(16,162,'N',NULL,0),(17,170,'N',NULL,0),(17,171,'N',NULL,0),(18,180,'N',NULL,0),(18,181,'N',NULL,0),(18,182,'N',NULL,0),(19,190,'N',NULL,0),(19,191,'N',NULL,0),(20,200,'N',NULL,0),(20,201,'N',NULL,0),(20,202,'N',NULL,0);
/*!40000 ALTER TABLE `movie_copies` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `video_db`.`movie_copies_AFTER_UPDATE` 
AFTER UPDATE ON `movie_copies` FOR EACH ROW
UPDATE members
INNER JOIN movie_copies ON members.memberID = movie_copies.memberID
SET members.currentlyHired = IF(
movie_copies.currentlyHired <> members.currentlyHired, 
movie_copies.currentlyHired, members.currentlyHired)
WHERE members.memberID = movie_copies.memberID */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-17 21:57:16
