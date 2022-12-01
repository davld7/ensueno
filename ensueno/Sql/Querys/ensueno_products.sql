--Perfumer�a Ensue�o.

create database ENSUENO
go

use ENSUENO
go

--Tabla de Productos con sus campos.

create table PRODUCTS
(
    product_id int not null identity(1,1) primary key,
    product_name nvarchar(50),
    product_stock int,
    product_unit_price decimal,
    product_image image,
	product_active bit
)
go

--Restricciones.

alter table [dbo].[PRODUCTS] add constraint unique_product_name unique ([product_name])
go

--Procedimientos almacenados.

--Crear producto.

create procedure product_create
    @product_name nvarchar(50),
    @product_stock int,
    @product_unit_price decimal,
    @product_image image
as
begin
    insert into PRODUCTS
    values
        (@product_name, @product_stock, @product_unit_price, @product_image, 1)
end
go

--Leer productos activos.

create procedure products_read
as
begin
    select p.product_id as 'ID', p.product_name as 'Nombre', p.product_stock as 'Existencia', p.product_unit_price as 'Precio unitario'
    from PRODUCTS as p
    where product_active=1
end
go

--Leer imagen del producto.

create procedure product_read_image
    @product_id int
as
begin
    select p.product_image
    from PRODUCTS as p
    where product_id=@product_id
end
go