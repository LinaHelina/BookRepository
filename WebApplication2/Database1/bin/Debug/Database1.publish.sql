/*
Скрипт развертывания для Database1

Этот код был создан программным средством.
Изменения, внесенные в этот файл, могут привести к неверному выполнению кода и будут потеряны
в случае его повторного формирования.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Database1"
:setvar DefaultFilePrefix "Database1"
:setvar DefaultDataPath "E:\Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "E:\Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Проверьте режим SQLCMD и отключите выполнение скрипта, если режим SQLCMD не поддерживается.
Чтобы повторно включить скрипт после включения режима SQLCMD выполните следующую инструкцию:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Для успешного выполнения этого скрипта должен быть включен режим SQLCMD.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Операция рефакторинга Rename с помощью ключа df48664d-638d-4393-8830-dd0119f5452c пропущена, элемент [dbo].[Products].[Id] (SqlSimpleColumn) не будет переименован в ProductId';


GO
PRINT N'Идет создание Таблица [dbo].[Products]…';


GO
CREATE TABLE [dbo].[Products] (
    [ProductId]       INT             NOT NULL,
    [ProductName]     NVARCHAR (50)   NOT NULL,
    [ProductPrice]    DECIMAL (18, 2) NOT NULL,
    [ProductImageUrl] NVARCHAR (MAX)  NOT NULL,
    [ProductAuthor]   NVARCHAR (50)   NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);


GO
-- Выполняется этап рефакторинга для обновления развернутых журналов транзакций на целевом сервере

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'df48664d-638d-4393-8830-dd0119f5452c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('df48664d-638d-4393-8830-dd0119f5452c')

GO

GO
PRINT N'Обновление завершено.';


GO
