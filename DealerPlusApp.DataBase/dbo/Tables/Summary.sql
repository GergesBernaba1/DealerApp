CREATE TABLE [dbo].[Summary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarketID] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[InTotal] [bit] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Summary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Summary]  WITH CHECK ADD  CONSTRAINT [FK_Summary_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[Summary] CHECK CONSTRAINT [FK_Summary_Market]