CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarketID] [int] NULL,
	[StoreID] [int] NULL,
	[FirstName] [nvarchar](50) NULL,
	[SecondName] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [varbinary](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nchar](10) NULL,
	[IsActive] [bit] NULL,
	[IsMarketManager] [bit] NULL,
	[IsStoreManager] [bit] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [nchar](10) NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Market]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Store] FOREIGN KEY([StoreID])
REFERENCES [dbo].[Store] ([ID])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Store]