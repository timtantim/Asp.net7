�}�o���O
Database First���O: 

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Scaffold-DbContext "Server=LAPTOP-26R3OA5J\SQLEXPRESS;Database=ExampleDB;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

�W�����O�i�H�� "Server=LAPTOP-26R3OA5J\SQLEXPRESS;Database=ExampleDB;Trusted_Connection=True;TrustServerCertificate=True;" ������

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

�p�G���QMigrate �Ҧ���ƪ�i�H�[�W-table �Ѽƨӳ]�w�A�d�Ҧp�U(�uMigrate Book �o�Ӹ�ƪ�):

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -table Book

�p�G���Q��DBContext ��Model ��@�_�A�i�H�ΥH�U�y�k:

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Repos/Models -context dbfirstcontext -table Book

�p�G�Ʊ�W�[DataAnnotation �A���O�p�U:

Scaffold-DbContext -connection name=DefaultConnection Microsoft.EntityFrameworkCore.SqlServer -OutputDir Repos/Models -context dbfirstcontext -table Book -DataAnnotations -f

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Code First���O:

//����Migration Frame
add-migration init(���N�R�W)

//Migrate ���Ʈw
update-migration