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
    

    var config = null;
    var mgr = null;

    InitializeOidc();
    CheckLoginStatus();

    function InitializeOidc() {
        config = {
            authority: "http://localhost:5000",
            client_id: "NewsFeedJs",
            redirect_uri: "http://localhost:5003/callback.html",
            response_type: "id_token token",
            scope: "openid profile email NewsFeedApis",
            post_logout_redirect_uri: "http://localhost:5003/index.html",
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
                    $http.defaults.headers.common.Authorization = 'Bearer '+user.access_token;

                }
            })
        })
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

    $scope.postFeed = function() {
        DisplayFeedHelpMessage();

    }

    function getAllNews() {
        DisplayFeedHelpMessage();
        $http({
            method: "GET",
            url: "http://localhost:5001/api/News",
          
        }).then(function(response) {
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