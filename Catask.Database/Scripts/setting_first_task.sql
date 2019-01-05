IF not (EXISTS(SELECT * FROM [dbo].[tasks]))  
BEGIN  
    declare @main_task_uid uniqueidentifier = newid();
	insert into tasks ([uid], open_date, points, [priority], [description])
	  values (@main_task_uid, getdate(), 10, 3, 'Это первая задача');
	insert into tasks ([uid], open_date, points, [priority], [description], parent)
	  values (newid(), getdate(), 10, 3, 'Это этап задачи', @main_task_uid);
END  