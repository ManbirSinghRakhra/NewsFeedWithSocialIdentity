# Welcome to News Feed Posts

## Introduction to Asp.Net Core and AngularJS based News Feed Environments.
1. This Application is built using Asp.Net Core 2.0, 2.1 and AngularJs 1.7.
2. There are three main projects on this application.

## Introduction to main Projects
* IdentityServer - This handles the identity. I have attached it with Google External Authentication using OIDC.
* NewsFeedApis - this is api which only accepts valid and authenticated requests (Authenticated by Identity Server)
*  NewsFeedJs -  This is asp.net core and angularjs based api client which is visited by end users. This consumes NewFeedApis and Identifies the users using Identity Server.

## Instructions to run the application.
* This application will run with any problem if you hit the
![Multiple Startup Projects](./ReadmeImages/MultipleProjectsRun.JPG "Logo Title Text 1")