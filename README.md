# DigiozBB
Welcome to DigiozBB (Digioz Bulletin Board), an open-source forum software that aims to create a feature-rich, modern, and user-friendly bulletin board system for everyone. The DigiozBB (DigiOz Bulletin Board) is an old fashion forums system modeled after PHPBB (PHP Bulletin Board). The goal here is to take an existing well established Bulletin Board system and bring it over to the Microsoft .NET Core Stack which is also cross platform but with a lot more modern features and functionality. 

The development stack for the project is as follows:

1. Visual Studio 2022
2. Microsoft .NET Core 8.0
3. Microsoft SQL Server 2022

**🚀 We're Looking for Open-Source Contributors!**

We are currently looking for additional Open Source Developers & Contributors to join our Team as we wramp up development of the project. Whether you're a developer, designer, tester, or just someone who loves contributing to open-source, we’d love for you to join our journey!
 
**Why Contribute?**

- Be part of building a community-driven forum platform.
- Collaborate with other passionate open-source enthusiasts.
- Expand your skills in ASP.NET, MSSQL, front-end development, or open-source project management.
- Add valuable contributions to your portfolio.

**How You Can Help**

Here are some ways you can contribute:

- Code Contributions: Help us build features, fix bugs, or improve performance.
- UI/UX Design: Suggest or create designs to improve the look and feel of DigiozBB.
- Documentation: Improve or create documentation for developers and end-users.
- Testing and Feedback: Test the software and report issues or suggest improvements.

**Getting Started**
  
- Check out the Repository: [[GitHub Repo](https://github.com/digioz/digioz-forum)]
- Explore the Issues: Look for issues labeled good first issue or help wanted.
- Join the Discussion: Open an issue, comment, or reach out if you have questions.
- Connect with Us
- Open an Issue to start the conversation.
- Join our discussion board or Slack/Discord group.

We can’t wait to work with you and make DigiozBB an amazing platform!

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

