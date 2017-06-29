app.controller('MasterPlaceController', ['$scope', 'MasterPlaceServices', 'MasterDistrictsService', function ($scope, MasterPlaceServices, MasterDistrictsService) {


    //******************* Call All Property and DropDown List *****************************

    $scope.GetPlaceLists = "";
    $scope.GetPlaceDisplayLists = [];
    $scope.GetShiftTypeLists = [];
    $scope.getAllDistrictsList = [];


    GetPlaceList();
    GetPlaceDisplayList();
    GetShitTypeList();
    GetDistictList();

    $scope.sample = [{
        "DIST_CODE": '1',
        "DIST_Name": 'Suresh Dasari'
    }, {
        "DIST_CODE": '2',
        "DIST_Name": 'Rohini Alavala'
    }, {
        "DIST_CODE": '3',
        "DIST_Name": 'Mahendra Dasari'
    }, {
        "DIST_CODE": '4',
        "DIST_Name": 'Madhav Sai'
    }, {
        "DIST_CODE": '5',
        "DIST_Name": 'Mahesh Dasari'
    }, {
        "DIST_CODE": '6',
        "DIST_Name": 'Sateesh Alavala'
    }];


    //*******************End*****************************


    //*******************Show Hide Place Page Start*****************************


    //*******************Show Hide Place Page End*****************************


    //*******************Get Place List Start*****************************

    function GetPlaceList() {
        var data = MasterPlaceServices.getAllPlace();
        data.then(function (result) {
            var data = angular.fromJson(result.data);
            try {
                if (data.Status == 1)//Success
                {
                    $scope.GetPlaceLists = data.Data;
                }
                else {
                    throw "Angular Side binding error " + data;
                }
            }
            catch (e) {

            }
        }, function (error) {
            console.log("Master Place Error in Get Place List Start " + error);
        });
    }

    //*******************Get Place List End*****************************


    //*******************Get ShiftType and Place Display and Distict  List Start*****************************


    function GetShitTypeList() {
        var data = MasterPlaceServices.getShiftTypeList();
        data.then(function (result) {


            var data = angular.fromJson(result.data);
            try {
                if (data.Status == 1)//Success
                {
                    $scope.GetShiftTypeLists = data.Data;
                }
                else {
                    throw "Angular Side binding error " + data;
                }
            }
            catch (e) {

            }
        }, function (error) {
            console.log("Master GetShiftTypeLists " + error);
        });
    }

    function GetPlaceDisplayList() {
        var data = MasterPlaceServices.getAllPlaceDisplayList();
        data.then(function (result) {
            var data = angular.fromJson(result.data);
            try {
                if (data.Status == 1)//Success
                {
                    $scope.GetPlaceDisplayLists = angular.fromJson(data.Data);
                }
                else {
                    throw "Angular Side binding error " + data;
                }
            }
            catch (e) {

            }
        }, function (error) {
            console.log("Master GetPlaceDisplayLists " + error);
        });
    }

    function GetDistictList() {
        var data = MasterDistrictsService.getAllDistrictsList();
      
        //var data = MasterDistrictsService.getAllDistrictsList();
        data.then(function (result) {
            try {
                $scope.getAllDistrictsList = result.data;
            }
            catch (e) {

            }
        }, function (error) {
            console.log("Master getAllDistrictsList " + error);
        });
    }

    //*******************Get Place List End*****************************



    //*******************Add and Update Place  Start*****************************

    $scope.AddAndUpdatePlace = function () {
        var PlaceModel =
            {
                DIST_CODE: $scope.DIST_CODE,
                PlaceName: $scope.PlaceName,
                Category: $scope.Category,
                Code: $scope.Code,
                ShiftTypeID: $scope.ShiftTypeID,
                PlaceDisplayIDs: $scope.PlaceDisplayIDs,
                IsAccommodation: $scope.Accommodation,
                IsSafari: $scope.IsSafari,
                IsZone: $scope.IsZone,
                TicketAllocatedPerShift: $scope.TicketAllocatedPerShift,
                MaxBookingDuration: $scope.MaxBookingDuration,
                Tax: $scope.Tax,
                EmitraCharges: $scope.EmitraCharges,
                ContactPerson: $scope.ContactPerson,
                Address: $scope.Address,
                PhoneNo: $scope.PhoneNo,
                Boarding_Point: $scope.Boarding_Point,
                Status: $scope.Status
            }
        $scope.PlaceId = 0;
        var getData = MasterPlaceServices.AddPlace(PlaceModel);
        getData.then(function (result) {

            ClearFields();

        }, function (error) {
            console.log("Add Place Error" + error);

        });
    }

    $scope.PlaceDataByID = function (PlaceID) {
        var getData = MasterPlaceServices.GetPlaceDataById(PlaceID);
        getData.then(function (result) {
            var data = angular.fromJson(result.data);
            if (data.Status == 1) {
                $scope.BindSelectedData(data.Data);
            }
            else {
                alert("Some error Occured in PlaceData from this ID:" + PlaceID)
            }

        });
    }



    $scope.BindSelectedData = function (PlaceModel) {
        $scope.DIST_CODE = PlaceModel.DIST_CODE,
        $scope.PlaceName = PlaceModel.PlaceName,
        $scope.Category = PlaceModel.Category,
        $scope.Code = PlaceModel.Code,
        $scope.ShiftTypeID = PlaceModel.ShiftTypeID,
        $scope.PlaceDisplayIDs = PlaceModel.PlaceDisplayIDs,
        $scope.Accommodation = PlaceModel.IsAccommodation,
        $scope.IsSafari = PlaceModel.IsSafari,
        $scope.IsZone = PlaceModel.IsZone,
        $scope.TicketAllocatedPerShift = PlaceModel.TicketAllocatedPerShift,
        $scope.MaxBookingDuration = PlaceModel.MaxBookingDuration,
        $scope.Tax = PlaceModel.Tax,
        $scope.EmitraCharges = PlaceModel.EmitraCharges,
        $scope.ContactPerson = PlaceModel.ContactPerson,
        $scope.Address = PlaceModel.Address,
        $scope.PhoneNo = PlaceModel.PhoneNo,
        $scope.Boarding_Point = PlaceModel.Boarding_Point,
        $scope.Status = PlaceModel.Status
    }


    //*******************Add and Update  Place  End*****************************



    //*******************Clear ALL Object Start*****************************


    function ClearFields() {
        $scope.PlaceId = "";
        $scope.DIST_CODE = "";
        $scope.PlaceName = "";
        $scope.Category = "";
        $scope.Code = "";
        $scope.ShiftTypeID = "";
        $scope.PlaceDisplayIDs = "";
        $scope.Accommodation = "";
        $scope.IsSafari = "";
        $scope.IsZone = "";
        $scope.TicketAllocatedPerShift = "";
        $scope.MaxBookingDuration = "";
        $scope.Tax = "";
        $scope.EmitraCharges = "";
        $scope.ContactPerson = "";
        $scope.Address = "";
        $scope.PhoneNo = "";
        $scope.Boarding_Point = "";
        $scope.Status = "";

    }

    //*******************Clear ALL Object End*****************************

}]);