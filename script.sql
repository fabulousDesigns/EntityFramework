IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Books] (
    [BookId] int NOT NULL IDENTITY,
    [Title] nvarchar(50) NULL,
    [ISBN] nvarchar(13) NULL,
    [Price] float NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY ([BookId])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250304084527_AddBookModel', N'9.0.2');

DECLARE @var sysname;
SELECT @var = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'Price');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var + '];');
ALTER TABLE [Books] ALTER COLUMN [Price] decimal(18,5) NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250304091051_ChangePriceColumnToDecimalInBooksTable', N'9.0.2');

CREATE TABLE [Genres] (
    [GenreId] int NOT NULL IDENTITY,
    [GenreName] nvarchar(50) NULL,
    [Display] int NOT NULL,
    CONSTRAINT [PK_Genres] PRIMARY KEY ([GenreId])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250304091540_AddGenre', N'9.0.2');

EXEC sp_rename N'[Genres].[Display]', N'DisplayOrder', 'COLUMN';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250304092227_RenameDisplayColumnInGenre', N'9.0.2');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250304092423_NoChangeMigration', N'9.0.2');

DROP TABLE [Genres];

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250304092627_RemoveGenreTable', N'9.0.2');

COMMIT;
GO

