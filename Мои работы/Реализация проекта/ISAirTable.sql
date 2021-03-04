create database ISAir
use ISAir

create table LichnieDannie(
	ID int primary key identity,
	Family nvarchar(max) not null,
	Imy nvarchar(max) not null,
	Otchestvo nvarchar(max) null
);

create table Doljnost(
	ID int primary key identity,
	Naimenovanie nvarchar(max)
);

create table Klient(
	ID int primary key identity,
	Email varchar(255) not null,
	Password varchar(30) not null,
	Telefon nvarchar(30) null,
	NomerCarti nvarchar(30) null,
	IDLichnieDannie int not null,
	foreign key (IDLichnieDannie) references LichnieDannie (ID)
);

create table Sotrudnik(
	ID int primary key identity,
	Email varchar(255) not null,
	Password varchar(30) not null,
	IDLichnieDannie int not null,
	foreign key (IDLichnieDannie) references LichnieDannie (ID),
	IDDoljnost int not null,
	foreign key (IDDoljnost) references Doljnost (ID)
);

create table Samolet(
	ID int primary key identity,
	Naimenovanie nvarchar(max),
	KolVoMest int not null,
	KolVoEkipaja int not null
);

create table Reis(
	ID int primary key identity,
	MestoVilita nvarchar(max) not null,
	MestoPribitya nvarchar(max) not null,
	DateVileta datetime not null,
	Czena float(2)not null,
	IDSamolet int not null,
	foreign key (IDSamolet) references Samolet (ID)
);

create table Bilet(
	ID int primary key identity,
	DateVormirovaniya datetime not null,
	Summa float(2) not null,
	IDKlient int not null,
	foreign key (IDKlient) references Klient (ID),
	IDReis int not null,
	foreign key (IDReis) references Reis (ID)
);

select 
	LichnieDannie.Family as [Фамилия],
	LichnieDannie.Imy as [Имя],
	LichnieDannie.Otchestvo as [Отчество],
	Sotrudnik.Email as [Почта],
	Sotrudnik.Password as [Пароль],
	Doljnost.Naimenovanie as [Должность]
from Sotrudnik
	left join LichnieDannie on Sotrudnik.IDLichnieDannie = LichnieDannie.ID
	left join Doljnost on Sotrudnik.IDDoljnost = Doljnost.ID


insert into Doljnost(Naimenovanie) values
('Администратор'),
('Борт-проводник'),
('Пилот'),
('Менеджер полётов')

insert into LichnieDannie(Family, Imy, Otchestvo) values
('Иванов', 'Иван', 'Иванович')
insert into Sotrudnik(Email, Password, IDLichnieDannie, IDDoljnost) values
('admin', '123', (select top (1) ID from LichnieDannie order by ID desc), 1)

insert into Samolet(Naimenovanie, KolVoMest, KolVoEkipaja) values
('Боинг-13', 666, 13),
('Боинг-3', 137, 3)

insert into Bilet(DateVormirovaniya, Summa, IDKlient, IDReis) values
(getdate(), 13000, 1, 1)

--select
--	Reis.MestoVilita as [Откуда],
--	Reis.MestoPribitya as [Куда],
--	Reis.DateVileta as [Дата вылета],
--	LichnieDannie.Family as [Фамилия],
--	LichnieDannie.Imy as [Имя],
--	Bilet.Summa as [Стоимость],
--	Bilet.DateVormirovaniya as [Дата оформления]
--from Bilet
--	left join Klient on Bilet.IDKlient = Klient.ID
--	left join LichnieDannie on Klient.IDLichnieDannie = LichnieDannie.ID
--	left join Reis on Bilet.IDReis = Reis.ID

--select
--	LichnieDannie.Family as [Family],
--	LichnieDannie.Imy as [Imy],
--	LichnieDannie.Otchestvo as [Otchestvo]
--from Klient
--	left join LichnieDannie on Klient.IDLichnieDannie = LichnieDannie.ID
--where Klient.ID=1

--select
--	Reis.MestoVilita as [Откуда],
--	Reis.MestoPribitya as [Куда],
--	Reis.DateVileta as [Когда],
--	Reis.Czena as [Стоимость],
--	Samolet.Naimenovanie as [Самолёт]
--from Reis
--	left join Samolet on Reis.IDSamolet = Samolet.ID
