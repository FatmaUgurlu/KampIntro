--Select -> seçmek * tüm verileri from customers cumstomers tablosundan seç
--ANSII
--case insensitive= büyük küçük harf duyarsızdır.
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers
--Adi,sirketadi,sehir isimleriyle tablo listelenir. alliance olarak kolonlar isim alır. kullanılmazsa contactname gibi kolon adı olur.


Select * from Customers where City = 'London'
--where= koşul belirtir. tek trınak içinde yazılır. şehri londra olan tüm kolonları listele.


Select * from Products where CategoryID=1
--kategoriıd si 1 olanları listele.1 numaralı kategoriye ait bilgileri getir.

Select * from Products where CategoryID=1 or CategoryID=3
--or= ya da (iki koşuldan birini sağlaması yeterli)
--kategoriıd si 1 ya da 3 olanları getir.

Select * from Products where CategoryID=1 and UnitPrice>=10
--and=ve  ( iki koşulu da sağlaması gerekir)
--kategoriıd sı 1 olan ve unıtprice si 10dan büyük eşit olanları getir.

--order by= sıralama yapar. 
--ascending= asc= artış sırasına göre sırala
--descending= desc = azalana göre sırala
select * from Products order by ProductName
--productname göre sırala
select * from Products order by CategoryID,ProductName 
select * from Products order by UnitPrice desc

select * from Products where CategoryID=1 order by UnitPrice desc
--kategoriıd si 1 olanları fiyatı en pahallıdan en ucuza göre sırala

select count(*) from Products
--count=adet, tüm ürünleri say. conut yanına ekstradan bilgi girişi olmaz.

select count(*) from Products where CategoryID=2
--kategoriıd si 2 olan ürün sayısını verir.

--group by= bütün kategorileri tekrarlamadan sayılarını verır.select edilen kolon sadece group by da yazılan olabilir.
--hangi kategoride kaç farklı ürün var? her kategorideki üründen kaç tane var ayrı ayrı göster.
select CategoryID,count (*) from Products group by CategoryID
--her kategori numarasına göre kaç ürün olduğunu verir.

--KDS= karar destek sistemi

--bana fiyatı 20den büyük olan ürün sayısı 10dan az olan kategorileri listele. where koşulu kümületif dataya having olarak yazılır. 
--ilk where çalışır.
select CategoryID,count (*) from Products where UnitPrice>20 group by CategoryID having count (*)<10

--join= birleştirmek
--inner join= iki tabloda eşleşen tabloları getirir. eşleşmeyenleri getirmez.
--on= durumunda,şartında
select *  --tüm kolonlardan istenilen 
from Products inner join Categories  --kategori tablosundan
on Products.CategoryID=Categories.CategoryID    --kategoriıd birleştir.

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName  --hangi tablodan hangi kolonu istiyorsak onu yazarız.sadece bu kolonları çeker.
from Products inner join Categories  
on Products.CategoryID=Categories.CategoryID

--DTO=Data Transformation Object => joinler yapılarak classlar oluşturulmuş olur.

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories  
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10
--fiyatı ondan büyük olanları getirir.


select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID
--left join= solda olup sağda olmayanları da getir.

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
--müşteride olup müşterilerde olmayanları da getir demektir.

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
--ürün almadığın için sana özel indirim uygulandığında kullanılır. bu müşteriler hiç ürün almamıştır. ve bu müşterileri aktif etmek için onlara özel kampanya sağlanır.

--right join= sağda olup solda olmayanları getırır.
 select * from Customers c right join Orders o
on c.CustomerID = o.CustomerID

--ikiden fazla tablo join edilmek istenirse;
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID






