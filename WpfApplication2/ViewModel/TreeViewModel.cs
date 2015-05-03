using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.ViewModel
{
    class TreeViewModel : BaseViewModel
    {
        public ObservableCollection<TreeItemLevel1> Collection { get; set; }

        public TreeViewModel()
        {
            Collection = new ObservableCollection<TreeItemLevel1>();
            for (int i = 0; i < 4; i++)
            {
                TreeItemLevel1 level1 = new TreeItemLevel1();
                level1.Property1 = "Level1Item #" + i;
                for (int j = 0; j < 10; j++ )
                {
                    TreeItemLevel2 level2 = new TreeItemLevel2();
                    level2.Property1 = "Level2Item #" + i;
                    for (int k = 0; k < 5; k++)
                    {
                        TreeItemLevel3 level3 = new TreeItemLevel3();
                        level3.Property1 = "Level3Item #" + i;
                        level2.Collection.Add(level3);
                    }
                    level1.Collection.Add(level2);
                }
                Collection.Add(level1);
            }
        }
    }
}
