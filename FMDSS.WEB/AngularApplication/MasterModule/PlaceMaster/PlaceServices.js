
app.service("MasterPlaceServices", function ($http) {

    // **************************************************Master Places Start*******************************************************


    //############ GET Place List ################

    ////GET ALL PLACE
    this.getAllPlace = function () {
        return $http.get("http://localhost:40784/api/Master/GetPlaceList");
    }


    //############# END Place List ###############


    //############ GET ShiftType And PlaceDisplay List ################

    ////GET ALL ShiftType
    this.getAllPlaceDisplayList = function () {
        return $http.get("http://localhost:40784/api/Master/GetPlaceDisplay");
    }


    ////GET ALL PlaceDisplay
    this.getShiftTypeList = function () {
        return $http.get("http://localhost:40784/api/Master/GetShiftType");
    }

    //############# END Place List ###############




    ////Create new record  
    this.AddPlace = function (PlaceModel) {
        var request = $http({
            method: "post",
            url: "http://localhost:40784/api/Master/AddPlace",
            data: PlaceModel
        });
        return request;
    }


    ////Update the Record  
    this.UpdatePlace = function (PlaceModelID, PlaceModel) {
        var request = $http({
            method: "post",
            url: "http://localhost:40784/api/Master/AddPlace/" + PlaceModelID,
            data: PlaceModel
        });
        return request;
    }

    ////Get Record By ID
    this.GetPlaceDataById = function (PlaceModelID) {
        return $http.get("http://localhost:40784/api/Master/GetPlaceListByID?Id=" + PlaceModelID);
    }



    ////Delete the Record  
    //this.delete = function (StudentID) {
    //    var request = $http({
    //        method: "delete",
    //        url: "/api/StudentsAPI/" + StudentID
    //    });
    //    return request;
    //}



    //****************************************************Master Places END*******************************************************


});