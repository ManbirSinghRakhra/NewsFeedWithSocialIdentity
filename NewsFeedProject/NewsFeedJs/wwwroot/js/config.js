
var url = {
    apiUrl: "http://localhost:5001/api/News",
    identityUrl: "http://localhost:5000",
    clientBaseUrl: "http://localhost:5003/",
};



var configJs = {
    apiUrl: url.apiUrl,
    identityUrl: url.identityUrl,
    clientBaseUrl: url.clientBaseUrl,
    response_type: "id_token token",
    client_id: "NewsFeedJs",
    scope: "openid profile email NewsFeedApis",
    redirect_uri: url.clientBaseUrl + "callback.html",
    post_logout_redirect_uri: url.clientBaseUrl + "index.html"
};