using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace ImmediatePostCellValues {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }

        private void TableView_CellValueChanging(object sender, DevExpress.Xpf.Grid.CellValueChangedEventArgs e) {
            (sender as TableView).PostEditor();
        }
    }
}
