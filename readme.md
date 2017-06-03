[![Build status](https://ci.appveyor.com/api/projects/status/ael1mr6xk4yw97uf?svg=true)](https://ci.appveyor.com/project/rjhernandez/usgsclient-dt44t)


# USGS Client
## Description
UsgsClient is a `.NET Standard 1.1` library for querying the USGS Earthquake APIs.

## USGS Earthquake API
### GeoJSON Summary Feed
Retrieving all significant earthquakes for the past week.
```
var svc = Usgs
    .Quakes
    .Feed();

var features = await svc
    .Summary(
        Magnitude.Significant,
        Timeframe.Week);
```
> For documentation on the USGS Earthquake GeoJSON Summary Feed read the associated documentation at [https://earthquake.usgs.gov](
https://earthquake.usgs.gov/earthquakes/feed/v1.0/geojson.php)

### GeoJSON Detail Feed
Retrieving detail information for earthquake id `ak16139649`.
```
var svc = Usgs
    .Quakes
    .Feed();

var quakeId = "us20009jd6";

var quake = await svc.Detail(quakeId);
```
> For documentation on the USGS Earthquake GeoJSON Detail Feed read the associated documentation at [https://earthquake.usgs.gov](
https://earthquake.usgs.gov/earthquakes/feed/v1.0/geojson_detail.php)

## Roadmap
1) Introduce support for USGS [Earthquake Catalog](https://earthquake.usgs.gov/fdsnws/event/1/).

## Disclaimer
The software is not associated or maintained by USGS. The use of all USGS APIs should adhere to the rules defined in USGS's own [Feed Lifecycle Policy](https://earthquake.usgs.gov/earthquakes/feed/policy.php)
.
## License
UsgsClient is licensed under MIT. Refer to [LICENSE](https://github.com/overridethis/UsgsClient/blob/master/LICENSE) for more information.