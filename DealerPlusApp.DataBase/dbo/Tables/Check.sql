CREATE TABLE [dbo].[Check](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarketID] [int] NULL,
	[Employee] [int] NULL,
	[CheckType] [nvarchar](100) NULL,
	[Value] [decimal](18, 2) NULL,
	[Comment] [nvarchar](100) NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Check] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Check]  WITH CHECK ADD  CONSTRAINT [FK_Check_Employee] FOREIGN KEY([Employee])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[Check] CHECK CONSTRAINT [FK_Check_Employee]
GO
ALTER TABLE [dbo].[Check]  WITH CHECK ADD  CONSTRAINT [FK_Check_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[Check] CHECK CONSTRAINT [FK_Check_Market]