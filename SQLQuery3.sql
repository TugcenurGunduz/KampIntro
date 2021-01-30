--Select
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City='Berlin'

--case insensitive
Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products where CategoryID=1 order by UnitPrice desc --ascending(asc) artan --descending(desc) düşen, azalan

Select count(*) Adet from Products where CategoryID=2

--hangi kategoride kaç farklı ürün var? ->
select categoryID, count(*) from Products group by CategoryID

--birim fiyatı 20 den fazla olan ürünleri category ıd ye göre grupla ürün sayısı ondan az olan kategorileri listele ->
select categoryID, count(*) from Products where unitPrice>20 group by CategoryID having count(*)<10

--join
select  Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from products inner join categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10 

--DTO Data Transformation Object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 

--inner join sadece eşleşen kayıtları getirir!!!

--solda olup (productsta) sağda olmayanları da getir ->
Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID 

--customersta olup ordersta olmayanlar
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o
on o.OrderID = od.OrderID
