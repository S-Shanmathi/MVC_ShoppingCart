NAME    : 		Shanmathi S
PROJECT : 	  MVC SHOPPING CART
TITLE   : 		SHOP CART
_________________________________________________________________________________________________________________________________
CONTENTS 

1. Abstract
2. User Level. 
3. Modules 
4. Login Details 
5. Database Design 
6. Output Screenshot
_________________________________________________________________________________________________________________________________

Abstract:

 SHOPCART is designed for shopping online a piece of software that facilitates the purchase of any kind of perfume product. 
 You can order any products online, pay securely online. Variety of product categories are given. 
 Here the technology used is given below.
 MVC stands for Model, View, and Controller. 
 MVC separates an application into three components - Model, View, and Controller. 
 
1.	Model: Model represents the shape of the data. A class in C# is used to describe a model. Model objects store data retrieved from the database.
 
2.	View: View in MVC is a user interface. View display model data to the user and also enables them to modify them. View in ASP.NET MVC is HTML, CSS, and some special syntax (Razor syntax) that makes it easy to communicate with the model and the controller.
 
3.	Controller: The controller handles the user request. Typically, the user uses the view and raises an HTTP request, which will be handled by the controller. The controller processes the request and returns the appropriate




2. USER LEVEL
 ADMIN: 
Perform all tasks like add, delete, update and view the product stocks. 
CUSTOMER: 
Can view the product stock
Perform all tasks like add, delete, and update the products in their cart. 
Make a purchase through online mode.

MODULES 
// LOGIN MODULE 
  Prompt for User-ID and Password.
  Validates information from Login Driver and process login.
  As per the privilege, it will redirect to next page of screen. 
 ********************************** USERS ********************************************* 
Admin 
Admin Driver           : Add, update, delete products in the stock. 
Admin Page_Re-director : Admin Menu and information passing to another stage. 

Customer
 Customer Driver           : Register account and view the products in stock Add, update, delete and view the products in their cart, also can make payment
 Customer Page_Re-director : User Menu and information passing to another stage. 
 
// USER LEVEL 
ADMIN: 
The topmost authority. 
Assign the privileges for secondary users. 
Has the power to take privileges back from them and assign to self. 

CUSTOMERS: 
Secondary level authority. 
Register and create an account. 
Already existing user can check for the previous order details.

// PRODUCT MODULE
****************************** USERS************************************* 
ADMIN: 
If admin is authenticated with their credentials, all the functionalities regarding this module will be performed. 

CUSTOMER: 
If customer is authenticated with their credentials, only the stock products be viewed. 

****************************FUNCTIONALITIES*************************** 
(i)	Add 
A new product will be added in the stock with all the required details.
(ii)	Update
 		An existing product gets updated in the stock. Updating can be made like updating product price, product name or product availability.
(iii)	Delete
 In case if a product needs to be deleted from the stock, it can be done through this functionality.
(iv)	Display
 An entire product will be displayed in the page for reference.

// CART MODULE

 ****************************** USERS************************************* 
CUSTOMER: 
If customer is authenticated with their credentials, all the functionalities regarding this module can be performed.

 ****************************FUNCTIONALITIES*************************** 
If user is authenticated with their credentials, the below functionalities will be performed. 
(i)Add 
A new product will be added in the cart with all the required details. 

(ii) Update 
An existing product gets updated in the cart. Updations can be made like updating product quantity alone. 

(iii) Delete 
In case if a product needs to be deleted from the cart, it can be done through this functionality. 

(v)	View Products 
An entire stock product will be displayed in the page for reference. 

(vi)	View cart 
The product which is stored in their cart gets displayed.

// PAYMENT MODULE 
The user needs to purchase their orders by making payment through online for that purpose a separate module is maintained. 
Different options are provided for making payment like
 • UPI 
• Debit card 
• COD 
Based upon the user’s choice the validations and verifications take place and the customer order will be confirmed.

4.LOGIN DETAILS 
****************************** USERS************************************* 
ADMIN:
 USERNAME: admin 
PASSWORD: admin 
CUSTOMER 1: 
USERNAME : abc
PASSWORD : abc@123 
