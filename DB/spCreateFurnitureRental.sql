USE [cs6232-g3]
GO
/****** Object:  StoredProcedure [dbo].[spCreateFurnitureRental]    Script Date: 4/14/2022 8:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bharti yadav
-- Create date: April 10 2022
-- Description: Create an entry in the Furniture Rental table
-- =============================================
CREATE   PROCEDURE[dbo].[spCreateFurnitureRental] (
 @MemberID Integer,   
    @FurnitureID Integer  ,
	  @Quantity Integer  ,
	  @DueDate Date,
	  @SequenceID Integer,
	  @EmployeeID Integer
)
	
AS
BEGIN
declare @rentID int;

INSERT INTO RentalTransactions (RentDate,DueDate,EmployeeID,MemberID)
VALUES(CURRENT_TIMESTAMP,  @DueDate, @EmployeeID, @MemberID);

set @rentID=scope_identity();


INSERT INTO RentedItems(RentalTransactionID,SequenceNo,Quantity,FurnitureID)
VALUES(@rentID, @SequenceID, @Quantity, @FurnitureID);

UPDATE FURNITURES set QUANTITY=(QUANTITY-@Quantity) where FurnitureID=@FurnitureID;

END
GO
