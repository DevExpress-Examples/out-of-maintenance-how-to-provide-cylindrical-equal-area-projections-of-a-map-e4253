using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AvoidMapDistortion {
    public partial class MainWindow : Window {
        public struct WidthHeightRatio {
            public string Name { get; set; }
            public double Value { get; set; }
        }

        int defaultSideSize = 512;
        List<WidthHeightRatio> ratios = new List<WidthHeightRatio>() {
            new WidthHeightRatio() { Name = "(Default)", Value = 1 },
            new WidthHeightRatio() { Name = "Lambert", Value = 3.14 },
            new WidthHeightRatio() { Name = "Behrmann", Value = 2.36 },
            new WidthHeightRatio() { Name = "Trystan Edwards", Value = 2.0 },
            new WidthHeightRatio() { Name = "Gall-Peters", Value = 1.57 },
            new WidthHeightRatio() { Name = "Balthasart", Value = 1.3 }
        };
        public List<WidthHeightRatio> Ratios { get { return ratios; } }

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            this.DataContext = Ratios;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            mapControl.InitialMapSize = new Size() {
                Width = defaultSideSize,
                Height = (int)(defaultSideSize / ((WidthHeightRatio)lbRatio.SelectedValue).Value)
            };
        }
    }
}
