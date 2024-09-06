-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 21, 2024 at 10:23 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `celikoor_tixycket_db`
--

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aktors`
--

INSERT INTO `aktors` (`id`, `nama`, `tgl_lahir`, `gender`, `negara_asal`) VALUES
(1, 'Dwayne \"The Rock\" Johnson', '2023-11-01', 'L', 'Amerika Serikat'),
(2, 'Shah Rukh Khan', '2023-11-14', 'L', 'India'),
(3, 'Leonardo DiCaprio', '2023-11-15', 'L', 'Amerika Serikat'),
(5, 'Jackie Chan', '2023-11-14', 'L', 'Hong Kong'),
(14, 'Willy', '2024-01-19', 'L', 'Indonesia');

-- --------------------------------------------------------

--
-- Table structure for table `aktor_film`
--

CREATE TABLE `aktor_film` (
  `aktors_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  `peran` enum('UTAMA','PEMBANTU','FIGURAN') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aktor_film`
--

INSERT INTO `aktor_film` (`aktors_id`, `films_id`, `peran`) VALUES
(1, 1, 'UTAMA'),
(1, 9, 'UTAMA'),
(1, 41, 'PEMBANTU'),
(2, 1, 'FIGURAN'),
(2, 41, 'FIGURAN'),
(5, 2, 'FIGURAN'),
(5, 9, 'PEMBANTU'),
(14, 41, 'UTAMA');

-- --------------------------------------------------------

--
-- Table structure for table `cinemas`
--

CREATE TABLE `cinemas` (
  `id` int(11) NOT NULL,
  `nama_cabang` varchar(45) NOT NULL,
  `alamat` varchar(45) NOT NULL,
  `tgl_dibuka` date NOT NULL,
  `kota` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cinemas`
--

INSERT INTO `cinemas` (`id`, `nama_cabang`, `alamat`, `tgl_dibuka`, `kota`) VALUES
(1, 'celikoor1', 'Jl. Rungkut Asri Utara X no 1', '2023-11-01', 'surabaya'),
(2, 'celikoor2', 'Jl. Dukukupang no 5', '2023-11-17', 'Surabaya');

-- --------------------------------------------------------

--
-- Table structure for table `detail_menu`
--

CREATE TABLE `detail_menu` (
  `invoices_id` int(11) NOT NULL,
  `menus_id` int(11) NOT NULL,
  `waiters_id` int(11) NOT NULL,
  `total` double NOT NULL,
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL,
  `kuantitas` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `detail_menu`
--

INSERT INTO `detail_menu` (`invoices_id`, `menus_id`, `waiters_id`, `total`, `jadwal_film_id`, `studios_id`, `films_id`, `kuantitas`) VALUES
(31, 3, 4, 20000, 37, 1, 1, 1);

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `films`
--

INSERT INTO `films` (`id`, `judul`, `sinopsis`, `tahun`, `durasi`, `kelompoks_id`, `bahasa`, `is_sub_indo`, `cover_image`, `diskon_nominal`) VALUES
(1, 'AQUAMAN AND THE LOST KINGDOM', 'After failing to defeat Aquaman the first time, Black Manta wields the power of the mythic Black Trident to unleash an ancient and malevolent force. Hoping to end his reign of terror, Aquaman forges an unlikely alliance with his brother, Orm, the former king of Atlantis. Setting aside their differences, they join forces to protect their kingdom and save the world from irreversible destruction.', 2024, 124, 3, 'EN', 1, 'p1', 20),
(2, 'WONKA', 'With dreams of opening a shop in a city renowned for its chocolate, a young and poor Willy Wonka discovers that the industry is run by a cartel of greedy chocolatiers.', 2024, 116, 1, 'EN', 1, 'p2', 0),
(3, 'THE BEEKEPER', 'One man\'s brutal campaign for vengeance takes on national stakes after it\'s revealed he\'s a former operative of a powerful and clandestine organization known as Beekeepers.', 2024, 105, 4, 'EN', 1, 'p3', 0),
(4, 'SPIDER-MAN: ACROSS THE SPIDER VERSE', 'After reuniting with Gwen Stacy, Brooklyn\'s full-time, friendly neighborhood Spider-Man is catapulted across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence. However, when the heroes clash on how to handle a new threat, Miles finds himself pitted against the other Spiders. He must soon redefine what it means to be a hero so he can save the people he loves most.', 2024, 140, 3, 'EN', 1, 'p4', 0),
(5, 'TRANSFORMER: RISE OF THE BEAST', 'Optimus Prime and the Autobots team up with a down on his luck young man, an aspiring historian and with a powerful faction of Transformers known as the Maximals to combat a sinister force from outer space that threatens the Earth and all of mankind.\n', 2024, 127, 3, 'EN', 1, 'p5', 10),
(6, 'NIGHT SWIM', 'Forced into early retirement by a degenerative illness, former baseball player Ray Waller moves into a new house with his wife and two children. He hopes that the backyard swimming pool will be fun for the kids and provide physical therapy for himself. However, a dark secret from the home\'s past soon unleashes a malevolent force that drags the family into the depths of inescapable terror.\r\n', 2024, 98, 4, 'EN', 1, 'p6', 0),
(7, 'THE BOOK OF CLARENCE', 'A down-on-his-luck man struggles to find a better life for his family while fighting to free himself of debt. Captivated by the power and glory of the rising Messiah, he risks everything to carve his own path to a divine life, ultimately discovering that the redemptive power of belief may be his only way out.', 2023, 129, 3, 'EN', 1, 'p7', 0),
(8, 'THE PAINTER', 'An ex-CIA operative is tracked down by a young woman and they become entangled in an unauthorised black ops programme.', 2024, 100, 4, 'EN', 1, 'p8', 0),
(9, 'DARKGAME', 'A determined detective races against time to stop a twisted game show on the dark web, where captives are forced to compete for their lives.', 2024, 90, 4, 'EN', 1, 'p9', 0),
(10, 'WANTED MAN', 'Follows a police officer who must retrieve an eyewitness and escort her after a cartel shooting leaves several DEA agents dead, but then he must decide who to trust when they discover that the attack was executed by American forces.', 2024, 85, 4, 'EN', 1, 'p10', 0),
(11, 'INSIDE OUT 2', 'Joy, Sadness, Anger, Fear and Disgust have been running a successful operation by all accounts. However, when Anxiety shows up, they aren\'t sure how to feel.', 2024, 120, 1, 'EN', 1, 'p11', 0),
(12, 'GODZILLA VS KONG', 'Kong and his protectors undertake a perilous journey to find his true home. Along for the ride is Jia, an orphaned girl who has a unique and powerful bond with the mighty beast. However, they soon find themselves in the path of an enraged Godzilla as he cuts a swath of destruction across the globe. The initial confrontation between the two titans -- instigated by unseen forces -- is only the beginning of the mystery that lies deep within the core of the planet.\r\n', 2024, 117, 3, 'EN', 1, 'p12', 0),
(41, 'Pemimpi', 'Cerita mengenai pemimpi', 2024, 150, 3, 'ID', 1, 'p13', 20);

-- --------------------------------------------------------

--
-- Table structure for table `film_studio`
--

CREATE TABLE `film_studio` (
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `film_studio`
--

INSERT INTO `film_studio` (`studios_id`, `films_id`) VALUES
(1, 1),
(1, 2),
(1, 7),
(1, 11),
(3, 2),
(4, 1),
(4, 7),
(5, 2),
(5, 11),
(5, 41),
(6, 41),
(7, 2),
(8, 6),
(8, 7);

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`id`, `nama`, `deskripsi`) VALUES
(1, 'Horror', 'Adegan menakutkan'),
(2, 'Thriller', 'Adegan kekerasan atau keterlibatan darah'),
(3, 'Romance', 'Adegan asmara dan percintaan'),
(4, 'Action', 'Adegan seru dan menegangkan'),
(5, 'Comedy', 'Adegan lucu dan menyenangkan');

-- --------------------------------------------------------

--
-- Table structure for table `genre_film`
--

CREATE TABLE `genre_film` (
  `films_id` int(11) NOT NULL,
  `genres_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `genre_film`
--

INSERT INTO `genre_film` (`films_id`, `genres_id`) VALUES
(1, 4),
(1, 5),
(2, 5),
(9, 1),
(9, 2),
(41, 3);

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `invoices`
--

INSERT INTO `invoices` (`id`, `tanggal`, `grand_total`, `diskon_nominal`, `konsumens_id`, `kasir_id`, `status`) VALUES
(1, '2023-01-22 00:00:00', 50000, 0, 1, 2, 'TERBAYAR'),
(2, '2023-01-16 00:00:00', 100000, 20, 2, 2, 'TERBAYAR'),
(3, '2023-01-15 00:00:00', 100000, 0, 1, 2, 'TERBAYAR'),
(4, '2023-01-15 00:00:00', 100000, 0, 1, 2, 'TERBAYAR'),
(10, '2024-01-16 02:01:10', 180000, 20, 1, 2, 'TERBAYAR'),
(11, '2024-01-16 02:02:20', 108000, 20, 1, 2, 'TERBAYAR'),
(12, '2024-01-16 02:06:06', 180000, 20, 1, 2, 'TERBAYAR'),
(13, '2024-01-16 02:11:05', 288000, 20, 1, 2, 'VALIDASI'),
(14, '2024-01-16 02:11:45', 150000, 0, 1, NULL, 'PENDING'),
(15, '2024-01-16 19:53:18', 72000, 20, 1, NULL, 'PENDING'),
(16, '2024-01-16 21:52:01', 108000, 20, 11, NULL, 'PENDING'),
(19, '2024-01-17 00:01:47', 36000, 20, 1, NULL, 'PENDING'),
(22, '2024-01-17 13:23:45', 0, 20, 1, NULL, 'PENDING'),
(23, '2024-01-17 13:41:37', 140000, 0, 1, NULL, 'PENDING'),
(24, '2024-01-19 07:32:34', 200000, 20, 12, 2, 'VALIDASI'),
(25, '2024-01-19 07:32:53', 120000, 20, 12, 2, 'TERBAYAR'),
(26, '2024-01-21 15:51:45', 292000, 20, 1, NULL, 'PENDING'),
(27, '2024-01-21 15:51:52', 292000, 20, 1, NULL, 'PENDING'),
(28, '2024-01-21 15:52:31', 292000, 20, 1, NULL, 'PENDING'),
(29, '2024-01-21 16:10:49', 164000, 20, 1, NULL, 'PENDING'),
(30, '2024-01-21 16:11:45', 164000, 20, 1, NULL, 'PENDING'),
(31, '2024-01-21 16:13:38', 92000, 20, 1, NULL, 'PENDING');

-- --------------------------------------------------------

--
-- Table structure for table `jadwal_films`
--

CREATE TABLE `jadwal_films` (
  `id` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `jam_pemutaran` enum('I','II','III','IV') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `jadwal_films`
--

INSERT INTO `jadwal_films` (`id`, `tanggal`, `jam_pemutaran`) VALUES
(37, '2024-01-14', 'I'),
(46, '2024-01-14', 'IV'),
(47, '2024-01-14', 'III'),
(48, '2024-01-14', 'I'),
(49, '2024-01-15', 'IV'),
(50, '2024-01-15', 'III'),
(51, '2024-01-15', 'I'),
(52, '2024-01-15', 'II'),
(53, '2024-01-15', 'IV'),
(54, '2024-01-15', 'III'),
(55, '2024-01-15', 'I'),
(56, '2024-01-15', 'II'),
(57, '2024-01-15', 'IV'),
(58, '2024-01-15', 'III'),
(59, '2024-01-15', 'I'),
(60, '2024-01-15', 'IV'),
(61, '2024-01-15', 'III'),
(62, '2024-01-15', 'IV'),
(63, '2024-01-15', 'III'),
(64, '2024-01-15', 'IV'),
(65, '2024-01-15', 'III'),
(66, '2024-01-15', 'IV'),
(67, '2024-01-15', 'III'),
(68, '2024-01-15', 'IV'),
(69, '2024-01-15', 'III'),
(70, '2024-01-15', 'IV'),
(71, '2024-01-15', 'III'),
(72, '2024-01-17', 'IV'),
(73, '2024-01-17', 'I'),
(74, '2024-01-16', 'II'),
(75, '2024-01-16', 'I'),
(76, '2024-01-16', 'II'),
(77, '2024-01-16', 'I'),
(78, '2024-01-16', 'III'),
(79, '2024-01-16', 'IV'),
(80, '2024-01-16', 'I'),
(81, '2024-01-16', 'III'),
(82, '2024-01-16', 'IV'),
(83, '2024-01-16', 'III'),
(84, '2024-01-16', 'I'),
(85, '2024-01-16', 'II'),
(86, '2024-01-16', 'I'),
(87, '2024-01-16', 'II'),
(88, '2024-01-16', 'I'),
(89, '2024-01-16', 'II'),
(90, '2024-01-16', 'I'),
(93, '2024-01-16', 'II'),
(94, '2024-01-16', 'I'),
(95, '2024-01-16', 'II'),
(96, '2024-01-16', 'I'),
(97, '2024-01-16', 'II'),
(98, '2024-01-16', 'I'),
(99, '2024-01-19', 'IV'),
(100, '2024-01-19', 'III'),
(101, '2024-01-19', 'I'),
(102, '2024-01-19', 'IV'),
(103, '2024-01-19', 'III'),
(104, '2024-01-19', 'I');

-- --------------------------------------------------------

--
-- Table structure for table `jenis_studios`
--

CREATE TABLE `jenis_studios` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `deskripsi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `jenis_studios`
--

INSERT INTO `jenis_studios` (`id`, `nama`, `deskripsi`) VALUES
(1, 'Reguler', 'cinema reguler'),
(2, 'Premier', 'bisa sambil berbaring'),
(3, 'IMAX', 'layar besar');

-- --------------------------------------------------------

--
-- Table structure for table `kelompoks`
--

CREATE TABLE `kelompoks` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kelompoks`
--

INSERT INTO `kelompoks` (`id`, `nama`) VALUES
(1, 'all age'),
(2, 'PG'),
(3, 'PG-13'),
(4, 'Rated R'),
(5, 'Rated X');

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `konsumens`
--

INSERT INTO `konsumens` (`id`, `nama`, `email`, `no_hp`, `gender`, `tgl_lahir`, `saldo`, `username`, `password`) VALUES
(1, 'willy', 's160422011@student.ubaya.ac.id', '1234', '', '2023-11-09', 123580000, 'willy', '1'),
(2, 'budi', 'wda', '013483279847234', 'P', '0000-00-00', 30000, 'budies', '2'),
(3, 'febri', 'cas', '23432432424234', 'L', '2023-11-01', 50000, '3ed', '3'),
(4, 'oakle', 'wcve', '3243424', 'P', '2023-11-17', 10000000000, 'ooo', '4'),
(5, 'stnk', 'wdaswwd', '23143234324', 'P', '2023-11-19', 24000, 'dwedq', '5'),
(8, 's', 's', '123123123', 'L', '2024-01-15', 10000000, 's', 's'),
(9, 'f', 'f', '2312313', 'P', '2024-01-15', 200000, 'f', 'f'),
(11, 'd', 'd', '123123', 'L', '2024-01-16', 892000, 'd', 'd'),
(12, 'james', 'james@gmail.com', '10000002312', 'L', '2024-01-19', 680000, 'james', '1');

-- --------------------------------------------------------

--
-- Table structure for table `menus`
--

CREATE TABLE `menus` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `harga` double NOT NULL,
  `jenis_menu` enum('FOOD','BEVERAGE') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `menus`
--

INSERT INTO `menus` (`id`, `nama`, `harga`, `jenis_menu`) VALUES
(1, 'Popcorn', 100000, 'FOOD'),
(2, 'Chiken Wings', 200000, 'FOOD'),
(3, 'Pepsi', 20000, 'BEVERAGE'),
(4, 'Lemon Tea', 25000, 'BEVERAGE');

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
  `roles` enum('ADMIN','KASIR','OPERATOR','PELAYAN') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pegawais`
--

INSERT INTO `pegawais` (`id`, `nama`, `email`, `username`, `password`, `roles`) VALUES
(1, 'willy', 'w', 'willy', '1', 'ADMIN'),
(2, 'stenli', 's', 'stenli', '2', 'KASIR'),
(3, 'darius', 'wda', 'darius', '3', 'OPERATOR'),
(4, 'fio', 'w', 'fio', '4', 'PELAYAN');

-- --------------------------------------------------------

--
-- Table structure for table `sesi_films`
--

CREATE TABLE `sesi_films` (
  `jadwal_film_id` int(11) NOT NULL,
  `studios_id` int(11) NOT NULL,
  `films_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sesi_films`
--

INSERT INTO `sesi_films` (`jadwal_film_id`, `studios_id`, `films_id`) VALUES
(37, 1, 1),
(64, 1, 2),
(65, 1, 2),
(66, 5, 2),
(67, 5, 2),
(68, 3, 2),
(69, 3, 2),
(70, 7, 2),
(71, 7, 2),
(79, 8, 7),
(80, 8, 7),
(81, 8, 7),
(82, 4, 7),
(83, 4, 7),
(84, 4, 7),
(85, 8, 6),
(86, 8, 6),
(99, 5, 41),
(100, 5, 41),
(101, 5, 41),
(102, 6, 41),
(103, 6, 41),
(104, 6, 41);

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `studios`
--

INSERT INTO `studios` (`id`, `nama`, `kapasitas`, `jenis_studios_id`, `cinemas_id`, `harga_weekday`, `harga_weekend`) VALUES
(1, 'I', 60, 1, 1, 35000, 45000),
(2, 'II', 60, 1, 1, 35000, 45000),
(3, 'III', 84, 3, 1, 45000, 55000),
(4, 'IV', 24, 2, 1, 80000, 100000),
(5, 'I', 60, 1, 2, 50000, 60000),
(6, 'II', 60, 1, 2, 50000, 60000),
(7, 'III', 84, 3, 2, 55000, 65000),
(8, 'IV', 24, 2, 2, 100000, 120000);

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tikets`
--

INSERT INTO `tikets` (`invoices_id`, `nomor_kursi`, `status_hadir`, `operator_id`, `harga`, `jadwal_film_id`, `studios_id`, `films_id`) VALUES
(1, 'A1', 0, 1, 50000, 37, 1, 1),
(2, 'A1', 0, 1, 10000, 66, 5, 2),
(2, 'B12', 0, 1, 20000, 66, 5, 2),
(2, 'C1', 0, 1, 20000, 66, 5, 2),
(12, 'A3', 0, 1, 45000, 37, 1, 1),
(12, 'B2', 0, 1, 45000, 37, 1, 1),
(12, 'B3', 0, 1, 45000, 37, 1, 1),
(12, 'C2', 0, 1, 45000, 37, 1, 1),
(12, 'C3', 1, 1, 45000, 37, 1, 1),
(13, 'A6', 0, 1, 45000, 37, 1, 1),
(13, 'A7', 0, 1, 45000, 37, 1, 1),
(13, 'B15', 0, 1, 45000, 37, 1, 1),
(13, 'C13', 0, 1, 45000, 37, 1, 1),
(13, 'C14', 0, 1, 45000, 37, 1, 1),
(13, 'C15', 0, 1, 45000, 37, 1, 1),
(13, 'C16', 0, 1, 45000, 37, 1, 1),
(13, 'C20', 0, 1, 45000, 37, 1, 1),
(14, 'A19', 0, 1, 50000, 66, 5, 2),
(14, 'A20', 0, 1, 50000, 66, 5, 2),
(14, 'B17', 0, 1, 50000, 66, 5, 2),
(15, 'B10', 0, 1, 45000, 37, 1, 1),
(15, 'B11', 0, 1, 45000, 37, 1, 1),
(16, 'A13', 0, 1, 45000, 37, 1, 1),
(16, 'A17', 0, 1, 45000, 37, 1, 1),
(16, 'C6', 0, 1, 45000, 37, 1, 1),
(19, 'C9', 0, 1, 45000, 37, 1, 1),
(23, 'B1', 0, 1, 35000, 65, 1, 2),
(23, 'B2', 0, 1, 35000, 65, 1, 2),
(23, 'B3', 0, 1, 35000, 65, 1, 2),
(23, 'C4', 0, 1, 35000, 65, 1, 2),
(24, 'A1', 0, 1, 50000, 101, 5, 41),
(24, 'A3', 0, 1, 50000, 101, 5, 41),
(24, 'A4', 0, 1, 50000, 101, 5, 41),
(24, 'B2', 0, 1, 50000, 101, 5, 41),
(24, 'C3', 0, 1, 50000, 101, 5, 41),
(25, 'A20', 0, 1, 50000, 99, 5, 41),
(25, 'B18', 0, 1, 50000, 99, 5, 41),
(25, 'C18', 1, 1, 50000, 99, 5, 41),
(26, 'B5', 0, 1, 45000, 37, 1, 1),
(26, 'B8', 0, 1, 45000, 37, 1, 1),
(27, 'B5', 0, 1, 45000, 37, 1, 1),
(27, 'B8', 0, 1, 45000, 37, 1, 1),
(28, 'B5', 0, 1, 45000, 37, 1, 1),
(28, 'B8', 0, 1, 45000, 37, 1, 1),
(29, 'C1', 0, 1, 45000, 37, 1, 1),
(29, 'C10', 0, 1, 45000, 37, 1, 1),
(29, 'C11', 0, 1, 45000, 37, 1, 1),
(29, 'C5', 0, 1, 45000, 37, 1, 1),
(30, 'C1', 0, 1, 45000, 37, 1, 1),
(30, 'C10', 0, 1, 45000, 37, 1, 1),
(30, 'C11', 0, 1, 45000, 37, 1, 1),
(30, 'C5', 0, 1, 45000, 37, 1, 1),
(31, 'C12', 0, 1, 45000, 37, 1, 1),
(31, 'C8', 0, 1, 45000, 37, 1, 1);

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
-- Indexes for table `detail_menu`
--
ALTER TABLE `detail_menu`
  ADD PRIMARY KEY (`invoices_id`,`menus_id`),
  ADD KEY `fk_film_studio_has_invoices_invoices1_idx` (`invoices_id`),
  ADD KEY `fk_film_studio_has_invoices_pegawais1_idx` (`waiters_id`),
  ADD KEY `fk_menus_sesi_films1_idx` (`jadwal_film_id`,`studios_id`,`films_id`);

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
-- Indexes for table `menus`
--
ALTER TABLE `menus`
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `cinemas`
--
ALTER TABLE `cinemas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `films`
--
ALTER TABLE `films`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `invoices`
--
ALTER TABLE `invoices`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `jadwal_films`
--
ALTER TABLE `jadwal_films`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=105;

--
-- AUTO_INCREMENT for table `jenis_studios`
--
ALTER TABLE `jenis_studios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `kelompoks`
--
ALTER TABLE `kelompoks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `konsumens`
--
ALTER TABLE `konsumens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `menus`
--
ALTER TABLE `menus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `pegawais`
--
ALTER TABLE `pegawais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `studios`
--
ALTER TABLE `studios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aktor_film`
--
ALTER TABLE `aktor_film`
  ADD CONSTRAINT `fk_aktors_has_films_aktors1` FOREIGN KEY (`aktors_id`) REFERENCES `aktors` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_aktors_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `films`
--
ALTER TABLE `films`
  ADD CONSTRAINT `fk_films_kelompoks1` FOREIGN KEY (`kelompoks_id`) REFERENCES `kelompoks` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `film_studio`
--
ALTER TABLE `film_studio`
  ADD CONSTRAINT `fk_studios_has_films_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_studios_has_films_studios1` FOREIGN KEY (`studios_id`) REFERENCES `studios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `genre_film`
--
ALTER TABLE `genre_film`
  ADD CONSTRAINT `fk_films_has_genres_films1` FOREIGN KEY (`films_id`) REFERENCES `films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_films_has_genres_genres1` FOREIGN KEY (`genres_id`) REFERENCES `genres` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `invoices`
--
ALTER TABLE `invoices`
  ADD CONSTRAINT `fk_invoices_konsumens1` FOREIGN KEY (`konsumens_id`) REFERENCES `konsumens` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_invoices_pegawais1` FOREIGN KEY (`kasir_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `sesi_films`
--
ALTER TABLE `sesi_films`
  ADD CONSTRAINT `fk_jadwal_film_has_film_studio_film_studio1` FOREIGN KEY (`studios_id`,`films_id`) REFERENCES `film_studio` (`studios_id`, `films_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_jadwal_film_has_film_studio_jadwal_film1` FOREIGN KEY (`jadwal_film_id`) REFERENCES `jadwal_films` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `studios`
--
ALTER TABLE `studios`
  ADD CONSTRAINT `fk_studios_cinemas1` FOREIGN KEY (`cinemas_id`) REFERENCES `cinemas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_studios_jenis_studios` FOREIGN KEY (`jenis_studios_id`) REFERENCES `jenis_studios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tikets`
--
ALTER TABLE `tikets`
  ADD CONSTRAINT `fk_film_studio_has_invoices_invoices1` FOREIGN KEY (`invoices_id`) REFERENCES `invoices` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_film_studio_has_invoices_pegawais1` FOREIGN KEY (`operator_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tikets_sesi_films1` FOREIGN KEY (`jadwal_film_id`,`studios_id`,`films_id`) REFERENCES `sesi_films` (`jadwal_film_id`, `studios_id`, `films_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
