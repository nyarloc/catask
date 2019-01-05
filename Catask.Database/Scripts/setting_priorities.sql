IF not (EXISTS(SELECT * FROM [dbo].[priorities]))  
BEGIN  
    insert into priorities(id, [name])
	  values (0, 'Нужно вчера');
    insert into priorities(id, [name])
	  values (1, 'Горит');
    insert into priorities(id, [name])
	  values (2, 'Важно');
    insert into priorities(id, [name])
	  values (3, 'Обычная');
	insert into priorities(id, [name])
	  values (4, 'Подождет');
	insert into priorities(id, [name])
	  values (255, 'Не задан');
END  
IF (SELECT id from priorities where id = 255) is null
  insert into priorities(id, [name])
	  values (255, 'Не задан');