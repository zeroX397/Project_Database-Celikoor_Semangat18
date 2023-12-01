-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 01, 2023 at 01:35 PM
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
-- Database: `celikoor_semangat18`
--

-- --------------------------------------------------------

--
-- Table structure for table `aktors`
--

CREATE TABLE `aktors` (
  `id` int NOT NULL,
  `nama` varchar(45) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `negara_asal` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `aktors`
--

INSERT INTO `aktors` (`id`, `nama`, `tgl_lahir`, `gender`, `negara_asal`) VALUES
(1, 'Dwayne Johnson', '1972-05-02', 'L', 'USA'),
(2, 'Tom Hanks', '1956-07-09', 'L', 'USA'),
(3, 'Meryl Streep', '1949-06-22', 'P', 'USA'),
(4, 'Shah Rukh Khan', '1965-11-02', 'L', 'India'),
(5, 'Cate Blanchett', '1969-05-14', 'P', 'Australia');

-- --------------------------------------------------------

--
-- Table structure for table `aktor_film`
--

CREATE TABLE `aktor_film` (
  `aktors_id` int NOT NULL,
  `films_id` int NOT NULL,
  `peran` enum('UTAMA','PEMBANTU','FIGURAN') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `cinemas`
--

CREATE TABLE `cinemas` (
  `id` int NOT NULL,
  `nama_cabang` varchar(45) NOT NULL,
  `alamat` varchar(45) NOT NULL,
  `tgl_dibuka` date NOT NULL,
  `kota` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `cinemas`
--

INSERT INTO `cinemas` (`id`, `nama_cabang`, `alamat`, `tgl_dibuka`, `kota`) VALUES
(1, 'Ciputra World XXI', 'Jl. Mayjen Sungkono No. 89', '2000-01-01', 'Surabaya'),
(2, 'Delta', 'Jl. Pemuda 31-37', '2000-01-01', 'Surabaya'),
(3, 'Galaxy XXI', 'Jl. Dharma Husada No. 35-37', '2010-10-10', 'Surabaya'),
(4, 'Pakuwon City XXI', 'Jl. Kejawen Putih Mutiara No. 17', '2000-01-01', 'Surabaya'),
(5, 'Pakuwon Mall XXI', 'Jln. Puncak Indah Lontar No. 2', '2000-01-01', 'Surabaya');

-- --------------------------------------------------------

--
-- Table structure for table `films`
--

CREATE TABLE `films` (
  `id` int NOT NULL,
  `judul` varchar(45) NOT NULL,
  `sinopsis` text NOT NULL,
  `tahun` int NOT NULL,
  `durasi` smallint NOT NULL,
  `kelompoks_id` int NOT NULL,
  `bahasa` enum('EN','ID','CHN','KOR','JPN','OTH') NOT NULL DEFAULT 'EN',
  `is_sub_indo` tinyint NOT NULL DEFAULT '1',
  `cover_image` varchar(45) DEFAULT NULL,
  `diskon_nominal` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `film_studio`
--

CREATE TABLE `film_studio` (
  `studios_id` int NOT NULL,
  `films_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `id` int NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `genre_film`
--

CREATE TABLE `genre_film` (
  `films_id` int NOT NULL,
  `genres_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `invoices`
--

CREATE TABLE `invoices` (
  `id` int NOT NULL,
  `tanggal` datetime NOT NULL,
  `grand_total` double NOT NULL,
  `diskon_nominal` double DEFAULT NULL,
  `konsumens_id` int NOT NULL,
  `kasir_id` int DEFAULT NULL,
  `status` enum('PENDING','VALIDASI','TERBAYAR') NOT NULL DEFAULT 'PENDING'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `jadwal_films`
--

CREATE TABLE `jadwal_films` (
  `id` int NOT NULL,
  `tanggal` date NOT NULL,
  `jam_pemutaran` enum('I','II','III','IV') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `jenis_studios`
--

CREATE TABLE `jenis_studios` (
  `id` int NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `kelompoks`
--

CREATE TABLE `kelompoks` (
  `id` int NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `konsumens`
--

CREATE TABLE `konsumens` (
  `id` int NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `no_hp` varchar(45) NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `tgl_lahir` date NOT NULL,
  `saldo` double DEFAULT '0',
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `konsumens`
--

INSERT INTO `konsumens` (`id`, `nama`, `email`, `no_hp`, `gender`, `tgl_lahir`, `saldo`, `username`, `password`) VALUES
(1, 'Juan', 'juan@domain.com', '081234567891', 'L', '1990-10-31', 150000, 'juan1031', 'juanjuan'),
(2, 'John Smith', 'john@smith.com', '081112223334', 'L', '1990-06-03', 0, 'john36', 'johnthesmith'),
(3, 'Diane Chen Chen', 'chen123@domain.com', '081684513654', 'P', '2000-02-16', 1250000, 'princess.chen', 'chenzilauw'),
(4, 'Stephanie Rodriguez', 'stephan.rgz@email.com', '089756413587', 'P', '1988-05-28', 50000, 'stephan_rgz', 'rdgz28588'),
(5, 'Jonathan Kim', 'john@kim.com', '098227576251', 'L', '1977-11-12', 450000, 'kimjo', 'kimjo2377');

-- --------------------------------------------------------

--
-- Table structure for table `pegawais`
--

CREATE TABLE `pegawais` (
  `id` int NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL,
  `roles` enum('ADMIN','KASIR','OPERATOR') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `pegawais`
--

INSERT INTO `pegawais` (`id`, `nama`, `email`, `username`, `password`, `roles`) VALUES
(1, 'Slamet Mulyadi', 'slamet@mulyadi.com', 'kudu_slamet', 'slamet1234', 'ADMIN'),
(2, 'Rosa Lia', 'rosa@lia.com', 'rosalia.indah', 'rosasnyasatu', 'OPERATOR'),
(3, 'Farhan Kebab', 'farhan@farhankebab.com', 'kebabenak', 'yafarhankebab', 'OPERATOR'),
(4, 'Dita Leni', 'dita@leni.com', 'dita77', 'ditalenirafia', 'KASIR'),
(5, 'Ryan', 'ryan@email.com', 'ryan', 'ryan', 'ADMIN');

-- --------------------------------------------------------

--
-- Table structure for table `sesi_films`
--

CREATE TABLE `sesi_films` (
  `jadwal_film_id` int NOT NULL,
  `studios_id` int NOT NULL,
  `films_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `studios`
--

CREATE TABLE `studios` (
  `id` int NOT NULL,
  `nama` varchar(45) NOT NULL,
  `kapasitas` int NOT NULL,
  `jenis_studios_id` int NOT NULL,
  `cinemas_id` int NOT NULL,
  `harga_weekday` int NOT NULL,
  `harga_weekend` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `tikets`
--

CREATE TABLE `tikets` (
  `invoices_id` int NOT NULL,
  `nomor_kursi` varchar(3) NOT NULL,
  `status_hadir` tinyint DEFAULT NULL,
  `operator_id` int NOT NULL,
  `harga` double NOT NULL,
  `jadwal_film_id` int NOT NULL,
  `studios_id` int NOT NULL,
  `films_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aktors`
--
ALTER TABLE `aktors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `aktor_film`
--
ALTER TABLE `aktor_film`
  ADD PRIMARY KEY (`aktors_id`,`films_id`),
  ADD KEY `fk_aktors_has_films_films1_idx` (`films_id`),
  ADD KEY `fk_aktors_has_films_aktors1_idx` (`aktors_id`);

--
-- Indexes for table `cinemas`
--
ALTER TABLE `cinemas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `films`
--
ALTER TABLE `films`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_films_kelompoks1_idx` (`kelompoks_id`);

--
-- Indexes for table `film_studio`
--
ALTER TABLE `film_studio`
  ADD PRIMARY KEY (`studios_id`,`films_id`),
  ADD KEY `fk_studios_has_films_films1_idx` (`films_id`),
  ADD KEY `fk_studios_has_films_studios1_idx` (`studios_id`);

--
-- Indexes for table `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `genre_film`
--
ALTER TABLE `genre_film`
  ADD PRIMARY KEY (`films_id`,`genres_id`),
  ADD KEY `fk_films_has_genres_genres1_idx` (`genres_id`),
  ADD KEY `fk_films_has_genres_films1_idx` (`films_id`);

--
-- Indexes for table `invoices`
--
ALTER TABLE `invoices`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_invoices_konsumens1_idx` (`konsumens_id`),
  ADD KEY `fk_invoices_pegawais1_idx` (`kasir_id`);

--
-- Indexes for table `jadwal_films`
--
ALTER TABLE `jadwal_films`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `jenis_studios`
--
ALTER TABLE `jenis_studios`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kelompoks`
--
ALTER TABLE `kelompoks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `konsumens`
--
ALTER TABLE `konsumens`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pegawais`
--
ALTER TABLE `pegawais`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sesi_films`
--
ALTER TABLE `sesi_films`
  ADD PRIMARY KEY (`jadwal_film_id`,`studios_id`,`films_id`),
  ADD KEY `fk_jadwal_film_has_film_studio_film_studio1_idx` (`studios_id`,`films_id`),
  ADD KEY `fk_jadwal_film_has_film_studio_jadwal_film1_idx` (`jadwal_film_id`);

--
-- Indexes for table `studios`
--
ALTER TABLE `studios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_studios_jenis_studios_idx` (`jenis_studios_id`),
  ADD KEY `fk_studios_cinemas1_idx` (`cinemas_id`);

--
-- Indexes for table `tikets`
--
ALTER TABLE `tikets`
  ADD PRIMARY KEY (`invoices_id`,`nomor_kursi`),
  ADD KEY `fk_film_studio_has_invoices_invoices1_idx` (`invoices_id`),
  ADD KEY `fk_film_studio_has_invoices_pegawais1_idx` (`operator_id`),
  ADD KEY `fk_tikets_sesi_films1_idx` (`jadwal_film_id`,`studios_id`,`films_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aktors`
--
ALTER TABLE `aktors`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `films`
--
ALTER TABLE `films`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `invoices`
--
ALTER TABLE `invoices`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `jadwal_films`
--
ALTER TABLE `jadwal_films`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `jenis_studios`
--
ALTER TABLE `jenis_studios`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kelompoks`
--
ALTER TABLE `kelompoks`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `konsumens`
--
ALTER TABLE `konsumens`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `pegawais`
--
ALTER TABLE `pegawais`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `studios`
--
ALTER TABLE `studios`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aktor_film`
--
ALTER TABLE `aktor_film`
  ADD CONSTRAINT `fk_aktors_has_films_aktors1` FOREIGN KEY (`aktors_id`) REFERENCES `aktors` (`id`),
  ADD CONSTRAINT `fk_aktors_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`);

--
-- Constraints for table `films`
--
ALTER TABLE `films`
  ADD CONSTRAINT `fk_films_kelompoks1` FOREIGN KEY (`kelompoks_id`) REFERENCES `kelompoks` (`id`);

--
-- Constraints for table `film_studio`
--
ALTER TABLE `film_studio`
  ADD CONSTRAINT `fk_studios_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`),
  ADD CONSTRAINT `fk_studios_has_films_studios1` FOREIGN KEY (`studios_id`) REFERENCES `studios` (`id`);

--
-- Constraints for table `genre_film`
--
ALTER TABLE `genre_film`
  ADD CONSTRAINT `fk_films_has_genres_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`),
  ADD CONSTRAINT `fk_films_has_genres_genres1` FOREIGN KEY (`genres_id`) REFERENCES `genres` (`id`);

--
-- Constraints for table `invoices`
--
ALTER TABLE `invoices`
  ADD CONSTRAINT `fk_invoices_konsumens1` FOREIGN KEY (`konsumens_id`) REFERENCES `konsumens` (`id`),
  ADD CONSTRAINT `fk_invoices_pegawais1` FOREIGN KEY (`kasir_id`) REFERENCES `pegawais` (`id`);

--
-- Constraints for table `sesi_films`
--
ALTER TABLE `sesi_films`
  ADD CONSTRAINT `fk_jadwal_film_has_film_studio_film_studio1` FOREIGN KEY (`studios_id`,`films_id`) REFERENCES `film_studio` (`studios_id`, `films_id`),
  ADD CONSTRAINT `fk_jadwal_film_has_film_studio_jadwal_film1` FOREIGN KEY (`jadwal_film_id`) REFERENCES `jadwal_films` (`id`);

--
-- Constraints for table `studios`
--
ALTER TABLE `studios`
  ADD CONSTRAINT `fk_studios_cinemas1` FOREIGN KEY (`cinemas_id`) REFERENCES `cinemas` (`id`),
  ADD CONSTRAINT `fk_studios_jenis_studios` FOREIGN KEY (`jenis_studios_id`) REFERENCES `jenis_studios` (`id`);

--
-- Constraints for table `tikets`
--
ALTER TABLE `tikets`
  ADD CONSTRAINT `fk_film_studio_has_invoices_invoices1` FOREIGN KEY (`invoices_id`) REFERENCES `invoices` (`id`),
  ADD CONSTRAINT `fk_film_studio_has_invoices_pegawais1` FOREIGN KEY (`operator_id`) REFERENCES `pegawais` (`id`),
  ADD CONSTRAINT `fk_tikets_sesi_films1` FOREIGN KEY (`jadwal_film_id`,`studios_id`,`films_id`) REFERENCES `sesi_films` (`jadwal_film_id`, `studios_id`, `films_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
