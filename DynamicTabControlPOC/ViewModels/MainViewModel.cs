using DynamicData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DynamicTabControlPOC.ViewModels
{
    public class MainViewModel
    {
        private readonly SourceList<LocationViewModel> _locationSource = new SourceList<LocationViewModel>();
        private readonly SourceList<DriverViewModel> _driverSource = new SourceList<DriverViewModel>();
        private ReadOnlyObservableCollection<LocationViewModel> _locations;
        private ReadOnlyObservableCollection<DriverViewModel> _drivers;
        public ReadOnlyObservableCollection<LocationViewModel> Locations => _locations;
        public ReadOnlyObservableCollection<DriverViewModel> Drivers => _drivers;
        public TabControlViewModel TabControlViewModel { get; set; }

        public MainViewModel()
        {
            _locationSource.Edit(innerList =>
            {
                innerList.Add(new LocationViewModel()
                {
                    LocationNumber = "",
                    LocationName = "",
                    LOB = "",
                    ReportDate = ""
                });
            });

            _driverSource.Edit(innerList =>
            {
                innerList.Add(new DriverViewModel()
                {
                    DriverName = ""
                });
            });

            _locationSource.Connect()
                .Bind(out _locations)
                .Subscribe();

            _driverSource.Connect()
                .Bind(out _drivers)
                .Subscribe();
        }
    }
}
