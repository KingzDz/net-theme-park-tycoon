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
using System.Windows.Shapes;
using ThemeParkTycoonGame.Core;
using System.Speech.Synthesis;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for GuestinfoWindow.xaml
    /// </summary>
    public partial class GuestinfoWindow : Window
    {
        Core.Guest guest;
        Core.Wallet wallet;

        public GuestinfoWindow(Core.Guest selectedGuest)
        {
            InitializeComponent();

            this.guest = selectedGuest;

            this.guest.Wallet.BalanceChanged += (s, ev) =>
            {
                RefreshFinances();
            };
            RefreshFinances();
            //RefreshStats();
        }
        private void RefreshStats()
        {
            //wantingRideSlider.Value = RandomPercentage();
            //excitementSlider.Value = RandomPercentage();
            //hungerSlider.Value = RandomPercentage();
            //thirstSlider.Value = RandomPercentage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = guest.Name; 

            foreach(Stat stat in guest.CurrentStats)
            {
                Console.WriteLine(stat.Type.Name + " : " + stat.Value.ToString());
                if (stat.Type.Name == "Wanting to go on a ride")
                {
                    wantingRidePrecentageLabel.Content = string.Format("{0}%", stat.Value.ToString());
                    wantingRideSlider.Value = stat.Value / 10;
                }
                else if (stat.Type.Name == "Excitement")
                {
                    excitementPrecentageLabel.Content = string.Format("{0}%", stat.Value.ToString());
                    excitementSlider.Value = stat.Value / 10;
                }
                else if (stat.Type.Name == "Hunger")
                {
                    hungerRidePrecentageLabel.Content = string.Format("{0}%", stat.Value.ToString());
                    hungerSlider.Value = stat.Value / 10;
                }
                else if (stat.Type.Name == "Thirst")
                {
                    thirstRidePrecentageLabel.Content = string.Format("{0}%", stat.Value.ToString());
                    thirstSlider.Value = stat.Value / 10;
                }
            }
            //balanceLabel.Content = guest.Wallet.Balance;
            List<String> paths = new List<String>();
            paths.Add("/Resources/01w.jpg");
            paths.Add("/Resources/02m.jpg");
            paths.Add("/Resources/03w.jpg");
            paths.Add("/Resources/04w.jpg");
            paths.Add("/Resources/05w.jpg");
            paths.Add("/Resources/06w.jpg");
            paths.Add("/Resources/07w.jpg");
            paths.Add("/Resources/08w.jpg");
            paths.Add("/Resources/09w.jpg");
            paths.Add("/Resources/10m.jpg");
            paths.Add("/Resources/11m.jpg");
            paths.Add("/Resources/12m.jpg");
            paths.Add("/Resources/13m.jpg");
            paths.Add("/Resources/14m.jpg");
            paths.Add("/Resources/15w.jpg");
            paths.Add("/Resources/16w.jpg");
            paths.Add("/Resources/17w.jpg");
            paths.Add("/Resources/18w.jpg");
            paths.Add("/Resources/19m.jpg");
            paths.Add("/Resources/20w.jpg");
            paths.Add("/Resources/21w.jpg");
            paths.Add("/Resources/22w.jpg");
            paths.Add("/Resources/23w.jpg");
            paths.Add("/Resources/24w.jpg");
            paths.Add("/Resources/25w.jpg");
            paths.Add("/Resources/26m.jpg");
            paths.Add("/Resources/27m.jpg");
            paths.Add("/Resources/28m.jpg");
            paths.Add("/Resources/29w.jpg");
            paths.Add("/Resources/30w.jpg");
            paths.Add("/Resources/31m.jpg");
            paths.Add("/Resources/32m.jpg");
            paths.Add("/Resources/33w.jpg");
            paths.Add("/Resources/34m.jpg");
            paths.Add("/Resources/35w.jpg");
            paths.Add("/Resources/36m.jpg");
            paths.Add("/Resources/37w.jpg");
            paths.Add("/Resources/38w.jpg");
            paths.Add("/Resources/39w.jpg");
            paths.Add("/Resources/40w.jpg");
            paths.Add("/Resources/41w.jpg");
            paths.Add("/Resources/42w.jpg");
            paths.Add("/Resources/43w.jpg");
            paths.Add("/Resources/44w.jpg");
            paths.Add("/Resources/45m.jpg");
            paths.Add("/Resources/46w.jpg");
            paths.Add("/Resources/47w.jpg");
            paths.Add("/Resources/48m.jpg");
            paths.Add("/Resources/49w.jpg");
            paths.Add("/Resources/50w.jpg");

            Random random = new Random();
            imagePictureBox.Tag = paths[random.Next(0, paths.Count - 1)];
            imagePictureBox.Source = new BitmapImage(new Uri("pack://siteoforigin:,,," + paths[random.Next(0, paths.Count - 1)]));

            //Random random = new Random();
            //imagePictureBox.ImageLocatio = paths[random.Next(0, paths.Count - 1)];

            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            // Synchronous
            synthesizer.Speak("Welcome to your detail page" + guest.Name);

            // Asynchronous
            //synthesizer.SpeakAsync(guest.Name);

            this.Title = guest.Name;
        }

        //private void RefreshFinances()
        //{
        //clear the panel
        //ListView.Items.Clear();

        //foreach (TransactionLog log in this.guest.Wallet.History)
        //{
        //guest.Wallet.Add()
        //FinancieHistory.Colums.Add(new ) new string[] {
        //(-log.Amount).ToString(),
        //log.Time.ToString(),
        //log.Reason,
        //}));
        //}
        // balanceLabel.Content = guest.Wallet.Balance;

        //private void RefreshFinances()
        //{
        //    // clear the panel
        //    financialHistory.Items.Clear();

        //    foreach (TransactionLog log in this.guest.Wallet.History)
        //    {

        //        ListViewItem temp = new ListViewItem();

        //        financialHistory.Items.Add(temp);
        // balanceLabel.Content = guest.Wallet.Balance;


        //}

        private void RefreshFinances()
        {
            // clear the panel
            financialHistory.Items.Clear();



            foreach (TransactionLog log in this.guest.Wallet.History.ToList())
            {

                

                financialHistory.Items.Add(log);

                //        //new string[] {
                //        //    (-log.Amount).ToString(),
                //        //    log.Time.ToString(),
                //        //    log.Reason,
                //        //}));
                //    }
            }

        }

        private double RandomPercentage()
        {
            Random random = new Random();
            double decimalNumber = (double) random.Next(0, 10);
            

            return decimalNumber;
            
        }
    }
}

