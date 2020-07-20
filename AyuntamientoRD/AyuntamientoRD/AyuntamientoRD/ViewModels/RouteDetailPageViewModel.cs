using AyuntamientoRD.Models;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuntamientoRD.ViewModels
{
    public class RouteDetailPageViewModel : BaseViewModel,IInitialize
    {
        public Truck TruckDetail { get; set; } 
        public Route Route { get; set; }
        private Directions selectDirection;

        public Directions SelectDirection
        {
            get { return selectDirection; }
            set {
                selectDirection = value;
                if (selectDirection!=null)
                {
                    LoadTruck(selectDirection.NameDirection);
                }
                
               
            
            }
        }

        public List<Directions> Directions { get=>new List<Directions>() { 
        
        new Directions{ 
        NameDirection = "Plaza Oasis, 6-B, Autopista San Isidro, Santo Domingo Este, Santo Domingo"
        },
        new Directions{
        NameDirection = "Santo Domingo Este, Santo Domingo"
        },
          new Directions{
        NameDirection = "Calle Luis F. Thomen no. 110, Torre Ejecutiva Gapo, Suite 409, Evaristo Morales, Santo Domingo"
        },
        new Directions{
        NameDirection = "Manzana A1, Carmen Renata I, Santo Domingo"
        }
        };
        }

        public RouteDetailPageViewModel(INavigationService navigationservice, IPageDialogService dialogService) : base(navigationservice, dialogService)
        {
            TruckDetail = new Truck
            {
                IdTruck = 2016655,
                IsDriving = true
            };
            TruckDetail.Routes = new List<Route>
            {
                new Route{
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddMinutes(30),
                Destination = new GeoCoordinate{
                    Address= "Plaza Oasis, 6-B, Autopista San Isidro, Santo Domingo Este, Santo Domingo",
                Lat = 18.454200,
                Log  = -69.952290
                },
                Origin = new GeoCoordinate{
                Lat = 20.20,
                Log  = 30.2
                },
                TimeDistance = $"20",
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
                    Address="Santo Domingo Este, Santo Domingo",
                Lat = 20.20,
                Log  = 30.2
                },
                TimeDistance = "30",
                TravelMode="Driving"
                },

            };

        }
       async Task LoadTruck(string address)
        {
           
            Route = TruckDetail.Routes.Where(e=>e.Destination.Address.Contains(address)).FirstOrDefault();
        }

        public void Initialize(INavigationParameters parameters)
        {
         
        }
    }
}
