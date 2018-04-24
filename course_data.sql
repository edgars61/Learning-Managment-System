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
(13245, 'FIN 2301', 'Personal Finance', '3:00-4:30 TTH', 'Raymond', 'Allen', '3'),
(16803, 'MATH 2410', 'Discrete Mathematics', '11:00-12:30 MW', 'Jhon', 'Runnels', '3'),
(18550, 'ENG 2301', 'English I', '9:00-10:30 MW', 'Jennifer', 'Marquez', '3'),
(20315, 'ENG 2301', 'English II', '1:00-2:30 MW', 'Jennifer', 'Marquez', '3'),
(22204, 'CHEM 1411', 'Chemistry', '11:00-1:00 MW', 'Jim', 'Quad', '4'),
(22660, 'COMM 3306', 'Public Speaking', '5:00-7:00 TH', 'Randy', 'Perez', '2'),
(27801, 'BUS 3310', 'Business Management', '11:00-1:00 TTH', 'Royce', 'Jantes', '4'),
(29464, 'GEO 3301', 'Hydrogeology', '2:30-3:45 TH', 'Kenny', 'Martin', '2'),
(30075, 'MATH 2411', 'Liner Algebra', '11:00-12:00 MW', 'Jerry', 'Larson', '2'),
(30084, 'ECON 1301', 'Macroeconomics', '9:00-11:00 MW', 'Michael', 'Hurst', '4'),
(33221, 'CS 4311', 'App Development', '11:00-12:30 TTH', 'Markus', 'Renson', '3'),
(33241, 'CS 3344', 'Network Security', '9:00-10:00 MW', 'Markus', 'Renson', '2'),
(34254, 'MATH 3302', 'Calculus II', '11:00-12:30 TTH', 'Marcus', 'Ferguson', '3'),
(35198, 'MATH 3400', 'Proability and Statistics', '4:00-6:00 MW', 'Richard', 'Keller', '4'),
(40507, 'BUSS 4422', 'International Business ', '4:00-6:00 TH', 'Ron', 'Slater', '4'),
(42038, 'MUS 1300', 'Basic Music Theory', '4:00-6:00 M', 'Carlos', 'Campez', '2'),
(46947, 'BUSS 3420', 'Business Ethics', '2:00-4:00 MW', 'Ron ', 'Slater', '4'),
(55406, 'MKT 3401', 'Marketing I', '10:00-12:00 MW', 'Frank', 'Stevens', '4'),
(60515, 'MATH 2302', 'Calculus I', '8:00-9:00 MW', 'Joey', 'Johnson', '2'),
(74501, 'BIOL 2314', 'Human Biology ', '2:00-4:00 TH', 'Leticia', 'Baker', '2'),
(76706, 'GEO 1305', 'Oceanography', '11:00-12:00 TTH', 'Elizabeth', 'Newton', '2'),
(82720, 'CS 3406', 'Computation Theory', '9:00-11:00 TTH', 'Caine', 'Brady', '4'),
(87110, 'COMM 2308', 'Interpersonal Communicati', '3:00-6:00 TH', 'James', 'Vadtson', '3'),
(97420, 'BIO 1302', 'General Biology', '2:00-5:00 TH', 'Charles', 'Parkson', '3');

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
