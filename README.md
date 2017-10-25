# Legato
Just a little sample .NET/AngularJs project, nevermind

## Getting ready
IIS
1. Make sure that IIS (Internet Information Services) is intstalled on your computer.
   To do this, go to Control Panel->Programs->Turn Windows Features On or Off. Check 'Internet Information Services'.
   Wait for IIS to install.
2. Then, when IIS is installed, open IIS Manager. Expand the server you want to use. Right-click at 'Sites' -> Add website.
3. Enter site name: 'Legato Service', choose existing application pool or create the new one,
   choose a physical folder for the service files. Leave Type, IP Address, Port and Host name unchanged.
4. Click OK.
5. Repeat same actions for the Middleware service. Name it 'Legato Middleware Service'. Choose other that default port.
   Also an application pool for the Middleware service has to have 'LocalSystem' Identity.
   In order to set this, go to IIS Manager->Application Pools, right-click on the pool you chose, go to Advanced Settings->Process Model.
   Change Identity from 'ApplicationPoolIdentity' to 'LocalSystem'.

Legato uses MS SQL Server databases. Install MSSQL if it is not installed.

## Installing components

Clone Git repository, open 'Legato' solution with Visual Studio (2015 or higher is recommended).

1. Right-click at Legato.Middleware project.
2. Check 'Publish'.
3. Create custom publish profile. Name it however you want, e.g. 'LegatoMiddleware'.
   Enter server name 'localhost', site name: 'Legato Middleware Service'. Click 'Publish'.
4. Right-click at Legato.Service project.
5. Check 'Publish'.
6. Create one more custom profile. Name it however you want. Enter server name 'localhost' and site name 'Legato Service. Click 'Publish'.
7. Go to Legato.Client folder via command line.
8. Type 'npm install' to install application dependencies.
9. Type 'npm start' to start and application.