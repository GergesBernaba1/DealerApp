CREATE TABLE [dbo].[Market](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserAdminID] [int] NULL,
	[MarketName] [nvarchar](100) NULL,
	[MarketAddess] [nvarchar](200) NULL,
	[PhoneNumber] [nchar](10) NULL,
	[StoreCount] [char](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Markets] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Market]  WITH CHECK ADD  CONSTRAINT [FK_Market_UsersAdmin] FOREIGN KEY([UserAdminID])
REFERENCES [dbo].[UsersAdmin] ([ID])
GO

ALTER TABLE [dbo].[Market] CHECK CONSTRAINT [FK_Market_UsersAdmin]