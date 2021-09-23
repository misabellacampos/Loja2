-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23-Set-2021 às 17:46
-- Versão do servidor: 10.4.19-MariaDB
-- versão do PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `tênis`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tênis`
--

CREATE TABLE `tênis` (
  `idTênis` int(11) NOT NULL,
  `marcaTênis` varchar(50) NOT NULL,
  `modeloTênis` varchar(100) NOT NULL,
  `corTênis` varchar(100) NOT NULL,
  `anoTênis` int(20) NOT NULL,
  `ativoTênis` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tênis`
--

INSERT INTO `tênis` (`idTênis`, `marcaTênis`, `modeloTênis`, `corTênis`, `anoTênis`, `ativoTênis`) VALUES
(1, 'Adidas', 'Yeezy Boost 350 V2 BLACK REFLECTIVE', 'Preto', 2019, 1),
(2, 'Nike', 'Travis Scott x Nike Air Force 1 Low', 'Branco', 2017, 1),
(3, 'Nike', 'Travis Scott x Nike SB Dunk Low', 'Bege/Azul marinho', 2020, 1),
(4, 'Nike', 'Air Dior', 'Cinza/Branco', 2020, 1),
(5, 'Nike', 'Air Jordan 1 \"UNC\"', 'Branco/Azul Claro', 2020, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tênis`
--
ALTER TABLE `tênis`
  ADD PRIMARY KEY (`idTênis`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tênis`
--
ALTER TABLE `tênis`
  MODIFY `idTênis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
