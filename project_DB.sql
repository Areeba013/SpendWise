CREATE DATABASE SpendWiseDB;
USE SpendWiseDB;
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Currency VARCHAR(10) NOT NULL DEFAULT 'PKR',
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    LastLoginAt DATETIME NULL
);

CREATE TABLE SpendingProfiles (
    ProfileId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL UNIQUE,
    MonthlyIncome DECIMAL(18,2) NOT NULL DEFAULT 0,
    FixedMonthlyExpense DECIMAL(18,2) NOT NULL DEFAULT 0,
    SavingsRate DECIMAL(5,2) NOT NULL DEFAULT 0,
    SpendingHabit VARCHAR(50) NOT NULL DEFAULT 'Balanced',
    CONSTRAINT FK_SpendingProfiles_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NULL,
    CategoryName VARCHAR(50) NOT NULL,
    Type VARCHAR(20) NOT NULL,
    Description VARCHAR(255) NULL,
    IsDefault INT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Categories_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
INSERT INTO Categories 
    (UserId, CategoryName, Type, Description, IsDefault)
VALUES
    (NULL,'Food','Expense','Food and grocery expenses',1),
    (NULL,'Transport','Expense','Travel and transport expenses',1),
    (NULL,'Shopping','Expense','Shopping and clothing', 1),
    (NULL,'Health','Expense','Medical and health expenses',1),
    (NULL,'Entertainment','Expense','Fun and leisure expenses',1),
    (NULL,'Bills','Expense','Utility bills and rent',1),
    (NULL,'Salary','Income','Monthly salary income',1),
    (NULL,'Freelance','Income','Freelance project income',1),
    (NULL,'Business','Income','Business related income',1),
    (NULL,'Gift','Income','Gifts and rewards',1);

CREATE TABLE FinancialRecords (
    RecordId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    CategoryId INT NULL,
    Type VARCHAR(20) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Date DATETIME NOT NULL DEFAULT GETDATE(),
    Note VARCHAR(255) NULL,
    PaymentMethod VARCHAR(50) NULL,
    IsEssential INT NULL,
    Source VARCHAR(100) NULL,
    IsRecurring INT NULL,
    CONSTRAINT FK_FinancialRecords_Users FOREIGN KEY (UserId) REFERENCES Users(UserId),
    CONSTRAINT FK_FinancialRecords_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

CREATE TABLE Budgets (
    BudgetId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    CategoryId INT NOT NULL,
    SpendingLimit DECIMAL(18,2) NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    IsActive INT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Budgets_Users FOREIGN KEY (UserId) REFERENCES Users(UserId),
    CONSTRAINT FK_Budgets_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

CREATE TABLE SavingsGoals (
    GoalId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    GoalName VARCHAR(100) NOT NULL,
    TargetAmount DECIMAL(18,2) NOT NULL,
    Deadline DATETIME NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_SavingsGoals_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE BudgetAlerts (
    AlertId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    BudgetId INT NOT NULL,
    RecordId INT NOT NULL,
    AlertPercentage DECIMAL(5,2) NOT NULL,
    AlertMessage VARCHAR(255) NOT NULL,
    AlertDate DATETIME NOT NULL DEFAULT GETDATE(),
    IsRead INT NOT NULL DEFAULT 0,
    CONSTRAINT FK_BudgetAlerts_Users FOREIGN KEY (UserId) REFERENCES Users(UserId),
    CONSTRAINT FK_BudgetAlerts_Budgets FOREIGN KEY (BudgetId) REFERENCES Budgets(BudgetId),
    CONSTRAINT FK_BudgetAlerts_FinancialRecords FOREIGN KEY (RecordId) REFERENCES FinancialRecords(RecordId)
);

CREATE TABLE Notifications (
    NotificationId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    Message VARCHAR(255) NOT NULL,
    Type VARCHAR(50) NOT NULL,
    SourceId INT NULL,
    SourceType VARCHAR(50) NULL,
    NotificationDate DATETIME NOT NULL DEFAULT GETDATE(),
    IsRead INT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Notifications_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE HealthScores (
    ScoreId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    HealthScore INT NOT NULL,
    FinancialStatus VARCHAR(50) NOT NULL,
    ScoreMonth DATETIME NOT NULL,
    CalculatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_HealthScores_Users FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
