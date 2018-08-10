# Welcome to News Feed Posts

## Introduction to Asp.Net Core and AngularJS based News Feed Environments.
1. This Application is built using Asp.Net Core 2.0, 2.1 and AngularJs 1.7
2. There are three main projects on this application
..1.  IdentityServer - This handles the identity. I have attached it with Google External Authentication using OIDC.
..2.  NewsFeedApis - this is api which only accepts valid and authenticated requests (Authenticated by Identity Server)
..3.  NewsFeedJs -  This is asp.net core and angularjs based api client which is visited by end users. This consumes NewFeedApis and Identifies the users using Identity Server.


