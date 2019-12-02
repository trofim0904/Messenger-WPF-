using Messenger.Logic.ViewModel.MainVM;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Messenger.Presentation.View.Main.Pages
{
    /// <summary>
    /// Логика взаимодействия для AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
            
        }
        
        private void GIFAnimationClick(object sender, RoutedEventArgs e)
        {
           
            DoubleAnimation doubleAnimation = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(0.5)));
            RotateTransform rotateTransform = new RotateTransform();
            _gifImg.RenderTransform = rotateTransform;
            _gifImg.RenderTransformOrigin = new Point(0.5, 0.5);
           
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, doubleAnimation);
        }
    }
}
