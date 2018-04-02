CREATE TABLE [dbo].[OverheadSalaries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[MarketID] [int] NULL,
	[Value] [decimal](18, 2) NULL,
	[InitalDate] [datetime] NULL,
	[Comment] [nvarchar](100) NULL,
	[CreatedUserAdminID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedUserAdminID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_OverheadSalary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OverheadSalaries]  WITH CHECK ADD  CONSTRAINT [FK_OverheadSalaries_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[OverheadSalaries] CHECK CONSTRAINT [FK_OverheadSalaries_Employee]