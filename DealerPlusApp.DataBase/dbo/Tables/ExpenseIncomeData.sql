CREATE TABLE [dbo].[ExpenseIncomeData](
	[ID] [int] NOT NULL,
	[ExpenseIncomeID] [int] NULL,
	[Value] [decimal](18, 2) NULL,
	[Comment] [nvarchar](100) NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_ExpenseIncomeData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ExpenseIncomeData]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseIncomeData_ExpenseIncome] FOREIGN KEY([ExpenseIncomeID])
REFERENCES [dbo].[ExpenseIncome] ([ID])
GO

ALTER TABLE [dbo].[ExpenseIncomeData] CHECK CONSTRAINT [FK_ExpenseIncomeData_ExpenseIncome]