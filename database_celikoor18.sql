-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: kresnayangasli.my.id:12788
-- Generation Time: Dec 08, 2023 at 01:04 PM
-- Server version: 10.9.8-MariaDB-1:10.9.8+maria~ubu2204
-- PHP Version: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_celikoor18`
--
CREATE DATABASE IF NOT EXISTS `database_celikoor18` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `database_celikoor18`;

-- --------------------------------------------------------

--
-- Table structure for table `aktors`
--

CREATE TABLE `aktors` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `negara_asal` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `aktors`
--

INSERT INTO `aktors` (`id`, `nama`, `tgl_lahir`, `gender`, `negara_asal`) VALUES
(1, 'Dwayne Johnson', '1972-05-02', 'L', 'USA'),
(2, 'Tom Hanks', '1956-07-09', 'L', 'USA'),
(3, 'Meryl Streep', '1949-06-22', 'P', 'USA'),
(4, 'Shah Rukh Khan', '1965-11-02', 'L', 'India'),
(5, 'Cate Blanchett', '1969-05-14', 'P', 'Australia'),
(6, 'Amber Heard', '1986-04-22', 'P', 'USA'),
(7, 'John David Washington', '1984-07-28', 'L', 'USA'),
(8, 'Gemma Chan', '1982-09-29', 'P', 'Inggris'),
(9, 'Madeleine Yuna Voyles', '2014-09-03', 'P', 'USA'),
(10, 'Allison Janney', '1959-11-19', 'P', 'USA'),
(11, 'Cillian Murphy', '1976-05-25', 'L', 'Irlandia'),
(12, 'Emily Blunt', '1983-02-23', 'P', 'Inggris'),
(13, 'Robert Downey Jr', '1965-04-04', 'L', 'USA'),
(14, 'Alden Ehrenreich', '1989-11-22', 'L', 'USA'),
(15, 'Jessica Rothe', '1987-05-28', 'P', 'USA'),
(16, 'Charles Aitken', '1979-07-17', 'L', 'Inggris'),
(17, 'Phi Vu', '1991-11-21', 'L', 'USA'),
(18, 'Suraj Sharma', '1993-03-21', 'L', 'India'),
(19, 'Alexander Skarsgård', '1976-08-25', 'L', 'Swedia'),
(20, 'Millie Bobby Brown', '2004-02-19', 'P', 'Inggris'),
(21, 'Rebecca Hall', '1982-05-03', 'P', 'Inggris'),
(22, 'Brian Tyree Henry', '1982-03-31', 'L', 'USA'),
(23, 'Sam Worthington', '1976-08-02', 'L', 'Australia'),
(24, 'Zoe Saldana', '1978-06-19', 'P', 'USA'),
(25, 'Sigourney Weaver', '1949-10-08', 'L', 'USA'),
(26, 'Stephen Lang', '1952-07-11', 'L', 'USA'),
(27, 'xxx', '2023-12-08', 'L', 'USA');

-- --------------------------------------------------------

--
-- Table structure for table `aktor_film`
--

CREATE TABLE `aktor_film` (
  `aktors_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  `peran` enum('UTAMA','PEMBANTU','FIGURAN') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `aktor_film`
--

INSERT INTO `aktor_film` (`aktors_id`, `films_id`, `peran`) VALUES
(7, 6, 'UTAMA'),
(8, 6, 'PEMBANTU'),
(9, 6, 'FIGURAN'),
(10, 6, 'PEMBANTU');

-- --------------------------------------------------------

--
-- Table structure for table `cinemas`
--

CREATE TABLE `cinemas` (
  `id` int(11) NOT NULL,
  `nama_cabang` varchar(45) NOT NULL,
  `alamat` varchar(45) NOT NULL,
  `tgl_dibuka` date DEFAULT NULL,
  `kota` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `cinemas`
--

INSERT INTO `cinemas` (`id`, `nama_cabang`, `alamat`, `tgl_dibuka`, `kota`) VALUES
(1, 'Ciputra World XXI', 'Jl. Mayjen Sungkono No. 89', '2000-01-01', 'Surabaya'),
(2, 'Delta', 'Jl. Pemuda 31-37', '2000-01-01', 'Surabaya'),
(3, 'Galaxy XXI', 'Jl. Dharma Husada No. 35-37', '2010-10-10', 'Surabaya'),
(4, 'Pakuwon City XXI', 'Jl. Kejawen Putih Mutiara No. 17', '2000-01-01', 'Surabaya'),
(5, 'Pakuwon Mall XXI', 'Jln. Puncak Indah Lontar No. 2', '2000-01-01', 'Surabaya'),
(6, 'Tunjungan', 'Jl. Basuki Rahmat', '2023-12-05', 'Surabaya');

-- --------------------------------------------------------

--
-- Table structure for table `films`
--

CREATE TABLE `films` (
  `id` int(11) NOT NULL,
  `judul` varchar(45) NOT NULL,
  `sinopsis` text NOT NULL,
  `tahun` int(11) NOT NULL,
  `durasi` smallint(6) NOT NULL,
  `kelompoks_id` int(11) NOT NULL,
  `bahasa` enum('EN','ID','CHN','KOR','JPN','OTH') NOT NULL DEFAULT 'EN',
  `is_sub_indo` tinyint(4) NOT NULL DEFAULT 1,
  `cover_image` varchar(45) DEFAULT NULL,
  `diskon_nominal` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `films`
--

INSERT INTO `films` (`id`, `judul`, `sinopsis`, `tahun`, `durasi`, `kelompoks_id`, `bahasa`, `is_sub_indo`, `cover_image`, `diskon_nominal`) VALUES
(1, 'The Marvels', 'Kekuatan Captain Marvel (Brie Larson) ternyata terhubung dengan Ms. Marvel (Iman Vellani) dan Monica Rambeau (Teyonah Parris). Hal ini membuat ketiganya terus menerus bertukar tempat. Mereka akhirnya bertemu dan mencari tahu kenapa kekuatan mereka saling terkoneksi. Dengan ancaman baru yang datang, ketiganya memutuskan menjadi satu tim untuk menyelamatkan alam semesta sebagai The Marvels.', 2023, 105, 4, 'EN', 1, NULL, NULL),
(2, 'Sijjin', 'Irma (Anggika Bolsterli) jatuh cinta pada Galang (Ibrahim Risyad), sepupunya yang sudah beristri dan punya anak. Namun Irma masih terobsesi dan ingin menjadi perempuan satu-satunya di hidup Galang. Irma datang ke dukun untuk mengirim santet pada istri Galang. Sejak saat itu teror dimulai. Gangguan mistis, kesurupan, dan kematian terjadi di rumah Galang. Namun, yang tak diduga Irma, ancaman itu juga mengincar nyawanya sendiri.', 2023, 100, 5, 'ID', 1, NULL, NULL),
(3, 'Trolls Band Together', 'Poppy (Anna Kendrick) mengetahui bahwa Branch (Justin Timberlake) pernah menjadi bagian dari boy band, BroZone, bersama saudara-saudaranya: Floyd (Troye Sivan), John Dory (Eric Andre), Spruce (Daveed Diggs), dan Clay (Kid Cudi). Namun saat Floyd diculik, Branch dan Poppy melakukan perjalanan untuk menyatukan kembali saudara-saudara lainnya dan menyelamatkan Floyd.', 2023, 91, 1, 'EN', 1, NULL, NULL),
(4, 'Panggonan Wingit', 'RAINA (Luna Maya) dan adiknya, FEY (Bianca Hello) pindah dari Jakarta ke Semarang untuk mengelola Hotel Ambar Mangun, sebuah hotel warisan ayah mereka yang tidak pernah mereka kunjungi sebelumnya dan selama ini dikelola oleh SUKTINI (Oce Permatasari) dan GARINTO (Budi Ros), nenek dan kakek mereka.\r\n\r\nSuatu malam Raina mendengar suara tangis dari lantai tiga yang dilarang dimasuki siapapun lalu ia membuka pintu sebuah kamar tak bernomor di sana. Ternyata kamar itu adalah “Panggonan Wingit”, sebuah tempat yang sudah lama dihuni oleh sosok gaib. Jika ada yang membuka kamar itu, ia akan melihat sosok wanita berkulit putih dan berambut putih yang mengatakan “Telung dino, tengah wengi” yang artinya “Tiga hari, tengah malam”, lalu tiga hari kemudian akan mati dikuliti saat tengah malam.\r\n\r\nSekarang nyawa Raina terancam. Ia bersama ARDO (Christian Sugiono) – mantan pacarnya yang seorang jurnalis – Fey, Suktini, dan Garinto mencari cara supaya bisa selamat. Misteri demi misteri yang penuh teka-teki masa lalu terkuak. Akankah mereka bisa selamat dari kematian? Waktu mereka sangat sempit.', 2023, 110, 4, 'ID', 1, NULL, NULL),
(5, 'Aquaman and the Lost Kingdom', 'Arthur Curry (Jason Momoa) harus kembali melawan Black Manta (Yahya Abdul-Mateen II) yang sekarang semakin kuat dan menjadi ancaman besar bagi kehidupan Atlantis. Arthur terpaksa bekerja sama dengan Orm (Patrick Wilson) saudaranya sekaligus musuhnya demi nasib Atlantis.', 2023, 124, 4, 'EN', 1, NULL, NULL),
(6, 'The Creator', 'As a future war between the human race and artificial intelligence rages on, ex-special forces agent Joshua is recruited to hunt down and kill the Creator, the elusive architect of advanced AI. The Creator has developed a mysterious weapon that has the power to end the war and all of mankind. As Joshua and his team of elite operatives venture into enemy-occupied territory, they soon discover the world-ending weapon is actually an AI in the form of a young child\r\n', 2023, 133, 4, 'EN', 1, NULL, NULL),
(7, 'Oppenheimer', 'During World War II, Lt. Gen. Leslie Groves Jr. appoints physicist J. Robert Oppenheimer to work on the top-secret Manhattan Project. Oppenheimer and a team of scientists spend years developing and designing the atomic bomb. Their work comes to fruition on July 16, 1945, as they witness the world\'s first nuclear explosion, forever changing the course of history.', 2023, 180, 5, 'EN', 1, NULL, NULL),
(8, 'Godzilla vs. Kong', 'King Kong is transported out of his containment zone after Godzilla resurfaces and creates mayhem. Humans need his help to reach Hollow Earth and find a way to subdue the king of the monsters.', 2021, 113, 4, 'EN', 1, NULL, NULL),
(9, 'Avatar: The Way of Water', 'Jake Sully and Ney\'tiri have formed a family and are doing everything to stay together. However, they must leave their home and explore the regions of Pandora. When an ancient threat resurfaces, Jake must fight a difficult war against the humans.', 2022, 192, 4, 'EN', 1, NULL, NULL),
(10, 'Happy Death Day 2U', 'Tree Gelbman is the survivor of a time loop in which she was repeatedly murdered by a sadistic killer. However, when she finds herself in the same situation again, she sets out to stop it for good.', 2019, 100, 4, 'EN', 1, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `film_studio`
--

CREATE TABLE `film_studio` (
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `film_studio`
--

INSERT INTO `film_studio` (`studios_id`, `films_id`) VALUES
(1, 1),
(1, 2),
(2, 3),
(3, 3),
(3, 4);

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`id`, `nama`, `deskripsi`) VALUES
(1, 'Aksi', ''),
(2, 'Animasi', NULL),
(3, 'Drama', NULL),
(4, 'Komedi', NULL),
(5, 'Horor', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `genre_film`
--

CREATE TABLE `genre_film` (
  `films_id` int(11) NOT NULL,
  `genres_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `genre_film`
--

INSERT INTO `genre_film` (`films_id`, `genres_id`) VALUES
(1, 1),
(2, 5),
(3, 2),
(4, 5),
(5, 1);

-- --------------------------------------------------------

--
-- Table structure for table `invoices`
--

CREATE TABLE `invoices` (
  `id` int(11) NOT NULL,
  `tanggal` datetime NOT NULL,
  `grand_total` double NOT NULL,
  `diskon_nominal` double DEFAULT NULL,
  `konsumens_id` int(11) NOT NULL,
  `kasir_id` int(11) DEFAULT NULL,
  `status` enum('PENDING','VALIDASI','TERBAYAR') NOT NULL DEFAULT 'PENDING'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `jadwal_films`
--

CREATE TABLE `jadwal_films` (
  `id` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `jam_pemutaran` enum('I','II','III','IV') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `jadwal_films`
--

INSERT INTO `jadwal_films` (`id`, `tanggal`, `jam_pemutaran`) VALUES
(1, '2023-12-10', 'I'),
(2, '2023-12-10', 'II'),
(3, '2023-12-10', 'III'),
(4, '2023-12-10', 'IV'),
(5, '2023-12-11', 'I'),
(6, '2023-12-11', 'II'),
(7, '2023-12-12', 'I'),
(8, '2023-12-12', 'II'),
(9, '2023-12-12', 'III'),
(10, '2023-12-12', 'IV');

-- --------------------------------------------------------

--
-- Table structure for table `jenis_studios`
--

CREATE TABLE `jenis_studios` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `jenis_studios`
--

INSERT INTO `jenis_studios` (`id`, `nama`, `deskripsi`) VALUES
(1, 'Reguler', 'Studio dengan tipe reguler atau juga disebut dengan tipe Deluxe merupakan salah satu tipe studio di Cinema XXI yang paling banyak dibuka di berbagai kota atau di lokasi berdirinya bioskop Cinema XXI. Studio dengan tipe reguler atau deluxe di Cinema XXI juga telah menggunakan teknologi bioskop digital untuk memutar film-filmnya.'),
(2, 'IMAX', 'IMAX merupakan singkatan dari Image Maximum. Teknologi IMAX merupakan teknologi yang mampu menampilkan gambar dengan ukuran dan resolusi lebih besar dari film konvensional lainnya. Film-film yang diputar di studio IMAX merupakan film-film khusus yang diproduksi dengan menggunakan kamera berteknologi IMAX.'),
(3, 'Dolby Atmos', 'Tipe studio ini menggunakan teknologi tata suara terbaru yaitu Dolby Digital Surround 7.1 yang dikembangkan oleh Dolby Laboratories. Ruangan studio dengan tipe Dolby Atmos dilengkapi dengan total 64 speaker yang dihubungkan dengan Atmos enabled amplifier.'),
(4, 'The Premiere', 'Ruangan dalam studio The Premiere juga berdesain yang mewah, dengan ukuran sofa kulit yang sangat empuk. Jarak kursi satu dengan lainnya cukup berjauhan dan terdapat tombol untuk setting kursi sesuai keinginan. The Premiere juga difasilitasi dengan selimut yang berada di tempat duduk. Kamu juga bisa memesan makanan saat film sudah dimulai, baik lewat online atau pada petugas café Cinema XXI di studio.');

-- --------------------------------------------------------

--
-- Table structure for table `kelompoks`
--

CREATE TABLE `kelompoks` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `kelompoks`
--

INSERT INTO `kelompoks` (`id`, `nama`) VALUES
(1, 'Semua Usia'),
(2, 'Prasekolah'),
(3, 'Anak-anak'),
(4, 'Remaja'),
(5, 'Dewasa'),
(6, 'xxx');

-- --------------------------------------------------------

--
-- Table structure for table `konsumens`
--

CREATE TABLE `konsumens` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `no_hp` varchar(45) NOT NULL,
  `gender` enum('L','P') NOT NULL,
  `tgl_lahir` date NOT NULL,
  `saldo` double DEFAULT 0,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

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
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL,
  `roles` enum('ADMIN','KASIR','OPERATOR') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `pegawais`
--

INSERT INTO `pegawais` (`id`, `nama`, `email`, `username`, `password`, `roles`) VALUES
(1, 'Slamet Mulyadi', 'slamet@mulyadi.com', 'kudu_slamet', 'slamet1234', 'ADMIN'),
(2, 'Rosa Lia', 'rosa@lia.com', 'rosalia.indah', 'rosasnyasatu', 'OPERATOR'),
(3, 'Farhan Kebab', 'farhan@farhankebab.com', 'kebabenak', 'yafarhankebab', 'OPERATOR'),
(4, 'Dita Leni', 'dita@leni.com', 'dita77', 'ditalenirafia', 'KASIR'),
(5, 'Ryan', 'ryan@email.com', 'ryan', 'ryan', 'ADMIN'),
(6, 'Lisa', 'lisa@lisa.com', 'lisaa', 'rahasia', 'ADMIN');

-- --------------------------------------------------------

--
-- Table structure for table `sesi_films`
--

CREATE TABLE `sesi_films` (
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `studios`
--

CREATE TABLE `studios` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `kapasitas` int(11) NOT NULL,
  `jenis_studios_id` int(11) NOT NULL,
  `cinemas_id` int(11) NOT NULL,
  `harga_weekday` int(11) NOT NULL,
  `harga_weekend` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `studios`
--

INSERT INTO `studios` (`id`, `nama`, `kapasitas`, `jenis_studios_id`, `cinemas_id`, `harga_weekday`, `harga_weekend`) VALUES
(1, 'I', 60, 1, 1, 30000, 45000),
(2, 'II', 48, 1, 1, 30000, 35000),
(3, 'I', 72, 1, 2, 25000, 40000),
(4, 'II', 48, 1, 2, 25000, 40000),
(5, 'III', 48, 1, 2, 25000, 40000),
(6, 'I', 84, 1, 3, 40000, 50000),
(7, 'II', 84, 1, 3, 40000, 50000),
(8, 'I', 84, 4, 5, 100000, 150000),
(9, 'I', 72, 2, 5, 55000, 65000),
(10, 'I', 84, 3, 1, 30000, 35000);

-- --------------------------------------------------------

--
-- Table structure for table `tikets`
--

CREATE TABLE `tikets` (
  `invoices_id` int(11) NOT NULL,
  `nomor_kursi` varchar(3) NOT NULL,
  `status_hadir` tinyint(4) DEFAULT NULL,
  `operator_id` int(11) NOT NULL,
  `harga` double NOT NULL,
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `films`
--
ALTER TABLE `films`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `invoices`
--
ALTER TABLE `invoices`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `jadwal_films`
--
ALTER TABLE `jadwal_films`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `jenis_studios`
--
ALTER TABLE `jenis_studios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `kelompoks`
--
ALTER TABLE `kelompoks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `konsumens`
--
ALTER TABLE `konsumens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `pegawais`
--
ALTER TABLE `pegawais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `studios`
--
ALTER TABLE `studios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
