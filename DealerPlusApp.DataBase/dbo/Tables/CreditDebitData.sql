CREATE TABLE [dbo].[CreditDebitData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreditDebitID] [int] NULL,
	[StoreID] [int] NULL,
	[EmplyeeID] [int] NULL,
	[Value] [decimal](18, 2) NULL,
	[Comment] [nvarchar](100) NULL,
	[InitalDate] [datetime] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Cread] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CreditDebitData]  WITH CHECK ADD  CONSTRAINT [FK_CreditDebitData_CreditDebit] FOREIGN KEY([CreditDebitID])
REFERENCES [dbo].[CreditDebit] ([ID])
GO

ALTER TABLE [dbo].[CreditDebitData] CHECK CONSTRAINT [FK_CreditDebitData_CreditDebit]
GO
ALTER TABLE [dbo].[CreditDebitData]  WITH CHECK ADD  CONSTRAINT [FK_CreditDebitData_Employee] FOREIGN KEY([EmplyeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[CreditDebitData] CHECK CONSTRAINT [FK_CreditDebitData_Employee]
GO
ALTER TABLE [dbo].[CreditDebitData]  WITH CHECK ADD  CONSTRAINT [FK_CreditDebitData_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([ID])
GO

ALTER TABLE [dbo].[CreditDebitData] CHECK CONSTRAINT [FK_CreditDebitData_Store]