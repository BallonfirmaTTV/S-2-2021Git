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
using BIZ;


namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Her oprettes en tom instans af datatypen ClassBIZ som vi har givet navnet biz.
       
        ClassBIZ biz;

        /// <summary>
        /// En default contructor  
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            biz = new ClassBIZ();
            MainGrid.DataContext = biz;
        }
        
        /// <summary>
        /// Det en eventhandler som gør når en man trykker på tasterne kan man rykke med farverne.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">Keyeventargs</param>

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.G))
            {
              
                if (e.Key == Key.Left)
                {
                    biz.colorData.greenValue = biz.colorData.greenValue - 1;
                }

                if (e.Key == Key.Right)
                {
                    biz.colorData.greenValue = biz.colorData.greenValue + 1;
                }
            }

            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.R))
            {
                
                if (e.Key == Key.Left)
                {
                    biz.colorData.redValue = biz.colorData.redValue - 1;
                }
                
                if (e.Key == Key.Right)
                {
                    biz.colorData.redValue = biz.colorData.redValue + 1;
                }
            }

            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.B))
            {

                if (e.Key == Key.Left)
                {
                    biz.colorData.blueValue = biz.colorData.blueValue - 1;
                }
                

                if (e.Key == Key.Right)
                {
                    biz.colorData.blueValue = biz.colorData.blueValue + 1;
                }
            }

            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.C))
            {
                
                if (e.Key == Key.Left)
                {
                    biz.colorData.trnsValue = biz.colorData.trnsValue - 1;                    
                }
               
                if (e.Key == Key.Right)
                {
                    biz.colorData.trnsValue = biz.colorData.trnsValue + 1;
                }
            }
        }
    }
}
