-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 13.12.2021 klo 09:26
-- Palvelimen versio: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kauppa`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `kirjautuminen`
--

CREATE TABLE `kirjautuminen` (
  `ID` int(11) NOT NULL,
  `Käyttäjätyyppi` varchar(12) NOT NULL,
  `Etunimi` varchar(15) NOT NULL,
  `Sukunimi` varchar(15) NOT NULL,
  `Username` varchar(12) NOT NULL,
  `Password` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `kirjautuminen`
--

INSERT INTO `kirjautuminen` (`ID`, `Käyttäjätyyppi`, `Etunimi`, `Sukunimi`, `Username`, `Password`) VALUES
(1, 'Ylläpitäjä', 'Sulo', 'Forsgren', 'Sulo', 'Teddy123'),
(12, 'Ylläpitäjä', 'Timo', 'Testaaja', 'Timppa', 'Testaa1');

-- --------------------------------------------------------

--
-- Rakenne taululle `kirjautuminen asiakas`
--

CREATE TABLE `kirjautuminen asiakas` (
  `ID` int(11) NOT NULL,
  `Etunimi` varchar(15) NOT NULL,
  `Sukunimi` varchar(15) NOT NULL,
  `Käyttäjätunnus` varchar(12) NOT NULL,
  `Salasana` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `kirjautuminen asiakas`
--

INSERT INTO `kirjautuminen asiakas` (`ID`, `Etunimi`, `Sukunimi`, `Käyttäjätunnus`, `Salasana`) VALUES
(1, 'Sulo', 'Forsgren', 'Teddy', 'Tester123'),
(2, 'Timo', 'Testaaja', 'Timppa', 'Testaaja1');

-- --------------------------------------------------------

--
-- Rakenne taululle `tuotteet`
--

CREATE TABLE `tuotteet` (
  `ID` int(11) NOT NULL,
  `Tuote` varchar(15) NOT NULL,
  `Hinta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `tuotteet`
--

INSERT INTO `tuotteet` (`ID`, `Tuote`, `Hinta`) VALUES
(3, 'Maito', 1),
(4, 'Broiler filee', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kirjautuminen`
--
ALTER TABLE `kirjautuminen`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `kirjautuminen asiakas`
--
ALTER TABLE `kirjautuminen asiakas`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tuotteet`
--
ALTER TABLE `tuotteet`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kirjautuminen`
--
ALTER TABLE `kirjautuminen`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `kirjautuminen asiakas`
--
ALTER TABLE `kirjautuminen asiakas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tuotteet`
--
ALTER TABLE `tuotteet`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
