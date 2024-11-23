# DigiozBB
The DigiozBB (DigiOz Bulletin Board) is an old fashion forums system modeled after PHPBB (PHP Bulletin Board). The goal here is to take an existing well established Bulletin Board system and bring it over to the Microsoft .NET Core Stack which is also cross platform but with a lot more modern features and functionality. 

The development stack for the project is as follows:

1. Visual Studio 2022
2. Microsoft .NET Core 8.0
3. Microsoft SQL Server 2022

We are currently looking for additional Open Source Developers to join our Team as we wramp up development of the project. 

Contact webmaster@digioz.com if you are interested.

Thanks,
Pete - https://digioz.com

![image](https://github.com/user-attachments/assets/6e5b0b0e-6ddb-4ffa-b633-b34d37fb83b9)

**Developer Setup Steps**

1. Close the source code of the project from https://github.com/digioz/digioz-forum
2. Open the Project in Visual Studio 2022
3. Open Package Manager Console
4. Create a database in SQL Server called DigiozForum1
5. Run the following command to run the migration and create the tables and populate initial data

> Database-Update -context ApplicationDbContext
> 
