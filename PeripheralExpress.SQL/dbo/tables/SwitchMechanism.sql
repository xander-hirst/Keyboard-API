CREATE TABLE [dbo].[SwitchMechanism]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, [Mechanism] VARCHAR(20) NOT NULL
)
GO

CREATE INDEX [IX_SwitchMechanism_Id] ON [dbo].[SwitchMechanism]([Id])
GO
