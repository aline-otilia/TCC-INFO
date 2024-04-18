-- Doador(Id, Nome, Descricao, Foto)
-- Categoria(Id, Nome)
-- Doacao(Id, NomeDoacao, Descricao, Foto, CategoriaId, DoadorId)
-- Contato(Id, DataContato, NomePessoa, EmailPessoa, DoadorId)


-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17-Maio-2021 às 22:02
-- Versão do servidor: 10.4.18-MariaDB
-- versão do PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `boacao`
--
DROP DATABASE IF EXISTS `boacao`;
CREATE DATABASE IF NOT EXISTS `boacao` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `boacao`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `blog`
--

DROP TABLE IF EXISTS `blog`;
CREATE TABLE `blog` (
  `Id` int(11) NOT NULL,
  `DataCadastro` datetime(6) NOT NULL,
  `Titulo` varchar(100) NOT NULL,
  `Texto` varchar(8000) NOT NULL,
  `Imagem` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `doador`
--

DROP TABLE IF EXISTS `doador`;
CREATE TABLE `doador` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `doador`
--

INSERT INTO `doador` (`Id`, `Nome`) VALUES
(1, 'CEO, Co Fundador'),
(2, 'Chefe de Cozinha'),
(3, 'Cozinheiro Chefe');

-- --------------------------------------------------------

DROP TABLE IF EXISTS `time`;
CREATE TABLE `time` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(60) NOT NULL,
  `Descricao` varchar(500) DEFAULT NULL,
  `Foto` varchar(200) DEFAULT NULL  
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `time`
--

INSERT INTO `time` (`Id`, `Nome`, `Descricao`, `Foto`) VALUES
(1, 'Aline Otília dos Santos', 'Eu sou um workaholic ambicioso, mas fora isso, uma pessoa muito simples.', '~/images/donor_15.jpg'),
(2, 'Miria Dias de Castro', 'Eu sou um workaholic ambicioso, mas fora isso, uma pessoa muito simples.', '~/images/donor_14.jpg'),
(3, 'Heloisa Coutinho Martinez', 'Eu sou um workaholic ambicioso, mas fora isso, uma pessoa muito simples.', '~/images/donor_05.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE `categoria` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `contato`
--

DROP TABLE IF EXISTS `contato`;
CREATE TABLE `contato` (
  `Id` int(11) NOT NULL,
  `DataContato` datetime(6) NOT NULL,
  `NomePessoa` varchar(60) NOT NULL,
  `EmailPessoa` varchar(100) NOT NULL,
  `Assunto` varchar(100) NOT NULL,
  `Mensagem` varchar(500) NOT NULL,
  `Status` tinyint(3) UNSIGNED NOT NULL,
  `Retorno` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
CREATE TABLE `pessoa` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(60) NOT NULL,
  `Descricao` varchar(500) DEFAULT NULL,
  `Foto` varchar(200) DEFAULT NULL,
  `DoadorId` int(11) NOT NULL,
  `ExibirHome` tinyint(1) NOT NULL,
  `OrdemExibicao` tinyint(3) UNSIGNED NOT NULL,
  `Ativo` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`Id`, `Nome`, `Descricao`, `DoadorId`, `Foto`, `ExibirHome`, `OrdemExibicao`, `Ativo`) VALUES
(1, 'John Gustavo', 'Eu sou um workaholic ambicioso, mas fora isso, uma pessoa muito simples.', 1, '~/images/chef-4.jpg', 1, 1, 1),
(2, 'Michelle Fraulen', 'Eu sou um workaholic ambicioso, mas fora isso, uma pessoa muito simples.', 2, '~/images/chef-2.jpg', 1, 2, 1),
(3, 'Alfred Smith', 'Eu sou um workaholic ambicioso, mas fora isso, uma pessoa muito simples.', 3, '~/images/chef-3.jpg', 1, 3, 1),
(4, 'Antonio Santibanez', 'Eu sou um workaholic ambicioso, mas fora isso, uma pessoa muito simples.', 3, '~/images/chef-1.jpg', 1, 4, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtoparadoar`
--

DROP TABLE IF EXISTS `produtoparadoar`;
CREATE TABLE `produtoparadoar` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(60) NOT NULL,
  `Descricao` varchar(500) DEFAULT NULL,
  `Preco` decimal(8,2) NOT NULL,
  `Foto` varchar(200) DEFAULT NULL,
  `CategoriaId` int(11) NOT NULL,
  `ExibirHome` tinyint(1) NOT NULL,
  `Ativo` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `relato`
--

DROP TABLE IF EXISTS `relato`;
CREATE TABLE `relato` (
  `Id` int(11) NOT NULL,
  `Texto` varchar(1000) NOT NULL,
  `NomePessoa` varchar(60) DEFAULT NULL,
  `FotoPessoa` varchar(200) DEFAULT NULL,
  `TipoPessoa` varchar(30) DEFAULT NULL,
  `DataCadastro` datetime(6) NOT NULL,
  `ExibirHome` tinyint(1) NOT NULL,
  `OrdemExibicao` tinyint(3) UNSIGNED NOT NULL,
  `Ativo` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `reserva`
--

DROP TABLE IF EXISTS `reserva`;
CREATE TABLE `reserva` (
  `Id` int(11) NOT NULL,
  `NomePessoa` varchar(60) NOT NULL,
  `EmailPessoa` varchar(100) NOT NULL,
  `FonePessoa` varchar(20) NOT NULL,
  `DataCadastro` datetime(6) NOT NULL,
  `DataReserva` datetime(6) NOT NULL,
  `Convidados` tinyint(3) UNSIGNED NOT NULL,
  `Status` tinyint(3) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20210517192253_inicio', '5.0.6');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `blog`
--
ALTER TABLE `blog`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `doador`
--
ALTER TABLE `doador`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `contato`
--
ALTER TABLE `contato`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Pessoa_DoadorId` (`DoadorId`);

--
-- Índices para tabela `produtoparadoar`
--
ALTER TABLE `produtoparadoar`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Produtoparadoar_CategoriaId` (`CategoriaId`);

--
-- Índices para tabela `relato`
--
ALTER TABLE `relato`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `blog`
--
ALTER TABLE `blog`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `doador`
--
ALTER TABLE `doador`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `categoria`
--
ALTER TABLE `categoria`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `contato`
--
ALTER TABLE `contato`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pessoa`
--
ALTER TABLE `pessoa`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `produtoparadoar`
--
ALTER TABLE `produtoparadoar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `relato`
--
ALTER TABLE `relato`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `reserva`
--
ALTER TABLE `reserva`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;



--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD CONSTRAINT `FK_Pessoa_Doador_DoadorId` FOREIGN KEY (`DoadorId`) REFERENCES `doador` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `produtoparadoar`
--
ALTER TABLE `produtoparadoar`
  ADD CONSTRAINT `FK_Produtoparadoar_Categoria_CategoriaId` FOREIGN KEY (`CategoriaId`) REFERENCES `categoria` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
