CREATE TABLE [dbo].[StoreSalaryData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[StoreSalaryID] [int] NULL,
	[StoreID] [int] NULL,
	[Value] [decimal](18, 2) NULL,
	[Comment] [nvarchar](100) NULL,
	[CreatedUserNameID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserNameID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_StoreSalaryData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StoreSalaryData]  WITH CHECK ADD  CONSTRAINT [FK_StoreSalaryData_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[StoreSalaryData] CHECK CONSTRAINT [FK_StoreSalaryData_Employee]
GO
ALTER TABLE [dbo].[StoreSalaryData]  WITH CHECK ADD  CONSTRAINT [FK_StoreSalaryData_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([ID])
GO

ALTER TABLE [dbo].[StoreSalaryData] CHECK CONSTRAINT [FK_StoreSalaryData_Store]
GO
ALTER TABLE [dbo].[StoreSalaryData]  WITH CHECK ADD  CONSTRAINT [FK_StoreSalaryData_StoreSalary] FOREIGN KEY([StoreSalaryID])
REFERENCES [dbo].[StoreSalary] ([ID])
GO

ALTER TABLE [dbo].[StoreSalaryData] CHECK CONSTRAINT [FK_StoreSalaryData_StoreSalary]