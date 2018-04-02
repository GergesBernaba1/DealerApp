CREATE TABLE [dbo].[Store](
	[ID] [int] NOT NULL,
	[MarketID] [int] NULL,
	[StoreName] [nvarchar](50) NULL,
	[StoreAddress] [nvarchar](100) NULL,
	[PhoneNumber] [nchar](10) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Store]  WITH CHECK ADD  CONSTRAINT [FK_Store_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[Store] CHECK CONSTRAINT [FK_Store_Market]