-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2018 at 10:52 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `slmsdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `student_data`
--

CREATE TABLE `student_data` (
  `Student_Id` int(11) NOT NULL,
  `Password` varchar(25) DEFAULT NULL,
  `First_Name` varchar(12) DEFAULT NULL,
  `Last_Name` varchar(12) DEFAULT NULL,
  `Address` varchar(25) DEFAULT NULL,
  `City` varchar(25) DEFAULT NULL,
  `Zip_Code` int(11) NOT NULL,
  `Phone_Number` varchar(12) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `SSN` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student_data`
--

INSERT INTO `student_data` (`Student_Id`, `Password`, `First_Name`, `Last_Name`, `Address`, `City`, `Zip_Code`, `Phone_Number`, `DOB`, `SSN`) VALUES
(90019138, 'Smolka2312', 'Rigo', 'Smolka', '395 New Street', 'Housotn', 77023, '713-287-1951', '1970-08-12', '344-23-3246'),
(90037632, 'WallT111', 'Terry', 'Wall', '1916 Rivendell Drive', 'Cypress', 77762, '281-861-9388', '1980-12-26', '236-68-5344'),
(99002141, 'RomanEJ1', 'Joel', 'Roman', '397 Fire Access Road', 'Sugarland', 77895, '713-924-4774', '1964-07-25', '681-95-2318'),
(99008102, 'WatsonBV9', 'Vincent', 'Watson', '3736 Hiney Road', 'Katy', 77002, '832-222-9821', '1984-12-04', '638-53-5498'),
(99019108, 'Turcio123R', 'Robert', 'Turcio', '639 Saint Clair Street', 'Houston', 77614, '713-627-5689', '1971-02-04', '854-34-6024'),
(99022011, 'SandersSR21', 'Rachell', 'Sanders', '1736 Langtown Road', 'Houston', 77907, '832-231-2194', '1959-10-28', '228-64-4438'),
(99031707, 'VidaLoca12', 'Ricky', 'Martins', '3136 Pine Street', 'Cypress', 77044, '281-321-1863', '1946-03-26', '143-22-5735'),
(99033436, 'MMAHOUR1232', 'Ariel', 'Helwani', '1369 Orchard Street', 'Humble', 77104, '346-601-7925', '1960-05-05', '443-00-1216'),
(99037660, 'Sacksonfive5', 'Janet', 'Sackson', '4954 Giraffe Hill Drive', 'Sugarland', 77247, '281-317-7508', '1976-07-24', '623-23-2150'),
(99045406, 'Friday13th', 'Jason', 'Vorges', '4393 Sampson Street', 'Katy', 77221, '281-609-8275', '1981-10-16', '523-45-2653'),
(99048235, 'Richardson11E', 'Emmanuel', 'Richardson', '3684 Payne Street', 'Astascocita', 77228, '713-926-7416', '1979-08-07', '213-11-1157'),
(99053151, 'FelderElbow1', 'Bob', 'Felder', '4806 Maple Court', 'Houston', 77101, '832-395-8650', '1965-04-19', '424-70-0876'),
(99058554, 'Manson1423F', 'Felicity', 'Manson', '2137 Wescam Court', 'Katy', 77132, '713-223-2723', '1970-07-27', '198-15-5326'),
(99061820, 'BennettBT7', 'Troy', 'Bennett', '3351 Pickens Way', 'Houston', 77446, '346-378-8395', '1973-03-21', '435-12-3425'),
(99065325, 'VantesJ315', 'Jose', 'Cervantes', '1518 Heavens Way', 'Cypress', 77014, '346-265-1157', '1986-02-03', '765-67-7899'),
(99072212, 'CooksP12', 'Patricia', 'Cooks', '1851 Coleman Avenue', 'Humble', 77262, '713-799-5157', '1966-01-23', '687-65-4347'),
(99080015, 'NegredoCS12', 'Conor', 'Negredo', '1040 Amethyst Drive', 'Jacinto', 77262, '832-287-2321', '1980-09-19', '125-40-7898'),
(99084120, 'Anderston123', 'Megan', 'Anderton', '1634 Park Street', 'Pasadena', 77612, '281-419-6874', '1954-06-06', '345-82-4352'),
(99092111, 'CreedVicky65', 'Victoria', 'Creed', '2278 Traction Street', 'Houston', 77601, '713-538-1515', '1994-10-18', '312-58-9906'),
(99097205, 'LopezAsh432', 'Ashley', 'Lopez', '1398 Philadelphia Avenue', 'Humble', 77010, '832-298-2521', '1988-07-15', '14-12-1221'),
(900346544, 'FullerHouse', 'Jordan', 'Fuller', '9103 Danielle Ct.', 'Houston', 77132, '832-543-2324', '1990-05-28', '8764-34-9867'),
(900352233, '12345', 'Sergio', 'Toledo', '565 Main road', 'Houston', 77022, '7136957944', '1996-03-17', '356656325');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student_data`
--
ALTER TABLE `student_data`
  ADD PRIMARY KEY (`Student_Id`),
  ADD KEY `Zip_Code_index` (`Zip_Code`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
