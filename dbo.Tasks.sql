CREATE TABLE [dbo].[Task] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Description]    VARCHAR (255) NOT NULL,
    [AssignedTo]     NCHAR (50)    NOT NULL,  -- Change data type to match [Name] column of Users table
    [DueDate]        DATETIME      NOT NULL,
    [IsCompleted]    BIT           DEFAULT 0 NOT NULL,
    [CompletionTime] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AssignedTo]) REFERENCES [dbo].[Users] ([Name])  -- Change to reference [Name] column
);