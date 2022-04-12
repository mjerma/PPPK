create database PPPK_Projekt
go

select *from Vozac

use PPPK_Projekt
go

create table Vozac (
	IDVozac int not null primary key identity,
	Ime nvarchar(50) not null,
	Prezime nvarchar(50) not null,
	BrojMobitela nvarchar(50) not null,
	BrojVozackeDozvole nvarchar(50) not null,
)
go

create table Vozilo (
	IDVozilo int not null primary key identity,
	Tip nvarchar(50) not null,
	Marka nvarchar(50) not null,
	GodinaProizvodnje int not null,
	PrijedeniKilometri int not null,
	JeSlobodno bit not null
)
go

create table PutniNalog (
	IDPutniNalog int not null primary key identity,
	Naredbodavac nvarchar(50),
	BrojNaloga int not null,
	VozacID int foreign key references Vozac(IDVozac) not null,
	VoziloID int foreign key references Vozilo(IDVozilo) not null,
	Polaziste nvarchar(50) not null,
	Odrediste nvarchar(50) not null,
	BrojDana int not null,
	DatumOtvaranja datetime not null,
	DatumZatvaranja datetime
)
go

create table Ruta (
	IDRuta int not null primary key identity,
	Sati int not null,
	KoordinataA float not null,
	KoordinataB float not null,
	PutniNalogID int foreign key references PutniNalog(IDPutniNalog) not null,
	PrijedeniKilometri int not null,
	ProsjecnaBrzina int not null,
	PotrosenoGorivo float not null
)
go

create table Servis (
	IDServis int not null primary key identity,
	Opis nvarchar(100) not null,
	Datum datetime not null,
	VoziloID int foreign key references Vozilo(IDVozilo) not null
)
go

create proc CleanDB 
as
begin
	EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' 
	EXEC sp_MSForEachTable 'DELETE FROM ?' 
	EXEC sp_MSForEachTable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL' 
	exec sp_MSforeachtable @command1 = 'DBCC CHECKIDENT(''?'', RESEED,0)'
end
go

create proc AddExampleRecords
as
begin
	insert into Vozac values
	('Pero', 'Peric', '12958125', '326236236'),
	('Maja', 'Majic', '62623326', '854834388'),
	('Josip', 'Josic', '436347437', '347347347'),
	('Mirta', 'Mirtic', '3473474', '457457227')


	insert into Vozilo values
	('Auto', 'Bmw', '2011', '20000',0),
	('Auto', 'Audi', '1999', '32362',0),
	('Auto', 'Mercedes', '2016', '500',0),
	('Auto', 'VW', '2018', '32523',0)

	insert into PutniNalog values
	('Ivan Ivic', '23', 1, 1, 'Zagreb', 'Rijeka', 2, '12-aug-2020', '14-aug-2020'),
	('Ivo Sanader', '15', 2, 2, 'Zagreb', 'Split', 9, '20-sep-2020', '28-sep-2020'),
	('Zdravko Mamic', '34', 3, 3, 'Pula', 'Varazdin', 4, '11-nov-2020', null),
	('Pero Peric', '34', 4, 4, 'Osijek', 'Varazdin', 3, '01-nov-2020', null)

	insert into Ruta values
	(2, 312, 231, 1, 1032, 120, 25),
	(4, 213, 287, 2, 1784, 120, 30)

	insert into Servis values
	('Remen', '20-sep-2020', 1),
	('Krpanje gume', '20-sep-2020', 1),
	('Random', '12-aug-2020', 3)
end
go

create proc GetVozaci
as
begin
	select * from Vozac
end
go

create proc GetVozila
as
begin
	select * from Vozilo
end
go

create proc GetVozilo
	@VoziloID int
as
begin
	select * from Vozilo
	where IDVozilo = @VoziloID
end
go

create proc GetPutniNalozi
as
begin
	select * from PutniNalog
end
go

create proc GetPutniNalogRute
	@PutniNalogID int
as
begin
	select *from Ruta
	where PutniNalogID = @PutniNalogID
end
go

create proc SelectRutaData
	@IDRuta int
as
begin
	select *from Ruta
	where IDRuta = @IDRuta
end
go

CREATE PROC GetAllDatabaseData
AS
BEGIN
	SELECT
		pn.IDPutniNalog,
		pn.Naredbodavac,
		pn.BrojNaloga,
		pn.Polaziste,
		pn.Odrediste,
		pn.BrojDana,
		pn.DatumOtvaranja,
		pn.DatumZatvaranja,
		v.IDVozac,
		v.Ime,
		v.Prezime,
		v.BrojMobitela,
		v.BrojVozackeDozvole,
		voz.IDVozilo,
		voz.Tip,
		voz.Marka,
		voz.GodinaProizvodnje,
		voz.PrijedeniKilometri,
		voz.JeSlobodno
	FROM
		PutniNalog as pn
	INNER JOIN Vozac as v
		on v.IDVozac = pn.VozacID
	INNER JOIN Vozilo as voz
		on voz.IDVozilo = pn.VoziloID
	ORDER BY pn.IDPutniNalog
END
GO

create proc AddVozac	
	@Ime nvarchar(50),
	@Prezime nvarchar(50),
	@BrojMobitela nvarchar(50),
	@BrojVozackeDozvole nvarchar(50),
	@VozacID int output
as
begin
	insert into Vozac values(@Ime, @Prezime, @BrojMobitela, @BrojVozackeDozvole)
	set @VozacID = SCOPE_IDENTITY()
end
go

create proc AddVozilo	
	@Tip nvarchar(50),
	@Marka nvarchar(50),
	@GodinaProizvodnje int,
	@PrijedeniKilometri int
as
begin
	insert into Vozilo values(@Tip, @Marka, @GodinaProizvodnje, @PrijedeniKilometri, 1)
end
go

create proc AddPutniNalog	
	@Naredbodavac nvarchar(50),
	@BrojNaloga nvarchar(50),
	@VozacID int,
	@VoziloID int,
	@Polaziste nvarchar(50),
	@Odrediste nvarchar(50),
	@BrojDana int,
	@DatumOtvaranja datetime,
	@DatumZatvaranja datetime,
	@PutniNalogID int output
as
begin
	insert into PutniNalog 
	values(@Naredbodavac, @BrojNaloga, @VozacID, @VoziloID, @Polaziste, @Odrediste, @BrojDana, @DatumOtvaranja, @DatumZatvaranja)
	set @PutniNalogID = SCOPE_IDENTITY()

	update Vozilo set
		JeSlobodno = 0
	where IDVozilo = @VoziloID

end
go

create proc AddRuta	
	@Sati int,
	@KoordinataA float,
	@KoordinataB float,
	@PutniNalogID int,
	@PrijedeniKilometri int,
	@ProsjecnaBrzina int, 
	@PotrosenoGorivo float
as
begin
	insert into Ruta values(@Sati, @KoordinataA, @KoordinataB, @PutniNalogID, @PrijedeniKilometri, @ProsjecnaBrzina, @PotrosenoGorivo)
end
go

create proc UpdateVozac	
	@VozacID int,
	@Ime nvarchar(50),
	@Prezime nvarchar(50),
	@BrojMobitela nvarchar(50),
	@BrojVozackeDozvole nvarchar(50)
as
begin
	update Vozac set
		Ime = @Ime,
		Prezime = @Prezime,
		BrojMobitela = @BrojMobitela,
		BrojVozackeDozvole = @BrojVozackeDozvole
	where 
		IDVozac = @VozacID
end
go

create proc UpdatePutniNalog	
	@PutniNalogID int,
	@Naredbodavac nvarchar(50),
	@BrojNaloga nvarchar(50),
	@VozacID int,
	@VoziloID int,
	@Polaziste nvarchar(50),
	@Odrediste nvarchar(50),
	@BrojDana int,
	@DatumOtvaranja datetime,
	@DatumZatvaranja datetime
as
begin
	update PutniNalog set
		Naredbodavac = @Naredbodavac,
		BrojNaloga = @BrojNaloga,
		VozacID = @VozacID,
		VoziloID = @VoziloID,
		Polaziste = @Polaziste,
		Odrediste = @Odrediste,
		BrojDana = @BrojDana,
		DatumOtvaranja = @DatumOtvaranja,
		DatumZatvaranja = @DatumZatvaranja
	where 
		IDPutniNalog = @PutniNalogID
	update Vozilo set
		JeSlobodno = 1
	where IDVozilo = @VoziloID
end
go

create proc UpdateRuta	
	@IDRuta int,
	@Sati int,
	@KoordinataA float,
	@KoordinataB float,
	@PutniNalogID int,
	@PrijedeniKilometri int,
	@ProsjecnaBrzina int, 
	@PotrosenoGorivo float
as
begin
	update Ruta set
		Sati = @Sati,
		KoordinataA = @KoordinataA,
		KoordinataB = @KoordinataB,
		PutniNalogID = @PutniNalogID,
		PrijedeniKilometri = @PrijedeniKilometri,
		ProsjecnaBrzina = @ProsjecnaBrzina,
		PotrosenoGorivo = @PotrosenoGorivo
	where 
		IDRuta = @IDRuta
end
go

create proc DeleteVozac
	@VozacID int
as
begin
	delete from Trosak where VozacID = @VozacID

	delete from PutniNalog where VozacID = @VozacID

	delete from Vozac where IDVozac = @VozacID
end
go

create proc DeletePutniNalog
	@PutniNalogID int
as
begin
	delete from PutniNalog where IDPutniNalog = @PutniNalogID
end
go

create proc DeleteRuta
	@IDRuta int
as
begin
	delete from Ruta where IDRuta = @IDRuta
end
go