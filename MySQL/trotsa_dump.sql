-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: trotsa
-- ------------------------------------------------------
-- Server version	8.0.36

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
-- Table structure for table `applicant_faculties`
--

DROP TABLE IF EXISTS `applicant_faculties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicant_faculties` (
  `id_operation` int NOT NULL AUTO_INCREMENT,
  `ID_applicant` int NOT NULL,
  `code_facultie` varchar(100) NOT NULL,
  PRIMARY KEY (`id_operation`),
  KEY `facultie_id` (`code_facultie`),
  KEY `applicant_id` (`ID_applicant`),
  CONSTRAINT `applicant_id` FOREIGN KEY (`ID_applicant`) REFERENCES `applicants` (`ID_applicant`),
  CONSTRAINT `facultie_id` FOREIGN KEY (`code_facultie`) REFERENCES `faculties` (`code_facultie`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicant_faculties`
--

LOCK TABLES `applicant_faculties` WRITE;
/*!40000 ALTER TABLE `applicant_faculties` DISABLE KEYS */;
/*!40000 ALTER TABLE `applicant_faculties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applicants`
--

DROP TABLE IF EXISTS `applicants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicants` (
  `ID_applicant` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `patronymic` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_applicant`)
) ENGINE=InnoDB AUTO_INCREMENT=134 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicants`
--

LOCK TABLES `applicants` WRITE;
/*!40000 ALTER TABLE `applicants` DISABLE KEYS */;
/*!40000 ALTER TABLE `applicants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `exam_applicants`
--

DROP TABLE IF EXISTS `exam_applicants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `exam_applicants` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ID_applicant` int NOT NULL,
  `russian` int DEFAULT '0',
  `math` int DEFAULT '0',
  `social_science` int DEFAULT '0',
  `physic` int DEFAULT '0',
  `history` int DEFAULT '0',
  `computer_science` int DEFAULT '0',
  `biology` int DEFAULT '0',
  `chemistry` int DEFAULT '0',
  `geography` int DEFAULT '0',
  `literature` int DEFAULT '0',
  `foreign_language` int DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `code_applicant_idx` (`ID_applicant`),
  CONSTRAINT `code_applicant` FOREIGN KEY (`ID_applicant`) REFERENCES `applicants` (`ID_applicant`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exam_applicants`
--

LOCK TABLES `exam_applicants` WRITE;
/*!40000 ALTER TABLE `exam_applicants` DISABLE KEYS */;
/*!40000 ALTER TABLE `exam_applicants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `exam_faculty`
--

DROP TABLE IF EXISTS `exam_faculty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `exam_faculty` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code_facultie` varchar(50) NOT NULL,
  `russian` tinyint(1) DEFAULT '0',
  `math` tinyint(1) DEFAULT '0',
  `social_science` tinyint(1) DEFAULT '0',
  `physic` tinyint(1) DEFAULT '0',
  `history` tinyint(1) DEFAULT '0',
  `computer_science` tinyint(1) DEFAULT '0',
  `biology` tinyint(1) DEFAULT '0',
  `chemistry` tinyint(1) DEFAULT '0',
  `geography` tinyint(1) DEFAULT '0',
  `literature` tinyint(1) DEFAULT '0',
  `foreign_language` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `code_faculty_idx` (`code_facultie`),
  CONSTRAINT `code_faculty` FOREIGN KEY (`code_facultie`) REFERENCES `faculties` (`code_facultie`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exam_faculty`
--

LOCK TABLES `exam_faculty` WRITE;
/*!40000 ALTER TABLE `exam_faculty` DISABLE KEYS */;
/*!40000 ALTER TABLE `exam_faculty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faculties`
--

DROP TABLE IF EXISTS `faculties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faculties` (
  `code_facultie` varchar(50) NOT NULL,
  `name_facultie` varchar(50) NOT NULL,
  `short_name` varchar(50) NOT NULL,
  PRIMARY KEY (`code_facultie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faculties`
--

LOCK TABLES `faculties` WRITE;
/*!40000 ALTER TABLE `faculties` DISABLE KEYS */;
/*!40000 ALTER TABLE `faculties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personal_data_applicant`
--

DROP TABLE IF EXISTS `personal_data_applicant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personal_data_applicant` (
  `ID_pda` int NOT NULL AUTO_INCREMENT,
  `ID_applicant` int NOT NULL,
  `exam_scores` int DEFAULT NULL,
  `Disability` tinyint(1) DEFAULT '0',
  `Privileges` tinyint(1) DEFAULT '0',
  `Orphan` tinyint(1) DEFAULT '0',
  `Documents_Commentary` text,
  `Commentary` tinytext,
  PRIMARY KEY (`ID_pda`),
  KEY `ID_applicant` (`ID_applicant`),
  CONSTRAINT `personal_data_applicant_ibfk_1` FOREIGN KEY (`ID_applicant`) REFERENCES `applicants` (`ID_applicant`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personal_data_applicant`
--

LOCK TABLES `personal_data_applicant` WRITE;
/*!40000 ALTER TABLE `personal_data_applicant` DISABLE KEYS */;
/*!40000 ALTER TABLE `personal_data_applicant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registrars`
--

DROP TABLE IF EXISTS `registrars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registrars` (
  `ID_registrar` int NOT NULL AUTO_INCREMENT,
  `Login_registrar` varchar(15) NOT NULL,
  `Password_registrar` varchar(10) NOT NULL,
  `Administrator` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_registrar`),
  UNIQUE KEY `Login_registrar` (`Login_registrar`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registrars`
--

LOCK TABLES `registrars` WRITE;
/*!40000 ALTER TABLE `registrars` DISABLE KEYS */;
/*!40000 ALTER TABLE `registrars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'trotsa'
--

--
-- Dumping routines for database 'trotsa'
--
/*!50003 DROP FUNCTION IF EXISTS `authorization` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `authorization`(login_reg varchar(15), pass_reg varchar(10)) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
DECLARE USER_COUNTER INTEGER;
DECLARE OK BOOL;

select count(*) INTO USER_COUNTER from trotsa.registrars where Login_registrar = login_reg and Password_registrar = pass_reg;

IF (USER_COUNTER = 0) then  SET OK = FALSE;
ELSEIF (USER_COUNTER = 1) THEN SET OK = TRUE;
END IF;
RETURN OK;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `exists_applicants_in_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `exists_applicants_in_facultie`(code_facultie_param varchar(50), ID_applicant_param int) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
declare count_param int;
declare ok bool;
SELECT count(*) into count_param FROM trotsa.applicant_faculties where ID_applicant = ID_applicant_param and code_facultie = code_facultie_param;
if(count_param = 0) then set ok = false;
elseif(count_param = 1) then set ok = true;
end if;
RETURN ok;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `facultie exist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `facultie exist`(param_code_facultie varchar(50)) RETURNS int
    DETERMINISTIC
BEGIN
DECLARE facultie_COUNTER INTEGER;
DECLARE OK BOOL;

select count(*) INTO facultie_COUNTER from trotsa.faculties where code_facultie = param_code_facultie;

IF (facultie_COUNTER = 0) then  SET OK = FALSE;
ELSEIF (facultie_COUNTER = 1) THEN SET OK = TRUE;
END IF;
RETURN OK;
RETURN 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `facultie_name` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `facultie_name`(param_code_facultie varchar(50)) RETURNS varchar(50) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
declare nameFacultie varchar(50);
select name_facultie into nameFacultie from trotsa.faculties where code_facultie = param_code_facultie;
RETURN nameFacultie;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `facultie_short_name` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `facultie_short_name`(param_code_facultie varchar(50)) RETURNS varchar(50) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
declare nameFacultie varchar(50);
select short_name into nameFacultie from trotsa.faculties where code_facultie = param_code_facultie;
RETURN nameFacultie;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_current_facultie_applicant` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_current_facultie_applicant`(ID_applicant_param int) RETURNS varchar(50) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
declare  code_ret varchar(50);
SELECT code_facultie into code_ret FROM trotsa.applicant_faculties where ID_applicant = ID_applicant_param;
RETURN code_ret;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `IsUserAdmin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `IsUserAdmin`(Login_registrar_param varchar(50)) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
declare admin_param tinyint(1);
SELECT Administrator into admin_param FROM trotsa.registrars where Login_registrar = Login_registrar_param;
RETURN admin_param;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `search_login_registar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `search_login_registar`(login_reg varchar(15)) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
DECLARE USER_COUNTER INTEGER;
DECLARE OK BOOL;

select count(*) INTO USER_COUNTER from trotsa.registrars where Login_registrar = login_reg;
IF (USER_COUNTER = 0) then  SET OK = FALSE;
ELSEIF (USER_COUNTER = 1) THEN SET OK = TRUE;
END IF;
RETURN OK;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `access_to_exams` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `access_to_exams`(code_facultie_param varchar(50))
BEGIN
SELECT * FROM trotsa.exam_faculty where code_facultie =code_facultie_param;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `add_applicant` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_applicant`(arg_name varchar(10), arg_surname varchar(10), arg_patronymic varchar(10))
BEGIN
declare last_id int;
INSERT INTO `trotsa`.`applicants` (`name`, `surname`, `patronymic`) VALUES (arg_name, arg_surname, arg_patronymic);
set last_id = last_insert_id();
INSERT INTO `trotsa`.`personal_data_applicant` (`ID_applicant`, `exam_scores`) VALUES (last_id, 0);
INSERT INTO `trotsa`.`exam_applicants` (`ID_applicant`) VALUES (last_id);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `add_applicant_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_applicant_facultie`(ID_applicant_param int, code_facultie_param varchar(50))
BEGIN
DELETE FROM `trotsa`.`applicant_faculties` WHERE (`code_facultie` != code_facultie_param);
INSERT INTO `trotsa`.`applicant_faculties` (`ID_applicant`, `code_facultie`) VALUES (ID_applicant_param, code_facultie_param);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `add_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_facultie`(code_facultie varchar(50), name_facultie varchar(50), short_name_facultie varchar(50))
BEGIN
INSERT INTO `trotsa`.`faculties` (`code_facultie`, `name_facultie`, `short_name`) VALUES (code_facultie, name_facultie, short_name_facultie);
INSERT INTO `trotsa`.`exam_faculty` (`code_facultie`, `russian`, `math`, `social_science`, `physic`, `history`, `computer_science`, `biology`, `chemistry`, `geography`, `literature`, `foreign_language`) VALUES (code_facultie, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `change_code` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `change_code`(old_code varchar(50), new_code varchar(50))
BEGIN
declare name_facultie_param varchar(50);
declare  short_name_facultie_param varchar(50);

SELECT name_facultie into name_facultie_param FROM trotsa.faculties where code_facultie = old_code;
SELECT short_name  into short_name_facultie_param FROM trotsa.faculties where code_facultie = old_code;

INSERT INTO `trotsa`.`faculties` (`code_facultie`, `name_facultie`, `short_name`) VALUES (new_code, name_facultie_param, short_name_facultie_param);
UPDATE `trotsa`.`applicant_faculties` SET `code_facultie` = new_code WHERE (`code_facultie` = old_code);
UPDATE `trotsa`.`exam_faculty` SET `code_facultie` = new_code WHERE (`code_facultie` = old_code);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `change_requirements_exam_faculty` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `change_requirements_exam_faculty`(code_facultie_param varchar(50),
 `russian_param` tinyint(1), `math_param` tinyint(1), `social_science_param` tinyint(1),
 `physic_param` tinyint(1), `history_param` tinyint(1), `computer_science_param` tinyint(1),
 `biology_param` tinyint(1), `chemistry_param` tinyint(1), `geography_param` tinyint(1),
 `literature_param` tinyint(1), `foreign_language_param` tinyint(1))
BEGIN
UPDATE `trotsa`.`exam_faculty` SET `russian` = russian_param, `math` = math_param, `social_science` = social_science_param,
`physic` = physic_param, `history` = history_param, `computer_science` = computer_science_param,
`biology` = biology_param, `chemistry` = chemistry_param, `geography` = geography_param,
`literature` = literature_param, `foreign_language` = foreign_language_param WHERE (code_facultie = code_facultie_param);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_applicant` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_applicant`(ID_applicant_param int)
BEGIN
DELETE FROM `trotsa`.`applicant_faculties` WHERE (`ID_applicant` = ID_applicant_param);
DELETE FROM `trotsa`.`personal_data_applicant` WHERE (`ID_applicant` = ID_applicant_param);
DELETE FROM `trotsa`.`exam_applicants` WHERE (`ID_applicant` = ID_applicant_param);
DELETE FROM `trotsa`.`applicants` WHERE (`ID_applicant` = ID_applicant_param);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_applicant_from_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_applicant_from_facultie`(ID_applicant_param int, code_facultie_param varchar(50))
BEGIN
DELETE FROM `trotsa`.`applicant_faculties` WHERE (`ID_applicant` = ID_applicant_param and code_facultie = code_facultie_param);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_facultie`(delete_code varchar(50))
BEGIN
DELETE FROM `trotsa`.`applicant_faculties` WHERE (code_facultie = delete_code);
DELETE FROM `trotsa`.`faculties` WHERE (`code_facultie` = delete_code);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_old_code_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_old_code_facultie`(code_facultie_param varchar(50))
BEGIN
SET FOREIGN_KEY_CHECKS=0;
DELETE FROM `trotsa`.`faculties` WHERE (`code_facultie` = code_facultie_param) limit 1;
SET FOREIGN_KEY_CHECKS=1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `edit_fio_applicants` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `edit_fio_applicants`(id int, surname_param varchar(50),  `name_param` varchar(50),  patronymic_param varchar(50))
BEGIN
UPDATE `trotsa`.`applicants` SET `surname` = surname_param, `name` = `name_param`, `patronymic` = patronymic_param WHERE (`ID_applicant` = id);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `faculties_of_applicant` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `faculties_of_applicant`(code_param int)
BEGIN
select code_facultie, name_facultie, short_name FROM trotsa.applicant_faculties
join faculties on faculties.code_facultie = `faculties_of_applicant`.code_facultie 
where ( code_param = code_facultie);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_applicants` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_applicants`(counter_from int, counter_to int)
BEGIN
SELECT applicants.ID_applicant as `Идентификатор`, applicants.surname as `Фамилия`, applicants.`name` as `Имя`, applicants.patronymic as `Отчество`
FROM trotsa.applicants
join trotsa.personal_data_applicant on trotsa.applicants.ID_applicant = trotsa.personal_data_applicant.ID_applicant
order by exam_scores desc
limit counter_from, counter_to; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_applicants_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_applicants_facultie`(facultie varchar(50), counter_from int, counter_to int)
BEGIN
SELECT applicants.ID_applicant as `Идентификатор`, applicants.surname as `Фамилия`, applicants.`name` as `Имя`, applicants.patronymic as `Отчество`
FROM trotsa.applicants
join trotsa.applicant_faculties on trotsa.applicants.ID_applicant = trotsa.applicant_faculties.ID_applicant and trotsa.applicant_faculties.code_facultie = facultie
join trotsa.personal_data_applicant on trotsa.applicants.ID_applicant = trotsa.personal_data_applicant.ID_applicant
#group by applicants.ID_applicant
order by exam_scores desc
limit counter_from, counter_to; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_exam_requirements` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_exam_requirements`(code_facultie_param varchar(50))
BEGIN
SELECT russian, math, social_science, physic, `history`, computer_science, biology, chemistry, geography, literature, foreign_language FROM trotsa.exam_faculty
where code_facultie = code_facultie_param;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_code_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_code_facultie`(old_code_facultie varchar(50), new_code_facultie varchar(50))
BEGIN
INSERT INTO `faculties` (`code_facultie`, name_facultie, short_name)
VALUES (new_code_facultie, '','');
UPDATE `applicant_faculties` SET `code_facultie` = new_code_facultie WHERE (`code_facultie` = old_code_facultie);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_data_facultie` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_data_facultie`(code_facultie varchar(50), name_facultie varchar(50), short_facultie varchar(50))
BEGIN
UPDATE `trotsa`.`faculties` SET `name_facultie` = name_facultie, `short_name` = short_facultie WHERE (`code_facultie` = code_facultie);
END ;;
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

-- Dump completed on 2024-06-12  1:06:01
