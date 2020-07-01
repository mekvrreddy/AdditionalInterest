/// <reference path="../angular.js" />
/// <reference path="../app.js" />
/// <reference path="../services/additionalinterestservice.js" />

app.controller('AdditionalInterestCtrl', function ($scope, AdditionalInterestService) {


    $scope.Quote = {};

    $scope.searchName = "";

    $scope.searchResults = [];

    $scope.States = [];

    $scope.selectedState = {
        Code: "",
        Name: ""
    };

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
    loadStates();

    $scope.enableSearch = false;
    $scope.enableAddContact = false;
    $scope.enableSearchResults = false;

    function loadAdditionalInterest() {

        var quote = AdditionalInterestService.getQuote();

        quote.then(function (ai) {
            $scope.Quote = ai.data;
        }, function (errorai) {
            alert(errrai);
        });
    }

    function loadStates() {

        var states = AdditionalInterestService.getStates();

        states.then(function (ai) {
            $scope.States = ai.data;
        }, function (errorai) {
            alert(errrai);
        });
    }

    $scope.EnableDisableSection = function (selectedoption) {
        $scope.enableSearch = false;
        $scope.enableAddContact = false;
        $scope.searchName = "";
        $scope.searchResults = [];
        $scope.enableSearchResults = false;
        if (selectedoption == true) {
            $scope.enableSearch = true;
        }
    }

    $scope.SearchCommand = function loadSearchResults(searchname) {

        var searchres = AdditionalInterestService.getSearchResults(searchname);

        searchres.then(function (ai) {
            $scope.searchResults = ai.data;
            if ($scope.searchResults.length > 0) {
                $scope.enableSearchResults = true;
            }
        }, function (errorai) {
            alert(errrai);
        });
    }

    $scope.EnableAddSection = function () {
        $scope.enableAddContact = true;
        $scope.enableSearchResults = false;
        resetContact();
        $scope.Contact.Name = $scope.searchName;
    }

    $scope.SaveContact = function (Contact) {
        var quote = AdditionalInterestService.SaveAdditionalInterestContact(Contact);

        quote.then(function (ai) {
            $scope.enableAddContact = false;
            $scope.enableSearchResults = false;
            resetContact();
            loadSearchResults($scope.searchName);
        }, function (errorai) {
            alert(errrai);
        });
    }

    function resetContact() {
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
    }

    $scope.SelectedState = function () {
        $scope.Contact.State = $scope.selectedState.Code;
    }

});