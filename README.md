## Description

Solution example describing the way to inject configuration in constructors using IOptions in .NET Core.

## How to run

Clone/download the repository.
Run ```dotnet restore ```
Run Web project using IISExpress/Kestrel.

## More information
1. Take a look into all the NuGet packages in ```ClassLibraryConfiguration.Core``` project.
2. Inside ```ClassLibraryConfiguration.Core.ConfigurationHelper``` we are building the Configuration that is situated in another project (```ClassLibraryConfiguration.Web```).
3. The ```ClassLibraryConfiguration.Core.Infrastructure.CoreIoCContainer``` class is responsable with registrations.
4. ```CoreIoCContainer.AddToContainer``` is called from Web project (Startup.cs).
