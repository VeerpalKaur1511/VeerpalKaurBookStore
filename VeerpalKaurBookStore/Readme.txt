﻿﻿31/10/2023
name: veerpal kaur
student id : 0826070

its my 2 assignment of  using mvc application. I make a website on subject bookstore.
now i started my readme file and i create a new repositry on github.

part 1

in the first step i commented the ssport and test it ...its working...
then i register my account by adding username and password then create
but it showing an error that A database operation failed while processing the request.
then i a apply migration ..refresh...its successfully login
i modify the startup.cs by commiting the requireConirmedAccount and examine all the files 

part 2

now  started debugging
i add two breakepoints to start debugging then test it .. its not continue because brwoser is stop .. yhen i click on cotinue step by step 
and agter that i remove it
 part 3 

 now staring bootswatch
 i download a bootstrap themenamed journal online and remain exiting bootstrap file in wwwroot
 then add downloaded file and change the nav bar and remove text dark from lauout file and updated my footer


 first i clone my repositry ...then test my application....then update database
 **********lets go**********
 then changed my existing site.css file in wwwroot with the provided css in main folder
 then i add new css stylsheets in layout page provided in the blackbord

 30/10/2023  3:06 pm

 now i add new button dropdown add the coding ....test....its showing button....but not opening the other options
 afetr that i changed code from data-bs-toggle to data-toggle ....then test its....its working wow....
 then i changed name of dropdown to conyent managment..


 now i added three new projects to my application named (VeerpalBooks.DataAccess,VeerpalBooks.Models, VeerpalBooks.uitilty )
 then i copy my data folder to data access and delete the orioginal 
 then i install relational and sqlserver packages 
 after that i deleted my migration folder
 then i download identity.entityframeworkcore version 5.0.2
 then i deleted all class1.cs from all new projects and modify my namespace
 then i bulid project.....
 then i move models floder to VeerpalBooks.Models anf delete the the original one
 then i change namespace of models folder ti ViewModel and updated the startup .cs file code with the instruction given in the project.
 then i solved the errors by changing the namespaces in the error.cshtml file.
 then i run the project ..... it worked.

 Now i added new class of name SD.cs and change the properties. 
 then i add the refrences of the main project and the models and utility project.

 then i added the new area under the Area folder name Customer and chaned the path in the startup.cs file as given.
 then i modify my statup.cs...,.then i move the homecontroller.cs to area > customer> controller
 and delete my data and models folder
 then i edit my homecontroller.cs file...
 after that i moved my home folder under views  ....test my app
 wow... its working 
 in the next step i add new area admin in areas folder ...then move my view files to admin folder..
 then delete data , model, and controller folder and i done my assignment.....

 I got so many errors and found that my parth was not set...
 Then changed the path    and it worked.

 03/11/2023  1.38pm

 now i'm starting my 2part of my assignment regarding bookstore
 first i modify database

 1.2 create the db
 04/11/2023  2.30pm
 then i run nuget console package and run add-migration AddDefaultIdentityMigration which makes this file(20231103182157_AddDefaultIdentityMigration.cs)
 but it showing error then i change default project to .dataAccess thenrun again ...its working
i added new DB and create new file named category in models project...then add migrationin pm console
its empty then update my using statment and ass some code
then i run pmconsole then run migration ...but not build..

06/11/2023 11.00am

its showing too much erreor in ApplicationDbContext.cs ....
then i slove it by many efforts.
i delete my migration file and again run the compand for mifration 
and do all changes and test its
....its working....


11.45Am
2.2 repositry
first i added Repository folder in data.Access and some code to this file
then add new folder IRepository in the repository folder
then add new class IRepository.cs 
then Modify so it can be used on the Category class to do all the CRUD operations 
Methods to use for CRUD:
Get item from the DB
List of Categories
Add objects
Remove objects
i updated my repositry.cs file

1.00pm
i added new class Category.cs and IcategoryRepository.cs
then i modify my code in Category.cs and IcategoryRepository.cs
then i add new interface in repositry.cs named ISP_Call.csnad modify my code

2.10pm
then i add class (SP_Call.cs) and add using statments and connection string to the datbase
and modify my all code and slove all errors
then i add new interface IUnitOfWork and modify my code
then i add new class unitOfWork and modify my code....
there is alot of errors....now im sloving it ...its good

2.2 Category CRUD
5.09Pm
now i added new categorycontroller.cs in my controllers folder
then i modify my my file code.....
then i add Category folder to my views .../
then i add new new index.cshtml and modify my code
then i add new code in layout.cshtml for adding my dropdown menu...then i tested it.....its working .....

i added new file nmaed category.js
then i added provided category.js file to my wwwroot>js>Category.js...
then i run it ...
its working....and showing vey nice...

then i apply the code to activate edit , delete and create buttons
then i add new Upsert.cshtml file
then cody code from blackbord ....then 
then i added two file _CreateAndBackToListButton.cshtml and _EditAndBackToListButton 
then i updated all code
then i add some code in index.cshtml..
then i modify my CategoeryController.cs...add more....code...
also i added more code in categoery.js
and i also delete one line of savechanges from RepositoryCategory..

then i run it...its showing an error

13/11/2023
when i run the application its showing this error .."DataTables warning: table id=tblData - Ajax error. For more information about this error, please see http://datatables.net/tn/7"..
and when i click on category its showing An unhandled exception occurred while processing the request.
InvalidOperationException: The partial view '_ValidationScriptPartial' was not found. The following locations were searched:
/Areas/Admin/Views/Category/_ValidationScriptPartial.cshtml


17/11/2023   3.00pm
part 3 (section 1)
i started my 3 part of my 2 assignment first i make i  class Covertype.cs under models folder
then make new class and interface under repositry folder ...after that i new code to applicationDbContext.cs named CoverType
then i run a migration command add migration AddcoverTypeToDb...which  makes a new folder named (20231117214837_AddCoverTypeToDB.cs)

then i modify my code in covertyperepositry and icovertyperepositry 
i updated code in files
then i added code to unitofwork and i unitofwork

20/11/2023   11.26pm

then i added i new folder named covertypecontroller and modify my code
then i add a code in layout to get covertype in brower
then i add new foder named covertype under area/admin/views...
then i add new index file under this folder and modify my code in this file...
 

2:00pm

then i added new js file under wwwroot..and modify my code
11/20/2023   4.15pm

then i added new file under viewmodels and modify my code...
then i add code to data...
then i added add-migration AddProductToDb ...which makes this folder (20231120213543_addProductToDb...)
then update database

then i added  add-migration addValidationToProduct ...which makes this folder (20231120214533_addValidationToProduct..)
then update database

then io addded new class and interface named productrepositry nd iproductrepositry
then i modify my code in productrepositry and iproductrepositry 
i updated code in files
then i added code to unitofwork and iunitofwork


part(3) section (2)  5.25pm
then i added new controller under controllers folder and modify my all code..
then i create a viewmodel under models folder and hold the covertype and category
thrn i install a microsoft.aspnetcore.Mvc.viewfeatures command

then i modify my code in productcontroller and add API calls
then i comment the upsert in controller 
then i added a index in view folder and modify my code...
then i add a new js file in wwwroot named product.js...
then run my application...its working....

part(3) section(3) 7.15pm
then i create an upsert file for product and modify my code...
then  i added some script from tinycloud in upsert file ... 
then uncomment code in same file and some other code for validation//\
then update datbase...
then run my application ....itworking

11/24/2023  9.48AM

part(4)

now i'm staring my part 4 for my application to make its unique
first i created anew folder under wwwroot named images...
under images i createda folder for products
first i modify my code in Sd.cs file and i added i public function

11/24/2023  12.21pm

then i add new code public double ListPrice { get; set; },public double Price { get; set; }
,public double Price50 { get; set; },public double Price100 { get; set; } to make new filds
...then i also add code  to productcontroller.cs 

11/24/2023  2.36pm
then i get a ajax error to solve this error i replace 0 instaed of nulll
i do this replacment in upsert.cs file
then i modify my code in product>upsert.cshtml to get new fileds for price and listprice

then i modify my code in Controller > Homecontroller.cs             
IEnumerable<Product> productList = _unifOfWork.Product.GetAll(includeProperties: "Category,CoverType");
after that i also add some using statments to get error free code

3.02pm
then i replace my code in Area>customer>views>Home>Index.cshtml with provided code
and replace id with ID
in this part i add new code to Productrepositry.cs about added new fileds like listprice, price and price50

3.15pm
then i replace my modify my code in repositry.cs and i get this code from provided
github repositry after that i get some error
then i click on show potenial error and i fix my all errors
then i run my application ...
update-datbase in pm console....

its showing bulid faild ...then i build my project...
its showing too much errors with id...
then i replace id with actuall aid that i written in product.cs (ID)
then i again update-database ...its bulid ...

12/04/2023  12.39 Pm
my application showing an error...
then i replace my  category.cs code with provided repositry ..
then i test it ....
and its working ... ajax error not showing anymore....

1.15pm
then again make some changes/...
then showing some error that migration is not correct and my product table is not shown..
then i update my product migration byy adding add-migration updateProduct ...
then update database...
its solve the error and ny product table is craeted