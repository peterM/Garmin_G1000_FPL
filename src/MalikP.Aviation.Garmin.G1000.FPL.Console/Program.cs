using MalikP.Aviation.Garmin.G1000.FPL.V1;
using MalikP.Core.Serialization.Xml;

namespace MalikP.Aviation.Garmin.G1000.FPL.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Could be connected to some GUI and generated depoending on GUI design.
            FlightPlanType flightPlan = new FlightPlanType
            {
                Author = new PersonType
                {
                    AuthorName = "Peter Mrkvicka",
                    Email = new EmailType
                    {
                        ID = "myMail",
                        Domain = "email.com"
                    },
                    Link = null
                },
                Created = DateTime.UtcNow,
                CreatedSpecified = true,
                FileDescription = "My Test FPL",
                Route = new RouteType
                {
                    FlightPlanIndex = "1",
                    RouteDescription = "Bratislava - Kosice",
                    RouteName = "LZIB/LZKZ"
                }
            };

            // GUI DB connected data
            flightPlan.Waypoints.Add(new WaypointType
            {
                Comment = "BRATISLAVA",
                CountryCode = "LZ",
                Elevation = 436,
                ElevationSpecified = true,
                Identifier = "LZIB",
                WaypointTypetype = WaypointTypeEnum.AIRPORT,
                WaypointDescription = "LZIB - Bratislava",
                Latitude = 48.170200m,
                Longitude = 17.212700m,
            });

            flightPlan.Waypoints.Add(new WaypointType
            {
                Comment = "NITRA VOR/DME",
                CountryCode = "LZ",
                Elevation = 810,
                ElevationSpecified = true,
                Identifier = "NIT",
                WaypointTypetype = WaypointTypeEnum.VOR,
                WaypointDescription = "NIT - NITRA",
                Latitude = 48.290401m,
                Longitude = 18.050600m,
            });

            flightPlan.Waypoints.Add(new WaypointType
            {
                Comment = "SLIAC VOR/DME",
                CountryCode = "LZ",
                Elevation = 1670,
                ElevationSpecified = true,
                Identifier = "SLC",
                WaypointTypetype = WaypointTypeEnum.VOR,
                WaypointDescription = "SLC - SLIAC",
                Latitude = 48.453201m,
                Longitude = 19.115900m,
            });

            flightPlan.Waypoints.Add(new WaypointType
            {
                Comment = "KOSICE VOR/DME",
                CountryCode = "LZ",
                Elevation = 787,
                ElevationSpecified = true,
                Identifier = "KSC",
                WaypointTypetype = WaypointTypeEnum.VOR,
                WaypointDescription = "KSC - KOSICE",
                Latitude = 48.683102m,
                Longitude = 21.248199m,
            });

            flightPlan.Waypoints.Add(new WaypointType
            {
                Comment = "KOSICE",
                CountryCode = "LZ",
                Elevation = 755,
                ElevationSpecified = true,
                Identifier = "LZKZ",
                WaypointTypetype = WaypointTypeEnum.AIRPORT,
                WaypointDescription = "LZKZ - KOSICE",
                Latitude = 48.663101m,
                Longitude = 21.241100m,
            });

            // Using GUI could be route designed depending on it pull all data needed to construct route
            flightPlan.Route.RoutePoints.Add(new RoutePointType
            {
                WaypointCountryCode = "LZ",
                WaypointIdentifier = "LZIB",
                WaypointType = WaypointTypeEnum.AIRPORT
            });

            flightPlan.Route.RoutePoints.Add(new RoutePointType
            {
                WaypointCountryCode = "LZ",
                WaypointIdentifier = "NIT",
                WaypointType = WaypointTypeEnum.VOR
            });

            flightPlan.Route.RoutePoints.Add(new RoutePointType
            {
                WaypointCountryCode = "LZ",
                WaypointIdentifier = "SLC",
                WaypointType = WaypointTypeEnum.VOR
            });

            flightPlan.Route.RoutePoints.Add(new RoutePointType
            {
                WaypointCountryCode = "LZ",
                WaypointIdentifier = "KSC",
                WaypointType = WaypointTypeEnum.VOR
            });

            flightPlan.Route.RoutePoints.Add(new RoutePointType
            {
                WaypointCountryCode = "LZ",
                WaypointIdentifier = "LZKZ",
                WaypointType = WaypointTypeEnum.AIRPORT
            });

            // use your xml serializer
            var xml = flightPlan.SerializeToXml();

            // Save to File
            File.WriteAllText(@"C:\CODE\TestFPL.xml", xml);

            // show xml in console or save it to file
            using (var strReader = new StringReader(xml))
            {
                var str = strReader.ReadLine();
                while (!string.IsNullOrWhiteSpace(str))
                {
                    System.Console.WriteLine(str);

                    str = strReader.ReadLine();
                }
            }
        }
    }
}