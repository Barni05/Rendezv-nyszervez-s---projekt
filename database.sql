-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Jan 07. 13:49
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

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

CREATE TABLE `equipment` (
  `equipment_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `size` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

CREATE TABLE `event` (
  `event_id` int(11) NOT NULL,
  `location_id` int(11) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `event_equipment`
--

CREATE TABLE `event_equipment` (
  `event_id` int(11) NOT NULL,
  `equipment_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `locations`
--

CREATE TABLE `locations` (
  `location_id` int(11) NOT NULL,
  `capacity` int(11) DEFAULT NULL,
  `available_times` varchar(255) DEFAULT NULL,
  `elegance` int(11) DEFAULT NULL,
  `catering_type` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `truck`
--

CREATE TABLE `truck` (
  `truck_id` int(11) NOT NULL,
  `current_location` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `truckparking`
--

CREATE TABLE `truckparking` (
  `parking_id` int(11) NOT NULL,
  `truck_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `truckparking`
--

INSERT INTO `truckparking` (`parking_id`, `truck_id`) VALUES
(1, 0),
(2, 2);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `warehouse`
--

CREATE TABLE `warehouse` (
  `warehouse_id` int(11) NOT NULL,
  `capacity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `warehouse`
--

INSERT INTO `warehouse` (`warehouse_id`, `capacity`) VALUES
(1, 500);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `warehouse_equipment`
--

CREATE TABLE `warehouse_equipment` (
  `warehouse_id` int(11) NOT NULL,
  `equipment_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `warehouse_equipment`
--

INSERT INTO `warehouse_equipment` (`warehouse_id`, `equipment_id`, `quantity`) VALUES
(1, 1, 23);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `equipment`
--
ALTER TABLE `equipment`
  ADD PRIMARY KEY (`equipment_id`);

--
-- A tábla indexei `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`event_id`),
  ADD KEY `location_id` (`location_id`);

--
-- A tábla indexei `event_equipment`
--
ALTER TABLE `event_equipment`
  ADD PRIMARY KEY (`event_id`,`equipment_id`),
  ADD KEY `equipment_id` (`equipment_id`);

--
-- A tábla indexei `locations`
--
ALTER TABLE `locations`
  ADD PRIMARY KEY (`location_id`);

--
-- A tábla indexei `truck`
--
ALTER TABLE `truck`
  ADD PRIMARY KEY (`truck_id`),
  ADD KEY `current_location` (`current_location`);

--
-- A tábla indexei `truckparking`
--
ALTER TABLE `truckparking`
  ADD PRIMARY KEY (`parking_id`);

--
-- A tábla indexei `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`warehouse_id`);

--
-- A tábla indexei `warehouse_equipment`
--
ALTER TABLE `warehouse_equipment`
  ADD PRIMARY KEY (`warehouse_id`,`equipment_id`),
  ADD KEY `equipment_id` (`equipment_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `equipment`
--
ALTER TABLE `equipment`
  MODIFY `equipment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=104;

--
-- AUTO_INCREMENT a táblához `event`
--
ALTER TABLE `event`
  MODIFY `event_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `locations`
--
ALTER TABLE `locations`
  MODIFY `location_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `truck`
--
ALTER TABLE `truck`
  MODIFY `truck_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `truckparking`
--
ALTER TABLE `truckparking`
  MODIFY `parking_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `warehouse_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
-- Megkötések a táblához `warehouse_equipment`
--
ALTER TABLE `warehouse_equipment`
  ADD CONSTRAINT `warehouse_equipment_ibfk_1` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`),
  ADD CONSTRAINT `warehouse_equipment_ibfk_2` FOREIGN KEY (`equipment_id`) REFERENCES `equipment` (`equipment_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
