/// <reference path="../angular.js" />
/// <reference path="../app.js" />

app.service('AdditionalInterestService', function ($http) {
    var api = 'http://localhost:61824/api';

    this.getQuote = function () {

        return $http.get(api+'/AdditionalInterest/GetQuote');

    }

    this.getSearchResults = function (name) {

        return $http.get(api + '/AdditionalInterest/GetSearchResults?name=' + name);

    }

    this.SaveAdditionalInterestContact = function (contact) {

        var response = $http({
            method: "post",
            url: api + '/AdditionalInterest/SaveContact',
            data: JSON.stringify(contact),
            dataType: "json"
        });
        return response;

    }

});