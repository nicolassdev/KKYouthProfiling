-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 17, 2024 at 08:09 PM
-- Server version: 8.0.35
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kkprofiling_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `ADMIN_NUM` int NOT NULL,
  `ADMIN_ID` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `FIRSTNAME` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `LASTNAME` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `ADDRESS` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `CONTACT` varchar(50) NOT NULL,
  `ROLE` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `USERNAME` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `PASSWORD` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `PICTURE` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `CREATE_DATE` datetime DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`ADMIN_NUM`, `ADMIN_ID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `CONTACT`, `ROLE`, `USERNAME`, `PASSWORD`, `PICTURE`, `CREATE_DATE`) VALUES
(1, 'ADMIN-2024-1', 'CAMILA', 'REMOTO', 'BURAGUIS\n', '+63 932 9329 392', 'SK CHAIRPERSON', 'camila', 'm22KIRzdthdNxFLOrKJSwg==', 'D:;YouthProfiling;KKYouthProfiling;KKYouthProfiling;Resources;camila.jpg', '2024-09-13 03:33:02'),
(2, 'ADMIN-2024-2', 'MARICAR', 'AYDALLA', 'MATANAG LEGAZPI CITY', '+63 967 3507 791', 'SK CHAIRPERSON', 'lalove', 'V/fY/tI3QWG+mF1wCWGxcQ==', 'C:;Users;USER;OneDrive;Pictures;DABA;bgh.jpg', '2024-09-22 18:18:27'),
(3, 'ADMIN-2024-3', 'ADMIN', 'ADMIN', 'BURAGUIS', '+63 932 3231 312', 'SK CHAIRPERSON', 'admin', 'CinA5MJWDvBTvOJSvluE4g==', 'C:;Users;USER;OneDrive;Pictures;DABA;skb.jpg', '2024-10-13 13:36:10'),
(4, 'ADMIN-2024-4', 'JOHN DAVE', 'DAEN', 'BURAUGUIS  ', '+63 942 4020 424', 'SK KAGAWAD', 'dave', 'yGjLrkpCmzyuVSHt7ZUflw==', 'C:;Users;USER;OneDrive;Pictures;DABA;zombi-icon.png', '2024-10-14 19:05:22');

-- --------------------------------------------------------

--
-- Table structure for table `demographic_details`
--

CREATE TABLE `demographic_details` (
  `YOUTH_ID` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT 'References ID from Youth Details',
  `CIVIL_STATUS` varchar(30) COLLATE utf8mb4_general_ci NOT NULL,
  `AGE_GROUP` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `CLASSIFICATION` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `EDUC_ATTAINMENT` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `WORK_STATUS` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `VOTER` enum('YES','NO') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `ATTEND_KK_ASSEMBLY` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `IS_ATTENDED` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL COMMENT 'How many times youth attended KK Assembly',
  `NOT_ATTENDED` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL COMMENT 'Reason why not attended KK Assembly',
  `PICTURE` varchar(100) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `demographic_details`
--

INSERT INTO `demographic_details` (`YOUTH_ID`, `CIVIL_STATUS`, `AGE_GROUP`, `CLASSIFICATION`, `EDUC_ATTAINMENT`, `WORK_STATUS`, `VOTER`, `ATTEND_KK_ASSEMBLY`, `IS_ATTENDED`, `NOT_ATTENDED`, `PICTURE`) VALUES
('SKB-2024-1', 'SINGLE', 'Child Youth(15-17 y/o)', 'ISY', 'High School level', 'N/A', 'YES', 'NO', '', 'N/A', 'C:;Users;USER;OneDrive;Pictures;DABA;zombi-icon.png'),
('SKB-2024-2', 'MARRIED', 'Young Adult(25-30 y/o)', 'N/A', 'College Grad', 'EMPLOYED', 'YES', 'NO', '', 'N/A', 'C:;Users;USER;OneDrive;Pictures;DABA;daba.jpg'),
('SKB-2024-3', 'SINGLE', 'Core Youth(18-24 y/o)', 'ISY', 'College Level', 'N/A', 'YES', 'YES', '1-2 Times', '', 'C:;Users;USER;OneDrive;Pictures;DABA;man.png'),
('SKB-2024-4', 'SINGLE', 'Core Youth(18-24 y/o)', 'ISY', 'College Level', 'EMPLOYED', 'NO', 'YES', '5 and above', '', 'C:;Users;USER;OneDrive;Pictures;DABA;akoin.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `security`
--

CREATE TABLE `security` (
  `security_username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `security_password` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `security`
--

INSERT INTO `security` (`security_username`, `security_password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `youth_details`
--

CREATE TABLE `youth_details` (
  `YOUTH_NUM` int UNSIGNED NOT NULL,
  `YOUTH_ID` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT 'Generated Youth ID',
  `FIRSTNAME` varchar(30) COLLATE utf8mb4_general_ci NOT NULL,
  `MIDDLENAME` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `LASTNAME` varchar(30) COLLATE utf8mb4_general_ci NOT NULL,
  `AGE` tinyint UNSIGNED DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `GENDER` enum('Male','Female') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `CONTACT` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `EMAIL` varchar(80) COLLATE utf8mb4_general_ci NOT NULL,
  `PUROK` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `BARANGAY` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `MUNICIPALITY` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `PROVINCE` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `REGION` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `DATE_ADDED` datetime DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `youth_details`
--

INSERT INTO `youth_details` (`YOUTH_NUM`, `YOUTH_ID`, `FIRSTNAME`, `MIDDLENAME`, `LASTNAME`, `AGE`, `DOB`, `GENDER`, `CONTACT`, `EMAIL`, `PUROK`, `BARANGAY`, `MUNICIPALITY`, `PROVINCE`, `REGION`, `DATE_ADDED`) VALUES
(1, 'SKB-2024-1', 'SHAMMA', 'LECTURA', 'PEREZ', 16, '2008-09-04', 'Male', '+63 915 8725 231', 'shammaperez.29@gmail.com', 'PUROK-1', '58 BURAGUIS', 'LEGAZPI', 'ALBAY', 'V', '2024-11-17 18:08:17'),
(2, 'SKB-2024-2', 'SAMAR', 'MARIFES', 'BENIG', 30, '1994-04-05', 'Male', '+63 995 9758 190', 'maritesbinig@gmail.com', 'PUROK-1', '58 BURAGUIS', 'LEGAZPI', 'ALBAY', 'V', '2024-11-17 19:00:43'),
(3, 'SKB-2024-3', 'MARCO', 'DADO', 'DAEN', 18, '2006-03-28', 'Male', '+63 939 1239 129', 'marcodaen@gmail.com', 'PUROK-2', '58 BURAGUIS', 'LEGAZPI', 'ALBAY', 'V', '2024-11-17 21:27:32'),
(4, 'SKB-2024-4', 'ANTHONY NICOLE', 'DADO', 'DAEN', 22, '2002-05-10', 'Male', '+63 995 5310 164', 'anthonydaen25@gmail.com', 'PUROK-2', '58 BURAGUIS', 'LEGAZPI', 'ALBAY', 'V', '2024-11-17 23:34:13');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ADMIN_ID`),
  ADD UNIQUE KEY `ADMIN_NUM` (`ADMIN_NUM`);

--
-- Indexes for table `demographic_details`
--
ALTER TABLE `demographic_details`
  ADD PRIMARY KEY (`YOUTH_ID`);

--
-- Indexes for table `youth_details`
--
ALTER TABLE `youth_details`
  ADD PRIMARY KEY (`YOUTH_ID`),
  ADD UNIQUE KEY `YOUTH_NUM` (`YOUTH_NUM`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `ADMIN_NUM` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `youth_details`
--
ALTER TABLE `youth_details`
  MODIFY `YOUTH_NUM` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `demographic_details`
--
ALTER TABLE `demographic_details`
  ADD CONSTRAINT `demographic_details_ibfk_1` FOREIGN KEY (`YOUTH_ID`) REFERENCES `youth_details` (`YOUTH_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
