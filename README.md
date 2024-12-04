![WebExpress](https://raw.githubusercontent.com/ReneSchwarzer/WebExpress/main/assets/banner.png)

# WebExpress
`WebExpress` is a lightweight web server optimized for use in low-performance environments (e.g. Rasperry PI). By providing 
a powerful plugin system and a comprehensive API, web applications can be easily and quickly integrated into a .net 
language (e.g. C#). Some advantages of `WebExpress` are:

- It is easy to use.
- It offers a variety of features and tools that can help you build and manage your website.
- It is fast and efficient and can help you save time and money.
- It is flexible and can be customized to meet your specific requirements.

The `WebExpress` family includes the following projects:

- [WebExpress](https://github.com/ReneSchwarzer/WebExpress#readme) - The web server for `WebExpress` applications and the documentation.
- [WebExpress.WebCore](https://github.com/ReneSchwarzer/WebExpress.WebCore#readme) - The core for `WebExpress` applications.
- [WebExpress.WebUI](https://github.com/ReneSchwarzer/WebExpress.WebUI#readme) - Common templates and controls for `WebExpress` applications.
- [WebExpress.WebIndex](https://github.com/ReneSchwarzer/WebExpress.WebIndex#readme) - Reverse index for `WebExpress` applications.
- [WebExpress.WebApp](https://github.com/ReneSchwarzer/WebExpress.WebApp#readme) - Business application template for `WebExpress` applications.

`WebExpress` is part of the `WebExpress` family. The project provides a web server for `WebExpress` applications.

To get started with `WebExpress`, use the following links.

- [installation guide](https://github.com/ReneSchwarzer/WebExpress/blob/main/doc/installation_guide.md) 
- [development guide](https://github.com/ReneSchwarzer/WebExpress/blob/main/doc/development_guide.md)

# Tutorial
Tutorial of a simple Hello World application for WebExpress. Two projects are created for the tutorial. The `HelloWorld` project contains the functionality and all resources to run as a WebExpress application. The project `HelloWorld.App` is a helper project that is needed for debugging, testing and packaging creation.

## Prerequisites
- Install .NET 9.0. You can download and install .NET 9.0 from the official .NET website. Follow the instructions on the website to complete the installation.
- Verify the installation. Open the command line or terminal and run the following command:
  ```bash
  dotnet --version
  ```
  This command outputs the installed .NET version. Make sure the outputted version matches the version you installed (in this case 9.0).

After fulfilling these prerequisites, you can proceed with the tutorial.

## Create a new solution
- Open the command line or terminal.
    - On Windows, you can open the command line by typing cmd into the search box of the Start menu and pressing Enter.
    - On MacOS or Linux, you can open the terminal by typing terminal into the Spotlight search and pressing Enter.
- Navigate to the desired directory.
- Use the command cd `path/to/directory` to navigate to the desired directory.
- Create a new solution. Enter the following command and press Enter:
  ```bash
  # create a new folder for your solution
  mkdir WebExpress.Tutorial.HelloWorld
  cd WebExpress.Tutorial.HelloWorld

  # create a new solution
  dotnet new sln -n WebExpress.Tutorial.HelloWorld

  # create a new console application
  dotnet new console -n HelloWorld.App -f net9.0

  # create a new class library
  dotnet new classlib -n HelloWorld -f net9.0

  # add the projects to the solution
  dotnet sln add ./HelloWorld.App/HelloWorld.App.csproj
  dotnet sln add ./HelloWorld/HelloWorld.csproj
  ```

This command creates a new .NET solution named `WebExpress.Tutorial.HelloWorld` and uses .NET 9.0 as the framework.
- Check the newly created solution. There should now be a new directory named `WebExpress.Tutorial.HelloWorld` in the current directory. You can view the contents of this directory with the command ls (Linux/Mac) or dir (Windows).
- Open the solution in your preferred development environment.
  - If you are using Visual Studio Code, you can open the solution with the command `code .` in the solution directory.

Now you have created a new solution and are ready to proceed with the next steps in your tutorial.

## Customize the project
- Add the necessary dependencies in the `HelloWorld` project file.
  ```xml
  <PropertyGroup>
      ...
      <EnableDynamicLoading>true</EnableDynamicLoading>
  </PropertyGroup>

  <ItemGroup>
      <PackageReference Include="WebExpress.WebCore" Version="0.0.8-alpha">
          <Private>false</Private>
          <ExcludeAssets>runtime</ExcludeAssets>
      </PackageReference>
  </ItemGroup>
  ```
- Add the necessary dependencies in the `HelloWorld.App` project file.
  ```xml
  <ItemGroup>
      <PackageReference Include="WebExpress.WebCore" Version="0.0.8-alpha" />
  </ItemGroup>

  <ItemGroup>
      <ProjectReference Include="../HelloWorld/HelloWorld.csproj" />
  </ItemGroup>
  ```
- Adjust the project file to your requirements.

## Configure the WebExpress package
- Add a file named `WebExpress.Tutorial.HelloWorld.spec` in the solution folder.
  ```xml
  <?xml version="1.0" encoding="utf-8"?>
  <package>
      <id>WebExpress.Tutorial.HelloWorld</id>
      <version>0.0.8-alpha</version>
      <title>HelloWorld</title>
      <authors>rene_schwarzer@hotmail.de</authors>
      <license>MIT</license>
      <icon>icon.png</icon>
      <readme>README.md</readme>
      <privacypolicy>PrivacyPolicy.md</privacypolicy>
      <description>Provides a simple web application that issues a hello world greeting.</description>
      <tags>webexpress tutorial</tags>
      <plugin>HelloWorld</plugin>
  </package>
  ```
- Adjust the spec file to your requirements.
- Add the spec file in the `HelloWorld.App` project file.
  ```
  <Target Name="PostBuild" AfterTargets="PostBuildEvent" Condition="'$(Configuration)' == 'Release'">
      <Exec Command="$(SolutionDir)$(AssemblyName)/bin/$(Configuration)/$(TargetFramework)/$(AssemblyName).exe -s $(SolutionDir)/$(SolutionName).spec -c $(Configuration) -t $(TargetFramework) -o $(SolutionDir)/pkg/$(Configuration)" />
  </Target>
  ```

## Create a WebExpress plugin
- Create a new class `Plugin` in the `HelloWorld` project that implements the `IPlugin` interface.
  ```csharp
  using WebExpress.WebCore.WebAttribute;
  using WebExpress.WebCore.WebPlugin;

  namespace HelloWorld
  {
      [Name("HelloWorld:plugin.name")]
      [Description("HelloWorld:plugin.description")]
      [Icon("/assets/img/helloworld.svg")]
      [Application<Application>()]
      public sealed class Plugin : IPlugin
      {
          public void Run() {}
          public void Dispose() {}
      }
  }
  ```
- Adjust the class to your requirements.

## Create a WebExpress application
- Create a new class `Application` in the `HelloWorld` project that implements the `IApplication` interface.
  ```csharp
  using WebExpress.WebCore.WebApplication;
  using WebExpress.WebCore.WebAttribute;

  namespace HelloWorld
  {
      [Name("HelloWorld:app.name")]
      [Description("HelloWorld:app.description")]
      [Icon("/assets/img/helloworld.svg")]
      [AssetPath("/")]
      [ContextPath("/helloworld")]
      public sealed class Application : IApplication
      {
          public void Run() {}
          public void Dispose() {}
     }
  }
  ```
- Adjust the class to your requirements.

## Create a homepage
- Create a new view for the home page in the `HelloWorld` project.
  ```csharp
  using WebExpress.WebCore.Internationalization;
  using WebExpress.WebCore.WebAttribute;
  using WebExpress.WebCore.WebHtml;
  using WebExpress.WebCore.WebPage;

  namespace HelloWorld.WebPage
  {
      [Title("HelloWorld:homepage.label")]
      [Segment(null, "HelloWorld:homepage.label")]
      [ContextPath(null)]
      public sealed class HomePage : IPage<RenderContext>
      {
          public void Redirecting(string uri) {}
  
          public void Process(IRenderContext renderContext)
          {
              renderContext.VisualTree.Favicons.Add(new Favicon(renderContext?.PageContext?.ApplicationContext?.ContextPath.Append("/assets/img/favicon.png")));
              renderContext.VisualTree.Content = new HtmlText(I18N.Translate("HelloWorld:homepage.text"));
          }

          public void Dispose() {}
      }
  }
  ```
- Adjust the homepage to your requirements.

## Change the program class
- Change the program class of the `HelloWorld.App` project as follows:
  ```csharp
  using System.Reflection;

  namespace HalloWorld.App
  {
      internal class Program
      {
          static void Main(string[] args)
          {
              var app = new WebExpress.WebCore.WebEx()
              {
                  Name = Assembly.GetExecutingAssembly().GetName().Name
              };

              app.Execution(args);
          }
      }
  }
  ```

## Internationalization
- Add support for multiple languages. This can be achieved by using i18n files. Each resource file contains the translations for all strings in your application. Name your resource files according to the culture they represent. For example, the file for German translations should be called `de``. In the following, we use the english language.
 ```
 plugin.name=HelloWorld
 plugin.description=

  app.name=HelloWorld
  app.label=Hello World
  app.description=Tutorial of a simple hello world WebExpress application.
  app.license.label=License MIT 
  app.license.uri=https://github.com/ReneSchwarzer/WebExpress.Tutorial.HelloWorld/blob/main/LICENSE
  app.version.label={0} version {1} created with {2} version {3}.

  homepage.label=Home page
  homepage.text=Hello world!
  ```

  - Add the en file in the `HelloWorld` project file.
  ```xml
  <ItemGroup>
      <EmbeddedResource Include="Internationalization/en" />
  </ItemGroup>
  ```

## Add the Assets
- Add assets to the `HelloWorld` project. You can get the assets for this tutorial here: https://github.com/ReneSchwarzer/WebExpress.Tutorial.HelloWorld/tree/main/src/HelloWorld/Assets/img
- Add the assets in the `HelloWorld` project file.
  ```xml
  <ItemGroup>
      <EmbeddedResource Include="Assets/img/favicon.png" />
      <EmbeddedResource Include="Assets/img/helloworld.svg" />
  </ItemGroup>
  ```

## Add a Configuration
- The application must be configured. A standard configuration must be delivered for this purpose. Add the configuration file to the `HelloWorld.App` project.
  ```xml
  <?xml version="1.0" encoding="utf-8" ?>
  <config version = "1">
      <log modus="Off" debug="false" path="/var/log/" encoding="utf-8" filename="webexpress.log" timepattern="dd.MM.yyyy HH:mm:ss" />
      <uri>http://localhost/</uri>
      <endpoint uri="http://localhost/"/>
      <limit>
          <connectionlimit>300</connectionlimit>
          <uploadlimit>3000000000</uploadlimit>
      </limit>
      <culture>en</culture>
      <packages>./packages</packages>
      <assets>./assets</assets>
      <data>./data</data>
      <contextpath></contextpath>
  </config>
  ```
- Include the configuration file in the `HelloWorld.App` project file.
  ```
  <ItemGroup>
      <None Update="config/webexpress.config.xml">
          <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
      </None>
  </ItemGroup>
  ```

## Compile and register in WebExpress
- Compile the solution as a release. To do this, open the command line or terminal in the solution directory and run the following command:
  ```bash
  dotnet build --configuration Release
  ```
  This command compiles the solution in release mode. You can find the compiled files in the `bin/Release` directory of your project.

- Run the solution by starting the `HelloWorld.App` project.
  ```bash
  cd HelloWorld.App\bin\Release\net9.0
  dotnet run --project ../../../HelloWorld.App.csproj
  ```

- After compiling, there should be a file with the `.wxp` extension in the `pkg/Release` directory. This file do you need in `WebExpress`.

## Try the application
- Check the result by calling up the following URL in the browser: [http://localhost/helloworld](http://localhost/helloworld)

Good luck!
    
# Tags
#WebExpress #WebServer #WebCore #WebUI #Tutorial #DotNet