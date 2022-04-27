USE [cs6232-g3]
GO

/****** Object:  StoredProcedure [dbo].[spGetMostPopularFurnitureDuringDates]    Script Date: 4/24/2022 12:49:01 AM ******/
DROP PROCEDURE IF EXISTS [dbo].[spGetMostPopularFurnitureDuringDates]
GO

/****** Object:  StoredProcedure [dbo].[spGetMostPopularFurnitureDuringDates]    Script Date: 4/24/2022 12:49:01 AM ******/
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
declare @total_rental_qualified_furniture int, @total_furniture_rental int ;

 
    -- validate parameter values 
    if (@StartDate  is null OR @StartDate='')  AND  (@EndDate  is null OR @EndDate='') 
		 RAISERROR ('Start Date and End Date cannot be null or empty',11,1, 'spGetMostPopularFurnitureDuringDates'); 
	ELSE if @StartDate  is null OR @StartDate=''
		 RAISERROR ('Start Date cannot be null or empty',11,1, 'spGetMostPopularFurnitureDuringDates'); 
	ELSE if  @EndDate  is null OR @EndDate=''
		 RAISERROR ('End Date cannot be null or empty',11,1, 'spGetMostPopularFurnitureDuringDates'); 
	ELSE if @StartDate > @EndDate
		 RAISERROR ('Start Date cannot be greater than End Date cannot be null',-1,-1, 'spGetMostPopularFurnitureDuringDates');  
	ELSE
		set @total_rental_qualified_furniture=	(Select count (*) from (select  count(ren.TransactionID) as cnt from RentalTransactions ren  
			inner join renteditems item on item.RentalTransactionID=ren.TransactionID		
			where  ren.RentDate BETWEEN @StartDate AND @EndDate
			group by item.FurnitureID having count(item.FurnitureID) >1) totalr);

		set @total_furniture_rental = (Select count (*) from (select  count(ren.TransactionID) as cnt from RentalTransactions ren 		
		where  ren.RentDate BETWEEN @StartDate AND @EndDate group by ren.TransactionID ) totlaf);

		SELECT 
		ri.furnitureID, 
		c.Name AS Category, 
		f.Name,
		@total_rental_qualified_furniture as Total_rental_qualified_furniture,
		@total_furniture_rental as Total_Rental,
		CONCAT(ROUND((@total_rental_qualified_furniture * 100 / @total_furniture_rental), 2),'%') AS percentage_of_rentals,
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

END
GO

--EXEC spGetMostPopularFurnitureDuringDates  null, null;

--EXEC spGetMostPopularFurnitureDuringDates '2001-01-01', '2019-01-01';