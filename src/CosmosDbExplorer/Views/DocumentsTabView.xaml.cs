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
using CosmosDbExplorer.ViewModels;

namespace CosmosDbExplorer.Views
{
    /// <summary>
    /// Interaction logic for DocumentsTabView.xaml
    /// </summary>
    public partial class DocumentsTabView : UserControl
    {
        public DocumentsTabView()
        {
            InitializeComponent();
            this.Loaded += (s, e) => this.Focus();
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                var viewModel = (DocumentsTabViewModel)DataContext;
                if (viewModel.RefreshCommand.CanExecute(null))
                {
                    viewModel.RefreshCommand.Execute(null);
                }
            }
        }
    }
}
