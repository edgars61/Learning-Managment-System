-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2018 at 09:20 PM
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
-- Table structure for table `course_data`
--

CREATE TABLE `course_data` (
  `CRN_Number` int(11) NOT NULL,
  `Course_ID` varchar(12) DEFAULT NULL,
  `Course_Name` varchar(25) DEFAULT NULL,
  `Course_Time` varchar(25) DEFAULT NULL,
  `First_Name` varchar(12) DEFAULT NULL,
  `Last_Name` varchar(12) DEFAULT NULL,
  `Course_Hours` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `course_data`
--

INSERT INTO `course_data` (`CRN_Number`, `Course_ID`, `Course_Name`, `Course_Time`, `First_Name`, `Last_Name`, `Course_Hours`) VALUES
(13245, 'FIN 2301', 'Personal Finance', '3:00-4:15 TTH', 'Raymond', 'Allen', '3'),
(16803, 'MATH 2410', 'Discrete Mathematics', '11:00-12:45 MW', 'Jhon', 'Runnels', '4'),
(18550, 'ENG 2301', 'English I', '9:00-10:15 MW', 'Jennifer', 'Marquez', '3'),
(20315, 'ENG 2301', 'English II', '1:00-2:15 MW', 'Jennifer', 'Marquez', '3'),
(22204, 'CHEM 1411', 'Chemistry', '11:00-12:45 MW', 'Jim', 'Quad', '4'),
(22660, 'COMM 3306', 'Public Speaking', '5:00-7:45 TH', 'Randy', 'Perez', '3'),
(27801, 'BUS 3310', 'Business Management', '11:00-12:15 TTH', 'Royce', 'Jantes', '3'),
(29464, 'GEO 3301', 'Hydrogeology', '2:30-3:45 TH', 'Kenny', 'Martin', '3'),
(30075, 'MATH 2411', 'Liner Algebra', '11:00-12:45 MW', 'Jerry', 'Larson', '4'),
(30084, 'ECON 1301', 'Macroeconomics', '9:00-10:15 MW', 'Michael', 'Hurst', '3'),
(33221, 'CS 4311', 'App Development', '11:00-12:15 TTH', 'Markus', 'Renson', '3'),
(33241, 'CS 3344', 'Network Security', '9:00-10:15 MW', 'Markus', 'Renson', '3'),
(34254, 'MATH 3302', 'Calculus II', '11:00-12:15 TTH', 'Marcus', 'Ferguson', '3'),
(35198, 'MATH 3400', 'Proability and Statistics', '4:00-5:45 MW', 'Richard', 'Keller', '4'),
(40507, 'BUSS 4322', 'International Business ', '4:00-5:15 TH', 'Ron', 'Slater', '3'),
(42038, 'MUS 1300', 'Basic Music Theory', '4:00-5:15 MW', 'Carlos', 'Campez', '3'),
(46947, 'BUSS 3320', 'Business Ethics', '2:00-4:15 MW', 'Ron ', 'Slater', '3'),
(55406, 'MKT 3301', 'Finance', '11:00-12:15 MW', 'Frank', 'Stevens', '3'),
(60515, 'MATH 2302', 'Calculus I', '8:00-9:15 MW', 'Joey', 'Johnson', '3'),
(74501, 'BIOL 2314', 'Human Biology ', '2:00-4:45 TH', 'Leticia', 'Baker', '3'),
(76706, 'GEO 1305', 'Oceanography', '11:00-12:15 TTH', 'Elizabeth', 'Newton', '3'),
(82720, 'CS 3306', 'Computation Theory', '9:00-10:15 TTH', 'Caine', 'Brady', '3'),
(87110, 'COMM 2308', 'Interpersonal Communicati', '3:00-5:45TH', 'James', 'Vadtson', '3'),
(97420, 'BIO 1302', 'General Biology', '2:00-4:15 TH', 'Charles', 'Parkson', '3');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course_data`
--
ALTER TABLE `course_data`
  ADD PRIMARY KEY (`CRN_Number`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
