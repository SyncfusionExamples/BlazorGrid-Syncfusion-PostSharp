# Blazor DataGrid - PostSharp

## Overview

This sample demonstrates how to use Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) together with PostSharp-based application patterns to retrieve data from a server and automatically retry requests when transient connection failures occur. The application fetches data from the server, applies retry behavior when the connection is unavailable, and binds the resulting records to the Syncfusion Blazor DataGrid after a successful response. The sample provides a practical reference for improving resiliency in Blazor applications that depend on remote data sources.

## Key Features

- Demonstrates Syncfusion Blazor DataGrid data binding with server-side data retrieval.
- Implements an automatic retry mechanism when a server connection failure occurs.
- Loads and binds Grid data after a successful retry operation.
- Shows how resiliency patterns can be integrated into a Blazor application before data is rendered in the Grid.
- Includes a dedicated project named `PostSharpBlazorSyncfusionGrid`.
- Demonstrates a workflow where transient communication failures are handled before updating the Grid data source.
- References a PostSharp-based implementation approach described in the associated blog article.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file located in the `PostSharpBlazorSyncfusionGrid` project folder. `[VERIFY: exact .sln filename]`
3. Restore all NuGet packages.
4. Set the appropriate startup project if required.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory.

```bash
cd PostSharpBlazorSyncfusionGrid
dotnet restore
dotnet run
```

4. Open the local application URL displayed in the terminal after startup.

## Project Structure

- `PostSharpBlazorSyncfusionGrid/Pages/` — contains the page that renders the Syncfusion Blazor DataGrid and initiates data loading. 
- `PostSharpBlazorSyncfusionGrid/Services/` — contains server communication and retry-related logic. 
- `PostSharpBlazorSyncfusionGrid/wwwroot/` — contains static assets and styles consumed by the sample application.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official Syncfusion Blazor DataGrid documentation, see https://help.syncfusion.com/grid-sdk/blazor/data-grid/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
