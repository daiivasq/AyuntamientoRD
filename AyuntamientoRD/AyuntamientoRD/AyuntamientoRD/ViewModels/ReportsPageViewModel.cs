using AyuntamientoRD.Helpers;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AyuntamientoRD.ViewModels
{
    public class ReportsPageViewModel : BaseViewModel
    {

        public DelegateCommand GotoCreateReport { get; set; }
        public ReportsPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
            GotoCreateReport = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync(new Uri(NavigationConstants.CreateReportPage , UriKind.Relative));
            });
        }
    }
}
