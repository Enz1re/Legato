# Legato
Just a little sample .NET/AngularJs project, nevermind

## Getting ready
IIS
1. Make sure that IIS (Internet Information Services) is intstalled on your computer.
   To do this, go to Control Panel->Programs->Turn Windows Features On or Off. Check 'Internet Information Services'.
   Wait for IIS to install.
2. Then, when IIS is installed, open IIS Manager. Expand the server you want to use. Right-click at 'Sites'->Add website.
3. Enter site name: 'Legato Service', choose existing application pool or create the new one,
   choose a physical folder for the service files - a folder with Legato.Service project.
   Leave Type, IP Address, Port and Host name unchanged.
4. Click OK.
5. Repeat same actions for the Middleware service. Name it 'Legato Middleware Service'. Choose other that default port.
   Also an application pool for the Middleware service has to have 'LocalSystem' Identity.
   In order to set this, go to IIS Manager->Application Pools, right-click on the pool you chose, go to Advanced Settings->Process Model.
   Change Identity from 'ApplicationPoolIdentity' to 'LocalSystem'.

Typescript & npm
1. As long as project uses typescript, you should install Typescript for Visual Studio extenstion.
   For VS2015: https://www.microsoft.com/en-us/download/details.aspx?id=48593
   For VS2017: https://www.microsoft.com/en-us/download/details.aspx?id=55258
2. To use project with npm, you need to install npm.
   To install it go to https://www.npmjs.com/get-npm?utm_source=house&utm_medium=homepage&utm_campaign=free%20orgs&utm_term=Install%20npm.
   Be sure that you have on

Legato uses MS SQL Server databases. Install MSSQL if it is not installed.

## Installing components

Clone Git repository, open 'Legato' solution with Visual Studio (2015 or higher is recommended) in administrator mode.

1. Click Build->Rebuild solution.
2. If build is successful, you can start using Legato.
7. Go to Legato.Client folder via the command line.
8. Type 'npm install' to install application dependencies.
9. Type 'npm start' to start application.