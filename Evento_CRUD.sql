USE EventosEmpresariais;
GO

-- =============================================
-- CRUD - Tabela dbo.Evento
-- Colunas: IdEvento (int), Nome (nvarchar(100)), Data (date), Local (nvarchar(100))
-- =============================================

-- =============================================
-- SP: Inserir Evento
-- =============================================
IF OBJECT_ID('dbo.spInserirEvento', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spInserirEvento;
GO

CREATE PROCEDURE dbo.spInserirEvento
    @Nome  NVARCHAR(100),
    @Data  DATE,
    @Local NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Evento (Nome, Data, Local)
    VALUES (@Nome, @Data, @Local);

    SELECT SCOPE_IDENTITY() AS IdEvento;
END
GO

-- =============================================
-- SP: Listar Eventos
-- =============================================
IF OBJECT_ID('dbo.spListarEventos', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spListarEventos;
GO

CREATE PROCEDURE dbo.spListarEventos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdEvento,
        Nome,
        Data,
        Local
    FROM dbo.Evento
    ORDER BY Data DESC, Nome ASC;
END
GO

-- =============================================
-- SP: Atualizar Evento
-- =============================================
IF OBJECT_ID('dbo.spAtualizarEvento', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spAtualizarEvento;
GO

CREATE PROCEDURE dbo.spAtualizarEvento
    @IdEvento INT,
    @Nome     NVARCHAR(100),
    @Data     DATE,
    @Local    NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Evento
    SET
        Nome  = @Nome,
        Data  = @Data,
        Local = @Local
    WHERE IdEvento = @IdEvento;
END
GO

-- =============================================
-- SP: Eliminar Evento
-- =============================================
IF OBJECT_ID('dbo.spEliminarEvento', 'P') IS NOT NULL
    DROP PROCEDURE dbo.spEliminarEvento;
GO

CREATE PROCEDURE dbo.spEliminarEvento
    @IdEvento INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.Evento
    WHERE IdEvento = @IdEvento;
END
GO
