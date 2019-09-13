-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: opr-dev.cpg5wznsaxzi.us-east-2.rds.amazonaws.com    Database: OCR_DEV
-- ------------------------------------------------------
-- Server version	5.7.22-log

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
-- Table structure for table `ClothingSize`
--

DROP TABLE IF EXISTS `ClothingSize`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ClothingSize` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(15) NOT NULL,
  `GenderId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `GenderId_ClothingSize_idx` (`GenderId`),
  CONSTRAINT `GenderId_ClothingSize` FOREIGN KEY (`GenderId`) REFERENCES `Gender` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ClothingSize`
--

LOCK TABLES `ClothingSize` WRITE;
/*!40000 ALTER TABLE `ClothingSize` DISABLE KEYS */;
INSERT INTO `ClothingSize` VALUES (1,'M X-Small',1),(2,'M Small',1),(3,'M Medium',1),(4,'M Large',1),(5,'M X-Large',1),(6,'F X-Small',2),(7,'F Small',2),(8,'F Medium',2),(9,'F Large',2),(10,'F X-Large',2);
/*!40000 ALTER TABLE `ClothingSize` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Gender`
--

DROP TABLE IF EXISTS `Gender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Gender` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Gender`
--

LOCK TABLES `Gender` WRITE;
/*!40000 ALTER TABLE `Gender` DISABLE KEYS */;
INSERT INTO `Gender` VALUES (1,'Male'),(2,'Female');
/*!40000 ALTER TABLE `Gender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Race`
--

DROP TABLE IF EXISTS `Race`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Race` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RaceName` varchar(50) NOT NULL,
  `RaceDate` date NOT NULL,
  `RaceCity` varchar(50) NOT NULL,
  `RaceStateId` int(11) DEFAULT NULL,
  `RaceStatusId` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `RaceStatusId_Race_idx` (`RaceStatusId`),
  CONSTRAINT `RaceStatusId_Race` FOREIGN KEY (`RaceStatusId`) REFERENCES `StatusRace` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Race`
--

LOCK TABLES `Race` WRITE;
/*!40000 ALTER TABLE `Race` DISABLE KEYS */;
/*!40000 ALTER TABLE `Race` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RacePace`
--

DROP TABLE IF EXISTS `RacePace`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `RacePace` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Pace` time NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RacePace`
--

LOCK TABLES `RacePace` WRITE;
/*!40000 ALTER TABLE `RacePace` DISABLE KEYS */;
INSERT INTO `RacePace` VALUES (1,'00:02:00'),(2,'00:02:05'),(3,'00:02:10'),(4,'00:02:15'),(5,'00:02:20'),(6,'00:02:25'),(7,'00:02:30'),(8,'00:02:35'),(9,'00:02:40'),(10,'00:02:45'),(11,'00:02:50'),(12,'00:02:55'),(13,'00:03:00'),(14,'00:03:05'),(15,'00:03:10'),(16,'00:03:15'),(17,'00:03:20'),(18,'00:03:25'),(19,'00:03:30'),(20,'00:03:35'),(21,'00:03:40'),(22,'00:03:45'),(23,'00:03:50'),(24,'00:03:55'),(25,'00:04:00'),(26,'00:04:05'),(27,'00:04:10'),(28,'00:04:15'),(29,'00:04:20'),(30,'00:04:25'),(31,'00:04:30'),(32,'00:04:35'),(33,'00:04:40'),(34,'00:04:45'),(35,'00:04:50'),(36,'00:04:55'),(37,'00:05:00'),(38,'00:05:05'),(39,'00:05:10'),(40,'00:05:15'),(41,'00:05:20'),(42,'00:05:25'),(43,'00:05:30'),(44,'00:05:35'),(45,'00:05:40'),(46,'00:05:45'),(47,'00:05:50'),(48,'00:05:55'),(49,'00:06:00'),(50,'00:06:05'),(51,'00:06:10'),(52,'00:06:15'),(53,'00:06:20'),(54,'00:06:25'),(55,'00:06:30'),(56,'00:01:55'),(57,'00:01:50'),(58,'00:01:45'),(59,'00:01:40'),(60,'00:01:35'),(61,'00:01:40'),(62,'00:01:35'),(63,'00:01:30'),(64,'00:01:25'),(65,'00:01:20'),(66,'00:01:15'),(67,'00:01:10'),(68,'00:01:05'),(69,'00:01:00');
/*!40000 ALTER TABLE `RacePace` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RaceToRaceType`
--

DROP TABLE IF EXISTS `RaceToRaceType`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `RaceToRaceType` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RaceTypeId` int(11) NOT NULL,
  `RaceId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `RaceTypeId_RaceToRaceType_idx` (`RaceTypeId`),
  KEY `RaceId_RaceToRaceType_idx` (`RaceId`),
  CONSTRAINT `RaceId_RaceToRaceType` FOREIGN KEY (`RaceId`) REFERENCES `Race` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `RaceTypeId_RaceToRaceType` FOREIGN KEY (`RaceTypeId`) REFERENCES `RaceType` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RaceToRaceType`
--

LOCK TABLES `RaceToRaceType` WRITE;
/*!40000 ALTER TABLE `RaceToRaceType` DISABLE KEYS */;
/*!40000 ALTER TABLE `RaceToRaceType` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RaceType`
--

DROP TABLE IF EXISTS `RaceType`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `RaceType` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RaceType`
--

LOCK TABLES `RaceType` WRITE;
/*!40000 ALTER TABLE `RaceType` DISABLE KEYS */;
INSERT INTO `RaceType` VALUES (1,'5k'),(2,'10k'),(3,'Half Marathon'),(4,'Full Marathon'),(5,'50k'),(6,'50 miler'),(7,'100k'),(8,'100 miler');
/*!40000 ALTER TABLE `RaceType` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RacesToRunners`
--

DROP TABLE IF EXISTS `RacesToRunners`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `RacesToRunners` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RaceId` int(11) NOT NULL,
  `RaceTypeId` int(11) NOT NULL,
  `RunnerId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `RaceTypeId_RacesToRunners_idx` (`RaceTypeId`),
  KEY `RaceId_RacesToRunners_idx` (`RaceId`),
  KEY `RunnerId_RacesToRunners_idx` (`RunnerId`),
  CONSTRAINT `RaceId_RacesToRunners` FOREIGN KEY (`RaceId`) REFERENCES `Race` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `RaceTypeId_RacesToRunners` FOREIGN KEY (`RaceTypeId`) REFERENCES `RaceType` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `RunnerId_RacesToRunners` FOREIGN KEY (`RunnerId`) REFERENCES `Runner` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RacesToRunners`
--

LOCK TABLES `RacesToRunners` WRITE;
/*!40000 ALTER TABLE `RacesToRunners` DISABLE KEYS */;
/*!40000 ALTER TABLE `RacesToRunners` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Runner`
--

DROP TABLE IF EXISTS `Runner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Runner` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `PhoneNumber` varchar(12) DEFAULT NULL,
  `ClothingSizeId` int(11) DEFAULT NULL,
  `RunnerNote` varchar(5000) DEFAULT NULL,
  `RacePaceId` int(11) DEFAULT NULL,
  `Address` varchar(150) DEFAULT NULL,
  `City` varchar(150) DEFAULT NULL,
  `StateId` int(11) DEFAULT NULL,
  `Zipcode` varchar(10) DEFAULT NULL,
  `GenderId` int(11) NOT NULL DEFAULT '1',
  `Age` int(11) DEFAULT NULL,
  `RunnerStatusId` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `GenderId_Gender_idx` (`GenderId`),
  KEY `StateId_States_idx` (`StateId`),
  KEY `StatusRunnerId_Runner_idx` (`RunnerStatusId`),
  CONSTRAINT `GenderId_Gender` FOREIGN KEY (`GenderId`) REFERENCES `Gender` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `StateId_States` FOREIGN KEY (`StateId`) REFERENCES `States` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `StatusRunnerId_Runner` FOREIGN KEY (`RunnerStatusId`) REFERENCES `StatusRunner` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=241 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Runner`
--

LOCK TABLES `Runner` WRITE;
/*!40000 ALTER TABLE `Runner` DISABLE KEYS */;
INSERT INTO `Runner` VALUES (3,'Colette','Adore','Medic4babe@aol.com','610-710-6063',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(4,'Shilpi ','Adya','shilpiadya@hotmail.com','469-562-8738',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(5,'Lisa','Allen','allen.lisa7@gmail.com','214-923-1656',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(6,'Terry','Anderson','terry.w.anderson@gmail.com','847-567-8494',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(7,'Heidi ','Anhaldt','runrgrl@gmail.com','319-360-4817',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(9,'Brent','Baravetto','turboman1996@gmail.com','920-530-3593',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(11,'Scott','Bartels','scott.j.bartels@hotmail.com','920-819-8170',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(12,'Dan','Beck','danbeck@corridorrunning.com','319-430-8267',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(15,'Jim','Benner','jjbenner99@yahoo.com','832-725-2127',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(16,'Lindsay','Benson','lindsay.e.riley@gmail.com','508-612-5364',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(17,'Dan','Bessette','db7152502686@icloud.com','715-250-2686',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(18,'Kevin ','Bielinski','kcb0207@gmail.com','920-680-8558',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(21,'Ryan ','Borucki','ryan.borucki@hotmail.com','503-816-2771',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(22,'Aaron','Braunstein','christopher.roller2@gmail.com','4148409070',NULL,NULL,NULL,'3485 N 88th St','Milwaukee',48,NULL,1,NULL,1),(24,'Curt ','Brey','gainhp@yahoo.com','920-323-7627',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(25,'Rich','Brooks','Email Todd Burns','507-221-2892',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(28,'Todd','Burns','toddaburns@hotmail.com','508-246-0190',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(29,'Tommy ','Byrne','tommy@headway.io','920-288-7942',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(30,'Jeanette ','Caballero-Bell','skinnyminnieinmejcb@gmail.com','214-592-3760',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(33,'Jo','Chang','joseobchang@gmail.com','847-414-6887',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(34,'Kara ','Cherne','cherne9309@gmail.com','920-574-6627',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(35,'Joey','Cleaves','jjcleaves@live.com','920-370-3313',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(36,'Zach','Cloe','zach_cloe@hotmail.com','515-975-6088',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(37,'Robin ','Coburn','rcoburn@new.rr.com','920-470-1200',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(38,'Elise ','Coon','elise.manders@gmail.com','920-205-2428',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(39,'Joel ','Coon','mtnbykr_99@yahoo.com','920-819-6236',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(40,'Deanne','Cooper','cooper16@sbcglobal.net','847-894-9979',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(41,'Bobby','Cooper','rodec2@sbcglobal.net','847-977-0492',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(42,'Tom','Cotter','twcotter@gmail.com','920-606-2060',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(43,'Julianna','Coughlin','jcoughlin195@aol.com','508-887-1024',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(44,'Katy','Coughlin','coughlinkm6@gmail.com','508-864-4728',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(45,'Andrea','Dalebroux','andreajanow@yahoo.com','920-639-8889',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(46,'Steph ','Davidson','stephmdavidson@gmail.com','512-659-5548',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(49,'Kathy','Derks','derks94@gmail.com','920-470-4215',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(51,'Ron','DuVernay','bilronn@gmail.com ','920-830-9637',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(52,'Tammy ','Eiland','tammy12ann@aol.com','985-778-6796',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(53,'Tom','Enright','tlenright2@wisc.edu','262-327-2585',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(54,'Jose','Escoriza','jce159@gmail.com','321-440-8330',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(55,'Ken ','Fattmann','drfatt@aol.com','417-350-3553',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(56,'Cleo','Ferris','cleo_ferris@yahoo.com','920-737-2555',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(57,'Katie ','Feucht','katie.feucht@yahoo.com','920-428-2208',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(59,'Katie','Fritz','fritzkt@gmail.com','701-226-8308',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(60,'Jorge','Gallo','jgallo619@hotmail.com','847-337-3629',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(61,'Blanca ','Garcia','Bgarcia@mckinneytexas.org','469-288-2380',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(62,'Mark ','Garrigan','mark@nurun.co','920-217-4980',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(63,'Marc','Gill','gillanaut@yahoo.com','501-952-6272',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(64,'Tressa','Gitzlaff','tressa@gitzlaff.net','715-574-3929',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(65,'Kayla ','Glenn','kaylaglenn30@gmail.com','715-409-9579',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(66,'Eric ','Gorder','egorder@sbcglobal.net','920-819-2896',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(68,'Debbie','Gutenerberg','debbienjim@tds.net','920-639-3068',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(69,'Rob','Hampton','rghampton@gmail.com',' 920-436-015',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(70,'Jason ','Helgeson','jason.helgeson@hshs.org','920-609-2485',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(71,'Katie ','Herald','kherald13@gmail.com','920-471-5021',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(72,'Aaron','Hizon','aaronhizon@gmail.com','920-254-3525',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(74,'Eddie ','Holzem','eholzem88@gmail.com','920-419-7601',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(75,'Christian','Holzheu','chrisholzheu@gmail.com ','612-875-2288',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(76,'Trey','Horbinski','treyhorbins@gmail.com','608-548-7453',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(77,'Katie','Houle','katiehoule@gmail.com','920-471-7867',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(78,'Jeri ','Howey','jerihowey@yahoo.com','920-609-5442',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(79,'Tom','Huben','tomhuben1@aol.com','920-309-7434',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(80,'Kimberly','Huntley','kimberly_huntley@hotmail.com','414-915-2877',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(81,'Mitch ','Isaac ','trailrunner3854@gmail.com','920-479-5622',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(82,'Tim ','Jakubek','timjakubek@gmail.com','920-205-6300',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(83,'Mike','James','Mjjames@new.rr.com','920-309-2304',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(84,'Jenny ','Johnson','jennifer.m.johnson@kcc.com','920-216-9653',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(85,'Adam','Johnson','Eh.es.jay@gmail.com','715-614-9665',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(86,'Eric ','Johnson',' ejohnson@imperialsupplies.com','920-857-4804',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(87,'Daniel ','Johnston','Daniel.Johnston@foth.com','920-585-2929',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(88,'Mike','Jovanovich','Mike.jovanovich@gmail.com ','920-540-2313',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(90,'Rhonda','Kempen','Rjk091275@gmail.com','414-617-8810',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(91,'Teresa','Kennedy','tbrennankennedy@gmail.com','920-362-1219',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(94,'Matt ','Kilka','mrklika@gmail.com','920-241-4538',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(95,'Stephanie','Kliethermes','stephanie.kliethermes@gmail.com','630-437-1795',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(96,'Peter','Klinner','pklinner@uwalumni.com','715-965-6696',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(97,'Jeremy','Knaus','anomalie@gmail.com','920-227-5398',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(98,'Chad ','Koch','Chad.koch@gmail.com ','608-616-9283',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(99,'Jackie ','Kohlhagen','jackiekohlhagen@yahoo.com','920-428-0057',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(100,'Stuart','Kolb','spkolb@new.rr.com','920-676-1341',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(101,'Robin','Kopelman','robin.kopelman@gmail.com','319-331-6387',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(102,'Don','Kossow','don.kossow@gmail.com','262-366-8625',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(103,'Cassie ','Kottke','stridemultisport@yahoo.com','920-428-4255',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(104,'Tim ','Kowols','kowotd27@gmail.com','847-772-1210',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(105,'Fred','Kramer','frkramer44@gmail.com','920-664-5488',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(106,'Carla','Lacombe','rungirl@comcast.net','508-287-4972',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(107,'Abby','Leach','abby@leachlawalbertlea.com','507-391-0361',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(110,'Jennifer','Lefor','jamjoanz@yahoo.com','715-919-1395',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(111,'Jessica ','LeMere','firedancer1974@gmail.com',' 920-639-996',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(112,'Mike','LeMere','michael.lamere@prevea.com','920-217-1551',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(113,'Paul ','LeTourneau','prl@letourneauplastics.net','920-362-1086',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(114,'Keith ','Lindsey','keith.lindsey@gmail.com','914-484-8849',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(115,'Gina ','Lindwall','gina.lindwall@gmail.com','608-358-3347',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(116,'TJ ','Lindwall','tommyjon1@yahoo.com','608-333-2683',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(117,'Anissa ','Lodzinski','ronandanissa@gmail.com','920-606-4883',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(118,'Shawn','Loy','sloy@highlandhuskies.org','319-461-1395',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(119,'Larry','Lueck','larslueck@yahoo.com','920-621-9948',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(121,'Jess ','Maher','maherjess@gmail.com','917-692-4156',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(122,'Erin','Mahr','erinmkleiber@gmail.com','309-738-0760',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(123,'Robin','Manning','robinmanning@comcast.net','508-364-0021',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(124,'Allyson ','Marshall','allyson@marshallvillage.com','512-633-0360',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(127,'Sue','Martin','sue0362@yahoo.com','608-481-3854',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(128,'Beth Ann ','Matlock','cruzinmom1@gmail.com','512-934-0918',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(129,'Alastair','Matthews','alastairnmatthews@gmail.com',' 920 797 934',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(130,'Gordy','McDaniel','gmcdaniel1@new.rr.com','920-788-9545',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(131,'Shannon','McFarland','Shannon.mcfarland@live.com','314-805-4267',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(132,'Cleve ','Meacham','akarig@yahoo.com','832-646-3420',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(134,'Theresa ','Meredith','drewfish21@gmail.com','920-203-3255',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(135,'Paula ','Meyer','meyerpaula84@gmail.com','920-915-8873',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(136,'Carrie ','Miller','carrielmiller99@gmail.com','920-309-2444',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(137,'Paul ','Miller','pmiller@entrision.com','920-217-3456',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(138,'Adam','Monaghan','adammonaghan83@gmail.com','316-734-4466',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(139,'Mary','Moran','mary.p.moran@gmail.com','608-772-5999',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(140,'Tim ','Muldoon','muldoontm@gmail.com','920-242-7669',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(142,'Kim','Murtagh','kmm0801@gmail.com','508-527-0143',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(144,'Fr. Jordan','Neeck','jordan.neeck@snc.edu','920-595-0047',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(145,'Axel','Neree','axel@trufunction.net','305-801-3919',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(146,'Megan','Nieland','megnieland@gmail.com','515-975-3455',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(147,'Nate ','Nitka','nitknp25@gmail.com','920-471-3049',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(148,'Meredith ','Nitka','meredithduchaine@yahoo.com','920-629-7432',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(150,'David ','Ostermann','ostermannelectricservice@gmail.com','715-937-3706',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(151,'Terra ','Otis','terra614@gmail.com','920-475-9684',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(152,'Chad ','Otis','chotis729@gmail.com','920-707-3429',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(153,'Ashley ','Pax','paxley@gmail.com','512-568-1769',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(154,'Tom','Perri','tmperri@juno.com ','763-218-9754',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(155,'Ryan ','Peterson','rpeterson08@gmail.com','507-301-2309',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(156,'Kelly','Pheulpin','kpheulpin@aol.com','978-290-9901',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(158,'Jeff ','Picken','jdpicken@sbcglobal.net','920-224-5517',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(160,'Allison ','Pitt','allisonannpitt@gmail.com','414-248-6569',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(161,'Michael','Price','michaelprice@corridorrunning.com','319-389-1957',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(162,'Nate ','Qualls','nqualls@new.rr.com','920-737-6985',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(163,'Melissa','Radar','mr0199343@otc.edu','417-300-7611',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(165,'DJ ','Rein','dj43gb@yahoo.com','920-569-6819',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(169,'Ingrid ','Ristroph','ingrid.ristroph@gmail.com','512-576-2171',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(170,'Justin','Rolain','justinrolain@gmail.com','920-562-0971',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(173,'Kevin ','Sas','kevinsas21@yahoo.com','920-205-2559',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(174,'Melony','Sasser','melony.sasser@va.gov','218-248-9717',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(176,'Greg ','Schauer','gpschauer@yahoo.com','414-248-6958',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(177,'Josh ','Schill','joshschill.js@gmail.com','920-598-1491',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(179,'Eric ','Schmidt','ericschmidt23@yahoo.com','920-794-4064',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(180,'Catie','Schmitt','catieschultz6@gmail.com','920-680-1034',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(181,'Pam ','Schmitz','pamela.jean.schmitz@gmail.com','608-669-1043',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(182,'Chris ','Schmitz','ccschmitz@gmail.com','920-279-1277',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(183,'Dave','Schroeder','Dave.p.schroeder@gmail.com','920-585-9376',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(184,'Bethany','Schumacher','bethanyschumacher@gmail.com ','920-216-9357',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(185,'Ann','Senn','ann@thethrivesolution.com','920-373-6705',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(186,'Esther ','Sherman','esthers@bu.edu','507-477-1838',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(188,'Amanda ','Sonnenberg','Schuak18@gmail.com','715-938-1771',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(189,'Jennifer','Steadman','jennifersteadman19@gmail.com','319-241-1501',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(190,'Mike','Steffek','msteffek5_30@yahoo.com','920 470 8248',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(191,'Jill','Steffek','jillian.nondorf@gmail.com','920-267-1066',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(192,'Sarah ','Stevenson','ssteve2010@gmail.com','501-951-2555',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(194,'Bob ','Strauss','bobsrun1@gmail.com','847-337-5921',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(195,'Dorene ','Stubbe','dorene73@hotmail.com','714-397-3453',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(196,'Michael','Suer','michaeljsuer@gmail.com','765-717-0732',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(198,'Dave','Taylor','newrtac@gmail.com','920-373-1083',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(199,'Kevin ','Terry','kevinjtterry@gmail.com','715-803-0568',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(200,'Marty ','Thomas','wreststuds@aol.com','920-366-2428',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(201,'Jen','Thomas','jethomas07@alumni.uwosh.edu','608-220-1134',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(202,'Rene ','Thomas','renhan@msn.com','512-826-1348',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(203,'Barry ','Thrune','bjthrune@scj.com','262-227-3569',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(205,'Deborah','Townsend','deb24mom@gmail.com','508-360-6396',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(207,'Rebekah','Tregger','rtregger@gmail.com','847-309-3837',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(208,'Lindsay','Tristine','ltristine@gmail.com','203-605-8250',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(211,'Janine ','Van Rixel','thescrubnut@gmail.com','715-573-6997',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(212,'Ron','Van Straten','ronald.vanstraten@graef-usa.com','920-676-7284',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(213,'Sydney','Vanderloop','sydney.vanderloop@thedacare.org','920-788-1254',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(214,'Paula ','Walker','mgpjwalker@yahoo.com',' 920-606-560',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(215,'Sara','Wall','sararwall@gmail.com','920-430-1628',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(216,'Wanda ','Wanie','ultrachick50@yahoo.com','920-376-0144',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(217,'Michelle ','Webb','michellewebb72@gmail.com','920-619-7264',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(218,'Jonathon','Webb','bdgolfwi@yahoo.com','920-227-5539',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(220,'Steve','Weick','sbweick@gmail.com','651-767-2170',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(221,'Allie','Welch','allier24@hotmail.com','603-860-8080',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(222,'Thomas','Wells','itutormke@gmail.com','608-312-3982',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(223,'Jason ','Wesolowski','jasonweso@yahoo.com','971-227-6616',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(224,'Nate ','Wesolowski','nateweso@gmail.com','920-606-8151',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(225,'Ryan','Westin','rwestin1@gmail.com','501-613-4505',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(226,'David ','Wians','davidwians@yahoo.com','920-619-7115',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(227,'Mandi','Wilke','mandi.wilke@n2pub.com','920-246-1442',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(228,'Chelsea','Williams','chels39c@gmail.com','920-359-1091',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(229,'Andrew ','Winters','andrew.winters@yahoo.com','920-471-9740',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(230,'Zach','Wolk','zach@artisticframing.com','847-460-2132',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(231,'Jeff ','Zeman','jeff.zeman@gmail.com','920-629-5333',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(232,'Samantha','Ziegler','runcupcake@gmail.com','401-742-0536',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(233,'Marissa ','Zoda','marissazoda@yahoo.com','972-746-7946',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(234,'Mary','Zuelke','','920-246-6690',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1),(238,'Michael','Guth','mnbguth@gmail.com','262-993-8224',NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,1),(239,'Melanie','Martin','laniek14@gmail.com','715-370-5280',NULL,NULL,NULL,NULL,NULL,NULL,NULL,2,NULL,1);
/*!40000 ALTER TABLE `Runner` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RunnerNote`
--

DROP TABLE IF EXISTS `RunnerNote`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `RunnerNote` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RunnerId` int(11) DEFAULT NULL,
  `RunnerNote` varchar(500) DEFAULT NULL,
  `DateAdded` date DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `RunnerId_RunnerNote_idx` (`RunnerId`),
  CONSTRAINT `RunnerId_RunnerNote` FOREIGN KEY (`RunnerId`) REFERENCES `Runner` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RunnerNote`
--

LOCK TABLES `RunnerNote` WRITE;
/*!40000 ALTER TABLE `RunnerNote` DISABLE KEYS */;
INSERT INTO `RunnerNote` VALUES (1,22,'Test','2019-09-06'),(2,22,'TEst asdfasdfasdfasdfasdfasdfsdfasdfdfsdfs','2019-09-06'),(3,22,NULL,'2019-09-06');
/*!40000 ALTER TABLE `RunnerNote` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RunnerToRacePace`
--

DROP TABLE IF EXISTS `RunnerToRacePace`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `RunnerToRacePace` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RunnerId` int(11) DEFAULT NULL,
  `RaceTypeId` int(11) DEFAULT NULL,
  `RacePaceFromId` int(11) DEFAULT NULL,
  `RacePaceToId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  KEY `RunnerId_RunnerToRacePace_idx` (`RunnerId`),
  KEY `RacePaceId_RunnerToRacePace_idx` (`RacePaceFromId`),
  KEY `RaceTypeId_RunnerToRacePace_idx` (`RaceTypeId`),
  KEY `RacePaceToId_RunnerToRacePace_idx` (`RacePaceToId`),
  CONSTRAINT `RacePaceId_RunnerToRacePace` FOREIGN KEY (`RacePaceFromId`) REFERENCES `RacePace` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `RacePaceToId_RunnerToRacePace` FOREIGN KEY (`RacePaceToId`) REFERENCES `RacePace` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `RaceTypeId_RunnerToRacePace` FOREIGN KEY (`RaceTypeId`) REFERENCES `RaceType` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `RunnerId_RunnerToRacePace` FOREIGN KEY (`RunnerId`) REFERENCES `Runner` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RunnerToRacePace`
--

LOCK TABLES `RunnerToRacePace` WRITE;
/*!40000 ALTER TABLE `RunnerToRacePace` DISABLE KEYS */;
/*!40000 ALTER TABLE `RunnerToRacePace` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RunnerToRaceType`
--

DROP TABLE IF EXISTS `RunnerToRaceType`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `RunnerToRaceType` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RunnerId` int(11) NOT NULL,
  `RaceTypeId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `RunnerId_RunnerToRaceType_idx` (`RunnerId`),
  KEY `RaceId_RunnerToRaceType_idx` (`RaceTypeId`),
  CONSTRAINT `RaceId_RunnerToRaceType` FOREIGN KEY (`RaceTypeId`) REFERENCES `RaceType` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `RunnerId_RunnerToRaceType` FOREIGN KEY (`RunnerId`) REFERENCES `Runner` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RunnerToRaceType`
--

LOCK TABLES `RunnerToRaceType` WRITE;
/*!40000 ALTER TABLE `RunnerToRaceType` DISABLE KEYS */;
/*!40000 ALTER TABLE `RunnerToRaceType` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `States`
--

DROP TABLE IF EXISTS `States`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `States` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Abbreviation` varchar(2) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `States`
--

LOCK TABLES `States` WRITE;
/*!40000 ALTER TABLE `States` DISABLE KEYS */;
INSERT INTO `States` VALUES (1,'Alabma','AL'),(2,'Alaska','AK'),(3,'Arizona','AZ'),(4,'Arkansas','AR'),(5,'California','CA'),(6,'Colorado','CO'),(7,'Connecticut','CT'),(8,'Delaware','DE'),(9,'Florida','FL'),(10,'Georgia','GA'),(11,'Hawaii','HI'),(12,'Idaho','ID'),(13,'Illinois','IL'),(14,'Indiana','IN'),(15,'Iowa','IA'),(16,'Kansas','KA'),(17,'Kentucky','KY'),(18,'Louisiana','LO'),(19,'Maine','ME'),(20,'Maryland','MY'),(21,'Massachusetts','MA'),(22,'Michigan','MI'),(23,'Minnesota','MN'),(24,'Mississippi','MS'),(25,'Missouri','MO'),(26,'Montana','MT'),(27,'Nebraska','NE'),(28,'Nevada','NV'),(29,'New Hampshire','NH'),(30,'New Jersey','NJ'),(31,'New Mexico','NM'),(32,'New York','NY'),(33,'North Carolina','NC'),(34,'North Dakota','ND'),(35,'Ohio','OH'),(36,'Oklahoma','OK'),(37,'Oregon','OR'),(38,'Pennsylvania','PA'),(39,'Rhode Island','RI'),(40,'South Dakota','SD'),(41,'Tennessee','TN'),(42,'Texas','TX'),(43,'Utah','UT'),(44,'Vermont','VT'),(45,'Virginia','VA'),(46,'Washington','WA'),(47,'West Virginia','WV'),(48,'Wisconsin','WI'),(49,'Wyoming','WY'),(50,'South Carolina','SC');
/*!40000 ALTER TABLE `States` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `StatusRace`
--

DROP TABLE IF EXISTS `StatusRace`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `StatusRace` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(15) NOT NULL,
  `IsCreated` bit(1) NOT NULL DEFAULT b'0',
  `IsScheduled` bit(1) NOT NULL DEFAULT b'0',
  `IsComplete` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `StatusRace`
--

LOCK TABLES `StatusRace` WRITE;
/*!40000 ALTER TABLE `StatusRace` DISABLE KEYS */;
INSERT INTO `StatusRace` VALUES (1,'Created','','',''),(2,'Scheduled','','',''),(3,'Complete','','','');
/*!40000 ALTER TABLE `StatusRace` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `StatusRunner`
--

DROP TABLE IF EXISTS `StatusRunner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `StatusRunner` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(15) NOT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `IsDisabled` bit(1) NOT NULL DEFAULT b'0',
  `IsBlacklisted` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `StatusRunner`
--

LOCK TABLES `StatusRunner` WRITE;
/*!40000 ALTER TABLE `StatusRunner` DISABLE KEYS */;
INSERT INTO `StatusRunner` VALUES (1,'Active','','',''),(2,'Disabled','','',''),(3,'Blacklisted','','','');
/*!40000 ALTER TABLE `StatusRunner` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-10  9:18:30
