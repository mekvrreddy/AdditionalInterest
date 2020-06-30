/// <reference path="../angular.js" />
/// <reference path="../app.js" />
/// <reference path="../services/additionalinterestservice.js" />

app.controller('AdditionalInterestCtrl', function ($scope, AdditionalInterestService) {


    $scope.Quote = {};

    $scope.searchName = "";

    $scope.searchResults = [];

    $scope.Contact = {
        Name: "",
        Address :"",
        City: "",
        StateId:0,
        State:"",
        ZipCode:"",
        Phone:"",
        Fax:"",
        Email:""
    };

    loadAdditionalInterest();

    $scope.enableSearch = false;
    $scope.enableAddContact = false;


    function loadAdditionalInterest() {

        var quote = AdditionalInterestService.getQuote();

        quote.then(function (ai) {
            $scope.Quote = ai.data;
        }, function (errorai) {
            alert(errrai);
        });
    }

    $scope.EnableDisableSection = function (selectedoption) {
        $scope.enableSearch = false;
        $scope.enableAddContact = false;
        $scope.searchName = "";
        $scope.searchResults = [];
        if (selectedoption == true) {
            $scope.enableSearch = true;
        }
    }

    $scope.SearchCommand = function loadSearchResults(searchname) {

        var searchres = AdditionalInterestService.getSearchResults(searchname);

        searchres.then(function (ai) {
            $scope.searchResults = ai.data;
        }, function (errorai) {
            alert(errrai);
        });
    }

    $scope.EnableAddSection = function () {
        $scope.enableAddContact = true;
        $scope.Contact = {
            Name: "",
            Address: "",
            City: "",
            StateId: 0,
            State: "",
            ZipCode: "",
            Phone: "",
            Fax: "",
            Email: ""
        };
        $scope.Contact.Name = $scope.searchName;
    }

    $scope.SaveContact = function (Contact) {
        var quote = AdditionalInterestService.SaveAdditionalInterestContact(Contact);

        quote.then(function (ai) {
            $scope.enableAddContact = false;
            $scope.Contact = {
                Name: "",
                Address: "",
                City: "",
                StateId: 0,
                State: "",
                ZipCode: "",
                Phone: "",
                Fax: "",
                Email: ""
            };
            loadSearchResults($scope.searchName);
        }, function (errorai) {
            alert(errrai);
        });
    }

});