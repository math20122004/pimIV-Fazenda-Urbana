CREATE DATABASE CityGreen;

DROP DATABASE CityGreen;

USE CityGreen;

-- Tabela de Funcionalidades
CREATE TABLE Funcionalidade 
(
    idFuncionalidade INT IDENTITY(1,1) PRIMARY KEY,
    nome NVARCHAR(100)
);

-- Tabela de Usuários
CREATE TABLE Usuarios 
(
    idUsuario NVARCHAR(8) PRIMARY KEY NOT NULL,
    nome NVARCHAR(255),
    email NVARCHAR(100),
    senhaHash VARBINARY(64),
    status NVARCHAR(10) CHECK (status IN ('ativo', 'inativo')) DEFAULT 'ativo'
);

-- Tabela de Permissões de Usuários
CREATE TABLE User_Permissao_Tem 
(
    fk_Usuarios_idUsuario NVARCHAR(8),
    fk_Funcionalidade_idFuncionalidade INT,
    FOREIGN KEY (fk_Usuarios_idUsuario) REFERENCES Usuarios (idUsuario),
    FOREIGN KEY (fk_Funcionalidade_idFuncionalidade) REFERENCES Funcionalidade (idFuncionalidade)
);

-- Tabela de Fornecedores
CREATE TABLE Fornecedores 
(
    cnpj CHAR(14) PRIMARY KEY NOT NULL,
    nome NVARCHAR(255),
    razaoSocial NVARCHAR(255),
    telefone1 NVARCHAR(20),
    telefone2 NVARCHAR(20),
    email NVARCHAR(100),
    status NVARCHAR(10) CHECK (status IN ('ativo', 'inativo')) DEFAULT 'ativo',
    tipo NVARCHAR(30),
    infAdicionais NVARCHAR(255),
    endereco NVARCHAR(100),
    numeroEndereco INT,
    bairro NVARCHAR(50),
    cidade NVARCHAR(20),
    estado CHAR(2),
    pais NVARCHAR(30),
    cep NVARCHAR(10)
);

CREATE TABLE Insumo 
(
    idInsumo INT PRIMARY KEY,
    nomeInsumo NVARCHAR(255),
    quantidadeInsumo INT,
    validade NVARCHAR(10) CHECK (validade IN ('Vencido', 'Disponivel','esgotado')) DEFAULT 'Disponivel',
    dataValidade DATE,
    idFornecedor CHAR(14),
    FOREIGN KEY (idFornecedor) REFERENCES Fornecedores(cnpj)
);

-- Tabela de Produção
CREATE TABLE Producao 
(
    idPlantio INT IDENTITY(1,1) PRIMARY KEY,
    dataInicio DATE,
    dataFim DATE,
    produto NVARCHAR(255),
    statusProducao NVARCHAR(10) CHECK (statusProducao IN ('Ativa', 'Cancelada', 'Completa')) DEFAULT 'Ativa'
);

-- Tabela de Insumos utilizados na Produção
CREATE TABLE InsumoProducao 
(
    idInsumo INT,
    idPlantio INT,
    quantidade INT,
    FOREIGN KEY (idPlantio) REFERENCES Producao (idPlantio),
    FOREIGN KEY (idInsumo) REFERENCES Insumo (idInsumo)
);

CREATE TABLE Produto 
(
    idProduto INT PRIMARY KEY,
    nomeProduto VARCHAR(100),
    categoria VARCHAR(50)
);

-- Tabela de Lotes
CREATE TABLE Lote 
(
    idLote INT IDENTITY(1,1) PRIMARY KEY,
    idProduto INT,
    quantidade INT,
    idProducao INT,
	status NVARCHAR(10) CHECK (status IN ('disponível', 'esgotado','vencido')) DEFAULT 'disponível',
    dataValidade DATE,
    FOREIGN KEY (idProducao) REFERENCES Producao (idPlantio),
    FOREIGN KEY (idProduto) REFERENCES produto (idProduto)
);

-- Tabela de Clientes
CREATE TABLE Cliente 
(
    idCliente INT PRIMARY KEY NOT NULL,
    nome NVARCHAR(255),
    telefone1 NVARCHAR(20),
    telefone2 NVARCHAR(20),
    cnpj CHAR(14),
    ie CHAR(9),
    email NVARCHAR(100),
    numeroEndereco INT,
    nomeEndereco NVARCHAR(150),
    bairro NVARCHAR(50),
    cidade NVARCHAR(30),
    estado CHAR(2),
    cep NVARCHAR(10),
    clienteTipo NVARCHAR(30),
    statusCliente NVARCHAR(10) CHECK (statusCliente IN ('Ativo', 'Inativo')) DEFAULT 'Ativo'
);

-- Tabela de Vendas
CREATE TABLE Vendas 
(
    idVenda INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    numero NVARCHAR(30),
    infoAdicionais NVARCHAR(255),
    idCliente INT,
    statusVenda NVARCHAR(15) CHECK (statusVenda IN ('Cancelado', 'Entregue', 'Em andamento')),
    FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente)
);

-- Tabela de Itens da Venda
CREATE TABLE Itens_Venda 
(
	idVenda INT,
    idLote INT,
    quantidade INT,
    valor_total DECIMAL(9,2),
    FOREIGN KEY (idVenda) REFERENCES Vendas (idVenda),
    FOREIGN KEY (idLote) REFERENCES Lote (idLote)
);

-- Trigger para atualizar a validade do Insumo
CREATE TRIGGER trg_UpdateInsumoValidade
ON Insumo
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Insumo
    SET validade = 'Vencido'
    WHERE dataValidade <= CAST(GETDATE() AS DATE)
      AND validade != 'Vencido';
END;

-- Trigger para atualizar a validade do Lote
CREATE TRIGGER trg_UpdateLoteValidade
ON Lote
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Lote
    SET status = 'Vencido'
    WHERE dataValidade <= CAST(GETDATE() AS DATE)
      AND status != 'Vencido';
END;

-- Trigger para subtrair a quantidade de Insumo ao associar à Produção
CREATE TRIGGER trg_SubtractInsumoQuantity
ON InsumoProducao
AFTER INSERT
AS
BEGIN
    UPDATE Insumo
    SET quantidadeInsumo = quantidadeInsumo - inserted.quantidade
    FROM Insumo
    INNER JOIN inserted ON Insumo.idInsumo = inserted.idInsumo;
END;

-- Trigger para adicionar a quantidade de Insumo ao cancelar Produção
CREATE TRIGGER trg_AddInsumoQuantityOnCancel
ON Producao
AFTER UPDATE
AS
BEGIN
    IF UPDATE(statusProducao)
    BEGIN
        UPDATE Insumo
        SET quantidadeInsumo = quantidadeInsumo + InsumoProducao.quantidade
        FROM Insumo
        INNER JOIN InsumoProducao ON Insumo.idInsumo = InsumoProducao.idInsumo
        INNER JOIN inserted ON InsumoProducao.idPlantio = inserted.idPlantio
        WHERE inserted.statusProducao = 'Cancelada';
    END
END;

-- Trigger para subtrair a quantidade de Lote ao adicionar item à Venda
CREATE TRIGGER trg_SubtractLoteQuantity
ON Itens_Venda
AFTER INSERT
AS
BEGIN
    UPDATE Lote
    SET quantidade = Lote.quantidade - i.quantidade
    FROM Lote
    INNER JOIN inserted i ON Lote.idLote = i.idLote;
END;

-- Trigger para adicionar a quantidade de Lote ao cancelar Venda
CREATE TRIGGER trg_AddLoteQuantityOnCancel
ON Vendas
AFTER UPDATE
AS
BEGIN
    IF UPDATE(statusVenda)
    BEGIN
        UPDATE Lote
        SET quantidade = Lote.quantidade + iv.quantidade
        FROM Lote
        INNER JOIN Itens_Venda iv ON Lote.idLote = iv.idLote
        INNER JOIN inserted i ON iv.idVenda = i.idVenda
        WHERE i.statusVenda = 'Cancelado';
    END
END;

-- Procedimento Armazenado para Inserir Usuário
CREATE PROCEDURE uspAddUsuario
    @idUsuario NVARCHAR(8),
    @nome NVARCHAR(255),
    @pEmail NVARCHAR(100),
    @status NVARCHAR(10) = 'ativo',
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DECLARE @senhaPadrao NVARCHAR(50) = 'Troca123';

        INSERT INTO Usuarios (idUsuario, nome, email, senhaHash, status)
        VALUES (@idUsuario, @nome, @pEmail, HASHBYTES('SHA2_256', @senhaPadrao), @status);
        SET @responseMessage = 'Usuário inserido com sucesso';
    END TRY
    BEGIN CATCH
        SET @responseMessage = ERROR_MESSAGE();
    END CATCH
END;


-- Procedimento Armazenado para Autenticar Usuário
CREATE PROCEDURE uspAutenticarUsuario
    @login NVARCHAR(100),
    @pSenha NVARCHAR(50),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @senhaHash VARBINARY(64);
    DECLARE @idUsuario NVARCHAR(8);

    -- Verifica se o login é um email ou idUsuario
    IF CHARINDEX('@', @login) > 0
    BEGIN
        SELECT @idUsuario = idUsuario, @senhaHash = senhaHash
        FROM Usuarios
        WHERE email = @login;
    END
    ELSE
    BEGIN
        SELECT @idUsuario = idUsuario, @senhaHash = senhaHash
        FROM Usuarios
        WHERE idUsuario = @login;
    END

    IF @senhaHash = HASHBYTES('SHA2_256', @pSenha)
    BEGIN
        SET @responseMessage = 'Autenticação bem-sucedida';
    END
    ELSE
    BEGIN
        SET @responseMessage = 'Falha na autenticação';
    END
END;

-- Inserindo funcionalidades na tabela Funcionalidade
INSERT INTO Funcionalidade (nome) VALUES ('Fornecedores');
INSERT INTO Funcionalidade (nome) VALUES ('Vendas');
INSERT INTO Funcionalidade (nome) VALUES ('Produção');
INSERT INTO Funcionalidade (nome) VALUES ( 'Administrador');

-- Criptografar a senha "12345" usando SHA-256
DECLARE @senha NVARCHAR(50) = 'Troca123';
DECLARE @senhaHash VARBINARY(64);
SET @senhaHash = HASHBYTES('SHA2_256', @senha);

-- Inserir usuários no banco de dados
INSERT INTO Usuarios (idUsuario, nome, email, senhaHash, status) VALUES
('G764AE9', 'Maria Clara Sousa Torres', 'maria.clara@example.com', @senhaHash, 'ativo'),
('G783GA4', 'Niuan Spolidorio Da Rocha Souza', 'niuan.spolidorio@example.com', @senhaHash, 'ativo'),
('G79JBF6', 'Gabriel Contatori de Assis', 'gabriel.contatori@example.com', @senhaHash, 'ativo'),
('G872EC9', 'Sabrina Aparecida V Da Silva', 'sabrina.silva@example.com', @senhaHash, 'ativo'),
('N3573A1', 'Matheus Rafael Da Silva Jesus', 'matheus.jesus@example.com', @senhaHash, 'ativo'),
('G71GEG3', 'Victor Hugo Rodrigues Barros Antunes', 'victor.antunes@example.com', @senhaHash, 'ativo');

INSERT INTO User_Permissao_Tem (fk_Usuarios_idUsuario, fk_Funcionalidade_idFuncionalidade) VALUES 
('G783GA4', 1),
('G764AE9', 1),
('G783GA4', 2),
('G79JBF6', 2),
('G783GA4', 3),
('N3573A1', 3),
('G783GA4', 4),
('G71GEG3', 4);

INSERT INTO Fornecedores (cnpj, nome, razaoSocial, telefone1, telefone2, email, status, tipo, infAdicionais, endereco, numeroEndereco, bairro, cidade, estado, pais, cep) VALUES
('12345678000195', 'Fazenda Verde', 'Agronegócios Fazenda Verde Ltda', '11-98765-4321', '11-98888-8888', 'contato@fazendaverde.com', 'ativo', 'Produtor', NULL, 'Rua das Flores', 123, 'Jardim das Plantas', 'São Paulo', 'SP', 'Brasil', '01234-567'),
('98765432000107', 'Hortifruti Natural', 'Hortifruti Natural Ltda', '21-97654-3210', '21-97654-3210', 'contato@hortifrutinhatural.com', 'ativo', 'Distribuidor', 'Entregas diárias', 'Avenida Verde', 456, 'Centro', 'Rio de Janeiro', 'RJ', 'Brasil', '02345-678'),
('45678912000145', 'Sementes do Brasil', 'Sementes do Brasil Ltda', '31-98765-4321', '31-98888-8888', 'contato@sementesbrasil.com', 'ativo', 'Fornecedor', 'Sementes orgânicas', 'Rua das Sementes', 789, 'Vila Verde', 'Belo Horizonte', 'MG', 'Brasil', '03456-789');

INSERT INTO Insumo (idInsumo, nomeInsumo, quantidadeInsumo, validade, dataValidade, idFornecedor) VALUES
(1, 'Fertilizante Orgânico', 100, 'Disponivel', '2025-12-31', '12345678000195'),
(2, 'Agrotóxico Natural', 50, 'Disponivel', '2024-06-30', '98765432000107'),
(3, 'Semente de Tomate', 200, 'Disponivel', '2024-05-15', '45678912000145'),
(4, 'Semente de Alface', 150, 'Disponivel', '2024-07-20', '45678912000145'),
(5, 'Semente de Morango', 300, 'Disponivel', '2024-08-10', '12345678000195');

INSERT INTO Producao (dataInicio, dataFim, produto, statusProducao) VALUES
('2024-01-10', '2024-04-15', 'Tomate', 'Ativa'),
('2024-02-15', '2024-05-20', 'Alface', 'Ativa'),
('2024-03-01', '2024-06-01', 'Morango', 'Ativa'),
('2024-04-01', '2024-07-10', 'Cenoura', 'Cancelada'),
('2024-05-15', '2024-08-30', 'Pimentão', 'Ativa');

INSERT INTO InsumoProducao (idInsumo, idPlantio, quantidade) VALUES
(1, 1, 10),
(2, 2, 5),
(3, 1, 20),
(4, 3, 15),
(5, 5, 25); 

INSERT INTO Produto (idProduto, nomeProduto, categoria) VALUES
(1, 'Tomate Cereja', 'Vegetal'),
(2, 'Alface', 'Vegetal'),
(3, 'Manjericão', 'Erva'),
(4, 'Morango', 'Fruta'),
(5, 'Rúcula', 'Vegetal'),
(6, 'Cebolinha', 'Erva'),
(7, 'Pimentão', 'Vegetal'),
(8, 'Espinafre', 'Vegetal'),
(9, 'Cenoura', 'Vegetal'),
(10, 'Pepino', 'Vegetal');

INSERT INTO Lote (idProduto, quantidade, idProducao, status, dataValidade) VALUES
(1, 50, 1, 'disponível', '2025-01-01'),
(2, 30, 2, 'disponível', '2025-02-01'),
(3, 40, 3, 'disponível', '2025-03-01'),
(4, 20, 4, 'esgotado', '2024-01-01'),
(5, 10, 5, 'disponível', '2025-04-01');

INSERT INTO Cliente (idCliente,nome, telefone1, telefone2, cnpj, ie, email, numeroEndereco, nomeEndereco, bairro, cidade, estado, cep, clienteTipo, statusCliente) 
VALUES
(1,'Supermercado Verde', '11-91234-5678', '11-91234-5678', '12345678000195', 'IE123456', 'contato@supermercadoverde.com', 100, 'Rua do Comércio', 'Centro', 'São Paulo', 'SP', '01000-000', 'Jurídico', 'Ativo'),
(2,'Empório Natural', '21-92345-6789', NULL, '98765432000107', NULL, 'contato@emporionatural.com', 200, 'Avenida da Saúde', 'Bela Vista', 'Rio de Janeiro', 'RJ', '02000-000', 'Jurídico', 'Ativo'),
(3,'Supermercado do Povo', '31-93456-7890', '31-93456-7891', '45678912000145', NULL, 'contato@supermercadodopovo.com', 300, 'Rua da Amizade', 'Jardim Botânico', 'Belo Horizonte', 'MG', '03000-000', 'Jurídico', 'Ativo'),
(4,'Distribuidora de Alimentos Boa Sorte', '41-94456-7890', '41-94456-7891', '11223344000190', NULL, 'contato@boasorte.com', 400, 'Rua da Esperança', 'Centro', 'Curitiba', 'PR', '04000-000', 'Jurídico', 'Ativo'),
(5,'Ana Paula Silva', '11-91234-5678', '11-92234-5678', NULL, NULL, 'anapaula@exemplo.com', 101, 'Rua das Flores', 'Jardim Primavera', 'São Paulo', 'SP', '01100-000', 'Físico', 'Ativo'),
(6,'Carlos Alberto Santos', '21-92345-6789', NULL, NULL, NULL, 'carlos@exemplo.com', 202, 'Avenida dos Anjos', 'Centro', 'Rio de Janeiro', 'RJ', '02100-000', 'Físico', 'Ativo');

INSERT INTO Vendas (numero, infoAdicionais, idCliente, statusVenda) 
VALUES 
('VEN001', 'Venda de produtos frescos', 1, 'Em andamento'),
('VEN002', 'Compra de produtos orgânicos', 2, 'Entregue'),
('VEN003', 'Pedido de frutas e verduras', 3, 'Cancelado'),
('VEN004', 'Venda de cereais', 4, 'Em andamento'),
('VEN005', 'Pedido de produtos de limpeza', 5, 'Entregue'),
('VEN006', 'Venda de produtos para Ana Paula', 6, 'Em andamento');

INSERT INTO Itens_Venda (idVenda, idLote, quantidade, valor_total)
VALUES
(1, 1, 10, 150.00), 
(2, 2, 5, 250.00), 
(3, 3, 20, 500.00), 
(4, 4, 15, 750.00), 
(5, 1, 30, 900.00), 
(6, 2, 10, 1200.00);

-- Excluir tudo: 

USE CityGreen;

-- Desativar todas as foreign keys
DECLARE @sql NVARCHAR(MAX) = N'';

SELECT @sql += 'ALTER TABLE ' + QUOTENAME(OBJECT_NAME(parent_object_id)) + ' NOCHECK CONSTRAINT ALL; '
FROM sys.foreign_keys;

EXEC sp_executesql @sql;

-- Deletar todos os registros das tabelas
DELETE FROM Itens_Venda;
DELETE FROM Vendas;
DELETE FROM User_Permissao_Tem;
DELETE FROM Funcionalidade;
DELETE FROM InsumoProducao;
DELETE FROM Producao;
DELETE FROM Insumo;
DELETE FROM Lote;
DELETE FROM Produto;
DELETE FROM Fornecedores;
DELETE FROM Cliente;
DELETE FROM Usuarios;

-- Dropar as triggers
IF OBJECT_ID('trg_UpdateInsumoValidade', 'TR') IS NOT NULL
    DROP TRIGGER trg_UpdateInsumoValidade;
IF OBJECT_ID('trg_UpdateLoteValidade', 'TR') IS NOT NULL
    DROP TRIGGER trg_UpdateLoteValidade;
IF OBJECT_ID('trg_SubtractInsumoQuantity', 'TR') IS NOT NULL
    DROP TRIGGER trg_SubtractInsumoQuantity;
IF OBJECT_ID('trg_AddInsumoQuantityOnCancel', 'TR') IS NOT NULL
    DROP TRIGGER trg_AddInsumoQuantityOnCancel;
IF OBJECT_ID('trg_SubtractLoteQuantity', 'TR') IS NOT NULL
    DROP TRIGGER trg_SubtractLoteQuantity;
IF OBJECT_ID('trg_AddLoteQuantityOnCancel', 'TR') IS NOT NULL
    DROP TRIGGER trg_AddLoteQuantityOnCancel;

-- Dropar as tabelas na ordem correta
DROP TABLE IF EXISTS Itens_Venda;
DROP TABLE IF EXISTS Vendas;
DROP TABLE IF EXISTS InsumoProducao;
DROP TABLE IF EXISTS Producao;
DROP TABLE IF EXISTS Lote;
DROP TABLE IF EXISTS Insumo;
DROP TABLE IF EXISTS Fornecedores;
DROP TABLE IF EXISTS User_Permissao_Tem;
DROP TABLE IF EXISTS Usuarios;
DROP TABLE IF EXISTS Funcionalidade;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Produto;

-- Reativar todas as foreign keys
SET @sql = N'';

SELECT @sql += 'ALTER TABLE ' + QUOTENAME(OBJECT_NAME(parent_object_id)) + ' CHECK CONSTRAINT ALL; '
FROM sys.foreign_keys;

EXEC sp_executesql @sql;