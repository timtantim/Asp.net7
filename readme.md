開發筆記
Database First指令: 

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Scaffold-DbContext "Server=LAPTOP-26R3OA5J\SQLEXPRESS;Database=ExampleDB;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

上面指令可以把 "Server=LAPTOP-26R3OA5J\SQLEXPRESS;Database=ExampleDB;Trusted_Connection=True;TrustServerCertificate=True;" 替換成

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

如果不想Migrate 所有資料表可以加上-table 參數來設定，範例如下(只Migrate Book 這個資料表):

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -table Book

如果不想把DBContext 跟Model 放一起，可以用以下語法:

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Repos/Models -context dbfirstcontext -table Book

如果希望增加DataAnnotation ，指令如下:

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Repos/Models -context dbfirstcontext -table Book -DataAnnotations -f

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Code First指令:

//產生Migration Frame
add-migration init(任意命名)

//Migrate 到資料庫
update-migration