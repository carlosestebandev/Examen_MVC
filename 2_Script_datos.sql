USE BD_PRUEBA_UPC_CARLOS_RAMOS
GO

INSERT INTO TB_ALUMNO
VALUES ('Alumno 1', 'Apellido 1'),
('Alumno 2', 'Apellido 2'),
('Alumno 3', 'Apellido 3'),
('Alumno 4', 'Apellido 4'),
('Alumno 5', 'Apellido 5'),
('Alumno 6', 'Apellido 6'),
('Alumno 7', 'Apellido 7'),
('Alumno 8', 'Apellido 8'),
('Alumno 9', 'Apellido 9'),
('Alumno 10', 'Apellido 10'),
('Alumno 11', 'Apellido 11'),
('Alumno 12', 'Apellido 12'),
('Alumno 13', 'Apellido 13'),
('Alumno 13', 'Apellido 14'),
('Alumno 15', 'Apellido 15'),
('Alumno 16', 'Apellido 16'),
('Alumno 17', 'Apellido 17'),
('Alumno 18', 'Apellido 18'),
('Alumno 19', 'Apellido 19'),
('Alumno 20', 'Apellido 20'),
('Alumno 21', 'Apellido 21'),
('Alumno 22', 'Apellido 22'),
('Alumno 23', 'Apellido 23'),
('Alumno 23', 'Apellido 24'),
('Alumno 25', 'Apellido 25'),
('Alumno 26', 'Apellido 26'),
('Alumno 27', 'Apellido 27'),
('Alumno 28', 'Apellido 28'),
('Alumno 29', 'Apellido 29'),
('Alumno 30', 'Apellido 30')
GO

INSERT INTO TB_CURSO
VALUES ('Curso 1', 'Descripcion 1',1,1),
('Curso 2', 'Descripcion 2',1,1),
('Curso 3', 'Descripcion 3',1,1),
('Curso 4', 'Descripcion 4',3,1),
('Curso 5', 'Descripcion 5',1,1),
('Curso 6', 'Descripcion 6',4,1),
('Curso 7', 'Descripcion 7',1,1),
('Curso 8', 'Descripcion 8',2,1),
('Curso 9', 'Descripcion 9',1,1),
('Curso 10', 'Descripcion 10',3,1),
('Curso 11', 'Descripcion 11',1,1),
('Curso 12', 'Descripcion 12',3,1),
('Curso 13', 'Descripcion 13',1,1),
('Curso 14', 'Descripcion 14',2,1),
('Curso 15', 'Descripcion 15',2,1),
('Curso 16', 'Descripcion 16',5,1),
('Curso 17', 'Descripcion 17',3,1),
('Curso 18', 'Descripcion 18',2,1),
('Curso 19', 'Descripcion 19',1,0),
('Curso 20', 'Descripcion 20',1,0)
GO

INSERT INTO TB_SOLICITUD
VALUES (1,getdate(),'RGR11111','Carrera 1','2022-2')
GO

INSERT INTO TB_DETALLE_SOLICITUD
VALUES (1,1,'Nombre Profesor', 'Aula 1', 'Sede 2', 'Obs')
GO