using AyuntamientoRD.Models;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AyuntamientoRD.ViewModels
{
    public class TruckRoutePageViewModel: BaseViewModel
    {
        public Truck TruckDetail { get; set; }
        public ObservableCollection<Route> Routes { get; set; }
        public TruckRoutePageViewModel(INavigationService navigationservice, IPageDialogService dialogService) : base(navigationservice, dialogService)
        {
            var location = new Location(18.526340, -69.916473);
            var distance = location.CalculateDistance(18.533270, -69.811722, DistanceUnits.Kilometers);
            var calculate = Math.Round((distance / 19),4) * 60;

            Routes = new ObservableCollection<Route>
            {
                new Route{
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddMinutes(30),
                Destination = new GeoCoordinate{
                Lat = 18.454200,
                Log  = -69.952290
                },
                Origin = new GeoCoordinate{
                Lat = 20.20,
                Log  = 30.2
                },
                TimeDistance = $"{calculate}",
                TravelMode="Driving"
                },
                new Route{
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddMinutes(30),
                Destination = new GeoCoordinate{
                Lat = 20.20,
                Log  = 30.2
                },
                Origin = new GeoCoordinate{
                Lat = 20.20,
                Log  = 30.2
                },
                TimeDistance = "30",
                TravelMode="Driving"
                },

            };
           
           
        }
    }
}
