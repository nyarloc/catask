CREATE TABLE [dbo].[tasks]
(
	[uid] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [description] NVARCHAR(256) NULL, 
    [open_date] DATETIME NOT NULL, 
    [close_date] DATETIME NULL, 
    [parent] UNIQUEIDENTIFIER NULL, 
    [priority] TINYINT NOT NULL , 
    [points] SMALLINT NOT NULL, 
    [name] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_tasks_to_tasks] FOREIGN KEY ([parent]) REFERENCES [tasks]([uid])
)
