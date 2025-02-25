# Data-Resala

<div align="center">
  
 <img width=100% src="images.jpeg" alt="logo"></a>
<p>A system to facilitate the organization of data and facilitate access to it, as this helped save more than 40% of time in trying to obtain customer data and easily display it and know the number of customers for each department with the utmost ease.</p>
</div>


## 📝 Table of Contents

- [About](#about)
- [Technology](#tech)
- [Screenshots](#Screenshots)
- [relationship in the database](#database)

## 📙 About <a name = "about"></a>
<h1>Data_resala Project</h1>
<p>***A picture showing what the system looks like in reality</p>
<img width=100% src="Form1 21_02_2025 05_23_16 م.png" alt="logo"></a>
<p>
The <strong>data_resala</strong> project is a data management system designed to efficiently track and manage the number of customers with accuracy. This system provides a structured and simplified way to store and organize data, enhancing operational efficiency and record-keeping capabilities. 

Built with a strong foundation of security and rapid access to information, <strong>data_resala</strong> offers a smart and reliable data solution. The system allows easy identification of data through numerical segmentation, facilitating a streamlined data collection and management process.
</p>


## 💻 Built Using <a name = "tech"></a>
- **SQL**
- **.net**
- **C#**
- **Windows form APP**
- **ASP.NET
- **microsoft sql server**
## 📷 Screenshots 

<div align="center">
  
 <img width=100% src="Form20 21_02_2025 05_23_28 م.png" alt="logo"></a>
<p>Each part of the main page consists of a page to enter data for each client, and this data is saved, modified, deleted, and printed. As we see above, this is the form of the data displayed in relation to the database.</p>
</div>






   <hr>
   <hr>
   <h2 name="database">###The relationship in the database</h2>
  <p>+----------------+
|     main      |
|-------------- |
| id (PK)       |
| data          |
+----------------+
         |
--------------------------------------------------------
|         |         |         |         |         |    |
+------------+ +------------+ +------------+ +------------+
|  table1    | |  table2    | |  table3    | |  table4    | 
|------------| |------------| |------------| |------------| 
| id (PK)    | | id (PK)    | | id (PK)    | | id (PK)    | 
| data       | | data       | | data       | | data       | 
| main_id (FK)| | main_id (FK)| | main_id (FK)| | main_id (FK)|  
+------------+ +------------+ +------------+ +------------+ 
         |
--------------------------------------------------------
|         |         |         |         |         |    |
+------------+ +------------+ +------------+ +------------+
|  table5    | |  table6    | |  table7    | |  table8    | 
|------------| |------------| |------------| |------------| 
| id (PK)    | | id (PK)    | | id (PK)    | | id (PK)    | 
| data       | | data       | | data       | | data       | 
| main_id (FK)| | main_id (FK)| | main_id (FK)| | main_id (FK)|  
+------------+ +------------+ +------------+ +------------+ 
         |
--------------------------------------------------------
|         |         |         |         |         |    |
+------------+ +------------+ +------------+ +------------+
|  table9    | |  table10   | |  table11   | |  table12   | 
|------------| |------------| |------------| |------------| 
| id (PK)    | | id (PK)    | | id (PK)    | | id (PK)    | 
| data       | | data       | | data       | | data       | 
| main_id (FK)| | main_id (FK)| | main_id (FK)| | main_id (FK)|  
+------------+ +------------+ +------------+ +------------+ 
         |
--------------------------------------------------------
|         |         |         |         |        
+------------+ +------------+ +------------+ +------------+
|  table13   | |  table14   | |  table15   | |  table16   | 
|------------| |------------| |------------| |------------| 
| id (PK)    | | id (PK)    | | id (PK)    | | id (PK)    | 
| data       | | data       | | data       | | data       | 
| main_id (FK)| | main_id (FK)| | main_id (FK)| | main_id (FK)|  
+------------+ +------------+ +------------+ +------------+ 
</p>
   <br>
   <img width=100% src="Untitled.png" alt="logo"></a>

<p>**As we can see above, I have 200 tables in the project database 
All of them have a relationship with the main table 
Each table represents a doctor in the GUI, and each doctor represents a button 
The patient orders through it</p>

   <hr>
   <hr>
  
   
</div>






