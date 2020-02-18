-- Aula..............:   09
-- Nome..............:   Davy Paulino
-- Version...........:   0.1
-- Data..............:   17/02/2020


-- Certifica-se que o usuário
-- Esteja no banco Master
USE Master
GO

--  Cria o banco de dados AULA09
CREATE DATABASE AULA09
GO

-- Muda o contexto para AULA09
USE AULA09
GO

-- Cria a tabela FUNCIONARIOS
CREATE TABLE FUNCIONARIOS (
    ID  INT PRIMARY KEY,
    Nome VARCHAR(25),
    Sexo CHAR(1),
    Admissao DATE,
    Salario DECIMAL(10,2)
)
GO

-- Altera o formato de DATA do SQL Server
SET DATEFORMAT DMY
GO

-- Insere dados na tabela FUNCIONARIOS
-- Sintaxe 1
INSERT INTO FUNCIONARIOS (
    ID,
    Nome,
    Sexo,
    Admissao,
    Salario
)
VALUES (1, 'Jose Calor', 'F', '10/01/2020', 2500.00)
GO

-- Insere dados na tabela FUNCIONARIOS
-- Sintaxe 2
INSERT INTO FUNCIONARIOS VALUES (2, 'Pedro Pereira', 'M', '25/03/2015', 999.00)
GO

-- Insere dados na tabela FUNCIONARIOS
-- Sintaxe 3
INSERT INTO FUNCIONARIOS VALUES(3, 'Maria Cristina', 'F', '10/09/2020', 1200.00)
INSERT INTO FUNCIONARIOS VALUES(4, 'Antonio Carlos', 'M', '11/09/2020', 990.00)
GO

-- Insere dados na tabela FUNCIONARIOS
-- Sintaxe 4
INSERT INTO FUNCIONARIOS VALUES(5, 'Augusto Tores', 'M', '10/12/2020', 1900.00),
                                (6, 'Pedro Silva', 'M', '15/11/2015', 1050.000),
                                (7, 'Mônica da Silva', 'F', '12/10/2014', 3000.00),
                                (8, 'Tiago Lima', 'M', '10/12/2016', 1350.00)
GO


--------------- SIMULAÇÃO DE ERRO --------------------
-- Tenta inserir um novo registro cujo a chave prmária
-- Possui o mesmo valor de outro registro já cadastrado
-- dentro da tabela FUNCIONARIOS
INSERT INTO FUNCIONARIOS VALUES
    (8, 'Mateus Pereira', 'M', '25/03/2017', 2990.00)
GO


------------------
-- SELECT
------------------

-- Exibe algumas informações dos funcionários,
-- utilizando aliases
SELECT ID AS 'Código do Funcionários',
       Nome,
       Sexo,
       Salario AS 'Salário'
FROM FUNCIONARIOS
GO

-- Exibe todos os dados da tabela FUNCIONARIOS
SELECT * FROM FUNCIONARIOS
GO

-- Exibe todos os dados da tabela FUNCIONARIOS
-- Utiliza TOP para listar somente os 3 primeiros registros
SELECT TOP 3 * FROM FUNCIONARIOS
GO

------------------------
-- Exemplos WHERE...
------------------------

-- Exibe as informações de todos os funcionários masculinos,
-- cujo salário é maior do que 100 reais
SELECT * FROM FUNCIONARIOS
WHERE Sexo = 'M' AND Salario > 1000
GO

-- Exibe as informações de todos os funcionários
-- cujo sexo seja diferente de 'M'
-- Utilizando operado !=
SELECT * FROM FUNCIONARIOS
WHERE Sexo != 'M'
GO

-- Exibe as informações de todos os funcionários
-- cujo sexo seja diferente de 'M'
-- Utilizando operado !=
SELECT * FROM FUNCIONARIOS
WHERE NOT Sexo = 'M'
GO

-- Exibe os dados dos funcionários cujo salário esteja
-- entre 1000 e 2000 reais (inclusive).
-- Utiliza os operadores >=, AND e <=
SELECT * FROM FUNCIONARIOS
WHERE Salario >= 1000 AND Salario <= 2000
GO

-- Exibe os dados dos funcionários cujo salário esteja
-- entre 1000 e 2000 reais (inclusive).
-- Utiliza os operadores BETWEEN
SELECT * FROM FUNCIONARIOS
WHERE Salario BETWEEN 1000 AND 2000
GO

-- Verifica se existe algum funcionário cujo salário
-- seja maior do que 10000 reais e exibe uma mensagem
-- personalizada
IF EXISTS (SELECT * FROM FUNCIONARIOS
    WHERE Salario > 10000)
    PRINT 'Alguém ganha mais que 10 mil reais...'
ELSE
    PRINT 'Aqui só tem pobre...'
GO