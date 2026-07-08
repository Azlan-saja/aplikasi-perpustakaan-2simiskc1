-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 08, 2026 at 02:38 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Table structure for table `anggota`
--

CREATE TABLE `anggota` (
  `Nim` varchar(15) NOT NULL,
  `Nama` text NOT NULL,
  `Kelas` varchar(10) NOT NULL,
  `Jurusan` varchar(25) NOT NULL,
  `No_Hp` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `anggota`
--

INSERT INTO `anggota` (`Nim`, `Nama`, `Kelas`, `Jurusan`, `No_Hp`) VALUES
('1010', ' Azlan', ' ST1', ' Jur2', ' 0811');

-- --------------------------------------------------------

--
-- Table structure for table `buku`
--

CREATE TABLE `buku` (
  `Kode_Buku` varchar(10) NOT NULL,
  `Judul` varchar(25) NOT NULL,
  `Penulis` text NOT NULL,
  `Penerbit` varchar(20) NOT NULL,
  `Tahun_Terbit` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `buku`
--

INSERT INTO `buku` (`Kode_Buku`, `Judul`, `Penulis`, `Penerbit`, `Tahun_Terbit`) VALUES
('B1', ' 1', ' 3', ' 4', 5);

-- --------------------------------------------------------

--
-- Table structure for table `peminjaman`
--

CREATE TABLE `peminjaman` (
  `Kode_Pinjam` varchar(10) NOT NULL,
  `Nim` varchar(15) NOT NULL,
  `Kode_Buku` varchar(20) NOT NULL,
  `Tanggal_Pinjam` date NOT NULL,
  `Tanggal_Kembali` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `peminjaman`
--

INSERT INTO `peminjaman` (`Kode_Pinjam`, `Nim`, `Kode_Buku`, `Tanggal_Pinjam`, `Tanggal_Kembali`) VALUES
('2', '1010', 'B1', '2026-07-08', '2026-07-13');

-- --------------------------------------------------------

--
-- Table structure for table `pengembalian`
--

CREATE TABLE `pengembalian` (
  `Kode_Pinjam` varchar(10) NOT NULL,
  `Kode_Buku` varchar(10) NOT NULL,
  `Nim` varchar(15) NOT NULL,
  `Tanggal_Kembali` date NOT NULL,
  `Jatuh_Tempo` varchar(15) NOT NULL,
  `Denda_Perhari` int(11) NOT NULL,
  `Total_Denda` int(11) NOT NULL,
  `Tanggal_Pinjam` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pengembalian`
--

INSERT INTO `pengembalian` (`Kode_Pinjam`, `Kode_Buku`, `Nim`, `Tanggal_Kembali`, `Jatuh_Tempo`, `Denda_Perhari`, `Total_Denda`, `Tanggal_Pinjam`) VALUES
('1', ' B1', ' 1010', '2026-07-16', ' 8', 7000, 42000, '2026-07-08');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`) VALUES
('admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`Nim`);

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`Kode_Buku`);

--
-- Indexes for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD PRIMARY KEY (`Kode_Pinjam`);

--
-- Indexes for table `pengembalian`
--
ALTER TABLE `pengembalian`
  ADD PRIMARY KEY (`Kode_Pinjam`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
