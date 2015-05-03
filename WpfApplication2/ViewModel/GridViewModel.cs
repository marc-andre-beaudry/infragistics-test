using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.ViewModel
{
    public class GridViewModel : BaseViewModel
    {
        public ObservableCollection<GridRow> Collection { get; set; }

        public GridViewModel()
        {
            Collection = new ObservableCollection<GridRow>();
            for (int i = 0; i < 100000; i++)
            {
                GridRow marketState = new GridRow();
                marketState.Col1 = "Row " + i + " Col1";
                marketState.Col2 = "Row " + i + " Col2";
                marketState.Col3 = "Row " + i + " Col3";
                marketState.Col4 = "Row " + i + " Col4";
                marketState.Col5 = "Row " + i + " Col5";
                marketState.Col6 = "Row " + i + " Col6";
                Collection.Add(marketState);
            }
        }
    }
}
