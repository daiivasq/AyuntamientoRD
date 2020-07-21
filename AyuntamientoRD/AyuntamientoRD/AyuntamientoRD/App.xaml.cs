using AyuntamientoRD.Helpers;
using AyuntamientoRD.ViewModels;
using AyuntamientoRD.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AyuntamientoRD
{
    public partial class App : PrismApplication
    {

        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "Expander_Experimental" });
            NavigationService.NavigateAsync(new Uri(NavigationConstants.HomePage, UriKind.Absolute));
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<DirectoryPage, DirectoryPageViewModel>();
            containerRegistry.RegisterForNavigation<LegalPage, LegalPageViewModel>();
            containerRegistry.RegisterForNavigation<RouteDetailView, RouteDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<TruckRoutePage, TruckRoutePageViewModel>();
            containerRegistry.RegisterForNavigation<ReportsPage, ReportsPageViewModel>();
            containerRegistry.RegisterForNavigation<CreateReportPage, CreateReportPageViewModel>();
        }
    }
}
