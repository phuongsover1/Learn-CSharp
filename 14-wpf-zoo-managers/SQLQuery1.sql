--select a.Id, a.Name from Zoo_Animal za, (select * from Animal) a where za.ZooId = 5 and za.AnimalId = a.Id 
--select a.Name from (select ZooId,AnimalId from Zoo_Animal) za, Animal a where za.ZooId = 4 and za.AnimalId = a.Id;

select * from Animal a Where a.Id NOT IN (select AnimalId from Zoo_Animal where ZooId = 1)