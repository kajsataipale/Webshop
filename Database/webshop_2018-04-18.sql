# ************************************************************
# Sequel Pro SQL dump
# Version 4541
#
# http://www.sequelpro.com/
# https://github.com/sequelpro/sequelpro
#
# Host: 127.0.0.1 (MySQL 5.7.21)
# Database: webshop
# Generation Time: 2018-04-18 14:04:05 +0000
# ************************************************************


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


# Dump of table Cart
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Cart`;

CREATE TABLE `Cart` (
  `product_id` int(200) NOT NULL,
  `price` int(200) NOT NULL,
  `id` int(100) unsigned NOT NULL AUTO_INCREMENT,
  `amount` int(11) DEFAULT NULL,
  `cart_id` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

LOCK TABLES `Cart` WRITE;
/*!40000 ALTER TABLE `Cart` DISABLE KEYS */;

INSERT INTO `Cart` (`product_id`, `price`, `id`, `amount`, `cart_id`)
VALUES
	(3,60,41,1,'0a6fb8bb-4300-4519-b2cc-4c8ffa8f82b0'),
	(4,17,42,1,'0a6fb8bb-4300-4519-b2cc-4c8ffa8f82b0'),
	(4,17,43,1,'0a6fb8bb-4300-4519-b2cc-4c8ffa8f82b0'),
	(6,45,44,1,'f732f46d-0c91-4d76-9451-533134d7f7d7'),
	(2,40,45,1,'1b0a8c1c-56f0-4136-9512-4dec80d98d1b'),
	(3,60,46,1,'1b0a8c1c-56f0-4136-9512-4dec80d98d1b'),
	(5,199,47,1,'e31f208c-1a58-4d1e-9adc-a441f32d3326'),
	(5,199,48,1,'e31f208c-1a58-4d1e-9adc-a441f32d3326'),
	(2,40,49,1,'663036a9-2849-4aba-987b-03e5ad1bc699'),
	(3,60,50,1,'663036a9-2849-4aba-987b-03e5ad1bc699'),
	(4,17,51,1,'0da8ff5b-1fe8-45d1-810e-f27bf007dcd2'),
	(4,17,52,1,'0da8ff5b-1fe8-45d1-810e-f27bf007dcd2');

/*!40000 ALTER TABLE `Cart` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table Checkout
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Checkout`;

CREATE TABLE `Checkout` (
  `order_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `user_name` varchar(200) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `phone` int(200) DEFAULT NULL,
  `adress` varchar(200) DEFAULT NULL,
  `cart_id` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

LOCK TABLES `Checkout` WRITE;
/*!40000 ALTER TABLE `Checkout` DISABLE KEYS */;

INSERT INTO `Checkout` (`order_id`, `user_name`, `email`, `phone`, `adress`, `cart_id`)
VALUES
	(37,'hofosu','ryfon@mailinator.net',97,'Reiciendis doloremque reprehenderit earum distinctio Unde et voluptatem Cupiditate voluptas blanditiis quia laudantium aut magna et quae labore rerum labore',NULL),
	(38,'sifarexy','maho@mailinator.com',93,'Vel reprehenderit ad fugiat sunt ullam id dicta a et pariatur Praesentium officia corporis ut consequatur Et reprehenderit inventore incidunt',NULL),
	(39,'jeweno','catasedod@mailinator.com',86,'Eum aut quos sit tempora nemo enim qui corporis asperiores cupidatat excepturi irure doloribus neque doloribus',NULL),
	(40,'jeweno','catasedod@mailinator.com',86,'Eum aut quos sit tempora nemo enim qui corporis asperiores cupidatat excepturi irure doloribus neque doloribus',NULL),
	(41,'jeweno','catasedod@mailinator.com',86,'Eum aut quos sit tempora nemo enim qui corporis asperiores cupidatat excepturi irure doloribus neque doloribus',NULL),
	(42,'poruxuju','bahubo@mailinator.com',28,'Iure ut corrupti eveniet ut ullamco',NULL),
	(43,'poruxuju','bahubo@mailinator.com',28,'Iure ut corrupti eveniet ut ullamco',NULL),
	(44,'poruxuju','bahubo@mailinator.com',28,'Iure ut corrupti eveniet ut ullamco',NULL),
	(45,'sigadiqixu','cakaw@mailinator.com',12,'Dolores labore delectus dolorem consequat Aliquid dolorem reiciendis architecto ea distinctio Rerum debitis vero qui est quis distinctio',NULL),
	(46,'jobexow','pamatupe@mailinator.com',57,'Maiores omnis nostrud adipisicing recusandae Tempore vitae incididunt irure possimus fugit veritatis',NULL),
	(47,'koqucyt','nafetaxyha@mailinator.com',30,'Est commodo aliqua Quis quos dolore alias',NULL),
	(48,'buwotelop','cuqylaluhi@mailinator.com',3,'Odit eiusmod deserunt voluptatem eos a eos inventore qui nostrud quis ea','f732f46d-0c91-4d76-9451-533134d7f7d7'),
	(49,'gelox','pyxog@mailinator.com',15,'Qui quam labore eum aliquip consequuntur accusamus dolor quisquam','1b0a8c1c-56f0-4136-9512-4dec80d98d1b'),
	(50,'vyhapyqaw','cehuqysi@mailinator.com',97,'Laborum Dolorem nesciunt incididunt molestias rerum omnis quo est Nam nostrum architecto nihil minima','1b0a8c1c-56f0-4136-9512-4dec80d98d1b'),
	(59,'paxaduzy','nywuqyme@mailinator.net',38,'Saepe reprehenderit in est qui laboriosam','663036a9-2849-4aba-987b-03e5ad1bc699'),
	(60,'jisaxe','deba@mailinator.com',88,'Exercitation illo quos natus dolores ea exercitation velit distinctio In dolor vero tenetur veritatis minima maxime eos quis eligendi quasi','0da8ff5b-1fe8-45d1-810e-f27bf007dcd2');

/*!40000 ALTER TABLE `Checkout` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table Products
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Products`;

CREATE TABLE `Products` (
  `product_id` int(200) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(200) NOT NULL DEFAULT '',
  `price` int(200) NOT NULL,
  `image` varchar(500) NOT NULL DEFAULT '',
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

LOCK TABLES `Products` WRITE;
/*!40000 ALTER TABLE `Products` DISABLE KEYS */;

INSERT INTO `Products` (`product_id`, `name`, `price`, `image`)
VALUES
	(1,'ToiletSticker',20,'ToiletSticker.jpg'),
	(2,'SharkBowl',40,'SharkBowl.jpg'),
	(3,'PongBot',60,'PongBot.jpg'),
	(4,'Pogs',17,'Pogs.jpg'),
	(5,'PlantTrolls',199,'Trolls.jpg'),
	(6,'DarthVader ToothSaber',45,'DarthVader.jpg');

/*!40000 ALTER TABLE `Products` ENABLE KEYS */;
UNLOCK TABLES;



/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
