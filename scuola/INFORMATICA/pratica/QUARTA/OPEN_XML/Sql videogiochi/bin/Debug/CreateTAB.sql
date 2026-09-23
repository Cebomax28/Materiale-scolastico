CREATE TABLE [dbo].[Giocatori] (
    [IdGiocatore] INT            IDENTITY (1, 1) NOT NULL,
    [Nome]        NVARCHAR (50)  NOT NULL,
    [Cognome]     NVARCHAR (50)  NOT NULL,
    [Nickname]    NVARCHAR (30)  NOT NULL,
    [Email]       NVARCHAR (100) NULL,
    [DataNascita] DATE           NULL,
    PRIMARY KEY CLUSTERED ([IdGiocatore] ASC),
    UNIQUE NONCLUSTERED ([Nickname] ASC)
);


CREATE TABLE [dbo].[Giochi] (
    [IdGioco]         INT            IDENTITY (1, 1) NOT NULL,
    [Titolo]          NVARCHAR (100) NOT NULL,
    [Categoria]       NVARCHAR (50)  NOT NULL,
    [CasaProduttrice] NVARCHAR (50)  NULL,
    [AnnoUscita]      INT            NULL,
    PRIMARY KEY CLUSTERED ([IdGioco] ASC)
);

CREATE TABLE [dbo].[Partite] (
    [IdPartita]   INT  IDENTITY (1, 1) NOT NULL,
    [IdGiocatore] INT  NOT NULL,
    [IdGioco]     INT  NOT NULL,
    [DataPartita] DATE NOT NULL,
    [Punteggio]   INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([IdPartita] ASC),
    FOREIGN KEY ([IdGiocatore]) REFERENCES [dbo].[Giocatori] ([IdGiocatore]),
    FOREIGN KEY ([IdGioco]) REFERENCES [dbo].[Giochi] ([IdGioco])
);

