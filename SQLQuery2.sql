select * from Products
select * from Product_Category
alter table Products drop column CATEGORY_NAME
select Product_Category.CATEGORY_NAME, Products.PRODUCT_NAME,Products.PRODUCT_DESCRIPTION,Products.PRODUCT_PRICE,Products.PRODUCT_COUNT from Products inner join Product_Category on Products.CATEGORY_ID=Product_Category.CATEGORY_ID