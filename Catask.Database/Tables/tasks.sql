CREATE TABLE [dbo].[tasks]
(
	[uid] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [description] NVARCHAR(256) NOT NULL, 
    [open_date] DATETIME NOT NULL, 
    [close_date] DATETIME NULL, 
    [parent] UNIQUEIDENTIFIER NULL, 
    [priority] TINYINT NOT NULL , 
    [points] SMALLINT NOT NULL, 
    CONSTRAINT [FK_tasks_to_priorities] FOREIGN KEY ([priority]) REFERENCES [priorities]([id])
)
