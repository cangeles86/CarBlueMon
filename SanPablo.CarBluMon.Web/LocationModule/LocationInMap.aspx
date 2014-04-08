<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="LocationInMap.aspx.cs" Inherits="SanPablo.CarBluMon.Web.LocationModule.LocationInMap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
    <script type="text/javascript">
        //var lat = -12.104747;
        //var lng = -76.963283;
        var lat = '<%=Request.QueryString["Lat"]%>';
        var lng = '<%=Request.QueryString["Lon"]%>';        
        var markers = [        
                    {
                        "title": 'Solicitud de Ayuda',
                    "lat": lat,
                    "lng": lng,
                    "description": 'Usuario'
                    }
        ];
    </script>
    <script type="text/javascript">
        window.onload = function () {
            var mapOptions = {
                center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var infoWindow = new google.maps.InfoWindow();
            var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
            for (i = 0; i < markers.length; i++) {
                var data = markers[i]
                var myLatlng = new google.maps.LatLng(data.lat, data.lng);
                var marker = new google.maps.Marker({
                    position: myLatlng,
                    map: map,
                    title: data.title
                });
                (function (marker, data) {
                    google.maps.event.addListener(marker, "click", function (e) {
                        infoWindow.setContent(data.description);
                        infoWindow.open(map, marker);
                    });
                })(marker, data);
            }
        }
    </script>
    <div id="dvMap" style="width: 100%; height: 500px">
    </div>
</asp:Content>
