---Create SP

GO
/****** Object:  StoredProcedure [dbo].[uspCreateDepartment] **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspCreateDepartment]
	-- Add the parameters for the stored procedure here
	@Dname varchar(50),
	@MgrSSN numeric(9,0)
	

AS

If exists(select 'True' from Department where DName = @Dname)
BEGIN 
THROW 50001, 'Name already exist.', 1;
END
ELSE IF exists(select 'True' from Department where MgrSSN = @MgrSSN)
BEGIN
THROW 50002, 'Manager already assigned', 1;
END
ELSE
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @StartDate datetime = getDate()
    -- Insert statements for procedure here
	insert into Department(DName, MgrSSN, 
	MgrStartDate)
	output inserted.DNumber
	 values (@Dname, @MgrSSN, @StartDate)
	 
END

---Delete SP

GO
/****** Object:  StoredProcedure [dbo].[uspDeleteDepartment]    Script Date: 3/15/2019 4:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
create PROCEDURE [dbo].[uspDeleteDepartment]
  
  @departmentNum int 
-- add more stored procedure parameters here
AS
BEGIN
UPDATE Employee 
SET Dno = null
WHERE Employee.Dno = @departmentNum 
END
BEGIN
	
 delete Works_on where pno = (select Pno from Project where Project.DNum = @departmentNum )
 delete Project where DNum = @departmentNum
 delete Dept_Locations where DNUmber = @departmentNum
 delete Department where DNumber = @departmentNum


END

-- Get all departments

GO
/****** Object:  StoredProcedure [dbo].[uspGetAllDepartments]    Script Date: 3/15/2019 4:57:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[uspGetAllDepartments]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DName, DNumber, EmployeeCount from Department 
END
--GetDepartment

GO
/****** Object:  StoredProcedure [dbo].[uspGetDepartment]    Script Date: 3/15/2019 5:02:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspGetDepartment]
	-- Add the parameters for the stored procedure here
	@DNumber int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DName, EmployeeCount from Department where DNumber = @DNumber
	
END

-- UpdateDepartmentManager

GO
/****** Object:  StoredProcedure [dbo].[uspUpdateDepartmentManager]    Script Date: 3/15/2019 5:03:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[uspUpdateDepartmentManager]
	-- Add the parameters for the stored procedure here
	@DNumber int,
	@MgrSSN numeric(9,0)

AS
If exists(select 'True' from Department where MgrSSN = @MgrSSN)
BEGIN 
THROW 50004, 'The Manager is already assigned to a Department.', 1;
END

ELSE
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @currentMgrSSN numeric(9,0)
	Select @currentMgrSSN = MgrSSN from Department where DNumber = @DNumber

	declare @StartDate datetime = getDate()
    -- Insert statements for procedure here
	
	
END
If exists(select 'True' from Employee where SSN = @MgrSSN)
BEGIN TRY
	
	update Department set MgrSSN = @MgrSSN, MgrStartDate
	= @StartDate where DNumber = @DNumber
	END TRY
	BEGIN CATCH
		THROW 50010, 'Unidentified error occoured on update department table', 1;
	END CATCH
ELSE 
	THROW 50005, 'There is no Employee with that SSN', 1;

BEGIN
If exists(select 'True' from Employee where Employee.SSN != @MgrSSN AND Employee.SuperSSN = @currentMgrSSN AND Dno = @DNumber)

    update Employee set SuperSSN = @MgrSSN where Employee.SuperSSN = @currentMgrSSN AND Dno = @DNumber

END

-- update department name

GO
/****** Object:  StoredProcedure [dbo].[uspUpdateDepartmentName]    Script Date: 3/15/2019 5:04:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[uspUpdateDepartmentName]
	-- Add the parameters for the stored procedure here
	@DName varchar(50),
	@DNumber int
AS
If exists(select 'True' from Department where DName = @DName)
BEGIN 
THROW 50003, 'Name is already in use.', 1;
END
ELSE
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Department set DName = @DName where DNumber = @DNumber
	
END
 
GO
/****** Object:  UserDefinedFunction [dbo].[getEmpCount]    Script Date: 3/15/2019 5:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getEmpCount]
(	
	@DNumber int
)

RETURNS int 
AS
Begin
RETURN 
(
	(SELECT count(SSN) from Department JOIN Employee on DNumber = Dno where Dno = @DNumber)


)
end

