CREATE DATABASE NguyenHuuTuan_2310900112;
GO

USE NguyenHuuTuan_2310900112;
GO

CREATE TABLE NhtEmployee (
    nhtEmpId INT PRIMARY KEY,
    nhtEmpName NVARCHAR(100),
    nhtEmpLevel NVARCHAR(50),
    nhtEmpStartDate DATE,
    nhtEmpStatus BIT
);
GO

INSERT INTO NhtEmployee (nhtEmpId, nhtEmpName, nhtEmpLevel, nhtEmpStartDate, nhtEmpStatus)
VALUES
(1, N'Nguyễn Hữu Tuấn', N'Senior', '2023-09-01', 1),
(2, N'Lê Văn A', N'Junior', '2022-07-15', 1),
(3, N'Trần Thị B', N'Mid-Level', '2021-03-10', 0);
GO
