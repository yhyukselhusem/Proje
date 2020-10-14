# MVC ECommerce Project

## Proje Hakk�nda
�ncelikle projemize katmanlar� ekliyoruz. Her bir katman Class Library (.Net Framework)
(Class Library i�erisinde varsay�lan olarak olu�turulan classlar� silin.)


## Katmanlar
- CORE
- MODEL
- SERVICE
- UI (MVC)
	
----------------
- API

Katmanlar� olu�turduktan sonra birbirleriyle haberle�meleri i�in referans vermeliyiz.

## Reference

- Core katman� referanslar�
	- EntityFramework

- Model katman� referanslar�
	- EntityFramework
	-MVCProject.Core

- Service katman� referanslar�
	- EntityFramework
- UI(MVC) katman� referanslar�
	- EntityFramework

## Katmanlar�n G�revleri

�ok katmanl� (NTier) mimari yap�larda her bir katman�n kendine ait bir g�revi bulunmaktad�r. Bu g�revler tan�mlanan katmanlar�n �al��ma sistemini belirler. Olu�turulan projede yer alan katmanlar tek ba�lar�na bir anlam ifade etmezler ancak tamam� birbirleriyle haberle�erek bir projenin b�t�n�n� olu�tururlar.

### Core Katman�

Bu katman Interface,abstract gibi yap�lar� saklayan katmand�r.

### Model Katman�

Projemizdeki veritaban�n� temsil eden katmand�r. Veritaban� mapping i�lemleri gibi yap�lar bu katmanda tan�mlan�r.

### Service Katman�

Sunum katman�n� (UI/MVC) hizmet etmek i�in haz�rlanan ve �al��t�r�lacak olan kodlar bu katmanda yer al�r. Asl�nda hizmet katman� olarak ta adland�r�lmaktad�r.

### UI (Sunum) Katman�

kullan�c� ile do�rudan ileti�ime ge�ecek olan katmand�r.

## Core Katman� Yap�land�r�lmas�

- Bu k�t�phane i�erisine CoreEntity, Map ve Service klas�rlerini olu�turuyoruz. Bu klas�rler her bir katmanda olmas� gereken kurallar� i�ermelidir.

- Entity i�erisine Enums klas�r� olu�turuyoruz. Projede kullan�lacak sabitler (Enums) bu klas�rde yeralacak.

- CoreEntity klas�r� i�erisinde IEntity isminde bir interface olu�turuldu. ��erisinde sadece Id bulunmakta. Olu�turulan bu interface farkl� bir class'a (EntityRepository) miras vererek i�erisinde her bir entity'de olmas� gereken ID property'snin kural�n� olu�turmaktad�r.

- Map klas�r� i�erisine CoreMap class�n� olu�turuyoruz. Bu s�n�f bizim �ekirdek s�n�f�m�zdaki yap�lar�m�z�n map edilmesi i�in kullan�lmaktad�r.

- service class� i�erisine d��ar�da kullan�lacak/tan�mlanacak eylemleri i�erir.

## Model Katman� Yap�land�r�lmas�

- Model k�t�phanesi i�erisine Entities,Map ve Context isimlerinde 3 farkl� klas�r olu�turuldu.

- Entities Klas�r� i�erisine a�a��daki classlar tan�mland�.;
	- AppUser
	- AppUserRole
	- Category
	- Order
	- OrderDetails
	- Product
	- SubCategory

- Map isimli klas�r i�erisine t�m entitylerin mapleme i�lemleri ger�ekle�tirildi.
	- AppUserMap
	- AppUserRoleMap
	- CategoryMap
	- OrderMap
	- OrderDetailsMap
	- ProductMap
	- SubCategoryMap

- AppDbContext (/Context) i�erisinde yukar�da tan�mlanan entitylert dbset i�erisine al�narak veritban�nda tablo haline getirildi.

- OnModelCreating isimli metot ezilerek (override) Map klas�r� i�erisinde tan�mlanan classlar�n instance (�rnek)'lar�  al�nd�.
