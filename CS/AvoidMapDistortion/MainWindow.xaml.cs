
using System.Windows;

namespace AvoidMapDistortion {

    public partial class MainWindow : Window {

        public class ProjectionRatios {
            public const double Lambert = 3.14;
            public const double Behrmann = 2.36;
            public const double Edwards = 2.0;
            public const double GallPeters = 1.57;
            public const double Balthasart = 1.3;
        }

        public double imageTileWidth = 330;

        public MainWindow() {
            InitializeComponent();
        }


        private void RadioButton_Lambert(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Lambert, imageTileWidth);
        }

        private void RadioButton_Behrmann(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Behrmann, imageTileWidth);
        }

        private void RadioButton_Edwards(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Edwards, imageTileWidth);
        }

        private void RadioButton_Peters(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.GallPeters, imageTileWidth);
        }


        private void RadioButton_Balthasart(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Balthasart, imageTileWidth);
        }

    }
}
