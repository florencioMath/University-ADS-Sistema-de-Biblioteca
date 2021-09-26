-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Set-2021 às 02:04
-- Versão do servidor: 10.4.20-MariaDB
-- versão do PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sistema_de_biblioteca`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `nomeCliente` varchar(100) NOT NULL,
  `cpfCliente` varchar(20) NOT NULL,
  `emailCliente` varchar(150) NOT NULL,
  `ativoCliente` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`idCliente`, `nomeCliente`, `cpfCliente`, `emailCliente`, `ativoCliente`) VALUES
(1, 'Matheus Florêncio', '111.111.111-11', 'matheusflorencio@edu.univali.com.br', 1),
(2, 'Alex Rese', '222.222.222-22', 'alex.rese@univali.com.br', 1),
(3, 'Lucas Debatin', '333.333.333-33', 'lucas.debatin@univali.com.br', 1),
(4, 'Lucas Tenorio', '444.444.444-44', 'lucas.tenorio@univali.com.br', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `livro`
--

CREATE TABLE `livro` (
  `idLivro` int(11) NOT NULL,
  `nomeLivro` varchar(100) NOT NULL,
  `idAutor` varchar(100) NOT NULL,
  `descricaoLivro` text NOT NULL,
  `categoriaLivro` varchar(50) NOT NULL,
  `anoLivro` int(4) NOT NULL,
  `ativoLivro` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `livro`
--

INSERT INTO `livro` (`idLivro`, `nomeLivro`, `idAutor`, `descricaoLivro`, `categoriaLivro`, `anoLivro`, `ativoLivro`) VALUES
(1, 'O Alquimista', 'Paulo Coelho', 'O Alquimista é um best-seller do escritor brasileiro Paulo Coelho, publicado originalmente em 1988, em português Em abril de 2017 foi publicado pelo selo Paralela da editora Companhia das Letras.', 'Romance', 1988, 1),
(2, 'Harry Potter e a Pedra Filosofal', 'J. K. Rowling', 'Um bruxo que foi criado igual um porco para o abate!\r\nGo VEGAN!', 'Fantasia', 1997, 1),
(3, 'Meditações', 'Marco Aurélio', 'Meditações (em grego Τὰ εἰς ἑαυτόν, Ta eis heautón literalmente \"[pensamentos/escritos] endereçados a si mesmo\") é o título de uma série de escritos pessoais do imperador romano Marco Aurélio onde ele apresentou suas ideias sobre a filosofia estoica.', 'Estoicismo', 180, 1),
(4, 'Rápido e Devagar - Duas Formas de Pensar', 'Daniel Kahneman', 'Rápido e Devagar - Duas Formas de Pensar, Thinking, Fast and Slow (em inglês), é um best-seller publicado em 2011 pelo, laureado em Economia, Daniel Kahneman. Foi o vencedor do National Academies Communication Award de 2012 pelo melhor trabalho criativo que ajuda a compreensão pública de tópicos em ciência comportamental, engenharia e medicina. O livro resume as pesquisas que Kahneman realizou ao longo de décadas, muitas vezes em colaboração com Amos Tversky.', 'Psicologia; Economia', 2011, 1),
(5, 'A Divina Comédia', 'Dante Alighieri', 'A Divina Comédia (em italiano: Divina Commedia, originalmente Comedìa e, mais tarde, denominada Divina Comédia por Giovanni Boccaccio) é um poema de viés épico e teológico da literatura italiana e mundial, escrito por Dante Alighieri no século XIV e dividido em três partes: o Inferno, o Purgatório e o Paraíso.', 'Épico', 1304, 1),
(8, 'Onde os Sonhos Acontecem', 'Robert Iger', 'As histórias e os princípios de um líder visionário que transformou a Disney na maior companhia de mídia do planeta', 'Biografias', 2020, 1),
(12, '1984', 'George Orwell', '1984 foi responsável pela popularização de muitos termos e conceitos, como Grande Irmão, duplopensar, novidioma, buraco da memória e 2+2=5. O trabalho de Winston, o herói de 1984, é reescrever artigos de jornais do passado, de modo que o registro histórico sempre apoie a ideologia do Partido. Grande parte do Ministério também destrói os documentos que não foram revisados, dessa forma não há como provar que o governo esteja mentindo. Winston é um trabalhador diligente e habilidoso, mas odeia secretamente o Partido e sonha com a rebelião contra o Grande Irmão.', 'Ficção Clássica', 1949, 1),
(14, 'A Revolução dos Bichos', '\r\nGeorge Orwell', 'Uma fazenda é tomada por seus animais maltratados e sobrecarregados. Cheios de idealismo, eles se propõem a criar um paraíso de progresso, justiça e igualdade, administrando o local por conta própria.', 'Clássicos de Ficção', 1945, 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Índices para tabela `livro`
--
ALTER TABLE `livro`
  ADD PRIMARY KEY (`idLivro`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `livro`
--
ALTER TABLE `livro`
  MODIFY `idLivro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
