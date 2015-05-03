using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.ViewModel
{
    public class TreeItemLevel2
    {
        public String Property1 { get; set; }
        public ObservableCollection<TreeItemLevel3> Collection { get; set; }

        public TreeItemLevel2()
        {
            Collection = new ObservableCollection<TreeItemLevel3>();
        }
    }
}
