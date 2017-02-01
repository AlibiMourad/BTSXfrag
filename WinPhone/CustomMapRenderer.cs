using BTSxfrag;
using BTSxfrag.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Devices.Geolocation;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls.Maps;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.UWP;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace BTSxfrag.UWP
{
    public class CustomMapRenderer : MapRenderer
    {
        MapControl nativeMap;
        List<CustomPin> customPins;
        XamarinMapOverlay mapOverlay;
        XamarinMapOverlayOo mapOverlayOo;
        XamarinMapOverlayOr mapOverlayOr;
        XamarinMapOverlayTt mapOverlayTt;
        bool xamarinOverlayShown = false;
        public string Ico= ""; 
        protected override void OnElementChanged(ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                nativeMap.MapElementClick -= OnMapElementClick;
                nativeMap.Children.Clear();
                mapOverlay = null;
             
                nativeMap = null;
            }

            if (e.NewElement != null)
            {
                var formsMap = (CustomMap)e.NewElement;
                nativeMap = Control as MapControl;
                customPins = formsMap.CustomPins;
              
                nativeMap.Children.Clear();
                nativeMap.MapElementClick += OnMapElementClick;

                foreach (var pin in customPins)
                {
                    if (pin.Id == "Xamarin") { Ico = "ms-appx:///pinN.png"; }
                    if (pin.Id == "Tt") { Ico = "ms-appx:///pin2.png"; }
                    if (pin.Id == "Oo") { Ico = "ms-appx:///pin.png"; }
                    if (pin.Id == "Or") { Ico = "ms-appx:///pin3.png"; }

                    var snPosition = new BasicGeoposition { Latitude = pin.Pin.Position.Latitude, Longitude = pin.Pin.Position.Longitude };
                    var snPoint = new Geopoint(snPosition);

                    var mapIcon = new MapIcon();
                    mapIcon.Image = RandomAccessStreamReference.CreateFromUri(new Uri(Ico));
                    mapIcon.CollisionBehaviorDesired = MapElementCollisionBehavior.RemainVisible;
                    mapIcon.Location = snPoint;
                    mapIcon.NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0);

                    nativeMap.MapElements.Add(mapIcon);
                }
            }
        }

        private void OnMapElementClick(MapControl sender, MapElementClickEventArgs args)
        {
            var mapIcon = args.MapElements.FirstOrDefault(x => x is MapIcon) as MapIcon;
            if (mapIcon != null)
            {
                if (!xamarinOverlayShown)
                {
                    var customPin = GetCustomPin(mapIcon.Location.Position);
                    if (customPin == null)
                    {
                        throw new Exception("Custom pin not found");
                    }

                    if (customPin.Id == "Xamarin")
                    {
                        //  if (mapOverlay == null)
                        //{
                        mapOverlay = new XamarinMapOverlay(customPin);
                        // }

                        var snPosition = new BasicGeoposition
                        {
                            Latitude = customPin.Pin.Position.Latitude,
                            Longitude = customPin.Pin.Position.Longitude
                        };
                        var snPoint = new Geopoint(snPosition);

                        nativeMap.Children.Add(mapOverlay);
                        MapControl.SetLocation(mapOverlay, snPoint);
                        MapControl.SetNormalizedAnchorPoint(mapOverlay, new Windows.Foundation.Point(0.5, 1.0));
                        xamarinOverlayShown = true;
                    }
                    else
                    {
                        if (customPin.Id == "Tt")
                        {

                            //  if (mapOverlay == null)
                            //{
                            mapOverlayTt = new XamarinMapOverlayTt(customPin);
                            // }

                            var snPosition = new BasicGeoposition
                            {
                                Latitude = customPin.Pin.Position.Latitude,
                                Longitude = customPin.Pin.Position.Longitude
                            };
                            var snPoint = new Geopoint(snPosition);

                            nativeMap.Children.Add(mapOverlayTt);
                            MapControl.SetLocation(mapOverlayTt, snPoint);
                            MapControl.SetNormalizedAnchorPoint(mapOverlayTt, new Windows.Foundation.Point(0.5, 1.0));
                            xamarinOverlayShown = true;
                        }
                        else
                        {
                            if (customPin.Id == "Oo")
                            {

                                //  if (mapOverlay == null)
                                //{
                                mapOverlayOo = new XamarinMapOverlayOo(customPin);
                                // }

                                var snPosition = new BasicGeoposition
                                {
                                    Latitude = customPin.Pin.Position.Latitude,
                                    Longitude = customPin.Pin.Position.Longitude
                                };
                                var snPoint = new Geopoint(snPosition);

                                nativeMap.Children.Add(mapOverlayOo);
                                MapControl.SetLocation(mapOverlayOo, snPoint);
                                MapControl.SetNormalizedAnchorPoint(mapOverlayOo, new Windows.Foundation.Point(0.5, 1.0));
                                xamarinOverlayShown = true;
                            }
                            else
                            {


                                    //  if (mapOverlay == null)
                                    //{
                                    mapOverlayOr = new XamarinMapOverlayOr(customPin);
                                    // }

                                    var snPosition = new BasicGeoposition
                                    {
                                        Latitude = customPin.Pin.Position.Latitude,
                                        Longitude = customPin.Pin.Position.Longitude
                                    };
                                    var snPoint = new Geopoint(snPosition);

                                    nativeMap.Children.Add(mapOverlayOr);
                                    MapControl.SetLocation(mapOverlayOr, snPoint);
                                    MapControl.SetNormalizedAnchorPoint(mapOverlayOr, new Windows.Foundation.Point(0.5, 1.0));
                                    xamarinOverlayShown = true;

                            }

                        }

                    }

                }
                else
                {
                    nativeMap.Children.Remove(mapOverlay);
                    nativeMap.Children.Remove(mapOverlayOo);
                    nativeMap.Children.Remove(mapOverlayOr);
                    nativeMap.Children.Remove(mapOverlayTt);
                    xamarinOverlayShown = false;
                }
            }
        }

        CustomPin GetCustomPin(BasicGeoposition position)
        {
            var pos = new Position(position.Latitude, position.Longitude);
            foreach (var pin in customPins)
            {
                if (pin.Pin.Position == pos)
                {
                    return pin;
                }
            }
            return null;
        }
    }
}
