--Part 1

select column_name,data_type from information_schema.columns 
where table_schema = 'techjobs' and table_name = 'Jobs';

Name - Longtext
Id - integer
EmployerId - Integer

--Part 2

SELECT * FROM Employers
WHERE Location = "St. Louis City";

--Part 3

SELECT DISTINCT(Name), Description FROM Skills
INNER JOIN JobSkills ON Skills.Id = JobSkills.SkillId
ORDER BY Name;

