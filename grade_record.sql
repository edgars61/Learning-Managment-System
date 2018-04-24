-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2018 at 10:14 PM
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
-- Table structure for table `grade_record`
--

CREATE TABLE `grade_record` (
  `Student_Id` int(11) NOT NULL,
  `Semester` varchar(12) DEFAULT NULL,
  `CRN1` int(11) NOT NULL,
  `Midterm_1_1` int(11) NOT NULL,
  `Midterm_2_1` int(11) NOT NULL,
  `Final_1` int(11) NOT NULL,
  `CourseGrade_1` int(11) NOT NULL,
  `CRN2` int(11) NOT NULL,
  `Midterm_1_2` int(11) NOT NULL,
  `Midterm_2_2` int(11) NOT NULL,
  `Final_2` int(11) NOT NULL,
  `CourseGrade_2` int(11) NOT NULL,
  `CRN3` int(11) NOT NULL,
  `Midterm_1_3` int(11) NOT NULL,
  `Midterm_2_3` int(11) NOT NULL,
  `Final_3` int(11) NOT NULL,
  `CourseGrade_3` int(11) NOT NULL,
  `CRN4` int(11) NOT NULL,
  `Midterm_1_4` int(11) NOT NULL,
  `Midterm_2_4` int(11) NOT NULL,
  `Final_4` int(11) NOT NULL,
  `CourseGrade_4` int(11) NOT NULL,
  `CRN5` int(11) NOT NULL,
  `Midterm_1_5` int(11) NOT NULL,
  `Midterm_2_5` int(11) NOT NULL,
  `Final_5` int(11) NOT NULL,
  `CourseGrade_5` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `grade_record`
--

INSERT INTO `grade_record` (`Student_Id`, `Semester`, `CRN1`, `Midterm_1_1`, `Midterm_2_1`, `Final_1`, `CourseGrade_1`, `CRN2`, `Midterm_1_2`, `Midterm_2_2`, `Final_2`, `CourseGrade_2`, `CRN3`, `Midterm_1_3`, `Midterm_2_3`, `Final_3`, `CourseGrade_3`, `CRN4`, `Midterm_1_4`, `Midterm_2_4`, `Final_4`, `CourseGrade_4`, `CRN5`, `Midterm_1_5`, `Midterm_2_5`, `Final_5`, `CourseGrade_5`) VALUES
(90019138, 'Spring2017', 82720, 79, 90, 85, 96, 42038, 79, 97, 88, 88, 30084, 99, 84, 83, 89, 22660, 78, 82, 97, 86, 74501, 83, 92, 75, 84),
(90037632, 'Spring2017', 22204, 93, 81, 75, 91, 30084, 76, 84, 90, 84, 76706, 94, 87, 82, 88, 60515, 76, 77, 86, 80, 13245, 78, 83, 95, 86),
(99002141, 'Fall2017', 22204, 76, 85, 99, 79, 74501, 87, 86, 85, 86, 78550, 96, 88, 93, 93, 40507, 82, 75, 91, 83, 20315, 80, 88, 95, 88),
(99008102, 'Spring2017', 29464, 83, 91, 97, 98, 33221, 76, 82, 94, 84, 46947, 83, 77, 80, 80, 22660, 82, 84, 76, 81, 22204, 99, 92, 86, 93),
(99019108, 'Spring2017', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(99022011, 'Spring2017', 30075, 78, 89, 81, 93, 76706, 89, 77, 91, 86, 60515, 90, 87, 97, 92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(99031707, 'Spring2017', 13245, 80, 86, 91, 88, 33221, 80, 79, 99, 86, 22204, 84, 93, 99, 92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(99033436, 'Fall2017', 78550, 85, 94, 91, 88, 30084, 95, 77, 91, 88, 16803, 82, 98, 76, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(99037660, 'Fall2017', 87110, 85, 99, 94, 76, 97420, 75, 84, 90, 83, 22204, 94, 75, 89, 86, 16803, 75, 78, 92, 82, 55406, 88, 91, 99, 93),
(99045406, 'Fall2017', 87110, 88, 83, 88, 92, 22660, 96, 93, 90, 93, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(99048235, 'Fall2017', 33221, 99, 76, 84, 87, 22660, 96, 95, 78, 90, 29464, 75, 89, 81, 82, 46947, 75, 92, 84, 84, 0, 0, 0, 0, 0),
(99053151, 'Fall2017', 60515, 91, 96, 80, 79, 30084, 85, 96, 86, 89, 40507, 98, 99, 96, 98, 46947, 93, 78, 96, 89, 13245, 96, 81, 86, 88),
(99058554, 'Spring2017', 42038, 97, 93, 80, 81, 33221, 80, 98, 77, 85, 27801, 79, 76, 99, 85, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(99061820, 'Fall2017', 22204, 93, 85, 89, 77, 76706, 89, 87, 94, 90, 78550, 97, 84, 96, 93, 13245, 98, 93, 78, 90, 30075, 93, 76, 98, 89),
(99065325, 'Fall2017', 78550, 81, 85, 88, 85, 33221, 85, 85, 89, 87, 22660, 82, 94, 95, 91, 29464, 93, 92, 96, 94, 0, 0, 0, 0, 0),
(99072212, 'Fall2017', 13245, 86, 93, 82, 92, 97420, 97, 77, 97, 91, 22204, 78, 86, 80, 82, 76706, 84, 75, 85, 82, 40507, 77, 78, 97, 84),
(99080015, 'Spring2017', 74501, 82, 89, 95, 90, 33241, 80, 79, 99, 86, 22660, 78, 93, 88, 87, 82720, 98, 95, 88, 94, 97420, 94, 77, 86, 86),
(99084120, 'Spring2017', 40507, 76, 79, 90, 95, 42038, 96, 94, 89, 93, 76706, 99, 81, 79, 87, 29464, 78, 98, 95, 91, 0, 0, 0, 0, 0),
(99092111, 'Fall2017', 97420, 96, 93, 91, 89, 29464, 95, 78, 94, 89, 78550, 81, 79, 81, 81, 20315, 97, 80, 89, 89, 0, 0, 0, 0, 0),
(99097205, 'Fall2017', 42038, 90, 85, 76, 83, 30084, 91, 92, 91, 92, 22660, 82, 88, 83, 85, 82720, 87, 96, 80, 88, 13245, 92, 77, 97, 89),
(900346544, 'Spring2017', 15213, 100, 100, 100, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(900352233, 'NotEnrolled', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `grade_record`
--
ALTER TABLE `grade_record`
  ADD PRIMARY KEY (`Student_Id`),
  ADD KEY `Student_Id_index` (`Student_Id`),
  ADD KEY `CRN1_index` (`CRN1`),
  ADD KEY `Midterm_1-1_index` (`Midterm_1_1`),
  ADD KEY `Midterm_1-2_index` (`Midterm_2_1`),
  ADD KEY `Final_1_index` (`Final_1`),
  ADD KEY `CourseGrade_1_index` (`CourseGrade_1`),
  ADD KEY `CRN2_index` (`CRN2`),
  ADD KEY `Midterm_2-1_index` (`Midterm_1_2`),
  ADD KEY `Midterm_2-2_index` (`Midterm_2_2`),
  ADD KEY `Final_2_index` (`Final_2`),
  ADD KEY `CourseGrade_2_index` (`CourseGrade_2`),
  ADD KEY `CRN3_index` (`CRN3`),
  ADD KEY `Midterm_3-1_index` (`Midterm_1_3`),
  ADD KEY `Midterm_3-2_index` (`Midterm_2_3`),
  ADD KEY `Final_3_index` (`Final_3`),
  ADD KEY `CourseGrade_3_index` (`CourseGrade_3`),
  ADD KEY `CRN4_index` (`CRN4`),
  ADD KEY `Midterm_4-1_index` (`Midterm_1_4`),
  ADD KEY `Midterm_4-2_index` (`Midterm_2_4`),
  ADD KEY `Final_4_index` (`Final_4`),
  ADD KEY `CourseGrade_4_index` (`CourseGrade_4`),
  ADD KEY `CRN5_index` (`CRN5`),
  ADD KEY `Midterm_5-1_index` (`Midterm_1_5`),
  ADD KEY `Midterm_5-2_index` (`Midterm_2_5`),
  ADD KEY `Final_5_index` (`Final_5`),
  ADD KEY `CourseGrade_5_index` (`CourseGrade_5`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
