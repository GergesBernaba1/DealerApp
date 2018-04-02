CREATE TABLE [dbo].[MRQVSCash](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[MarketID] [int] NULL,
	[OriginalReport] [decimal](18, 2) NULL,
	[SkimReport] [decimal](18, 2) NULL,
	[Cash] [decimal](18, 2) NULL,
	[Check] [nchar](2) NULL,
	[Diff] [decimal](18, 2) NULL,
	[CommentOriginalReport] [nvarchar](50) NULL,
	[CommentSkimRevport] [nvarchar](50) NULL,
	[CommentCash] [nvarchar](50) NULL,
	[CommentCheck] [nvarchar](50) NULL,
	[CommentDiff] [nvarchar](50) NULL,
	[InitalDate] [date] NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_MarketTabsColumns] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MRQVSCash]  WITH CHECK ADD  CONSTRAINT [FK_MRQVSCash_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[MRQVSCash] CHECK CONSTRAINT [FK_MRQVSCash_Employee]
GO
ALTER TABLE [dbo].[MRQVSCash]  WITH CHECK ADD  CONSTRAINT [FK_MRQVSCash_Market] FOREIGN KEY([MarketID])
REFERENCES [dbo].[Market] ([ID])
GO

ALTER TABLE [dbo].[MRQVSCash] CHECK CONSTRAINT [FK_MRQVSCash_Market]