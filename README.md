# Employee-Personal-Tracking-System
READ ME

PersonalTracking project
This is C# Project
Windows forms

READ ME
This is an Employee Personal Tracking app

# **🧾 Employee Personal Tracking System**
Employee Personal Tracking System is a C# Windows Forms desktop application designed for administrators to manage employees and their work-related information efficiently. It provides a secure and user-friendly interface for overseeing departments, positions, employee records, salaries, task assignments, and user access permissions.
### **🔍 Key Features**
- **Task Assignment:** Admins can create and assign tasks to employees.
- **Employee Management:** Add, update, or delete employee records, including name, position, department, and salary details.
- **Salary Management:** Track and update employee salaries.
- **Department & Position Setup:** Define new departments and create positions within them.
- **Role-Based Access Control:** Restrict user access based on permission levels (admin or standard user).
- **Login System:** Authenticate users using unique user numbers and passwords.
- **Data Handling:** Uses a layered architecture with:
  1. **DAL (Data Access Layer)** for database interaction,
2. **BLL (Business Logic Layer)** for processing,
3. **UI Layer** for forms and user interface.

### **💻 Technologies Used **
- C# (.NET Framework)
- Windows Forms (WinForms)
- LINQ to SQL (DataContext)
- Layered architecture: BLL, DAL, DTO

### 🔐 User Roles
- **Admin:** Full access to employee management, department setup, salary updates, task assignments, and permission settings.
- **Standard User:** Can view and update their own employee details and assigned tasks.

### 🛠 Installation & Setup
✅ Prerequisites
Before running the project, make sure you have the following installed:
.NET Framework (recommended: 4.7.2 or later)
 - You can install it via Visual Studio Installer or from the official .NET Framework downloads.

- Visual Studio (Community or higher)
- Ensure that Windows Forms development and .NET desktop development workloads are installed.
- SQL Server or SQL Server Express
 Required to host and manage the database backend.

- SQL Server Management Studio (SSMS) (optional but recommended)
For running and managing SQL scripts and queries.

### 📁 Project Setup Instructions
Clone or download this repository:

 bash
CopyEdit
git clone https://github.com/your-username/your-repo-name.git


Database Setup:


Open the provided SQL_set_up.sql file in SSMS (or any SQL client).


Execute the script to create the database and tables.


Configure Database Connection:


Open the EmployeeDataClass.dbml or related *.dbml.cs file under the DAL project.


Ensure your database connection string is correct and pointing to your SQL Server instance.


OR, if using App.config, update the connection string like below:

 xml
CopyEdit
<connectionStrings>
  <add name="YourConnectionStringName"
       connectionString="Data Source=YOUR_SERVER;Initial Catalog=YOUR_DB;Integrated Security=True"
       providerName="System.Data.SqlClient"/>
</connectionStrings>


Build and Run:


Open the solution in Visual Studio.


Set the Windows Forms project as the startup project.


Press F5 to build and run the application.



📌 Notes
If you're using LINQ to SQL (dbml), make sure your .dbml file is correctly mapped to your SQL Server database tables.


If you're using Image Uploads, verify that the image folder path exists or adjust it in the code.


Permissions (admin vs. standard user) are enforced through the login form using user credentials stored in the database.



Open SQL_set_up.sql to set up your own database in MySQL. If needed the code is as follows:
…….
USE [master]
GO
/****** Object:  Database [PersonalTracking]    Script Date: 31/07/2025 15:19:37 ******/
CREATE DATABASE [PersonalTracking]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonalTracking', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PersonalTracking.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PersonalTracking_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PersonalTracking_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PersonalTracking] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonalTracking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonalTracking] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonalTracking] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonalTracking] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonalTracking] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonalTracking] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonalTracking] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PersonalTracking] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonalTracking] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonalTracking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonalTracking] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonalTracking] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonalTracking] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonalTracking] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonalTracking] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonalTracking] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PersonalTracking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonalTracking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonalTracking] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonalTracking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonalTracking] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonalTracking] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonalTracking] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonalTracking] SET RECOVERY FULL 
GO
ALTER DATABASE [PersonalTracking] SET  MULTI_USER 
GO
ALTER DATABASE [PersonalTracking] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonalTracking] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonalTracking] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonalTracking] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PersonalTracking] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PersonalTracking] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PersonalTracking', N'ON'
GO
ALTER DATABASE [PersonalTracking] SET QUERY_STORE = ON
GO
ALTER DATABASE [PersonalTracking] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PersonalTracking]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserNumber] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[ImagePath] [varchar](max) NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[PositionID] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[Birthday] [date] NULL,
	[Address] [varchar](max) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[isAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Months]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Months](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MonthName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Months] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[PermissionStartDate] [date] NOT NULL,
	[PermissionEndDate] [date] NOT NULL,
	[PermissionState] [int] NOT NULL,
	[PermissionExplanation] [varchar](max) NULL,
	[PermissionDay] [int] NOT NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissionState]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionState](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PermissionState] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
	[DepartmentID] [int] NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[MonthID] [int] NOT NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[TaskTitle] [varchar](50) NOT NULL,
	[TaskContent] [varchar](max) NULL,
	[TaskStarDate] [date] NULL,
	[TaskDeliveryDate] [date] NULL,
	[TaskState] [int] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskState]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskState](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TaskState] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Position] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Position]
GO
ALTER TABLE [dbo].[Permission]  WITH CHECK ADD  CONSTRAINT [FK_Permission_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Permission] CHECK CONSTRAINT [FK_Permission_Employee]
GO
ALTER TABLE [dbo].[Position]  WITH CHECK ADD  CONSTRAINT [FK_Position_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([ID])
GO
ALTER TABLE [dbo].[Position] CHECK CONSTRAINT [FK_Position_Department]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Employee]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Months] FOREIGN KEY([MonthID])
REFERENCES [dbo].[Months] ([ID])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Months]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Employee]
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployeeById]    Script Date: 31/07/2025 15:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteEmployeeById]
	@EmployeeId int
	
AS
DELETE FROM Employee WHERE ID = @EmployeeId
GO
USE [master]
GO
ALTER DATABASE [PersonalTracking] SET  READ_WRITE 
GO
…….

This second script has example data. This may be useful if you want to  play around with existing data rather than creating your own.

………..

USE [PersonalTracking]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserNumber] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[ImagePath] [varchar](max) NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[PositionID] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[Birthday] [date] NULL,
	[Address] [varchar](max) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[isAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Months]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Months](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MonthName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Months] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[PermissionStartDate] [date] NOT NULL,
	[PermissionEndDate] [date] NOT NULL,
	[PermissionState] [int] NOT NULL,
	[PermissionExplanation] [varchar](max) NULL,
	[PermissionDay] [int] NOT NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissionState]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionState](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PermissionState] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
	[DepartmentID] [int] NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[MonthID] [int] NOT NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[TaskTitle] [varchar](50) NOT NULL,
	[TaskContent] [varchar](max) NULL,
	[TaskStarDate] [date] NULL,
	[TaskDeliveryDate] [date] NULL,
	[TaskState] [int] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskState]    Script Date: 31/07/2025 15:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskState](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TaskState] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (1, N'1')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (2, N'2')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (3, N'D1')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (4, N'D2')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (5, N'D3')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (6, N'D4')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (7, N'D5')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (8, N'D6')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (9, N'D7')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (10, N'D8')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (11, N'D9')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (12, N'D10')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (13, N'D11')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (14, N'D12')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (15, N'D13')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (16, N'Sales Department')
INSERT [dbo].[Department] ([ID], [DepartmentName]) VALUES (17, N'IT Department')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (3, 10003, N'Harry', N'Kane', N'C:\Users\LayefaAgwosi\Pictures\Screenshots\profile pics\Screenshot 2024-07-19 080920.png', 1, 1, 2000, NULL, N'123 Short Lane', N'10003', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (4, 10004, N'Michael', N'Charles', N'C:\Users\LayefaAgwosi\Pictures\Screenshots\profile pics\Screenshot 2024-07-19 080920.png', 1, 2, 2000, NULL, N'123 Plastic Lane', N'10004', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (5, 10005, N'Lucy', N'Brown', N'19e859eb-94c6-4cb3-95e3-e7807d6611eaScreenshot 2024-07-19 081205.png', 3, 3, 1000, CAST(N'1999-06-24' AS Date), N'5 Story Close', N'10005', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (6, 10006, N'James', N'Blunt', N'19e859eb-94c6-4cb3-95e3-e7807d6611eaScreenshot 2024-07-19 081205.png44e48a78-c3b2-459b-8c9d-2d4602d6ad23Screenshot 2024-07-19 080953.png', 3, 15, 50000, CAST(N'1995-07-29' AS Date), N'12 Park Lane', N'10006', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (7, 10007, N'Jessica', N'Rabbit', N'19e859eb-94c6-4cb3-95e3-e7807d6611eaScreenshot 2024-07-19 081205.png44e48a78-c3b2-459b-8c9d-2d4602d6ad23Screenshot 2024-07-19 080953.png65a0b3d3-5288-4c6d-8b21-679659a75199Screenshot 2024-07-19 081537.png', 8, 23, 1500, CAST(N'2000-03-13' AS Date), N'5 Maryland Park', N'10007', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (8, 10008, N'Kelly', N'Sharp', N'34e3a4e0-d1a3-491a-8382-483efeba3bbcScreenshot 2024-07-19 081537.png', 4, 22, 1200, CAST(N'1995-07-01' AS Date), N'4 Parkwood Close', N'10008', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (9, 10009, N'John', N'Thomas', N'723f38dc-0236-423f-a3e0-811d21b1b236Screenshot 2024-07-19 080920.png', 3, 3, 1009, CAST(N'2000-07-29' AS Date), N'1 Park Lane', N'10009', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (10, 100010, N'Lucy', N'Moon', N'718d01b7-7fd2-4695-8135-f749a7bd672fScreenshot 2024-07-19 081205.png', 4, 22, 1000, CAST(N'2000-07-29' AS Date), N'1 Park Lane', N'100010', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (11, 100011, N'john', N'Smith', N'5adcd0d7-27be-4589-958d-6e3d081219d3Screenshot 2024-07-19 081013.png', 3, 3, 1000, CAST(N'2000-07-29' AS Date), N'1 PArk Lane', N'100011', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (12, 100012, N'Mary', N'K', N'5adcd0d7-27be-4589-958d-6e3d081219d3Screenshot 2024-07-19 081013.png17f9e0b4-7329-4500-8448-225e2364bfe5Screenshot 2024-07-19 080953.png', 4, 22, 100, CAST(N'1999-07-29' AS Date), N'Old street', N'100012', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (13, 100013, N'Layefa', N'A', N'5adcd0d7-27be-4589-958d-6e3d081219d3Screenshot 2024-07-19 081013.png17f9e0b4-7329-4500-8448-225e2364bfe5Screenshot 2024-07-19 080953.png17e9ebab-3092-43a2-8481-dcdeb5989ca9Screenshot 2024-07-19 080920.png', 3, 3, 1000, CAST(N'2000-07-29' AS Date), N'Middleton rd', N'100013', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (14, 100014, N'Lynda', N'Jones', N'38b257af-d4db-4a7e-ac20-7fc030ba7e43Screenshot 2024-07-19 081118.png', 4, 22, 1000, CAST(N'2000-07-29' AS Date), N'14 Emply house', N'100014', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (15, 100015, N'Karen', N'Mouse', N'7af5971d-8156-486b-b8bd-05b280e49c7eScreenshot 2024-07-19 081051.png', 3, 3, 1000, CAST(N'1995-07-29' AS Date), N'1 Field road', N'100015', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (16, 100016, N'Mickey', N'Mouse', N'afdcb7eb-725e-44ec-8fba-9d06ec62c99bMickey-Mouse.jpg', 7, 9, 70000, CAST(N'1989-07-30' AS Date), N'DisneyLand Florida', N'100016', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (17, 100017, N'Karen', N'Bore', N'd34d0d51-e34d-4d82-aa52-3a93e4634656download.jpg', 4, 22, 67000, CAST(N'2000-07-30' AS Date), N'12 Blue Road', N'100017', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (18, 100018, N'Claire', N'Lui', N'7c64c7ea-f997-41a9-bbd3-454b61dfa84aScreenshot 2024-07-19 081259.png', 4, 22, 13000, CAST(N'1996-07-30' AS Date), N' 12 Select street', N'100018', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (19, 100019, N'Hannah', N'Class', N'c8d05887-b1b5-45b2-b13d-9a7e1c0133b2Screenshot 2024-07-19 081224.png', 2, 6, 37000, CAST(N'2024-07-30' AS Date), N'180 Reserved Place', N'100019', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (20, 100020, N'Minnie', N'Static', N'd9cd1ad2-db0b-431e-84e4-89cb7cf40d10Screenshot 2024-07-19 081507.png', 7, 9, 10000, CAST(N'1991-07-30' AS Date), N'13 Complie Place', N'100020', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (21, 100021, N'Priya', N'Lee', N'3af35148-df8b-4458-bf14-6ff6f28ea3ccScreenshot 2024-07-19 081240.png', 3, 15, 1700, CAST(N'1999-07-30' AS Date), N'27 Rude House', N'100021', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (22, 100022, N'Alexa', N'Chung', N'6d75c931-5b53-4b7c-aa19-b9fb53fcd800Screenshot 2024-07-19 081311.png', 4, 27, 17000, CAST(N'1992-07-01' AS Date), N'41 Newgate house', N'100022', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (23, 100023, N'Gladys', N'Knight', N'fc0906d9-fdff-4937-a796-9ca4dffa4ccdScreenshot 2024-07-19 081248.png', 4, 27, 35000, CAST(N'1990-02-08' AS Date), N'300 Cotton Lane', N'100023', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (24, 100024, N'Chi', N'Fang', N'7d8b4c34-a21e-4123-9f20-5a3d02c1c3b6Screenshot 2024-07-19 080920.png', 2, 21, 1000, CAST(N'1991-10-01' AS Date), N'24 Petty Coat  Lane', N'100024', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (25, 100025, N'Peter', N'Jones', N'1580a77b-94bf-4244-8c67-c1dab00f3294Screenshot 2024-07-19 081216.png', 4, 27, 10000, CAST(N'1987-11-01' AS Date), N'24 Holloway Road', N'100025', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (26, 100026, N'Sunny', N'Peters', N'd2c5990f-b635-4229-8c47-3251cbcf390blloyd-sikeba.jpg', 3, 7, 1000, CAST(N'1980-07-30' AS Date), N'50 Whisker road', N'100026', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (27, 100027, N'Mary', N'Bunn', N'33a452e0-2b30-4e1e-8391-12d2ac0b4e15download.jpg', 2, 2, 1000, CAST(N'1975-07-31' AS Date), N'1  Backspace House', N'100027', 1)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (29, 100029, N'Jenny', N'Lopez', N'C:\Users\LayefaAgwosi\Pictures\Screenshots\profile pics\james-person-1.jpg', 1, 2, 50000, CAST(N'1991-05-20' AS Date), N'123 Main St', N'100029', 0)
INSERT [dbo].[Employee] ([ID], [UserNumber], [Name], [Surname], [ImagePath], [DepartmentID], [PositionID], [Salary], [Birthday], [Address], [Password], [isAdmin]) VALUES (36, 100035, N'Leona', N'Lewis', N'C:\Pictures\Screenshots\profilepics\Mickey-Mouse.jpg', 7, 1, 100, CAST(N'2024-09-05' AS Date), N'null', N'100035', 0)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Months] ON 

INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (1, N'January')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (2, N'February')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (3, N'March')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (4, N'April')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (5, N'May')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (6, N'June')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (7, N'July')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (8, N'August')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (9, N'September')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (10, N'October')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (11, N'November')
INSERT [dbo].[Months] ([ID], [MonthName]) VALUES (12, N'December')
SET IDENTITY_INSERT [dbo].[Months] OFF
GO
SET IDENTITY_INSERT [dbo].[Permission] ON 

INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (1, 3, CAST(N'2024-08-08' AS Date), CAST(N'2024-08-30' AS Date), 2, N'testing permission', 22)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (2, 3, CAST(N'2024-09-12' AS Date), CAST(N'2024-12-12' AS Date), 1, N'Testing permission', 91)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (3, 3, CAST(N'2024-12-31' AS Date), CAST(N'2025-01-31' AS Date), 2, N'second test for permission', 31)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (4, 4, CAST(N'2024-08-08' AS Date), CAST(N'2024-08-16' AS Date), 1, N'Collections', 8)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (5, 4, CAST(N'2024-08-30' AS Date), CAST(N'2024-09-21' AS Date), 1, N'Debate', 22)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (6, 6, CAST(N'2024-08-09' AS Date), CAST(N'2024-08-16' AS Date), 1, N'Temp', 7)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (7, 6, CAST(N'2024-08-19' AS Date), CAST(N'2024-09-07' AS Date), 1, N'Temp2', 19)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (8, 6, CAST(N'2024-09-21' AS Date), CAST(N'2024-10-31' AS Date), 1, N'Temp3', 40)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (9, 7, CAST(N'2024-08-09' AS Date), CAST(N'2024-08-23' AS Date), 1, N'Handy person', 14)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (10, 7, CAST(N'2024-08-31' AS Date), CAST(N'2024-09-30' AS Date), 1, N'Handy person2', 30)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (11, 7, CAST(N'2024-11-11' AS Date), CAST(N'2024-11-30' AS Date), 1, N'Handy person3
', 19)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (12, 9, CAST(N'2024-08-09' AS Date), CAST(N'2024-08-16' AS Date), 1, N'Windows', 7)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (13, 9, CAST(N'2024-08-24' AS Date), CAST(N'2024-08-31' AS Date), 1, N'windows2', 7)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (14, 9, CAST(N'2024-09-01' AS Date), CAST(N'2024-10-01' AS Date), 1, N'windows3', 30)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (15, 9, CAST(N'2024-10-09' AS Date), CAST(N'2024-10-23' AS Date), 1, N'windows 4', 14)
INSERT [dbo].[Permission] ([ID], [EmployeeID], [PermissionStartDate], [PermissionEndDate], [PermissionState], [PermissionExplanation], [PermissionDay]) VALUES (16, 7, CAST(N'2024-08-17' AS Date), CAST(N'2024-08-30' AS Date), 1, N'explain1', 13)
SET IDENTITY_INSERT [dbo].[Permission] OFF
GO
SET IDENTITY_INSERT [dbo].[PermissionState] ON 

INSERT [dbo].[PermissionState] ([ID], [StateName]) VALUES (1, N'OnEmployee')
INSERT [dbo].[PermissionState] ([ID], [StateName]) VALUES (2, N'Approved')
INSERT [dbo].[PermissionState] ([ID], [StateName]) VALUES (3, N'Disapproved')
SET IDENTITY_INSERT [dbo].[PermissionState] OFF
GO
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (1, N'Position1', 1)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (2, N'Position1', 2)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (3, N'Position1', 3)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (4, N'Position1', 5)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (5, N'Position2', 1)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (6, N'Position2', 2)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (7, N'Position2', 3)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (8, N'Position2', 5)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (9, N'Position2', 7)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (10, N'Position2', 11)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (11, N'Position2', 15)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (12, N'Position2', 12)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (13, N'Head of Postion2', 1)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (14, N'Head of Position2', 13)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (15, N'Lead Position3', 3)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (16, N'Lead Position3', 3)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (17, N'Lead Position3', 5)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (18, N'Lead Position3', 7)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (19, N'Lead Position3', 10)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (20, N'Junior Postion4', 1)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (21, N'Junior Postion4', 2)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (22, N'Junior Postion4', 4)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (23, N'Junior Postion4', 8)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (24, N'Junior Postion4', 11)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (25, N'Operator position1', 1)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (26, N'Operator Postion2', 9)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (27, N'Operator Postion2', 4)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (28, N'Operator Postion2', 3)
INSERT [dbo].[Position] ([ID], [PositionName], [DepartmentID]) VALUES (29, N'Operator Postion2', 10)
SET IDENTITY_INSERT [dbo].[Position] OFF
GO
SET IDENTITY_INSERT [dbo].[Salary] ON 

INSERT [dbo].[Salary] ([ID], [EmployeeID], [Amount], [Year], [MonthID]) VALUES (1, 3, 2000, 2024, 1)
INSERT [dbo].[Salary] ([ID], [EmployeeID], [Amount], [Year], [MonthID]) VALUES (2, 4, 2000, 2024, 2)
INSERT [dbo].[Salary] ([ID], [EmployeeID], [Amount], [Year], [MonthID]) VALUES (3, 8, 1200, 2024, 4)
INSERT [dbo].[Salary] ([ID], [EmployeeID], [Amount], [Year], [MonthID]) VALUES (4, 10, 1000, 2023, 10)
INSERT [dbo].[Salary] ([ID], [EmployeeID], [Amount], [Year], [MonthID]) VALUES (5, 12, 100, 2023, 10)
INSERT [dbo].[Salary] ([ID], [EmployeeID], [Amount], [Year], [MonthID]) VALUES (6, 16, 70000, 2023, 11)
SET IDENTITY_INSERT [dbo].[Salary] OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON 

INSERT [dbo].[Task] ([ID], [EmployeeID], [TaskTitle], [TaskContent], [TaskStarDate], [TaskDeliveryDate], [TaskState]) VALUES (1, 4, N'Post', N'Send Letters to Post Office', NULL, NULL, 1)
INSERT [dbo].[Task] ([ID], [EmployeeID], [TaskTitle], [TaskContent], [TaskStarDate], [TaskDeliveryDate], [TaskState]) VALUES (2, 4, N'Post2', N'Send letters to post office', NULL, NULL, 1)
INSERT [dbo].[Task] ([ID], [EmployeeID], [TaskTitle], [TaskContent], [TaskStarDate], [TaskDeliveryDate], [TaskState]) VALUES (3, 3, N'Fast', N'Fast pace porject', NULL, NULL, 1)
INSERT [dbo].[Task] ([ID], [EmployeeID], [TaskTitle], [TaskContent], [TaskStarDate], [TaskDeliveryDate], [TaskState]) VALUES (4, 18, N'Bell', N'Ring the bell when the time is up', NULL, NULL, 1)
INSERT [dbo].[Task] ([ID], [EmployeeID], [TaskTitle], [TaskContent], [TaskStarDate], [TaskDeliveryDate], [TaskState]) VALUES (5, 15, N'Trap', N'Put all the traps down in the garden to catch all the mice', NULL, NULL, 1)
INSERT [dbo].[Task] ([ID], [EmployeeID], [TaskTitle], [TaskContent], [TaskStarDate], [TaskDeliveryDate], [TaskState]) VALUES (6, 4, N'Finding State', N'Find the Task State', NULL, NULL, 1)
INSERT [dbo].[Task] ([ID], [EmployeeID], [TaskTitle], [TaskContent], [TaskStarDate], [TaskDeliveryDate], [TaskState]) VALUES (7, 19, N'Adding Values', N'Adding values to the new task states', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
SET IDENTITY_INSERT [dbo].[TaskState] ON 

INSERT [dbo].[TaskState] ([ID], [StateName]) VALUES (1, N'OnEmployee')
INSERT [dbo].[TaskState] ([ID], [StateName]) VALUES (2, N'Delivered')
INSERT [dbo].[TaskState] ([ID], [StateName]) VALUES (3, N'Approved')
SET IDENTITY_INSERT [dbo].[TaskState] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Position] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Position] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Position]
GO
ALTER TABLE [dbo].[Permission]  WITH CHECK ADD  CONSTRAINT [FK_Permission_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Permission] CHECK CONSTRAINT [FK_Permission_Employee]
GO
ALTER TABLE [dbo].[Position]  WITH CHECK ADD  CONSTRAINT [FK_Position_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([ID])
GO
ALTER TABLE [dbo].[Position] CHECK CONSTRAINT [FK_Position_Department]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Employee]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Months] FOREIGN KEY([MonthID])
REFERENCES [dbo].[Months] ([ID])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_Months]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Employee]
GO

…………….
