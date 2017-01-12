var app = angular.module('myApp', ['uiGmapgoogle-maps']);
app.controller('mapController', function ($scope, $http) {

    //this is for default map focus when load first time
    $scope.map = { center: { latitude: 52.3810724, longitude: 4.637334799999962 }, zoom: 16 }

    $scope.markers = [];
    $scope.locations = [];

    //Populate all location
    $http.get('/product/GetAllLocation').then(function (data) {
        $scope.locaties = data.data;
    }, function () {
        alert('Error');
    });

    //get marker info
    $scope.ShowLocation = function (locatie_ID) {
        $http.get('/product/GetMarkerInfo', {
            params: {
                locatie_ID: locatie_ID
            }
        }).then(function (data) {
            //clear markers 
            $scope.markers = [];
            $scope.markers.push({
                id: data.data.Locatie_ID,
                coords: { latitude: data.data.Breedte, longitude: data.data.Lengte },
                title: data.data.Locatie_Naam,
                address: data.data.Straat,
            });

            //set map focus to center
            $scope.map.center.latitude = data.data.Breedte;
            $scope.map.center.longitude = data.data.Lengte;

        }, function () {
            alert('Error');
        });
    }

    //Show / Hide marker on map
    $scope.windowOptions = {
        show: true
    };

});