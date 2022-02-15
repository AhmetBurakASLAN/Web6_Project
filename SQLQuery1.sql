--CREATE DATABASE sRehber
use sRehber
CREATE TABLE tblKisiler
(
ID INT IDENTITY(1,1),
Ad VARCHAR(20) NOT NULL,
Soyad VARCHAR(20) NOT NULL,
Cinsiyet CHAR NOT NULL,
Tlefon NCHAR(11) NOT NULL,
PRIMARY KEY(ID)
)
INSERT INTO tblKisiler
VALUES
		('Haluk','Levent','E','05554325566'),
		('Seren','Günaçtı','K','05323211022'),
		('Kemal','Kalbul','E','05439802111'),
		('Saide','Kül','K','05352453987'),
		('Mahir','Çakmak','E','05534550404'),
		('Canan','Solak','K','05056549876')
