CREATE TABLE CLIENTES
(
  Cod_Cliente INT NOT NULL,
  Nome VARCHAR(20) NOT NULL,
  Sobrenome VARCHAR(20) NOT NULL,
  Inicial CHAR NOT NULL,
  DDD VARCHAR(2) NOT NULL,
  Telefone VARCHAR(9) NOT NULL,
  Saldo NUMERIC(14 2) NOT NULL,
  PRIMARY KEY (Cod_Cliente),
  UNIQUE ()
);

CREATE TABLE FATURAS
(
  Data_Fatura DATE NOT NULL,
  Num_Fatura INT NOT NULL,
  Cod_Cliente INT NOT NULL,
  PRIMARY KEY (Num_Fatura),
  FOREIGN KEY (Cod_Cliente) REFERENCES CLIENTES(Cod_Cliente)
);

CREATE TABLE FORNECEDORES
(
  Estado VARCHAR(2) NOT NULL,
  Nome VARCHAR(20) NOT NULL,
  DDD VARCHAR(2) NOT NULL,
  Telefone VARCHAR(9) NOT NULL,
  Contato VARCHAR(30) NOT NULL,
  Cod_Fornecedor INT NOT NULL,
  Cidade VARCHAR(20) NOT NULL,
  PRIMARY KEY (Cod_Fornecedor)
);

CREATE TABLE PRODUTOS
(
  Descricao VARCHAR(100) NOT NULL,
  Desconto INT NOT NULL,
  Valor NUMERIC(14 2) NOT NULL,
  Data_Compra DATE NOT NULL,
  Cod_Produto INT NOT NULL,
  Quantidade INT NOT NULL,
  Cod_Fornecedor INT NOT NULL,
  PRIMARY KEY (Cod_Produto),
  FOREIGN KEY (Cod_Fornecedor) REFERENCES FORNECEDORES(Cod_Fornecedor)
);

CREATE TABLE LINHAS
(
  Num_linha INT NOT NULL,
  Unidades INT NOT NULL,
  Valor NUMERIC(14 2) NOT NULL,
  Num_Fatura INT NOT NULL,
  Cod_Produto INT NOT NULL,
  PRIMARY KEY (Num_linha),
  FOREIGN KEY (Num_Fatura) REFERENCES FATURAS(Num_Fatura),
  FOREIGN KEY (Cod_Produto) REFERENCES PRODUTOS(Cod_Produto)
);