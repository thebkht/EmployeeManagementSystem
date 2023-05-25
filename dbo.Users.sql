CREATE TABLE [dbo].[User] (
    [Id]               INT         NOT NULL,
    [Username]         NCHAR (50)  NOT NULL,
    [Password]         NCHAR (100) NOT NULL,
    [Name]             NCHAR (50)  NOT NULL,
    [HourlyRate]       MONEY       NOT NULL,
    [CompletedTasks]   INT         DEFAULT ((0)) NOT NULL,
    [UncompletedTasks] INT         DEFAULT ((0)) NOT NULL,
    [IsEmployee]       BIT         DEFAULT ((0)) NOT NULL,
    [IsAdmin]          BIT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
	UNIQUE NONCLUSTERED ([Username] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

