using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Commands;
using Turbo.az_app.Domain.ViewModel.UserControlViewModels;
using Turbo.az_app.Domain.Views.UserControls;


namespace Turbo.az_app.Domain.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand SelectionBrandCommand { get; set; }
        public RelayCommand SelectionModelCommand { get; set; }
        public RelayCommand AllCommand { get; set; }
        public RelayCommand NewCommand { get; set; }
        public RelayCommand OldCommand { get; set; }


       
        

    }
}
