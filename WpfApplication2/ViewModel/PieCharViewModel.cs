using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.ViewModel
{
    public class PieCharViewModel : BaseViewModel
    {
        public ObservableCollection<PieChartData> Collection1 { get; set; }
        public ObservableCollection<PieChartData> Collection2 { get; set; }
        public ObservableCollection<PieChartData> Collection3 { get; set; }

        public PieCharViewModel()
        {
            Collection1 = new ObservableCollection<PieChartData>();
            Collection2 = new ObservableCollection<PieChartData>();
            Collection3 = new ObservableCollection<PieChartData>();

            for (int i = 0; i < 5; i++)
            {
                PieChartData data = new PieChartData();
                data.Category = "Category " + (i + 1);
                data.Value = (i + 1);

                Collection1.Add(data);
                Collection2.Add(data);
                Collection3.Add(data);
            }
        }
    }
}
