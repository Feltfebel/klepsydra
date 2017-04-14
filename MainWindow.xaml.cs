using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace klepsydra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime czas_start;
        double LiczbaMinut = 1;
  
        bool IsCancelled = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Loaded_klepsydra(object sender, RoutedEventArgs e)
        {
            edycja_off();
            LiczbaMinut = Convert.ToDouble(sldText.Text);
            uruchom_odliczanie();
        }

        private void uruchom_odliczanie()
        {
            czas_start = DateTime.Now;
            this.Title = "Klepsydra: " + czas_start.ToString();

            new Thread(
                 delegate ()
                 {
                     odmierzaj_czas();
                 }
                 ).Start();

        }

        private void odmierzaj_czas()
        {

            for (int i = 1; (i < LiczbaMinut * 60) && (!IsCancelled); i++)
            {
                Thread.Sleep(1000);
                if (!IsCancelled) {
                    Dispatcher.BeginInvoke(DispatcherPriority.Background, (SendOrPostCallback)delegate { Postep.SetValue(ProgressBar.ValueProperty, (double)i); }, null);
                    Dispatcher.BeginInvoke(DispatcherPriority.Background, (SendOrPostCallback)delegate { txtPostep.SetValue(TextBlock.TextProperty, i.ToString()+"s"); }, null);
                }
            }

          Dispatcher.BeginInvoke(DispatcherPriority.Background, (SendOrPostCallback)delegate { txtPostep.SetValue(TextBlock.TextProperty, "K O N I E C"); }, null);
           
            IsCancelled = false;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.IsCancelled = true;
            Close();
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            this.IsCancelled = false;
            edycja_off();
            uruchom_odliczanie();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            edycja_on();
            this.IsCancelled = true;
        }

        private void sldMinuty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // ... Get Slider reference.
            var slider = sender as Slider;
            // ... Get Value.
            double value = slider.Value;
            // ... Set Window Title.
           
            LiczbaMinut = value;           
     
            //pbar.Maximum = LiczbaMinut * 60;
           // Postep.Maximum = LiczbaMinut * 60;
        }

        private void edycja_on ()
        {
            btnRestart.IsEnabled = true;
            sldMinuty.IsEnabled = true;
            sldText.IsEnabled = true;
        }

        private void edycja_off()
        {
            btnRestart.IsEnabled = false;
            sldMinuty.IsEnabled = false;
            sldText.IsEnabled = false;
        }


    }
}
