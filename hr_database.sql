DROP DATABASE IF EXISTS hr_applicant_system;
CREATE DATABASE hr_applicant_system;
USE hr_applicant_system;

CREATE TABLE Roles (
    RoleID INT PRIMARY KEY AUTO_INCREMENT,
    RoleName VARCHAR(50) NOT NULL
);

INSERT INTO Roles (RoleName) VALUES 
('Admin'), ('HR Manager'), ('HR Staff');

CREATE TABLE Users (
UserID INT AUTO_INCREMENT PRIMARY KEY,
FullName VARCHAR(100) NOT NULL,
Email VARCHAR(100) NOT NULL UNIQUE,
Password VARCHAR(255) NOT NULL,
RoleID INT NOT NULL,
Status VARCHAR(20) DEFAULT 'Active',
CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

CREATE TABLE ApplicantAccounts (
AccountID INT AUTO_INCREMENT PRIMARY KEY,
Email VARCHAR(100) NOT NULL UNIQUE,
Password VARCHAR(255) NOT NULL,
Status VARCHAR(20) DEFAULT 'Active',
CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Departments (
DepartmentID INT AUTO_INCREMENT PRIMARY KEY,
DepartmentName VARCHAR(100) NOT NULL
);

INSERT INTO Departments (DepartmentName) VALUES
('Human Resources'), ('Information Technology'), ('Finance'), ('Operations');

CREATE TABLE JobVacancies (
JobID INT AUTO_INCREMENT PRIMARY KEY,
JobTitle VARCHAR(100) NOT NULL,
DepartmentID INT NOT NULL,
Description TEXT,
Qualifications TEXT,
Status VARCHAR(20) DEFAULT 'Open',
PostedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

CREATE TABLE Applicants (
ApplicantID INT AUTO_INCREMENT PRIMARY KEY,
AccountID INT NOT NULL,
FirstName VARCHAR(100) NOT NULL,
LastName VARCHAR(100) NOT NULL,
ContactNumber VARCHAR(20),
Address TEXT,
Education TEXT,
Skills TEXT,
WorkExperience TEXT,
FOREIGN KEY (AccountID) REFERENCES ApplicantAccounts(AccountID)
);

CREATE TABLE Applications (
ApplicationID INT AUTO_INCREMENT PRIMARY KEY,
AccountID INT NOT NULL,
JobID INT NOT NULL,
Status VARCHAR(50) DEFAULT 'Draft',
AppliedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
FOREIGN KEY (AccountID) REFERENCES ApplicantAccounts(AccountID),
FOREIGN KEY (JobID) REFERENCES JobVacancies(JobID)
);

CREATE TABLE RequirementTypes (
RequirementTypeID INT AUTO_INCREMENT PRIMARY KEY,
RequirementName VARCHAR(100) NOT NULL
);

INSERT INTO RequirementTypes (RequirementName) VALUES
('Resume'), ('Transcript of Records'), ('Valid ID'), ('Certificate');

CREATE TABLE ApplicantDocuments (
DocumentID INT AUTO_INCREMENT PRIMARY KEY,
ApplicationID INT NOT NULL,
RequirementTypeID INT NOT NULL,
FilePath VARCHAR(255),
Status VARCHAR(20) DEFAULT 'Missing',
Remarks TEXT,
FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
FOREIGN KEY (RequirementTypeID) REFERENCES RequirementTypes(RequirementTypeID)
);

CREATE TABLE ScreeningResults (
ScreeningID INT AUTO_INCREMENT PRIMARY KEY,
ApplicationID INT NOT NULL,
Result VARCHAR(20),
Remarks TEXT,
ScreenedBy INT NOT NULL,
ScreenedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
FOREIGN KEY (ScreenedBy) REFERENCES Users(UserID)
);

CREATE TABLE InterviewSchedules (
ScheduleID INT AUTO_INCREMENT PRIMARY KEY,
ApplicationID INT NOT NULL,
InterviewDate DATETIME NOT NULL,
Interviewer INT NOT NULL,
Mode VARCHAR(50),
Location VARCHAR(100),
Status VARCHAR(20) DEFAULT 'Scheduled',
FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
FOREIGN KEY (Interviewer) REFERENCES Users(UserID)
);

CREATE TABLE InterviewEvaluations (
EvaluationID INT AUTO_INCREMENT PRIMARY KEY,
ScheduleID INT NOT NULL,
Score DECIMAL(5,2),
Remarks TEXT,
Result VARCHAR(20),
EvaluatedBy INT NOT NULL,
EvaluatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
FOREIGN KEY (ScheduleID) REFERENCES InterviewSchedules(ScheduleID),
FOREIGN KEY (EvaluatedBy) REFERENCES Users(UserID)
);

CREATE TABLE HiringDecisions (
DecisionID INT AUTO_INCREMENT PRIMARY KEY,
ApplicationID INT NOT NULL,
Decision VARCHAR(20) NOT NULL,
Remarks TEXT,
DecidedBy INT NOT NULL,
DecidedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID),
FOREIGN KEY (DecidedBy) REFERENCES Users(UserID)
);

CREATE TABLE ApplicationStatusHistory (
HistoryID INT AUTO_INCREMENT PRIMARY KEY,
ApplicationID INT NOT NULL,
Status VARCHAR(50) NOT NULL,
ChangedBy VARCHAR(100),
ChangedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
Remarks TEXT,
FOREIGN KEY (ApplicationID) REFERENCES Applications(ApplicationID)
);

CREATE TABLE AuditTrail (
AuditID INT AUTO_INCREMENT PRIMARY KEY,
UserType VARCHAR(50),
UserID INT,
Action TEXT,
ActionAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Verify
SHOW TABLES;