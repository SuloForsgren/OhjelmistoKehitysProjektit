-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 07.12.2021 klo 12:32
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
-- Database: `kirjautuminen`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asujat`
--

DROP TABLE IF EXISTS `asujat`;
CREATE TABLE `asujat` (
  `Oid` int(11) NOT NULL,
  `Etunimi` varchar(15) NOT NULL,
  `Sukunimi` varchar(15) NOT NULL,
  `Puhelinnumero` varchar(15) NOT NULL,
  `sähköposti` varchar(30) NOT NULL,
  `Käyttäjänimi` varchar(20) NOT NULL,
  `Salasana` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `asujat`
--

INSERT INTO `asujat` (`Oid`, `Etunimi`, `Sukunimi`, `Puhelinnumero`, `sähköposti`, `Käyttäjänimi`, `Salasana`) VALUES
(13, 'Sulo', 'Forsgren', '12345678', 'sulo.forsgren@sfd.com', 'Sulo', 'Teddy123');

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

DROP TABLE IF EXISTS `huoneet`;
CREATE TABLE `huoneet` (
  `numero` int(11) NOT NULL,
  `tyyppi` int(11) NOT NULL,
  `puhelin` varchar(100) NOT NULL,
  `vapaa` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huoneet`
--

INSERT INTO `huoneet` (`numero`, `tyyppi`, `puhelin`, `vapaa`) VALUES
(100, 1, '123', 'Kyllä'),
(101, 1, '1234', 'Kyllä'),
(102, 1, '12345', 'Kyllä'),
(103, 1, '123456', 'Kyllä'),
(104, 1, '1234567', 'Kyllä'),
(110, 2, '234', 'Kyllä'),
(111, 2, '2345', 'Kyllä'),
(112, 2, '23456', 'Kyllä'),
(113, 2, '234567', 'Kyllä'),
(114, 2, '2345678', 'Kyllä'),
(120, 3, '01234', 'Kyllä'),
(121, 3, '012345', 'Kyllä'),
(122, 3, '0123456', 'Kyllä'),
(123, 3, '01234567', 'Kyllä'),
(124, 3, '012345678', 'Kyllä'),
(130, 4, '666', 'Kyllä'),
(131, 4, '6666', 'Kyllä'),
(132, 4, '66666', 'Kyllä'),
(133, 4, '666666', 'Kyllä'),
(134, 4, '6666666', 'Kyllä');

-- --------------------------------------------------------

--
-- Rakenne taululle `huonekategoria`
--

DROP TABLE IF EXISTS `huonekategoria`;
CREATE TABLE `huonekategoria` (
  `kategoriaid` int(11) NOT NULL,
  `Nimi` varchar(200) NOT NULL,
  `Hinta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huonekategoria`
--

INSERT INTO `huonekategoria` (`kategoriaid`, `Nimi`, `Hinta`) VALUES
(1, 'yksiö', '1000'),
(2, 'kaksio', '2000'),
(3, 'perhe', '3000'),
(4, 'sviitti', '5000');

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

DROP TABLE IF EXISTS `varaukset`;
CREATE TABLE `varaukset` (
  `varausID` int(11) NOT NULL,
  `huonenumero` int(11) NOT NULL,
  `asiakasID` int(11) NOT NULL,
  `pvmsisaan` date NOT NULL,
  `pvmulos` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asujat`
--
ALTER TABLE `asujat`
  ADD PRIMARY KEY (`Oid`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `fk_type_id` (`tyyppi`);

--
-- Indexes for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  ADD PRIMARY KEY (`kategoriaid`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`varausID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asujat`
--
ALTER TABLE `asujat`
  MODIFY `Oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  MODIFY `kategoriaid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `varausID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Rajoitteet vedostauluille
--

--
-- Rajoitteet taululle `huoneet`
--
ALTER TABLE `huoneet`
  ADD CONSTRAINT `fk_type_id` FOREIGN KEY (`tyyppi`) REFERENCES `huonekategoria` (`kategoriaid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Rajoitteet taululle `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `fk_huonenumero` FOREIGN KEY (`huonenumero`) REFERENCES `huoneet` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
