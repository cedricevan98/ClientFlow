# ClientFlow CRM

A full-stack CRM application demonstrating the complete technology stack used by modern web development teams.

## Tech Stack

### Backend (`crm-api/`)
- **C# 9** / **.NET 8** — ASP.NET Core Web API
- **Entity Framework Core 8** — ORM with SQLite (MSSQL-ready)
- **JWT Bearer Authentication** — BCrypt password hashing
- **Clean Architecture** — Controllers → Services → DbContext
- **Swagger / OpenAPI** — API documentation

### Frontend (`crm-web/`)
- **Next.js 14** — React framework with App Router
- **TypeScript** — Type-safe frontend
- **Tailwind CSS** — Utility-first styling
- **Axios** — HTTP client with JWT interceptor

## Features
- 🔐 **JWT Authentication** — Register / Login / Protected routes
- 👤 **Contacts** — CRUD with company linking, search & filter
- 🏢 **Companies** — CRUD with contact and deal counts
- 📊 **Deal Pipeline** — Kanban board across 6 stages (Lead → Won/Lost)
- 📝 **Activity Log** — Calls, emails, meetings, notes — linked to contacts & deals
- 📈 **Dashboard** — Pipeline stats, deal value, stage breakdown, recent activity

## Quick Start

```bash
# Backend
cd crm-api
dotnet restore
dotnet run
# API: http://localhost:5000
# Swagger: http://localhost:5000/swagger

# Frontend (new terminal)
cd crm-web
npm install
npm run dev
# App: http://localhost:3000
```
