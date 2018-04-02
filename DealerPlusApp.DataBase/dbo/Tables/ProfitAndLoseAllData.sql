CREATE TABLE [dbo].[ProfitAndLoseAllData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProfitLoseAllID] [int] NULL,
	[StoreID] [int] NULL,
	[Value] [decimal](18, 2) NULL,
	[IntialDate] [datetime] NULL,
	[Comment] [nvarchar](100) NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_ProfitAndLoseAllData\] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProfitAndLoseAllData]  WITH CHECK ADD  CONSTRAINT [FK_ProfitAndLoseAllData_ProfitAndLoseAll] FOREIGN KEY([ProfitLoseAllID])
REFERENCES [dbo].[ProfitAndLoseAll] ([ID])
GO

ALTER TABLE [dbo].[ProfitAndLoseAllData] CHECK CONSTRAINT [FK_ProfitAndLoseAllData_ProfitAndLoseAll]
GO
ALTER TABLE [dbo].[ProfitAndLoseAllData]  WITH CHECK ADD  CONSTRAINT [FK_ProfitAndLoseAllData_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([ID])
GO

ALTER TABLE [dbo].[ProfitAndLoseAllData] CHECK CONSTRAINT [FK_ProfitAndLoseAllData_Store]