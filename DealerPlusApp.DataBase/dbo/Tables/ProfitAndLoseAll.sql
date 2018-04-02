CREATE TABLE [dbo].[ProfitAndLoseAll](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarketID] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Precentage] [int] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Profit_Lose] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProfitAndLoseAll]  WITH CHECK ADD  CONSTRAINT [FK_ProfitAndLoseAll_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[ProfitAndLoseAll] CHECK CONSTRAINT [FK_ProfitAndLoseAll_Market]