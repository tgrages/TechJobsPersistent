--Part 1
SELECT * 
FROM techjobs.jobs;

--Part 2
SELECT Name
FROM techjobs.employers
WHERE Location = "St. Louis City";
--Part 3
SELECT * FROM Skills
	LEFT JOIN jobSkills ON Skills.Id = JobSkills.SkillId
	WHERE JobSkills.JobID IS NOT NULL
	ORDER BY name ASC;
