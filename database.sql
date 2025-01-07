-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Jan 07. 14:45
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `event_organizer`
--
CREATE DATABASE IF NOT EXISTS `event_organizer` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `event_organizer`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `equipment`
--

CREATE TABLE IF NOT EXISTS `equipment` (
  `equipment_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `size` decimal(10,0) NOT NULL,
  PRIMARY KEY (`equipment_id`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `equipment`
--

INSERT INTO `equipment` (`equipment_id`, `name`, `size`) VALUES
(1, 'Gizmo szőrős teste', 23),
(102, 'sdfsdfsdfsdbfsd', 334),
(103, 'fdsdsf', 4);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `event`
--

CREATE TABLE IF NOT EXISTS `event` (
  `event_id` int(11) NOT NULL AUTO_INCREMENT,
  `location_id` int(11) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `type` varchar(255) NOT NULL,
  PRIMARY KEY (`event_id`),
  KEY `location_id` (`location_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `event_equipment`
--

CREATE TABLE IF NOT EXISTS `event_equipment` (
  `event_id` int(11) NOT NULL,
  `equipment_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  PRIMARY KEY (`event_id`,`equipment_id`),
  KEY `equipment_id` (`equipment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `locations`
--

CREATE TABLE IF NOT EXISTS `locations` (
  `location_id` int(11) NOT NULL AUTO_INCREMENT,
  `capacity` int(11) DEFAULT NULL,
  `available_times` varchar(255) DEFAULT NULL,
  `elegance` int(11) DEFAULT NULL,
  `catering_type` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`location_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `locations`
--

INSERT INTO `locations` (`location_id`, `capacity`, `available_times`, `elegance`, `catering_type`) VALUES
(1, 400, 'AllDay', 3, 'Seated'),
(2, 400, 'Evening', 2, 'Standing'),
(3, 50, 'Morning', 5, 'Seated');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `truck`
--

CREATE TABLE IF NOT EXISTS `truck` (
  `truck_id` int(11) NOT NULL AUTO_INCREMENT,
  `current_location` int(11) NOT NULL,
  PRIMARY KEY (`truck_id`),
  KEY `current_location` (`current_location`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `truckparking`
--

CREATE TABLE IF NOT EXISTS `truckparking` (
  `parking_id` int(11) NOT NULL AUTO_INCREMENT,
  `truck_id` int(11) NOT NULL,
  PRIMARY KEY (`parking_id`),
  KEY `truck_id` (`truck_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `warehouse`
--

CREATE TABLE IF NOT EXISTS `warehouse` (
  `warehouse_id` int(11) NOT NULL AUTO_INCREMENT,
  `capacity` int(11) NOT NULL,
  PRIMARY KEY (`warehouse_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `warehouse`
--

INSERT INTO `warehouse` (`warehouse_id`, `capacity`) VALUES
(1, 500);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `warehouse_equipment`
--

CREATE TABLE IF NOT EXISTS `warehouse_equipment` (
  `warehouse_id` int(11) NOT NULL,
  `equipment_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`warehouse_id`,`equipment_id`),
  KEY `equipment_id` (`equipment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `warehouse_equipment`
--

INSERT INTO `warehouse_equipment` (`warehouse_id`, `equipment_id`, `quantity`) VALUES
(1, 1, 23);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `event_ibfk_1` FOREIGN KEY (`location_id`) REFERENCES `locations` (`location_id`);

--
-- Megkötések a táblához `event_equipment`
--
ALTER TABLE `event_equipment`
  ADD CONSTRAINT `event_equipment_ibfk_1` FOREIGN KEY (`event_id`) REFERENCES `event` (`event_id`),
  ADD CONSTRAINT `event_equipment_ibfk_2` FOREIGN KEY (`equipment_id`) REFERENCES `equipment` (`equipment_id`);

--
-- Megkötések a táblához `truck`
--
ALTER TABLE `truck`
  ADD CONSTRAINT `truck_ibfk_2` FOREIGN KEY (`current_location`) REFERENCES `locations` (`location_id`);

--
-- Megkötések a táblához `truckparking`
--
ALTER TABLE `truckparking`
  ADD CONSTRAINT `truckparking_ibfk_1` FOREIGN KEY (`parking_id`) REFERENCES `locations` (`location_id`),
  ADD CONSTRAINT `truckparking_ibfk_2` FOREIGN KEY (`truck_id`) REFERENCES `truck` (`truck_id`);

--
-- Megkötések a táblához `warehouse_equipment`
--
ALTER TABLE `warehouse_equipment`
  ADD CONSTRAINT `warehouse_equipment_ibfk_1` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`),
  ADD CONSTRAINT `warehouse_equipment_ibfk_2` FOREIGN KEY (`equipment_id`) REFERENCES `equipment` (`equipment_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
