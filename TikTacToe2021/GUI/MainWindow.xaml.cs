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
using GUI.UserControls;
using Repository;
namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    // Her oprettes en tom instans af ClassTexBoxHandler
    {
       
        ClassTextBoxHandler CTBH;
 

        // Contruktor hedder det samme som selve Classen
        // En overloaded Contrukter skal modtage parametre 
        // Hvis man har en default contrukter og en anden contruktrer som modtager nogle parametre
        // er den der modtager parametrene den som er overLoaded.

        /// <summary>
        /// Dette er den default constructor til Class MainWindow.
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();// Denne metode nedarves via Window og sørger for at opbygge GUI.
            CTBH = new ClassTextBoxHandler();// Her initialiseres den tomme instans med en ny instans af ClassTextBoxHandler.
            MainGrid.DataContext = CTBH;//Her skabes der en  forbindelsen mellem vores GUI og TextBoxHanlder
            // Her knyttes MainGrid DataContext til den nye instans af (CTBH) ClassTextBoxHandler.
        }

        /// <summary>
        /// Dette er eventhandleren som sørger for at tegn kommer frem når man double klikker på en af de ni tekstboxe.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseButtonEventArgs</param>
        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Her oprettes en ny instans af datatypen TextBox.
            // Instansen initialiseres med indholdet af parameteren sender.
            // Da parameteren sender er af datatypen object, skal den transformeres til datatypen TextBox.
            // Dette gøres ved at Caste objektet sender til datatypen TextBox.
            // Når man Caster, skrives datatypen man ønsker transformeret til i parantes foran det obejct der skal transformeres.

            TextBox textBox = (TextBox)sender;

            // I denne condition foretages der et kald til metoden RegTextBoxVlick i ClassTextBoxHandler, 
            // med parameterværdien som udtrækkes fra Tag værdien i den TextBox der blev klikket på.
            // Metoden RegTextBoxVlick retunere en bolsk værdi, som fortæller om der blev fundet en 
            // vinder efter at tegnet blev indsat på spillepladen.
            // Denne bolsk værdi afgøre om UserControlWinner skal vises i GUI.

            if (CTBH.RegTextBoxClick(textBox.Tag.ToString()))

            // Her oprettes en ny instans af UserControlWinner.
            // Constructoren i UserControlWinner betinger at der overføres to parametre.
            // Første parameter er en string der angiver hvilket tegn der sidst blev sat.
            // Anden parameter er en parameteroverført referance til WinnerGrid i XAML koden.
            {
                UserControlWinner UCW = new UserControlWinner(CTBH.actualSign, this.WinnerGrid);
                // Her indsættes instansen af UserControlWinner i WinnerGrid.
                WinnerGrid.Children.Add(UCW);
                // Nulstiller spillepladen og spillet til en ny start.
                CTBH.ResetAll();
            }
        }
    }
}
