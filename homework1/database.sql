-- CREATE DATABASE homework1;
USE homework1; 
CREATE TABLE IF NOT EXISTS City
(
    id INT PRIMARY KEY AUTO_INCREMENT,
    `Name` VARCHAR(20)
);
CREATE TABLE IF NOT EXISTS Users
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	`Name` VARCHAR(20),
	Email VARCHAR(30),
	Phone VARCHAR(15),
	City_id INT,
	FOREIGN KEY (City_id) REFERENCES City (Id)
 );
INSERT City (Name)
VALUES ('London'), ('Paris'), ('Capetown'), ('Washington D.C'), ('Saint-Petersburg');
INSERT Users(`Name`, Email, Phone, City_id)
VALUES
('Georgy Ivanov', 'georgiv@mail.com', '+7312893791', 3),
('Josh Bulkin','bulkin@mail.com', '+31289379812', 1),
('Huban Kusha', 'kusha@mail.com', '+2897419391', 2),
('Yoshki Matoro', 'matoro@mail.com','+92749871124', 5),
('Nwiwawa Wianata', 'wianata@mail.com', '+3274897298', 4),
('Jew Natural', 'fakemail@mail.com', '+723894712', 1),
('Gerard Alberto', 'galberto@mail.com', '+3982479832',2),
('Kimot Haapasalo', 'haapasalo@mail.com', '+56904809219',4),
('Andrew Marshall', 'marshall@mail.com', '+9349723947234',3),
('Huwan Nawanai', 'nawanai@mail.com', '+83428643202',5);