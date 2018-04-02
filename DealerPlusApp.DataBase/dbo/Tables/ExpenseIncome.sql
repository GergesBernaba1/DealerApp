CREATE TABLE [dbo].[ExpenseIncome](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[MarketID] [int] NULL,
	[StoreID] [int] NULL,
	[Type] [nchar](1) NULL,
	[Name] [nvarchar](100) NULL,
	[DefualtValue] [decimal](18, 2) NULL,
	[ChangeEveryMonth] [bit] NULL,
	[FixedValue] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_ExpenseIncome] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ExpenseIncome]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseIncome_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[ExpenseIncome] CHECK CONSTRAINT [FK_ExpenseIncome_Employee]
GO
ALTER TABLE [dbo].[ExpenseIncome]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseIncome_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[ExpenseIncome] CHECK CONSTRAINT [FK_ExpenseIncome_Market]
GO
ALTER TABLE [dbo].[ExpenseIncome]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseIncome_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([ID])
GO

ALTER TABLE [dbo].[ExpenseIncome] CHECK CONSTRAINT [FK_ExpenseIncome_Store]