using AyuntamientoRD.Helpers;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AyuntamientoRD.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public DelegateCommand GotoMapsPage { get; set; }
        public DelegateCommand GotoReportsPage { get; set; }
        public DelegateCommand GotoLegalPage { get; set; }
        public DelegateCommand GotoDirectoryPage { get; set; }
        public HomePageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
            GotoMapsPage = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync(new Uri(NavigationConstants.MapPage, UriKind.Relative));
            });
            GotoReportsPage = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync(new Uri(NavigationConstants.ReportsPage, UriKind.Relative));
            });
            GotoLegalPage = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync(new Uri(NavigationConstants.LegalPage, UriKind.Relative));
            });
            GotoDirectoryPage = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync(new Uri(NavigationConstants.DirectoryPage, UriKind.Relative));
              
            });
        }
    }
}
