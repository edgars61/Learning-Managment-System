-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2018 at 09:29 PM
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
-- Table structure for table `gpa_data`
--

CREATE TABLE `gpa_data` (
  `Student_Id` int(11) NOT NULL,
  `CRN1` int(11) NOT NULL,
  `Hours1` int(11) NOT NULL,
  `Grade1` int(11) NOT NULL,
  `GradeG1` decimal(12,2) DEFAULT NULL,
  `Grade_Points1` decimal(12,2) DEFAULT NULL,
  `CRN2` int(11) NOT NULL,
  `Hours2` int(11) NOT NULL,
  `Grade2` int(11) NOT NULL,
  `GradeG2` int(11) NOT NULL,
  `Grade_Points2` int(11) NOT NULL,
  `CRN3` int(11) NOT NULL,
  `Hours3` int(11) NOT NULL,
  `Grade3` int(11) NOT NULL,
  `GradeG3` int(11) NOT NULL,
  `Grade_Points3` int(11) NOT NULL,
  `CRN4` int(11) NOT NULL,
  `Hours4` int(11) NOT NULL,
  `Grade4` int(11) NOT NULL,
  `GradeG4` int(11) NOT NULL,
  `Grade_Points4` int(11) NOT NULL,
  `CRN5` int(11) NOT NULL,
  `Hours5` int(11) NOT NULL,
  `Grade5` int(11) NOT NULL,
  `GradeG5` int(11) NOT NULL,
  `Grade_Points5` int(11) NOT NULL,
  `Points_Earned` decimal(12,2) DEFAULT NULL,
  `Hours_Attempted` int(11) NOT NULL,
  `GPA` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `gpa_data`
--

INSERT INTO `gpa_data` (`Student_Id`, `CRN1`, `Hours1`, `Grade1`, `GradeG1`, `Grade_Points1`, `CRN2`, `Hours2`, `Grade2`, `GradeG2`, `Grade_Points2`, `CRN3`, `Hours3`, `Grade3`, `GradeG3`, `Grade_Points3`, `CRN4`, `Hours4`, `Grade4`, `GradeG4`, `Grade_Points4`, `CRN5`, `Hours5`, `Grade5`, `GradeG5`, `Grade_Points5`, `Points_Earned`, `Hours_Attempted`, `GPA`) VALUES
(90019138, 82720, 4, 96, '3.60', '14.40', 42038, 2, 88, 3, 6, 30084, 4, 89, 3, 12, 22660, 2, 86, 3, 6, 74501, 2, 84, 3, 6, '44.40', 14, '3.29'),
(90037632, 22204, 3, 91, '3.10', '9.30', 30084, 4, 84, 3, 12, 76706, 2, 88, 3, 6, 60515, 2, 80, 2, 4, 13245, 4, 86, 3, 12, '43.30', 15, '3.20'),
(99002141, 22204, 3, 79, '1.90', '5.70', 74501, 2, 86, 3, 6, 78550, 3, 93, 4, 12, 40507, 4, 83, 3, 12, 20315, 3, 88, 3, 9, '44.70', 15, '2.98'),
(99008102, 29464, 2, 98, '3.80', '7.60', 33221, 3, 84, 3, 9, 46947, 4, 80, 2, 8, 22660, 2, 81, 3, 6, 22204, 3, 93, 4, 12, '42.60', 14, '3.04'),
(99019108, 0, 0, 0, '0.00', '0.00', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0.00', 0, '0.00'),
(99022011, 30075, 2, 93, '3.30', '6.60', 76706, 2, 86, 3, 6, 60515, 2, 92, 4, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '20.60', 6, '3.43'),
(99031707, 13245, 4, 88, '2.80', '11.20', 33221, 3, 86, 3, 9, 20315, 3, 92, 4, 12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '32.20', 10, '3.22'),
(99033436, 78550, 3, 88, '2.80', '8.40', 30084, 4, 88, 3, 12, 16803, 3, 86, 3, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '29.40', 10, '2.94'),
(99037660, 87110, 3, 76, '1.60', '4.80', 97420, 2, 83, 3, 6, 20315, 3, 86, 3, 9, 16803, 3, 82, 3, 9, 55406, 4, 93, 4, 16, '44.80', 15, '2.99'),
(99045406, 87110, 3, 92, '3.20', '9.60', 22660, 2, 93, 4, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '17.60', 5, '3.52'),
(99048235, 33221, 3, 87, '2.70', '8.10', 22660, 2, 90, 3, 6, 29464, 2, 82, 3, 6, 46947, 4, 84, 3, 12, 0, 0, 0, 0, 0, '32.10', 11, '2.92'),
(99053151, 60515, 2, 79, '1.00', '2.00', 30084, 4, 89, 3, 12, 40507, 4, 98, 4, 16, 46947, 4, 89, 3, 12, 13245, 4, 88, 3, 12, '54.00', 18, '3.00'),
(99058554, 42038, 2, 81, '2.10', '4.20', 33221, 3, 85, 3, 9, 27801, 4, 85, 3, 12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '25.20', 9, '2.80'),
(99061820, 22204, 3, 77, '1.70', '5.10', 76706, 2, 90, 3, 6, 78550, 3, 93, 4, 12, 13245, 4, 90, 3, 12, 30075, 2, 89, 3, 6, '41.10', 14, '2.94'),
(99065325, 78550, 3, 85, '2.50', '7.50', 33221, 3, 87, 3, 9, 22660, 2, 91, 4, 8, 29464, 2, 94, 4, 8, 0, 0, 0, 0, 0, '32.50', 10, '3.25'),
(99072212, 13245, 4, 92, '3.20', '12.80', 97420, 2, 91, 4, 8, 20315, 3, 82, 3, 9, 76706, 2, 82, 3, 6, 40507, 4, 84, 3, 12, '47.80', 15, '3.19'),
(99080015, 74501, 2, 90, '3.00', '6.00', 33241, 2, 86, 3, 6, 22660, 2, 87, 3, 6, 82720, 4, 94, 4, 16, 97420, 2, 86, 3, 6, '40.00', 12, '3.33'),
(99084120, 40507, 4, 95, '3.50', '14.00', 42038, 2, 93, 4, 8, 76706, 2, 87, 3, 6, 29464, 2, 91, 4, 8, 0, 0, 0, 0, 0, '36.00', 10, '3.60'),
(99092111, 97420, 2, 89, '2.90', '5.80', 29464, 2, 89, 3, 6, 78550, 3, 81, 3, 9, 20315, 3, 89, 3, 9, 0, 0, 0, 0, 0, '29.80', 10, '2.98'),
(99097205, 42038, 2, 83, '2.30', '4.60', 30084, 4, 92, 4, 16, 22660, 2, 85, 3, 6, 82720, 4, 88, 3, 12, 13245, 4, 89, 3, 12, '50.60', 16, '3.16'),
(900346544, 0, 0, 0, '0.00', '0.00', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0.00', 0, '4.00'),
(900352233, 0, 0, 0, '0.00', '0.00', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0.00', 0, '0.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gpa_data`
--
ALTER TABLE `gpa_data`
  ADD PRIMARY KEY (`Student_Id`),
  ADD KEY `CRN1_index` (`CRN1`),
  ADD KEY `Hours1_index` (`Hours1`),
  ADD KEY `Grade1_index` (`Grade1`),
  ADD KEY `CRN2_index` (`CRN2`),
  ADD KEY `Hours2_index` (`Hours2`),
  ADD KEY `Grade2_index` (`Grade2`),
  ADD KEY `GradeG2_index` (`GradeG2`),
  ADD KEY `Grade_Points2_index` (`Grade_Points2`),
  ADD KEY `CRN3_index` (`CRN3`),
  ADD KEY `Hours3_index` (`Hours3`),
  ADD KEY `Grade3_index` (`Grade3`),
  ADD KEY `GradeG3_index` (`GradeG3`),
  ADD KEY `Grade_Points3_index` (`Grade_Points3`),
  ADD KEY `CRN4_index` (`CRN4`),
  ADD KEY `Hours4_index` (`Hours4`),
  ADD KEY `Grade4_index` (`Grade4`),
  ADD KEY `GradeG4_index` (`GradeG4`),
  ADD KEY `Grade_Points4_index` (`Grade_Points4`),
  ADD KEY `CRN5_index` (`CRN5`),
  ADD KEY `Hours5_index` (`Hours5`),
  ADD KEY `Grade5_index` (`Grade5`),
  ADD KEY `GradeG5_index` (`GradeG5`),
  ADD KEY `Grade_Points5_index` (`Grade_Points5`),
  ADD KEY `Hours_Attempted_index` (`Hours_Attempted`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
