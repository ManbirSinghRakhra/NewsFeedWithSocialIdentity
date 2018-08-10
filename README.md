# Welcome to News Feed Posts

## Introduction to Asp.Net Core and AngularJS based News Feed Environments.
1. This Application is built using Asp.Net Core 2.0, 2.1 and AngularJs 1.7.
2. There are three main projects on this application.
3. I have used SOLID Design principles in the programming level.
4. I have used in-built Dependency Injections package provided by Microsoft Asp.Net Core. This is very handy. Therefore, for this project, I have decided to use this over Ninject.
5. I have attempted this project with my best knowledge and honestly.



## Introduction to main Projects
* IdentityServer - This handles the identity. I have attached it with Google External Authentication using OIDC. This runs on port no: 5000
* NewsFeedApis - this is api which only accepts valid and authenticated requests (Authenticated by Identity Server). This runs on port no: 5001
*  NewsFeedJs -  This is asp.net core and angularjs based api client which is visited by end users. This consumes NewFeedApis and Identifies the users using Identity Server. This runs on port no: 5003

## Instructions to run the application.
* This application will run without any problem if you hit the start button with Multiple Start Up projects.
![Multiple Startup Projects](https://github.com/ManbirSinghRakhra/NewsFeedWithSocialIdentity/blob/master/ReadmeImages/MutlipleProjectsRun.JPG)

* If you still have any problem in running the project, Please ensure the following settings for individual projects and solution.
* Check the properties of IdentityServer project only for Debug
![IdentityServer Project Debug Properties](https://github.com/ManbirSinghRakhra/NewsFeedWithSocialIdentity/blob/master/ReadmeImages/IdentityServerDebugProperties.JPG)

* Check the properties of NewsFeedApis project only for Debug
![NewsFeedApis Project Debug Properties](https://github.com/ManbirSinghRakhra/NewsFeedWithSocialIdentity/blob/master/ReadmeImages/NewsFeedApisDebugProperties.JPG)

* Check the properties of NewsFeedJs project only for Debug
![NewsFeedApis Project Debug Properties](https://github.com/ManbirSinghRakhra/NewsFeedWithSocialIdentity/blob/master/ReadmeImages/NewsFeedJsDebugProperties.JPG)

* Check the properties of solution only for Debug
![Solution Debug Properties](https://github.com/ManbirSinghRakhra/NewsFeedWithSocialIdentity/blob/master/ReadmeImages/SolutionProperties.JPG)


## Further Important Notes and Instructions
* In order to give you best experience, I have done automated Database Migrations. This will successfully create the mssqllocaldb database on your first time use given below. 
> Your Visual Studio 2017 will have this database in built. Or, if you do not have, please change the connection string under project NewsFeedApis-> appsettings.json

> Server=(localdb)\\mssqllocaldb;Database=NewsFeedDatabase;Trusted_Connection=True;MultipleActiveResultSets=true

![Solution Debug Properties](https://github.com/ManbirSinghRakhra/NewsFeedWithSocialIdentity/blob/master/ReadmeImages/EnsureCreated.JPG)


* Please be paitence for the first time use. For your best experience, this project will be creating the database and adding some constructive News Feed posts using DbInitilizer class written by me.
* Upon start the project, this will bring up three end points
* IdentityServer: http://localhost:5000/  this runs in the background
* NewsFeedApis: http://localhost:5001/ this runs in the background
* NewsFeedJs: http://localhost:5003/ Upon starting the project, this will start your default browser and like below.
![Browsers](https://github.com/ManbirSinghRakhra/NewsFeedWithSocialIdentity/blob/master/ReadmeImages/Browsers.JPG)


## Authors
* Manbir Singh Rakhra 
* manbir.s.rakhra@gmail.com
* +61 413 230 257


