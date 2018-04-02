CREATE TABLE [dbo].[OverheadExpense](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarketID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_OverheadType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OverheadExpense]  WITH CHECK ADD  CONSTRAINT [FK_OverheadExpense_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[OverheadExpense] CHECK CONSTRAINT [FK_OverheadExpense_Market]