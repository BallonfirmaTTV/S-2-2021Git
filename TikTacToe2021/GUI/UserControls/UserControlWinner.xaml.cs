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


namespace GUI.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlWinner.xaml
    /// </summary>
    public partial class UserControlWinner : UserControl
    {
        // Her oprettes en tom instans af datatypen Grid som vi har givet navnet _grid.

        private Grid _grid;
        private ClassTextBoxHandler _ctbh;
        private string actualSign;
        private Grid winnerGrid;

        public UserControlWinner(string actualSign, Grid winnerGrid)
        {
            this.actualSign = actualSign;
            this.winnerGrid = winnerGrid;
        }

        /// <summary>
        /// Her har vi en default contructor med to parametere som skal vise os hvem der har vundet.
        /// Dette er default constructor for UserControlWinner.
        /// Constructoren modtager to parametre, som skal benyttes til at henholdsvis at opsætte formen med den rette
        /// tekst, samt at gøre det mugeligt at lukke ned for UserControlWinner, så spillet kan forsætte.
        /// Parameter stringWinner: Indeholder det tegn som har sat en vinder kombination og derved afgøre
        ///                         tekst og farve i UserControlWinner
        /// Parameter inGrid: Dette parameter skal sikre en reference til det grid i MainWindow som holder
        ///                   UserControlWinner. Derved for man muglighed for at fjerne UserControlWinner
        ///                   fra brugergrænsefladen, når spillet skal fortsætte.
        /// </summary>
        /// <param name="stringWinner">string</param>
        /// <param name="inGrid">Grid</param>
        public UserControlWinner(string stringWinner, Grid inGrid,ClassTextBoxHandler CTBH)
        {
            InitializeComponent();

            // inGrid = vores WinnerGrid.
            // Som bliver gemt i _grid så den kan bruges i hele classen.

            _grid = inGrid;// Her overføres parameter inGrid til lokal field _grid;
            _ctbh = CTBH;
            // Denne conditon afgøre om der skal skrive at det er X elller O der har vundet.
            // Det afgøres ud fra indholdet af parameren stringWinner.

            // Inde i denne condition har vi medført parameteren stringWinner som er gjordt til TOUpper.
            // (som gør at alle bogstaver bliver læst som værende store)
            // LabelWinnerText.Content er det som der bliver skrevet til den person som har vundet spillet.
            // Brushes ændre bagrundsfarven på vores winnerlabel.

            if (stringWinner.ToUpper() == "O")
            {
                labelWinnerText.Content = "Tillykke O vandt";// Her sættes teksten.
                labelWinnerText.Background = Brushes.Red;// Her sættes baggrundfarven på labelen

            }
            else
            {
                labelWinnerText.Content = "Tillykke X vandt";// Her sættes teksten.
                labelWinnerText.Background = Brushes.Blue; // Her sættes baggrundfarven på labelen
                labelWinnerText.Foreground = Brushes.White; // Her sættes baggrundfarven på labelen (farven på teksten)
            }
        }

        /// <summary>
        /// Denne eventhandler gør det mugligt for brugeren at fjerne UserConrtolWinner fra GUI, 
        /// ved at brugeren dobbeltklikker på UserControlWinner. 
        /// Her sletter vi vores children i _grid så spillet kan starte igen ved doubleklik (children = UserControlWinner)
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseButtonEventArgs</param>

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _grid.Children.Clear();// Her fjernes alle children fra objectet WinnerGrid, hvilket er objektet UserControlWinner.
        }
    }
}
