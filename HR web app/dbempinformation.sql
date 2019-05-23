-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 13, 2019 at 08:33 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbempinformation`
--

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `ID` int(11) NOT NULL,
  `EMPLOYEE_ID` int(11) NOT NULL,
  `FIRST_NAME` varchar(255) DEFAULT NULL,
  `LAST_NAME` varchar(255) DEFAULT NULL,
  `MIDDLE_NAME` varchar(255) DEFAULT NULL,
  `ADDRESS` varchar(255) DEFAULT NULL,
  `PHONE_NUMBER` varchar(255) DEFAULT NULL,
  `STATUS` varchar(255) DEFAULT NULL,
  `BIRTH_DATE` datetime DEFAULT NULL,
  `BIRTH_PLACE` varchar(255) DEFAULT NULL,
  `GENDER` varchar(255) DEFAULT NULL,
  `AGE` int(11) DEFAULT NULL,
  `EMERG_CONTACT` varchar(255) DEFAULT NULL,
  `EMPIMAGE` varchar(255) NOT NULL,
  `EmailAdd` varchar(90) NOT NULL,
  `SocialAccnt` varchar(90) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`ID`, `EMPLOYEE_ID`, `FIRST_NAME`, `LAST_NAME`, `MIDDLE_NAME`, `ADDRESS`, `PHONE_NUMBER`, `STATUS`, `BIRTH_DATE`, `BIRTH_PLACE`, `GENDER`, `AGE`, `EMERG_CONTACT`, `EMPIMAGE`, `EmailAdd`, `SocialAccnt`) VALUES
(3, 222, 'Janno', 'Palacios', 'esas', 'Kabankalan City', '898-999-999', 'Single', '2015-04-18 00:00:00', 'asdasdasasd', 'Male', 25, '898-999-999', 'cebu1.png', '', ''),
(6, 1000001, 'James', 'Yap', 'Marjen', 'Aklan', '123213123', 'Single', '1994-06-01 00:00:00', 'aklan', 'Male', 24, '23213123', 'cebu.png', '', ''),
(9, 213123, 'asd', 'sad', 'sad', 'sad', '2312312312', 'Single', '1990-08-31 00:00:00', 'sadasdasd', 'Male', 28, NULL, '38483630_274933653285108_2554784918622175232_n.jpg', 'sad', 'sad'),
(10, 2131232, 'asd', 'asd', 'sad', 'sadasd', '1312312', 'Single', '1992-08-31 00:00:00', 'sadasd', 'Male', 26, NULL, 'kisspng-reset-button-clip-art-update-cliparts-5aae91224c2291.1980798515213898583119.jpg', 'asdasd', 'sad');

-- --------------------------------------------------------

--
-- Table structure for table `employeesworkinfo`
--

CREATE TABLE `employeesworkinfo` (
  `ID` int(11) NOT NULL,
  `EMPLOYEE_ID` varchar(255) NOT NULL,
  `D_HIRED` date DEFAULT NULL,
  `JobStatus` varchar(30) NOT NULL,
  `JobType` varchar(30) NOT NULL,
  `EndDate` date NOT NULL,
  `SalaryGrade` double NOT NULL,
  `Salary` double NOT NULL,
  `Position` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employeesworkinfo`
--

INSERT INTO `employeesworkinfo` (`ID`, `EMPLOYEE_ID`, `D_HIRED`, `JobStatus`, `JobType`, `EndDate`, `SalaryGrade`, `Salary`, `Position`) VALUES
(3, '222', '2015-04-18', 'Contractual', 'Teaching', '2016-10-31', 0, 0, ''),
(6, '1000001', '1999-09-25', 'Permanent', 'Teaching', '2016-10-01', 222, 222, 'Staff'),
(8, '1000001', '1999-09-25', 'Permanent', 'Teaching', '2016-10-01', 444, 444, 'Rank2'),
(9, '222', '2015-04-18', 'Contractual', 'Teaching', '2016-10-31', 0, 0, ''),
(11, '213123', '2018-08-31', 'Contractual', 'Teaching', '2018-08-31', 12312, 12312, 'sadasd'),
(12, '213123', '2018-08-31', 'Contractual', 'Teaching', '2018-08-31', 12312, 12312, 'sadasd'),
(13, '213123', '2018-08-31', 'Contractual', 'Teaching', '2018-08-31', 12312, 12312, 'sadasd'),
(14, '213123', '2018-08-31', 'Contractual', 'Teaching', '2018-08-31', 12312, 12312, 'sadasd'),
(15, '2131232', '2018-08-31', 'Permanent', 'Non-Teaching', '2018-08-31', 213, 213, 'sadas');

-- --------------------------------------------------------

--
-- Table structure for table `tblauto`
--

CREATE TABLE `tblauto` (
  `autoID` int(11) NOT NULL,
  `AutoStart` varchar(30) NOT NULL,
  `AutoEnd` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblauto`
--

INSERT INTO `tblauto` (`autoID`, `AutoStart`, `AutoEnd`) VALUES
(1, 'User00', 6),
(2, '100000', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tblscannedfiles`
--

CREATE TABLE `tblscannedfiles` (
  `ScannedId` int(11) NOT NULL,
  `EmpId` int(11) NOT NULL,
  `IMGCaption` varchar(90) NOT NULL,
  `ImgType` varchar(90) NOT NULL,
  `FilesLocation` varchar(90) NOT NULL,
  `DateUpload` date NOT NULL,
  `IMGBLOB` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblscannedfiles`
--

INSERT INTO `tblscannedfiles` (`ScannedId`, `EmpId`, `IMGCaption`, `ImgType`, `FilesLocation`, `DateUpload`, `IMGBLOB`) VALUES
(3, 222, 's.pdf', 'pds', 's.pdf', '2018-08-31', ''),
(4, 1000001, 's.pdf', 'pds', 's.pdf', '2018-08-31', ''),
(5, 222, 's.pdf', 'pds', 's.pdf', '2018-08-31', ''),
(7, 1000001, 's.pdf', 'otr', 's.pdf', '2018-08-31', ''),
(11, 1000001, 'Easy Way to Search Data in ListView Using C.docx', 'pds', 'Easy Way to Search Data in ListView Using C.docx', '2019-05-13', ''),
(12, 222, 'determine the date based on the given days in c#.docx', 'pds', 'determine the date based on the given days in c#.docx', '2019-05-13', '');

-- --------------------------------------------------------

--
-- Table structure for table `useraccounts`
--

CREATE TABLE `useraccounts` (
  `ID` int(11) NOT NULL,
  `USER_ID` varchar(255) NOT NULL,
  `UNAME` varchar(255) DEFAULT NULL,
  `USERNAME` varchar(255) DEFAULT NULL,
  `PASS` varchar(255) DEFAULT NULL,
  `USERTYPE` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `useraccounts`
--

INSERT INTO `useraccounts` (`ID`, `USER_ID`, `UNAME`, `USERNAME`, `PASS`, `USERTYPE`) VALUES
(7, 'User001', 'Janobe', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator'),
(9, 'User003', 'Kenjie Earl', 'staff', '6ccb4b7c39a6e77f76ecfa935a855c6c46ad5611', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `EMPLOYEE_ID` (`EMPLOYEE_ID`);

--
-- Indexes for table `employeesworkinfo`
--
ALTER TABLE `employeesworkinfo`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `EMPLOYEE_ID` (`EMPLOYEE_ID`);

--
-- Indexes for table `tblauto`
--
ALTER TABLE `tblauto`
  ADD PRIMARY KEY (`autoID`);

--
-- Indexes for table `tblscannedfiles`
--
ALTER TABLE `tblscannedfiles`
  ADD PRIMARY KEY (`ScannedId`);

--
-- Indexes for table `useraccounts`
--
ALTER TABLE `useraccounts`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `USER_ID` (`USER_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `employeesworkinfo`
--
ALTER TABLE `employeesworkinfo`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tblauto`
--
ALTER TABLE `tblauto`
  MODIFY `autoID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tblscannedfiles`
--
ALTER TABLE `tblscannedfiles`
  MODIFY `ScannedId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `useraccounts`
--
ALTER TABLE `useraccounts`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
