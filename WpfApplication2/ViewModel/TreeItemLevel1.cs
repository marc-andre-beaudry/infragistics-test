using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.ViewModel
{
    public class TreeItemLevel1
    {
        public String Property1 { get; set; }
        public ObservableCollection<TreeItemLevel2> Collection { get; set; }

        public TreeItemLevel1()
        {
            Collection = new ObservableCollection<TreeItemLevel2>();
        }
    }
}
