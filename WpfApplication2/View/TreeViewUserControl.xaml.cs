using Infragistics.Controls.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2.View
{
    /// <summary>
    /// Interaction logic for TreeViewUserControler.xaml
    /// </summary>
    public partial class TreeViewUserControler : UserControl
    {
        public TreeViewUserControler()
        {
            InitializeComponent();
        }

        private void ExpandAll_Clicked(object sender, RoutedEventArgs e)
        {
            this.SetNodeExpandedState(this.XamDataTree.Nodes, true);
        }

        private void CollapseAll_Clicked(object sender, RoutedEventArgs e)
        {
            if (this.XamDataTree != null)
            {
                this.SetNodeExpandedState(this.XamDataTree.Nodes, false);
            }
        }

        private void SetNodeExpandedState(IEnumerable<XamDataTreeNode> nodes, bool expandNode)
        {
            foreach (XamDataTreeNode item in nodes)
            {
                item.IsExpanded = expandNode;
                this.SetNodeExpandedState(item.Nodes, expandNode);
            }
        }
    }
}
