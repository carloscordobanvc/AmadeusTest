# AmadeusTest
# ANGULAR AND .NET
This project is a CRUD of users
This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 9.1.1 and dotnet core 3.1.

To run front end in ClientApp route run  npm install - npm start

To run back end in main route run donet run

swagger url https://localhost:5001/swagger/index.html
## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Github

Run `git add .` to add files to commit
Run `git commit -m "Commit Name"` to create a commit
Run `git push origin master`  to upload changes
Run `git pull` to update


## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `-prod` flag for a production build.


## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).

## Installations
Google	Chrome
`https://www.google.com/chrome/browser/desktop/index.html`

NodeJS
`https://nodejs.org/es/`

Visual	Studio	Code (For Front-End)
`https://code.visualstudio.com/`

Visual	Studio	2019 (For Back-End)
`https://visualstudio.microsoft.com/es/downloads/`

Microsoft SQL Server Management Studio (For Database)
`https://aka.ms/ssmsfullsetup`

DBeaver (For Database)
`https://dbeaver.io/`

(DONT DO THIS STEP YET) Install the postgreSQL Add-On
`https://marketplace.visualstudio.com/items?itemName=RojanskyS.NpgsqlPostgreSQLIntegration`

PostMan (To check the APIs)
`https://www.getpostman.com/`

Microsoft OLE DB Driver 18 for SQL Server
`https://www.microsoft.com/en-us/download/confirmation.aspx?id=56730`

AngularCLI
`https://cli.angular.io/`

Plugins	y	snippets	de	Visual	Studio	Code
- Angular 2 TypeScript Emmet
- Angular 8 Snippets - TypeScript, Html, Angular
- Angular Files
- Angular Language Service
- Angular Snippets (Version 9)
- angular2-inline
- Auto Import
- Bootstrap 4, Font awesome 4, Font Awesome
- Debugger for Chrome
- Github
- Monokai Night Theme
- npm Intellisense
- Paste JSON as Code
- Prettier Code Formatter
- Prettier Now
- Terminal
- TSLint
- TypeScript Hero
- TypeScript Importer

# DEVELOPMENT


## Github Management

### Master Branch
in the master branch only commit the versions that has finished


## ANGULAR - Create Components and Services

### Components:
Component with style and without test file
`ng g c pages/lesson -is --skipTests`

Component without an aditional folder
`ng g c pages/lesson/clases -is --skipTests --flat`

### Services
Service without test file
ng g s services/lessons --skipTests

## VISUAL STUDIO 2019 (BACK-END) - Create Models and REST APIS

### Configuration on desktop

Go to `C:\Windows\System32\drivers\etc` edit with administrator privileges the file `host` and uncomment the localhost name resolution is handled within DNS itself.
```
127.0.0.1       localhost
::1             localhost
```
To trust the certificate run `dotnet dev-certs https --trust` (Windows and macOS only).
For establishing trust on other platforms refer to the platform specific documentation.

### Create models automatically
In Tools -> NuGet Package Manager -> Package Manager Console





