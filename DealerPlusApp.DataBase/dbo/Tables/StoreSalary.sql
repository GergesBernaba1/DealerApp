CREATE TABLE [dbo].[StoreSalary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarketID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[ChildName] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_StoreSalaryComponent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StoreSalary]  WITH CHECK ADD  CONSTRAINT [FK_StoreSalary_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[StoreSalary] CHECK CONSTRAINT [FK_StoreSalary_Market]