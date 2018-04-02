CREATE TABLE [dbo].[OverheadExpenseData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OHExpenseID] [int] NULL,
	[EmployeeID] [int] NULL,
	[Value] [decimal](18, 2) NULL,
	[Comment] [nvarchar](100) NULL,
	[InitalDate] [datetime] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [nchar](10) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_OverheadExpenseData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OverheadExpenseData]  WITH CHECK ADD  CONSTRAINT [FK_OverheadExpenseData_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[OverheadExpenseData] CHECK CONSTRAINT [FK_OverheadExpenseData_Employee]
GO
ALTER TABLE [dbo].[OverheadExpenseData]  WITH CHECK ADD  CONSTRAINT [FK_OverheadExpenseData_OverheadExpense] FOREIGN KEY([OHExpenseID])
REFERENCES [dbo].[OverheadExpense] ([ID])
GO

ALTER TABLE [dbo].[OverheadExpenseData] CHECK CONSTRAINT [FK_OverheadExpenseData_OverheadExpense]