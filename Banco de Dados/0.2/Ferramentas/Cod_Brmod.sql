-- Nome da Atividade: Exercicio ferramentas para modelagem
-- Autor: Davy Paulino da Silva Dantas
-- Version: 0.1
-- Data de Ultima modificação: 16/02/2020.

CREATE TABLE FATURAS (
    Data_Fatura DATETIME,
    Num_Fatura INTEGER PRIMARY KEY,
    Cod_cliente INTEGER
)

CREATE TABLE CLIENTES (
    Saldo DECIMAL(14,2),
    Inicial CHAR(1),
    Sobrenome VARCHAR(20),
    Nome VARCHAR(20),
    DDD VARCHAR(2),
    Telefone VARCHAR(9),
    Cod_cliente INTEGER PRIMARY KEY
)

CREATE TABLE LINHAS (
    Unidades INTEGER,
    Valor DECIMAL(14,2),
    Num_linha INTEGER PRIMARY KEY,
    Num_Fatura INTEGER,
    Cod_Produto INTEGER,
    FOREIGN KEY(Num_Fatura) REFERENCES FATURAS (Num_Fatura)
)

CREATE TABLE FORNECEDORES (
    Estado VARCHAR(2),
    Nome VARCHAR(20),
    DDD VARCHAR(2),
    Contato VARCHAR(30),
    Telefone VARCHAR(9),
    Cod_Fornecedor INTEGER PRIMARY KEY,
    Cidade VARCHAR(20)
)

CREATE TABLE PRODUTOS (
    Descricao VARCHAR(100),
    Desconto INTEGER,
    Valor DECIMAL(14,2),
    Data_Compra DATETIME,
    Quantidade INTEGER,
    Cod_Produto INTEGER PRIMARY KEY,
    Cod_Fornecedor INTEGER,
    FOREIGN KEY(Cod_Fornecedor) REFERENCES FORNECEDORES (Cod_Fornecedor)
)

ALTER TABLE FATURAS ADD FOREIGN KEY(Cod_cliente) REFERENCES CLIENTES (Cod_cliente)
ALTER TABLE LINHAS ADD FOREIGN KEY(Cod_Produto) REFERENCES PRODUTOS (Cod_Produto)
