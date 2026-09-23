CREATE TABLE [dbo].[classi] (
    [Id]      INT       IDENTITY (1, 1) NOT NULL,
    [numero]  INT       NULL,
    [sezione] NCHAR (1) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[alunni] (
    [matricola]  NCHAR (6)  NOT NULL,
    [codClasse]  INT        NOT NULL,
    [cognome]    NCHAR (20) NULL,
    [nome]       NCHAR (20) NULL,
    [dataN]      DATE       NULL,
    [cittaN]     NCHAR (20) NULL,
    [cittaR]     NCHAR (20) NULL,
    [indirizzoR] NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([matricola] ASC),
    CONSTRAINT [FK_Alunni_Classi] FOREIGN KEY ([codClasse]) REFERENCES [dbo].[classi] ([Id])
);

SET IDENTITY_INSERT [dbo].[classi] ON
INSERT INTO [dbo].[classi] ([Id], [numero], [sezione]) VALUES (1, 4, N'A')
INSERT INTO [dbo].[classi] ([Id], [numero], [sezione]) VALUES (2, 4, N'B')
INSERT INTO [dbo].[classi] ([Id], [numero], [sezione]) VALUES (3, 4, N'C')
INSERT INTO [dbo].[classi] ([Id], [numero], [sezione]) VALUES (4, 4, N'D')
INSERT INTO [dbo].[classi] ([Id], [numero], [sezione]) VALUES (5, 4, N'E')
SET IDENTITY_INSERT [dbo].[classi] OFF
