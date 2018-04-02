CREATE TABLE [dbo].[UsersAdmin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [varbinary](50) NULL,
	[FirstName] [nvarchar](15) NULL,
	[SecondName] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [nchar](10) NULL,
	[Islocked] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedAdminSystemID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedAdminSystemID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]