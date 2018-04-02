CREATE TABLE [dbo].[SummaryData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[SummaryID] [int] NULL,
	[StoreID] [int] NULL,
	[Value] [decimal](18, 2) NULL,
	[InitialDate] [datetime] NULL,
	[Comment] [nvarchar](100) NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_SummaryData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SummaryData]  WITH CHECK ADD  CONSTRAINT [FK_SummaryData_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([ID])
GO

ALTER TABLE [dbo].[SummaryData] CHECK CONSTRAINT [FK_SummaryData_Store]
GO
ALTER TABLE [dbo].[SummaryData]  WITH CHECK ADD  CONSTRAINT [FK_SummaryData_Summary] FOREIGN KEY([SummaryID])
REFERENCES [dbo].[Summary] ([ID])
GO

ALTER TABLE [dbo].[SummaryData] CHECK CONSTRAINT [FK_SummaryData_Summary]