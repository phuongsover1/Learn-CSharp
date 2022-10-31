--select a.Id, a.Name from Zoo_Animal za, (select * from Animal) a where za.ZooId = 5 and za.AnimalId = a.Id 
--select a.Name from (select ZooId,AnimalId from Zoo_Animal) za, Animal a where za.ZooId = 4 and za.AnimalId = a.Id;

--select * from Animal a Where a.Id NOT IN (select AnimalId from Zoo_Animal where ZooId = 1)

--alter table Zoo_Animal
----drop constraint fk_ZooAnimal_Anima;
--drop constraint FK_ZooAnimal_Zoo

--alter table Zoo_Animal
--add constraint FK_ZooAnimal_Zoo foreign key (ZooId) references Zoo(Id) on delete cascade
--add constraint FK_ZooAnimal_Animal foreign key (AnimalId) references Animal(Id) on delete cascade

--delete from Zoo where Zoo.Id = ?
select * from Zoo_Animal
