# Assignment 2
The customer approved your previous Assignment and would like your help again to fix an issue they are having.

The customer manages Cars for various companies and projects assigned to various users. A developer created an API which 3rd parties can use and consume when updating information. 
Unfortunately, the developer left the company and never told where they could find the source code for this API. 

You have been hired to recreate the API based on the swagger documentation and the following tiny bit of information the customer has.

## Info

The customer told us that they manage the following entities:
* Company
* Car
* User 
* Project (opt)
* Skill (opt)

Relationships between the entities are as follows (*all are One-to-Many relationships*): 
* A Company can have multiple Cars
* A Car can have a User
* A Car can have a Company
* A User can have multiple Cars
* A User can have multiple Projects
* A Project can have multiple Skills

## Tasks

1. Create ASP.NET Core API project
2. Define Entities
3. Create the Database (DbContext)
4. Define the API based on the swagger.json
5. Implement the new custom API Calls
   * Call 1
   * Call 2
   * Call 3

