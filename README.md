# CRM Easy Package Deploy

A simple pre-built template so you can use the Package Deployer tool without having to open Visual Studio.

Using this template you can create a package that will work with the CRM Package Deployer tool to install one or more CRM solutions along with any data imports.

There are two main limitations to using this template and not starting with the Visual Studio template
- You do not have the ability to run custom code to do that you would need to use the full Visual Studio Approach
- You can't create two or more packages with this template and have them used by one instance of the Package Deployer tool.  

The full Visual Studio Package Deployer package preparation documentation can be found here - https://msdn.microsoft.com/en-us/library/dn688182.aspx

Steps for using this template:

- Download the TemplatePackage.zip and unzip locally

- Edit the EasyCRMPackage.json file and change the following text
    "ShortName": "Package Short Name Here",
    "LongName": "Package Long Name Here",
    "Description": "Description Goes Here",

  For example it might look like the following
    "ShortName": "Dave's Cool Tools'",
    "LongName": "Dave's Really Long Cool Name",
    "Description": "This is a great tool to use on your project",

- Edit the PkgFolder\Content\en-us\WelcomeHtml\HTML\default.htm file and change the title and description 

- Edit the PkgFolder\Content\en-us\EndHtml\HTML\default.htm file and change the title and description 

- Copy your CRM Solution Files to PkgFolder

- Edit the ImportConfig.xml file

- Change the Solutions element to contain your list of Solutions to import - for example :
 <solutions>
    <configsolutionfile solutionpackagefilename="solutionFile1.zip" />
    <configsolutionfile solutionpackagefilename="solutionFile2.zip" />
  </solutions>

 - If you used the Configuraton Migration tool to extract data and you want to import it you can provide the name using the crmmigdataimportfile="" element 
 e.g crmmigdataimportfile="data.zip"

 You should be able to make most of the changes documented here - https://msdn.microsoft.com/en-us/library/dn688182.aspx that don't involve code using this approach

 - Download the CRM SDK

 - Copy $SDK\Tools\PackageDeployer folder to a new folder

 - Copy your template folder contents to that same folder

 - Run Package Deployer and you should see your package listed
