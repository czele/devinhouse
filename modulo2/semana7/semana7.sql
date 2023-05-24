CREATE TABLE dbo.Pessoas (
	id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nome VARCHAR(80) NOT NULL,
	sobrenome VARCHAR(80) NOT NULL,
)

CREATE TABLE dbo.Materia (
	id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nome VARCHAR(80) NOT NULL,
)

CREATE TABLE dbo.Materia_Pessoa (
	id INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	id_Materia INT,
	id_Pessoas INT,
	CONSTRAINT fk_Materia_Pessoas FOREIGN KEY (id_Materia) REFERENCES Materia(id),
	CONSTRAINT fk_Pessoas_Materia FOREIGN KEY (id_Pessoas) REFERENCES Pessoas(id),
)

INSERT INTO dbo.Materia_Pessoa VALUES (null, 2);
SELECT id, id_Materia, id_Pessoas FROM Audaces.dbo.Materia_Pessoa;
