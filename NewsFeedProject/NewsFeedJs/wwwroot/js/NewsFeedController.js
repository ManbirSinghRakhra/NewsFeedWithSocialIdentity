var app = angular.module("myNewsFeedApp", []);
app.controller("myNewsFeedController", function ($scope, $http) {


    //Login and Logout Functions -- Start
    $scope.loginSuccessful = false;
    $scope.login = login;
    $scope.logout = logout;
    $scope.loginSuccessful = false;
    $scope.profileName = "Hi There!";
    $scope.proifleEmail = "";
    $scope.AllNewsFeeds = [];
    $scope.PostFeed = PostFeed;
    apiUrl = "http://localhost:5001/api/News";
    identityUrl = "http://localhost:5000";
    clientBaseUrl = "http://localhost:5003/";

    var config = null;
    var mgr = null;

    InitializeOidc();
    CheckLoginStatus();

    function InitializeOidc() {
        config = {
            authority: identityUrl,
            client_id: "NewsFeedJs",
            redirect_uri: clientBaseUrl+"callback.html",
            response_type: "id_token token",
            scope: "openid profile email NewsFeedApis",
            post_logout_redirect_uri: clientBaseUrl+"index.html"
        };

        mgr = new Oidc.UserManager(config);
    }

    getAllNews();

    function CheckLoginStatus() {
        mgr.getUser().then(function (user) {
            $scope.$apply(function () {
                $scope.loginSuccessful = true;
                if (user === null) {
                    $scope.loginSuccessful = false;
                    $scope.profileName = "Hi There!";
                }
                else {
                    $scope.profileName = user.profile["name"];
                    $scope.profileEmail = user.profile["email"];
                    $http.defaults.headers.common.Authorization = 'Bearer ' + user.access_token;

                }
            });
        });
    }

    function login() {
        if (!$scope.loginSuccessful) {
            mgr.signinRedirect();
        }
    }

    function logout() {
        if ($scope.loginSuccessful) {
            mgr.signoutRedirect();
        }
    }
    //Login and Logout Functions -- End


    //Call to api -- Start
    function PostFeed() {
        DisplayFeedHelpMessage();
        if (!$scope.loginSuccessful)
            return;

        $http({
            method: "POST",
            url: apiUrl,
            data: {
                message: $scope.NewsFeedText,
                userName: $scope.profileName,
                userEmail: $scope.profileEmail
            }

        }).then(function (response) {
            $scope.NewsFeedText = "";
            CheckNewFeedTextBox();
            getAllNews();
            }, function myError(response) {
            console.log(response.statusText);
        });
    }

    function getAllNews() {
        DisplayFeedHelpMessage();
        $http({
            method: "GET",
            url: apiUrl
          
        }).then(function (response) {
            $scope.AllNewsFeeds = response.data;
        }, function myError(response) {
            console.log(response.statusText);
        });
    }
    //Call to api -- End



    //Code to handle View -- Start 
    $scope.CheckNewFeedTextBox = CheckNewFeedTextBox;
    $scope.DisableIfTextBoxEmpty = true;
    $scope.displayFeedHelpMessage = false;

    function CheckNewFeedTextBox() {
        DisplayFeedHelpMessage();
        if ($scope.displayFeedHelpMessage) {
            return;
        }
        
        $scope.DisableIfTextBoxEmpty = false;
        if ($scope.NewsFeedText.length === 0) {
            $scope.DisableIfTextBoxEmpty = true;
        }
    }

    function DisplayFeedHelpMessage() {
        $scope.displayFeedHelpMessage = false;
        if (!$scope.loginSuccessful) {
            $scope.displayFeedHelpMessage = true;
        }
    }
    //Code to handle View -- Start 
});