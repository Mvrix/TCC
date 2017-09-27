-- Table tcc_tecnicos --------------------------
-- 
CREATE TABLE [tcc_pessoas]
(
[id_pessoa] [int]  NOT NULL IDENTITY (1, 1),
[nome] [nvarchar] (50) NULL,
[endereco] [nvarchar] (50) NULL,
[bairro] [nvarchar] (30) NULL,
[cep] [nvarchar] (8) NULL,
[telefone] [nvarchar] (11) NULL,
[email] [nvarchar] (100) NULL,
[rg] [nvarchar] (20) NULL,
[cpf] [nvarchar] (20) NULL,
[cidade] [nvarchar] (30) NULL,
[datanasc] [datetime]  NULL,
[tipo] [int] NULL, 
[observacao] [nvarchar] (300) NULL,
CONSTRAINT PK_tcc_pessoas PRIMARY KEY (id)
)


CREATE TABLE [tcc_marcas]
(
[id_marcas] [int] NOT NULL IDENTITY (1, 1),
[marca] [nvarchar] (100) NULL,
CONSTRAINT PK_tcc_marcas PRIMARY KEY (id)
)


-- Table pc_produto --------------------------
-- Tabela que vai conter os produtos cadastrados
-- 
-- Quanto a marca dele, colocar no programa um combo box com as marcas
-- e caso ele queira adicionar uma que não está na lista, basta clicar em um botão do lado
-- e um dialog aparece para ele adicionar a nova marca, e em seguida, é adicionado a nova marca 
-- no banco e depois já é atualizado o combo box.
CREATE TABLE [tcc_produto]
(
[id_produto] [int]  NOT NULL IDENTITY (1, 1),
[capacidade] [nvarchar] (10) NULL,
[descricao] [nvarchar] (50) NULL,
[marca] [int] FOREIGN KEY REFERENCES tcc_marcas(id) null,
[tipo] [nvarchar] (50) NULL,
[tipo2] [nvarchar] (50) NULL,
[precounit] [float]  NULL,
CONSTRAINT PK_tcc_produto PRIMARY KEY (id)
)

--
--VAI MOSTRAR OQ O SERVIÇOFAZ
--

CREATE TABLE [tcc_observacao_servicos]
(
[id_observacao_servicos] [int] NOT NULL IDENTITY (1, 1),
[nome_servico] [nvarchar] (100) NULL,
[observacao] [nvarchar] (200) NULL,
CONSTRAINT PK_tcc_observacao_servicos PRIMARY KEY (id)
)


-- Table Ações --------------------------
-- Vai guardar as ações que o "usuário" vai escolher
-- 

CREATE TABLE [tcc_detalhe_acoes]
(
[id_detalhe_acoes] [int]  NOT NULL IDENTITY (1, 1),
[tipo] [nvarchar] (30) NULL,
[descricao] [nvarchar] (150) NULL,
CONSTRAINT PK_tcc_acoes PRIMARY KEY (id)
)

-- Vai guardar todas os pedidos por um servico

CREATE TABLE [tcc_servicos]
(
[id_servicos] [int]  NOT NULL IDENTITY (1, 1),
[observacao_servico_id] [int] FOREIGN KEY REFERENCES tcc_observacao_servicos(id) NULL,
[pessoas_id] [int] FOREIGN KEY REFERENCES tcc_pessoas(id) NULL,
[pessoas_id] [int] FOREIGN KEY REFERENCES tcc_pessoas(id) NULL,
[data_marcada] [datetime] NULL,
[observacao] [nvarchar] (100) NULL,
[data_criado] [datetime] NULL, -- Vai ser timestamp
CONSTRAINT PK_servicos PRIMARY KEY (id)
)