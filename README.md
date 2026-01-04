# CobNet BI Data Warehouse Dashboard

End-to-end BI and dashboard solution built on SQL Server Data Warehouse + OLAP cube, with an ASP.NET MVC web application that visualizes operational KPIs through interactive charts and gauges. The solution is organized into clean layers (Web, BLL, DAL, DTO) and includes a small charting library for Highcharts gauges.

## What this project delivers
- Real-time and historical KPI dashboards (ex: Alo, Localizados, Contato com Cliente, Promessas, Quebra de Pgto).
- Goal tracking at daily/monthly levels with visual progress bars and gauge thresholds.
- Drill-down flows from supervisor view to individual performance details.
- Feedback/justification capture when targets are missed.

## Tech stack
- Backend: C#, .NET Framework 4.5, ASP.NET MVC 4, ADO.NET, Entity Framework 5.
- Data: SQL Server (operational + Data Warehouse), stored procedures, OLAP cube access (SSAS via msmdpump), MDX.
- Frontend: Razor views, jQuery, jQuery UI, Knockout, Highcharts, FusionCharts, Modernizr.
- Tests: MSTest project (structure in place).

## Architecture overview
```
Web (MVC Controllers + Views)
  -> BLL (business orchestration)
     -> DAL (data access + stored procedure execution)
        -> SQL Server DW / Operational DBs / OLAP Cube
DTO (shared contracts across layers)
Highcharts (server-side chart helpers)
```

## Data access strategy
- **Stored procedure driven**: CRUD and reporting are executed through SPs in the DW.
- **Metadata-based binding**: DTOs use `[AtributoBind]` to map entity keys to SP names.
- **Generic repository pattern**: `Base<T>` handles common CRUD operations.
- **Custom queries**: `AuxConsultas<T>` supports parameterized SP calls with higher timeouts for analytics workloads.

## BI-specific implementation notes
- Connection targets include the operational DB, data warehouse, and OLAP cube.
- Cubes are accessed via HTTP pump (`msmdpump.dll`), enabling MDX-based analytics for dashboards.
- KPI visualizations are generated with a custom C# wrapper that emits Highcharts gauge configs.

## Project structure
- `CobNet.BI.Web` - ASP.NET MVC application and views.
- `CobNet.BI.BLL` - business logic layer (use-case orchestration).
- `CobNet.BI.DAL` - ADO.NET data access + stored procedure execution.
- `CobNet.BI.DTO` - DTOs and binding metadata attributes.
- `CobNet.BI.Highcharts` - helper classes to render Highcharts gauges.
- `CobNet.BI.Web.Tests` - MSTest project scaffold.

## Running locally
1. Open `CobNet.BI.sln` in Visual Studio 2013+.
2. Restore NuGet packages.
3. Configure connection strings in `CobNet.BI.DAL/Conexao.cs` for your environment.
4. Ensure required stored procedures and DW objects exist.
5. Run the `CobNet.BI.Web` project with IIS Express.

## Recruiter highlights
- Built a layered, maintainable BI platform with strong separation of concerns.
- Optimized for analytics workloads with stored procedures and a DW-first approach.
- Custom charting helpers that generate Highcharts gauges directly from C# models.
- Internationalization-aware UI (pt-BR) and a clear KPI-focused UX.

## Security note
Before publishing, replace any hardcoded credentials in `CobNet.BI.DAL/Conexao.cs` with environment-specific secrets (config or environment variables).
