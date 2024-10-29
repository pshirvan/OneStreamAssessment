# OnStreamAssessment Solution

This solution is a microservices-based architecture with a Blazor WebAssembly frontend and multiple backend API services. The projects are designed to work together, with BlazorFrontend as the primary frontend application and FrontendAPI, BackendAPI2, and BackendAPI3 as supporting backend services.

## Solution Overview

### Projects in the Solution

1. BlazorFrontend: The user-facing Blazor WebAssembly application.
2. FrontendAPI: Acts as a gateway API to handle requests from the Blazor frontend and route them to backend services.
3. BackendAPI2: A backend microservice managing part of the data processing.
4. BackendAPI3: Another backend microservice handling specific data operations.

### Requirements

- Visual Studio 2022 with .NET 8 SDK installed.
- Internet connection to restore NuGet packages if needed.

---

## Setting Up Multiple Startup Projects in Visual Studio 2022

To run the solution, you need to configure multiple startup projects so that all services start simultaneously. Here’s how to set it up in Visual Studio 2022:

1. Open the Solution:
   - Launch Visual Studio 2022 and open the `OnStreamAssessment.sln` solution file.

2. Set Multiple Startup Projects:
   - In Solution Explorer, right-click on the solution (`OnStreamAssessment`) and select Set Startup Projects....
   
3. Configure the Projects to Start:
   - In the Startup Project dialog, select Multiple startup projects.
   - For each project in the solution, set the Action to `Start`:
     - BlazorFrontend: `Start`
     - FrontendAPI: `Start`
     - BackendAPI2: `Start`
     - BackendAPI3: `Start`

4. Save the Settings:
   - Click OK to save the startup configuration.

5. Verify `launchSettings.json` Configuration (Optional):
   - Make sure each project’s `launchSettings.json` file has a unique port configured for `applicationUrl` to avoid port conflicts.
   - Example ports:
     - BlazorFrontend: `http://localhost:5214`
     - FrontendAPI: `http://localhost:5030`
     - BackendAPI2: `http://localhost:5001`
     - BackendAPI3: `http://localhost:5002`

6. Run the Solution:
   - Press F5 or click the Start button in Visual Studio to launch all projects.
   - The BlazorFrontend app will open in the browser, while the API projects will start and be accessible on their respective URLs.

---

## Troubleshooting

- Projects Don’t Start: If the projects don’t start as expected, double-check the startup configuration and ensure each project’s action is set to `Start`.
- Port Conflicts: If there are errors related to port conflicts, check each project’s `launchSettings.json` file to ensure all ports are unique.



