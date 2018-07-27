<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maps.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.maps" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAvBQ1Q9FjYfxdWJF6KPmO822RMMbY2w2o"></script>
    <script>
        var map;
        function initialize() {
            map = new google.maps.Map(document.getElementById('map-canvas'), {
                zoom: 11,
                center: { lat: 25.690351755466306, lng: -100.5118596553803 }
            });

            var marker = new google.maps.Marker({
                position: map.getCenter(),
                map: map,
                draggable: true,
                title: "Ubicacion de vacante"
            });

            google.maps.event.addListener(marker, 'dragend', function (event) {
                document.getElementById("coords").value = this.getPosition().toString();
            });
        }
        google.maps.event.addDomListener(window, 'load', initialize);
    </script>
</head>
<body onload="initialize()">
    <form id="form1" runat="server">

    
        <input type="text" style="width:400px" id="coords" />
    <div>
<div class="col-md-6 " id="map-canvas" style="height:400px;"></div>
    
    </div>
    </form>
</body>
</html>
