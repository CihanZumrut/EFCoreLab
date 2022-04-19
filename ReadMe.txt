Entity Framework Core

Entity Framework Core is the new version of Entity Framework after EF 6.x. It is open-source, lightweight, extensible and a cross-platform version of Entity Framework data access technology.

Entity Framework is an Object/Relational Mapping (O/RM) framework. It is an enhancement to ADO.NET that gives developers an automated mechanism for accessing & storing the data in the database.

EF Core is intended to be used with .NET Core applications. However, it can also be used with standard .NET 4.5+ framework based applications.

The following figure illustrates the supported application types, .NET Frameworks and OSs.


EF Core Version History
EF Core Version	Release Date
EF Core 2.0	August 2017
EF Core 1.1	November 2016
EF Core 1.0	June 2016
EF Core on GitHub: https://github.com/aspnet/EntityFrameworkCore

EF Core Roadmap: docs.microsoft.com/en-us/ef/core/what-is-new/roadmap

Track EF Core's issues at https://github.com/aspnet/EntityFrameworkCore/issues

EF Core Official Documentation: https://docs.microsoft.com/ef/core

EF Core Development Approaches
EF Core supports two development approaches 1) Code-First 2) Database-First. EF Core mainly targets the code-first approach and provides little support for the database-first approach because the visual designer or wizard for DB model is not supported as of EF Core 2.0.

In the code-first approach, EF Core API creates the database and tables using migration based on the conventions and configuration provided in your domain classes. This approach is useful in Domain Driven Design (DDD).

In the database-first approach, EF Core API creates the domain and context classes based on your existing database using EF Core commands. This has limited support in EF Core as it does not support visual designer or wizard.


EF Core vs EF 6
Entity Framework Core is the new and improved version of Entity Framework for .NET Core applications. EF Core is new, so still not as mature as EF 6.

EF Core continues to support the following features and concepts, same as EF 6.

DbContext & DbSet
Data Model
Querying using Linq-to-Entities
Change Tracking
SaveChanges
Migrations
EF Core will include most of the features of EF 6 gradually. However, there are some features of EF 6 which are not supported in EF Core 2.0 such as:

EDMX/ Graphical Visualization of Model
Entity Data Model Wizard (for DB-First approach)
ObjectContext API
Querying using Entity SQL.
Automated Migration
Inheritance: Table per type (TPT)
Inheritance: Table per concrete class (TPC)
Many-to-Many without join entity
Entity Splitting
Spatial Data
Lazy loading of related data
Stored procedure mapping with DbContext for CUD operation
Seed data
Automatic migration
EF Core includes the following new features which are not supported in EF 6.x:

Easy relationship configuration
Batch INSERT, UPDATE, and DELETE operations
In-memory provider for testing
Support for IoC (Inversion of Control)
Unique constraints
Shadow properties
Alternate keys
Global query filter
Field mapping
DbContext pooling
Better patterns for handling disconnected entity graphs
Learn more on EF Core and EF 6 differences at here.

EF Core Database Providers
Entity Framework Core uses a provider model to access many different databases. EF Core includes providers as NuGet packages which you need to install.

The following table lists database providers and NuGet packages for EF Core.

Database	NuGet Package
SQL Server	Microsoft.EntityFrameworkCore.SqlServer
MySQL	MySql.Data.EntityFrameworkCore
PostgreSQL	Npgsql.EntityFrameworkCore.PostgreSQL
SQLite	Microsoft.EntityFrameworkCore.SQLite
SQL Compact	EntityFrameworkCore.SqlServerCompact40
In-memory	Microsoft.EntityFrameworkCore.InMemory

Source: "https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx"

