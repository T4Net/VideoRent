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
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `idemployee` int(11) NOT NULL AUTO_INCREMENT,
  `employee_name` varchar(45) NOT NULL,
  `employee_surname` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(200) NOT NULL,
  `salt` varchar(100) NOT NULL,
  `passcode` varchar(24) DEFAULT NULL,
  PRIMARY KEY (`idemployee`),
  UNIQUE KEY `username_UNIQUE` (`username`),
  UNIQUE KEY `salt_UNIQUE` (`salt`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Conor','McGregor','Conor','Vpk97mgBaZ4I2hqFUhEiyrwXXFWt0JIThYDXb2wJvONpDZUScPdpXxwFm5rKXifZdH75gMyD0rCHlmAA+ENdcw==','M1V{M1t=su','admin'),(2,'Aldo','McGregor','Aldo','D2WTj8yGN68rSS4Uldd6twG8g1wBtN/33F3fNkv1ogQHpvEWQtW6feSif1b7BLwAxM6gHw5l+tB2GDmf+ymJaQ==','M1V{M1t=su}T5Apbi!u+','admin'),(3,'Jose','Aldo','Jose','Tn4sHJgx/oMB5sJuWb5LiWncmDMuihu3KFJxBZKBleyhIaAAKJMhn3hFIVcRdaEwmgzVLspKpi3u/AIiBtNQ3w==','G8wLFb}RvP','admin'),(9,'Lord','Darkness','LordDarkness','iIKYnOZv36F5evnzN7piIcdpWADKy+M8Fy0LwJgJDTG4dCIJdeCbfBnsVVnzzGm2wj9zKTZCrDRA3hkSKId5gA==','zuHYZ5k^e}',NULL),(10,'grep','pane','paynw','Z12fcmPHcH9Xab0UEYA+ZGTOxh7gvZWmFWubgPNEK1j2MmduZb3yNpqGSI0PVlLh4jFgnCcfEFR9+tSyDUDyjg==','0t)0%J&4qs',NULL),(11,'piano','tune','tuna','XSGoz76UpqLmknGmNw8nJDoZ/aBBm2HGpB4Z5H/157DfwYYilEUHhFENnuCajibocmnFGc6aUPiGlGGlC6p9+g==','0t)0%J&4qspBUCGhs=8%',NULL),(12,'another','user','newuser','E0P8dpB3Ce635oJew6QimEs1qAF6I0wRG7bD6bJ0zxg0pzocfcL/9xhn6iv19HQ48Vzs7leLTheO+uvWKEe4Gg==','0t)0%J&4qspBUCGhs=8%V3UfFDXs4D',NULL),(13,'andonemore','anotherone','anotherone','RWpkCWUvV71aE+xk0tNp4eDWoqK8Tq15XT2MvK2EmFvkYsrmYGV3DpoiCbVyZ4F51IRPBdONRunvS2X/4Tc03A==','0t)0%J&4qspBUCGhs=8%V3UfFDXs4Dy4S<V}{rQw',NULL),(14,'test11','test','test11','jBbe45HCnUQobhYVI6Mq2ZdIg8hk/pqUWjF/7R9caw/7iYVHBW0fkOgv+M3qtdsz3xNwKRNg67pTsa0QNDP+uA==','0t)0%J&4qspBUCGhs=8%V3UfFDXs4Dy4S<V}{rQw3^0Apx58Ie',NULL);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-17 21:57:16
