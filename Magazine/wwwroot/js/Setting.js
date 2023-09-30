
var setting = {
    GetAll: function () {
        Helper.AjaxCallGet("https://localhost:7281/api/Setting", {}, "json",
            function (data) {
                console.log(data)
                $("#facelink").attr("href", data.facebookLink);
                $("#twitlink").attr("href", data.twiterLink);
                $("#googlelink").attr("href", data.instagramLink);
                $("#instalink").attr("href", data.instagramLink);
                $("#githuplink").attr("href", data.githupLink);
                $("#linked").attr("href", data.linkedinLink);
            }, function () { }
        );
    }
}


setting.GetAll();