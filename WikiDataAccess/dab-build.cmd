@echo off
@echo This cmd file creates a Data API Builder configuration based on the chosen database objects.
@echo To run the cmd, create an .env file with the following contents:
@echo dab-connection-string=your connection string
@echo ** Make sure to exclude the .env file from source control **
@echo **
dotnet tool install -g Microsoft.DataApiBuilder
dab init -c dab-config.json --database-type mssql --connection-string "@env('dab-connection-string')" --host-mode Development
@echo Adding tables
dab add "Author" --source "[dbo].[Authors]" --fields.include "Author_Id,FirstName,LastName,BirthDate,Location" --permissions "anonymous:*" 
dab add "Book" --source "[dbo].[Books]" --fields.include "BookId,Title,ISBN,Price" --permissions "anonymous:*" 
dab add "Category" --source "[dbo].[Categories]" --fields.include "CategoryId,Name" --permissions "anonymous:*" 
dab add "Publisher" --source "[dbo].[Publishers]" --fields.include "Publisher_Id,Name,Location" --permissions "anonymous:*" 
dab add "SubCategory" --source "[dbo].[SubCategories]" --fields.include "SubCategory_Id,Name" --permissions "anonymous:*" 
@echo Adding views and tables without primary key
@echo Adding relationships
@echo Adding stored procedures
@echo **
@echo ** run 'dab validate' to validate your configuration **
@echo ** run 'dab start' to start the development API host **
