/*
SQLyog Ultimate v9.62 
MySQL - 5.6.37-log : Database - procurement_tracking
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`procurement_tracking` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `procurement_tracking`;

/*Table structure for table `procurement_list` */

DROP TABLE IF EXISTS `procurement_list`;

CREATE TABLE `procurement_list` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `description` varchar(255) DEFAULT NULL,
  `amount` int(11) NOT NULL DEFAULT '0',
  `supplier` int(11) DEFAULT NULL,
  `added_on` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `status` enum('To Ship','To Receive','Received') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

/*Data for the table `procurement_list` */

insert  into `procurement_list`(`id`,`description`,`amount`,`supplier`,`added_on`,`status`) values (1,'chair',1000,1,'2022-11-03 15:25:44','To Ship'),(2,'asdas',12312,4,'2022-11-03 15:56:35','To Receive'),(3,'123123',231231,3,'2022-11-03 16:00:55','To Ship'),(4,'Gaming chair',7500,1,'2022-11-03 16:43:14','To Ship'),(5,'sdfdf',212312,1,'2022-11-09 12:22:00','To Receive'),(6,'helloworld',100000,3,'2022-11-09 12:24:28','To Ship'),(7,'sadasdasdasd',1000000,3,'2022-11-09 12:24:41','To Ship');

/*Table structure for table `procurement_status` */

DROP TABLE IF EXISTS `procurement_status`;

CREATE TABLE `procurement_status` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pr_no` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `end_user` varchar(255) NOT NULL,
  `mode_of_pr` varchar(255) NOT NULL,
  `abc` float DEFAULT NULL,
  `pre_proc` timestamp NULL DEFAULT NULL COMMENT 'input on change',
  `posting` timestamp NULL DEFAULT NULL COMMENT 'input on change',
  `pre_bid` timestamp NULL DEFAULT NULL COMMENT 'input on change',
  `opening_of_bids` date DEFAULT NULL,
  `detailed_bid_eval` date DEFAULT NULL,
  `award` date DEFAULT NULL,
  `po` date DEFAULT NULL,
  `ntp` date DEFAULT NULL,
  `delivery` date DEFAULT NULL COMMENT 'due date',
  `purpose` text,
  PRIMARY KEY (`pr_no`),
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

/*Data for the table `procurement_status` */

insert  into `procurement_status`(`id`,`pr_no`,`description`,`end_user`,`mode_of_pr`,`abc`,`pre_proc`,`posting`,`pre_bid`,`opening_of_bids`,`detailed_bid_eval`,`award`,`po`,`ntp`,`delivery`,`purpose`) values (23,'1231231253415264336','sadsadasdasdasdas','asdasdas','dasdasd',23123,'2022-12-06 10:01:08',NULL,NULL,'2022-03-06','2022-12-06','2022-10-06','2022-11-06','2022-11-06','2022-11-06','sdadasdasdasdsa'),(19,'1909','trial lang example','maxdadog','Public Bidding',5000,'2022-12-06 08:39:59',NULL,NULL,'2022-12-01','2022-12-02','2022-12-03','2022-12-04','2022-12-05','2022-12-06','Trial lang tan.awon if sakto'),(21,'19099','what if ba','tenenen neneen','jopay',5000,'2022-12-06 09:55:52',NULL,NULL,'2022-01-06','2022-02-06','2022-03-06','2022-04-06','2022-05-06','2022-06-06','what if e u turn ka niya'),(26,'2022-00010','for the thesis','ian jamora','public bidding',1234,'2022-12-06 10:17:17','2022-12-06 10:20:00',NULL,'2022-09-06','2022-09-06','2022-04-06','2022-07-06','2022-05-06','2022-07-06','sadasdasd'),(9,'22-01-003','For Security Services of BISU Balilihan Campus (GF)','Ernesto B. Alijay Jr.','Public Bidding',621036,'2022-11-29 13:29:30','2022-11-29 14:18:05','2022-12-02 08:33:22','2011-11-22','2022-03-09','2022-03-21','2022-03-25','2022-03-31','2022-04-01',NULL),(10,'22-01-004','For Security Services of BISU Balilihan Campus (GF)','Ernesto B. Alijay Jr.','Public Bidding',621036,'2022-11-29 13:31:29','2022-12-02 08:33:17','2022-12-02 13:32:13','2011-11-22','2022-03-09','2022-03-21','2022-03-25','2022-03-31','2022-04-01',NULL),(18,'2312312312','sdasdasdasd','asdasda','dasdasdasd',12312300,'2022-12-01 15:33:52','2022-12-02 08:33:06','2022-12-02 13:32:17','2022-08-01','2022-09-01','2022-09-01','2022-10-01','2022-08-01','2022-08-01','sadasdasdas'),(24,'3123123123123432234','saddasd','sdasdasdasdasd','asdasdasdas',123413000000,'2022-12-06 10:10:45',NULL,NULL,'2022-09-06','2022-08-06','2022-10-06','2022-09-06','2022-08-06','2022-09-06','asaSSADFSF'),(28,'4546','21','1','1',1,'2022-12-19 14:02:20',NULL,NULL,'2022-12-06','2022-01-19','2022-01-19','2022-01-19','2022-01-19','2022-01-19','1asd'),(25,'54555','asdasd','sadasdasd','sadasasdasdas21312',123124,'2022-12-06 10:12:13',NULL,NULL,'2022-02-06','2022-02-06','2022-01-06','2022-01-06','2022-02-06','2022-01-06','asdasdasd'),(22,'5656','asd','sdafasd','asd',5000,'2022-12-06 09:56:56',NULL,NULL,'2022-01-06','2022-02-06','2022-03-06','2022-04-06','2022-06-06','2022-06-06','askdjfasdf'),(30,'987','asdf','asdf','asdf',1,'2022-12-29 14:24:17',NULL,NULL,'2022-01-29','2022-01-29','2022-01-29','2022-01-29','2022-01-29','2022-01-29','asdaf'),(29,'9999999999','asd','asd','awsd',4,'2022-12-19 14:06:58',NULL,NULL,'2022-04-19','2022-04-19','2022-04-19','2022-04-19','2022-04-19','2022-04-19','asd');

/*Table structure for table `purchase_order` */

DROP TABLE IF EXISTS `purchase_order`;

CREATE TABLE `purchase_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `property_no` varchar(255) DEFAULT NULL,
  `unit` varchar(10) DEFAULT NULL,
  `description` text,
  `quantity` int(11) DEFAULT NULL,
  `unit_cost` float DEFAULT NULL,
  `total_cost` float DEFAULT NULL,
  `procurement_no` varchar(255) DEFAULT NULL,
  `supplier` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

/*Data for the table `purchase_order` */

insert  into `purchase_order`(`id`,`property_no`,`unit`,`description`,`quantity`,`unit_cost`,`total_cost`,`procurement_no`,`supplier`) values (7,'52896','pc','Personal computer',5,100,500,'22-02-0004',NULL),(8,'52896234','pc','Personal computer hellosdd',5,100,500,'22-02-0004',NULL),(9,'12123124','pc','Personal computer hellosdd',5,100,500,'22-02-0004',NULL),(10,'12123124','pc','sdasdasdasd',5,100,500,'22-02-0004',NULL),(11,'123123','sdasd','sadasdasdasd',222,33333,7399930,'2312312312',NULL),(12,'232324','sdasd','asdasdasdasdas',222,33333,7399930,'2312312312',NULL),(13,'25456','pc','keyboard',3,800,2400,'1909',NULL),(14,'25457','pc','mouse',2,500,1000,'1909',NULL),(15,'25458','pc','monitor',4,1500,6000,'1909',NULL),(16,'123123123231','1233123','312312asdasdasdasd',12312,12312,151585000,'1231231253415264336',NULL),(17,'1','pcs','asdasdasdasasd',123123,12344,1519830000,'2022-00010',NULL),(18,'2','pcs','ball',244,334,81496,'2022-00010',NULL),(19,'3','pcs','personal computer',2222,333,739926,'2022-00010',NULL),(20,'1234','3','5c',4,5,20,'987','BOHOL QUALITY');

/*Table structure for table `supplier_list` */

DROP TABLE IF EXISTS `supplier_list`;

CREATE TABLE `supplier_list` (
  `id` int(50) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

/*Data for the table `supplier_list` */

insert  into `supplier_list`(`id`,`name`,`address`) values (1,'BOHOL QUALITY','Carlos, P. Garcia Avenue, Tagbilaran City, 6300 Bohol'),(2,'Alturas Group of Company','Carlos, P. Garcia Avenue, Tagbilaran City, 6300 Bohol'),(3,'All-Flex Marketing & Industrial Sales','Carlos, P. Garcia Avenue, Tagbilaran City, 6300 Bohol'),(4,'JFWIRE Business Center','51-A Graham Ave, Tagbilaran City, 6300 Bohol'),(5,'Parana Builders And General Merchandise',' MV75+76P, Bohol Circumferential Rd, Tagbilaran City, 6300 Bohol'),(6,'Three M Industrial Sales','JVR4+CC9, Carlos P. Garcia Avenue, Tagbilaran City, 6300 Bohol'),(7,'kittcymone','asdasdad'),(8,'asdas','asdasdas'),(10,'sadasdasd','asdasdasdasd'),(11,'asdasd','sdasdasdasdasdas');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `id` int(12) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `role` enum('Administrator','User') NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `user` */

insert  into `user`(`id`,`name`,`username`,`password`,`role`) values (2,'Administrator','admin','*4ACFE3202A5FF5CF467898FC58AAB1D615029441','Administrator'),(4,'user','user','*D5D9F81F5542DE067FFF5FF7A4CA4BDD322C578F','User');

/* Procedure structure for procedure `sp_supplier_list_get` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_supplier_list_get` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`bisu_procurement`@`%` PROCEDURE `sp_supplier_list_get`(
	
    )
BEGIN
    	DECLARE EXIT HANDLER FOR SQLEXCEPTION
	BEGIN
		ROLLBACK;
		RESIGNAL;
	END;
	START TRANSACTION;
	-- #########START#########;
	
	SELECT * FROM `supplier_list`;
	
	
	-- ##########END##########
	COMMIT;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_supplier_list_save` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_supplier_list_save` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`bisu_procurement`@`%` PROCEDURE `sp_supplier_list_save`(
	IN _id INT(50),
	IN _name VARCHAR (255),
	IN _description VARCHAR(255)
	
    )
BEGIN
    	DECLARE EXIT HANDLER FOR SQLEXCEPTION
	BEGIN
		ROLLBACK;
		RESIGNAL;
	END;
	START TRANSACTION;
	-- #########START#########;
	
	IF _id = 0 THEN -- add
		INSERT INTO `supplier_list` (`name`, `description`) 
		VALUES (_name, _description);
		SELECT 'added_new_supplier_successfully' _ret;
		
	ELSE -- edit
		UPDATE supplier_list SET `name` = _name, 
		description = _description 
		WHERE id  = _id;
		SELECT 'updated_supplier_successfully' _ret;
	END IF;
	
	-- ##########END##########
	COMMIT;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_user_login` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_user_login` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`bisu_procurement`@`%` PROCEDURE `sp_user_login`(
	IN _username VARCHAR (50),
	IN _password VARCHAR(50)
	
    )
BEGIN
    	DECLARE EXIT HANDLER FOR SQLEXCEPTION
	BEGIN
		ROLLBACK;
		RESIGNAL;
	END;
	START TRANSACTION;
	-- #########START#########;
	
	SELECT * FROM `user` WHERE username = _username && `password` = PASSWORD( _password );
	
	
	-- ##########END##########
	COMMIT;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
