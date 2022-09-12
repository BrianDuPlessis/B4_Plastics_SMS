CREATE TABLE [dbo].[Pipe_Details] (
    [pipe_id]       INT IDENTITY (1, 1) NOT NULL,
    [colour_id]     INT NOT NULL,
    [size_id]       INT NOT NULL,
    [pipe_quantity] INT NULL,
    PRIMARY KEY CLUSTERED ([pipe_id] ASC),
    CONSTRAINT [FK_Pipe_Details_Cokours] FOREIGN KEY ([colour_id]) REFERENCES [dbo].[Colours] ([colour_id]),
    CONSTRAINT [FK_Pipe_Details_Pipe Size] FOREIGN KEY ([size_id]) REFERENCES [dbo].[Pipe Size] ([size_id])
);

