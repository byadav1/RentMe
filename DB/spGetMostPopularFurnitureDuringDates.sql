USE [cs6232-g3]
GO
/****** Object:  StoredProcedure [dbo].[spGetMostPopularFurnitureDuringDates]    Script Date: 4/28/2022 4:34:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Bharti yadav
-- Create date: April 27 2022
-- Description: Create an entry in the Furniture Rental table
-- =============================================
CREATE   PROCEDURE[dbo].[spGetMostPopularFurnitureDuringDates] (
  @StartDate  date,
    @EndDate  date
)
	
AS
BEGIN
DECLARE @total_furniture_rental int ;

 
    -- validate parameter values 
    IF (@StartDate  is null OR @StartDate='')  AND  (@EndDate  is null OR @EndDate='') 
		 RAISERROR ('Start Date and End Date cannot be null or empty',11,1, 'spGetMostPopularFurnitureDuringDates'); 
	ELSE IF @StartDate  is null OR @StartDate=''
		 RAISERROR ('Start Date cannot be null or empty',11,1, 'spGetMostPopularFurnitureDuringDates'); 
	ELSE IF  @EndDate  is null OR @EndDate=''
		 RAISERROR ('End Date cannot be null or empty',11,1, 'spGetMostPopularFurnitureDuringDates'); 
	ELSE IF @StartDate > @EndDate
		 RAISERROR ('Start Date cannot be greater than End Date',-1,-1, 'spGetMostPopularFurnitureDuringDates');  
	ELSE
		SET @total_furniture_rental = (SELECT COUNT(*) 
											FROM RentalTransactions
											WHERE  RentDate BETWEEN @StartDate AND @EndDate);

		SELECT 
		ri.furnitureID, 
		c.Name AS Category, 
		f.Name,
		COUNT(*) AS Total_rental_qualified_furniture,
		@total_furniture_rental AS Total_Rental,
		CONCAT(ROUND((COUNT(*) * 100 / @total_furniture_rental), 2),'%') AS percentage_of_rentals,
		CONCAT(ROUND((SUM(CASE WHEN (DATEDIFF(YEAR, m.DateOfBirth, rt.RentDate) >= 18
									AND DATEDIFF(YEAR, m.DateOfBirth, rt.RentDate) < 30)
								THEN 1 ELSE 0 END) / CAST(COUNT(*) AS FLOAT)) * 100,
							2),
					'%') AS Qualified_Member_18_thru_29,
		CONCAT(ROUND((SUM(CASE WHEN (DATEDIFF(YEAR, m.DateOfBirth, rt.RentDate) < 18
									OR DATEDIFF(YEAR, m.DateOfBirth, rt.RentDate) >= 30)
								THEN 1 ELSE 0 END) / CAST(COUNT(*) AS FLOAT)) * 100,
						2),
				'%') AS Qualified_Member_Others
		FROM RentedItems ri
		JOIN RentalTransactions rt
			ON ri.RentalTransactionID = rt.TransactionID
			AND rt.RentDate BETWEEN @StartDate AND @EndDate
		JOIN Furnitures f
			ON ri.FurnitureID = f.FurnitureID
		JOIN Categories c
			ON f.CategoryID = c.CategoryID
		JOIN Members m
			ON rt.MemberID = m.MemberID
		GROUP BY ri.FurnitureID, c.Name, f.Name
		HAVING COUNT(*) >= 2
		ORDER BY COUNT(*) DESC, ri.FurnitureID DESC

END