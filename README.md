# Basic.Template.API
Basic bootstrapped project for creating a new dotnet app using the dotnet new command

### Clone the project locally
```git clone https://github.com/ZackBorton/Basic.Template.API.git```

### Ensure you have the correct version of dotnet installed
Should be 2.2.0 or higher if its not install the latest stable version

``` dotnet --version```

### If this is a local project use the directory containing the .template.config folder
```dotnet new -i FullPathToConfig```

Example 
```dotnet new -i "PathToYourProject/Basic.Template.API/Basic.Template.API/content/"```

### Finally create a new project using the dotnet new syntax
```dotnet new Basic.API.Template```

### Uninstalling
You need to supply the full path to the unintall

### Issues uninstalling
If you have issues uninstalling try running the below command

```dotnet new --debug:reinit```

### Project 
Includes swagger enabled by default @ http://RootURL/swagger/v1/swagger.json

Includes assembly scanning for dependency injection
