using Infragistics.Documents.Excel;
using Infragistics.Windows.DataPresenter.ExcelExporter;
using Microsoft.Win32;
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
    /// Interaction logic for GridUserControl.xaml
    /// </summary>
    public partial class GridUserControl : UserControl
    {
        private DataPresenterExcelExporter exporter;

        public GridUserControl()
        {
            exporter = new DataPresenterExcelExporter();
            exporter.ExportStarted += Exporter_ExportStarted;
            exporter.ExportEnded += Exporter_ExportEnded;
            InitializeComponent();
        }

        private void Exporter_ExportEnded(object sender, ExportEndedEventArgs e)
        {
            MessageBox.Show("Export complete");
        }

        private void Exporter_ExportStarted(object sender, ExportStartedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                exporter.Export(this.XamDataGrid, saveFileDialog.FileName, WorkbookFormat.Excel2007);
            }
        }
    }
}
