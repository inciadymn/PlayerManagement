# PlayerManagement
This project is a project that you can manage the players and teams with web services developed with .Net 8.

## Tech

- .Net 8.0
- MS-SQL


## About Architecture

- The layers created in the project are as follows. 

![image](https://github.com/user-attachments/assets/3d9208dd-32b9-45f8-9e52-a3dea97560ee)

- For the project setup, you need to replace the connection string inside the `appsettings.json` file in the `PlayerManagement.Api` layer with your own connection string.

![image](https://github.com/user-attachments/assets/36d63e80-344e-4609-ab01-6e95ddb96ac2)

- Then, you need to run the following command in the Package Manager Console ```update-database```. This command will update the database and insert sample data into it.
  

## Running The Project and Test

When the project runs, you will be greeted by the `swagger` screen. You can test that wanted APIs on swagger.

- The APIs written to handle requests for adding a player, updating a player, removing a player from a team and listing single player data retrieving all information related are as follows.

![image](https://github.com/user-attachments/assets/7727e35a-7ceb-492c-bba3-8ba9ea3cd2fc)


- The APIs written for listing all teams and listing all players from a team are as follows.

![image](https://github.com/user-attachments/assets/22d5165b-c39f-4324-8e02-f9ac4eea497b)


- For player position information, you can see on `swagger` `Schema`. You need to use position for player create and update methods. Player positions is defined as enum in the `PlayerManagement.Model.Enums`.
  
![image](https://github.com/user-attachments/assets/6529d384-73a8-4397-a9ad-090de23be6c4)

  
![image](https://github.com/user-attachments/assets/5a1b3a21-988c-4ea1-9ecc-b12e98172e9b)



