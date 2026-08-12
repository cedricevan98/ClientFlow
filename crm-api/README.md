# ClientFlow CRM — Backend API

C# 9 / .NET 8 RESTful API for the ClientFlow CRM application.

## Tech Stack
- **Runtime**: .NET 8 / C# 11
- **Framework**: ASP.NET Core Web API
- **ORM**: Entity Framework Core 8
- **Database**: SQLite (dev) — swap connection string for MSSQL in production
- **Auth**: JWT Bearer (BCrypt password hashing)
- **Docs**: Swagger / OpenAPI

## Quick Start
```bash
cd crm-api
dotnet restore
dotnet run
# Swagger UI: http://localhost:5000/swagger
```

## API Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | /api/auth/register | Register new user |
| POST | /api/auth/login | Login, get JWT |
| GET/POST | /api/contacts | List / create contacts |
| GET/PUT/DELETE | /api/contacts/{id} | Contact detail |
| GET/POST | /api/companies | List / create companies |
| GET/PUT/DELETE | /api/companies/{id} | Company detail |
| GET/POST | /api/deals | List / create deals |
| PATCH | /api/deals/{id}/stage | Move deal to stage |
| GET/POST | /api/activities | Activity log |
| GET | /api/dashboard | Stats & recent activity |

## Architecture
```
Controllers  →  Services  →  DbContext (EF Core)
                ↑
              DTOs / Models
```
