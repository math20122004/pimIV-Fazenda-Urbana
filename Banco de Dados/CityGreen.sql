CREATE DATABASE CityGreen;

USE CityGreen;

-- Tabela de Funcionalidades
CREATE TABLE Funcionalidade (
    idFuncionalidade INT IDENTITY(1,1) PRIMARY KEY,
    nome NVARCHAR(100)
);

-- Tabela de Usuários
CREATE TABLE Usuarios (
    idUsuario NVARCHAR(8) PRIMARY KEY NOT NULL,
    nome NVARCHAR(255),
    email NVARCHAR(100),
    senhaHash VARBINARY(64),
    status NVARCHAR(10) CHECK (status IN ('ativo', 'inativo')) DEFAULT 'ativo'
);

-- Tabela de Permissões de Usuários
CREATE TABLE User_Permissao_Tem (
    fk_Usuarios_idUsuario NVARCHAR(8),
    fk_Funcionalidade_idFuncionalidade INT,
    criar BIT,
    leitura BIT,
    modificacao BIT,
    FOREIGN KEY (fk_Usuarios_idUsuario) REFERENCES Usuarios (idUsuario),
    FOREIGN KEY (fk_Funcionalidade_idFuncionalidade) REFERENCES Funcionalidade (idFuncionalidade)
);

-- Tabela de Fornecedores
CREATE TABLE Fornecedores (
    idFornecedor INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nome NVARCHAR(255),
    razaoSocial NVARCHAR(255),
    cnpj CHAR(14),
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

-- Tabela de Insumos
CREATE TABLE Insumo (
    idInsumo INT PRIMARY KEY,
    nomeInsumo NVARCHAR(255),
    statusInsumo NVARCHAR(10) CHECK (statusInsumo IN ('ativo', 'inativo')) DEFAULT 'ativo',
    quantidadeInsumo INT,
    id_fornecedor INT,
    validade NVARCHAR(10) CHECK (validade IN ('Vencido', 'Usavel')) DEFAULT 'Usavel',
    dataValidade DATE,
    FOREIGN KEY (id_fornecedor) REFERENCES Fornecedores (idFornecedor)
);

-- Tabela de Produção
CREATE TABLE Producao (
    idPlantio INT PRIMARY KEY,
    dataInicio DATE,
    dataFim DATE,
    produto NVARCHAR(255),
    statusProducao NVARCHAR(10) CHECK (statusProducao IN ('Ativa', 'Cancelada', 'Completa')) DEFAULT 'Ativa'
);

-- Tabela de Insumos utilizados na Produção
CREATE TABLE InsumoProducao (
    idInsumo INT,
    idPlantio INT,
    quantidade INT,
    FOREIGN KEY (idPlantio) REFERENCES Producao (idPlantio),
    FOREIGN KEY (idInsumo) REFERENCES Insumo (idInsumo)
);

-- Tabela de Lotes
CREATE TABLE Lote (
    idLote INT PRIMARY KEY,
    nomeProduto NVARCHAR(255),
    quantidade INT,
    idProducao INT,
    validade NVARCHAR(10) CHECK (validade IN ('Vencido', 'Usavel')) DEFAULT 'Usavel',
    dataValidade DATE,
    FOREIGN KEY (idProducao) REFERENCES Producao (idPlantio)
);

-- Tabela de Clientes
CREATE TABLE Cliente (
    idCliente INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nome NVARCHAR(255),
    telefone1 NVARCHAR(20),
    telefone2 NVARCHAR(20),
    cpf CHAR(14),
    rg CHAR(9),
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
CREATE TABLE Vendas (
    idVenda INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    numero NVARCHAR(30),
    infoAdicionais NVARCHAR(255),
    idCliente INT,
    statusVenda NVARCHAR(15) CHECK (statusVenda IN ('Cancelado', 'Entregue', 'Em andamento')) DEFAULT 'Em andamento',
    FOREIGN KEY (idCliente) REFERENCES Cliente (idCliente)
);

-- Tabela de Itens da Venda
CREATE TABLE Itens_Venda (
    quantidade INT,
    valor_total DECIMAL(9,2),
    lote INT,
    fk_Venda_idVenda INT,
    FOREIGN KEY (fk_Venda_idVenda) REFERENCES Vendas (idVenda),
    FOREIGN KEY (lote) REFERENCES Lote (idLote)
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
    SET validade = 'Vencido'
    WHERE dataValidade <= CAST(GETDATE() AS DATE)
      AND validade != 'Vencido';
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
    INNER JOIN inserted i ON Lote.idLote = i.lote;
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
        INNER JOIN Itens_Venda iv ON Lote.idLote = iv.lote
        INNER JOIN inserted i ON iv.fk_Venda_idVenda = i.idVenda
        WHERE i.statusVenda = 'Cancelado';
    END
END;

-- Procedimento Armazenado para Inserir Usuário
CREATE PROCEDURE uspAddUsuario
    @idUsuario NVARCHAR(8),
    @nome NVARCHAR(255),
    @pEmail NVARCHAR(100),
    @pSenha NVARCHAR(50),
    @status NVARCHAR(10) = 'ativo',
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO Usuarios (idUsuario, nome, email, senhaHash, status)
        VALUES (@idUsuario, @nome, @pEmail, HASHBYTES('SHA2_512', @pSenha), @status);
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

    -- Verifica a senha
    IF @senhaHash = HASHBYTES('SHA2_512', @pSenha)
    BEGIN
        SET @responseMessage = 'Autenticação bem-sucedida';
    END
    ELSE
    BEGIN
        SET @responseMessage = 'Falha na autenticação';
    END
END

-- Inserindo funcionalidades na tabela Funcionalidade
INSERT INTO Funcionalidade (nome) VALUES ('Fornecedores');
INSERT INTO Funcionalidade (nome) VALUES ('Vendas');
INSERT INTO Funcionalidade (nome) VALUES ('Produção');
INSERT INTO Funcionalidade (nome) VALUES ('Administrador');
