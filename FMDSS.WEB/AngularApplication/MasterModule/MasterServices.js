app.service('MasterDistrictsService', function ($http) {

    //**************************************************Master Districts Start*******************************************************

    //############ GET District List ################
    ////Get All DistrictsList  
    this.getAllDistrictsList = function () {
        //return $http.get("/JsonFileFolder/PlaceList.json");
        return $http.get("http://localhost:40784/api/Master/GetDistrictsList");
    }
    //############# END Districts List ###############


    ////Create new record  
    //this.post = function (Student) {
    //    var request = $http({
    //        method: "post",
    //        url: "/api/StudentsAPI",
    //        data: Student
    //    });
    //    return request;
    //}

    ////Get Single Records  
    //this.get = function (StudentID) {
    //    return $http.get("/api/StudentsAPI/" + StudentID);
    //}


    ////Update the Record  
    //this.put = function (StudentID, Student) {
    //    var request = $http({
    //        method: "put",
    //        url: "/api/StudentsAPI/" + StudentID,
    //        data: Student
    //    });
    //    return request;
    //}

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