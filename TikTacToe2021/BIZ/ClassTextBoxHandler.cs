using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    /// <summary>
    ///  Denne class indeholder de metoder og property, der har ansvaret for logikken i spillet.
    /// </summary>

    public class ClassTextBoxHandler : ClassCheckForWinner
    {
        /// <summary>
        /// Fields der knytter sig til property .
        /// </summary>
        
        private string _gridColor;

        private string _actualSign;

        /// <summary>
        /// Default Consturctor for ClassTextBoxHandler.
        /// Her initialiseres de nødvændige elementer i ClassTextBoxHandler.
        /// </summary>
        public ClassTextBoxHandler()
       
        {
            ClassTextBoxCollection = new ClassTextBoxCollection();
            gridColor = "Blue";
        }

        public ClassTextBoxHandler(string inColor) 
        {
            ClassTextBoxCollection = new ClassTextBoxCollection();
            gridColor = inColor;
        }

        /// <summary>
        /// En simpel property af datatypen ClassTextBoxCollection, der skal 
        /// give adgang til de metoder og property der er i ClassTextBoxCollection.
        /// Det er gennem dette property der fortages Binding på GUI til div. TextBoxe
        /// så man får vidst det tegn brugeren har sat.
        /// </summary>
         
        public ClassTextBoxCollection ClassTextBoxCollection { get; set; }

        /// <summary>
        /// Holder den værdi der sættes på spillet.
        /// </summary>
        public string actualSign
        {
            get { return _actualSign; }
            private set
            {
                if (_actualSign != value)
                {
                    _actualSign = value;
                }
                Notify("actualSign");
            }
        }

        /// <summary>
        /// Angiver den farver som bagrunden har (Blå = X) (Rød = O).
        /// </summary>
        public string gridColor
        {
            get { return _gridColor; }
            set
            {
                if (_gridColor != value)
                {
                    _gridColor = value;
                    if (value == "Blue")
                    {
                        actualSign = "X";
                    }
                    else
                    {
                        actualSign = "O";
                    }
                }
                Notify("gridColor");
            }
        }

        /// <summary>
        ///  Denne metode danner grundlag for logikken og reglsætte for sspillet.
        /// </summary>
        /// <param name="boxID">string</param>
        /// <returns>bool</returns>

        public bool RegTextBoxClick(string boxID)

        {
            bool bolRes = false;// denne variable holder resultatet der skal retuneres.
            string[] arrayKey = boxID.Split(','); // Her splittes boxID op i et array,splitteren er et komma.
            int xCord = Convert.ToInt32(arrayKey[0]); // Den første værdi i boxID konvaters til en int og gemmes i xCord.
            int yCord = Convert.ToInt32(arrayKey[1]);// Den anden værdi i boxID konvaters til en int og gemmes i yCord.

            // Her undersøges det, om feltet der blev klikket på er tomt og at spilleren har sat mindre end 3 tegn.

            if (strSignPlacement[xCord, yCord] == "" && CheckNumberOfSigns() < 3)
            {
                // Spillerens tegn placeres i det 2 dim. array.
                strSignPlacement[xCord, yCord] = actualSign;
                // Kald til metode der tæller op på hvormange tegn spilleren har sat.
                UpdateNumberOfSignsAdd();
                //Kalder metoed i propery ClassTextBoxCollection, som opdatere det property TextBoxen i GUI er Binded til.
                ClassTextBoxCollection.SetSign(boxID, actualSign);

                // Hvis spilleren har sat 3 tegn, skal det undersøges om det er en vinderkombination.
                if (CheckNumberOfSigns() == 3)
                {
                    if (CheckNewDraw(actualSign) == true)
                    {
                        bolRes = true;
                    }
                }
                // Hvis der ikke er fundet en vinder skal baggrundsfarven ændres på GUI.
                if (bolRes == false)
                {
                    SetColor();
                }
            }
            // Hvis en af betingelserne i den overstående if ikke er opfyldt, skal denne del af koden udføres.
            else
            {
                // Logikken i spillet gør, at det ikkke giver mening at udføre noget, med mindre at spilleren har sat 3 tegn.
                if (CheckNumberOfSigns() == 3)
                {
                    // Hvis spilleren har sat 3 tegn, har han lov til at fjerne et af sine egne tegn.
                    // Derfor undersøges det om Texboxen indenholder et tegn der passer til spilleren.
                    if (strSignPlacement[xCord, yCord] == actualSign)
                    {
                        // Spillerens tegn fjernet i det 2 dim. array.
                        strSignPlacement[xCord, yCord] = "";
                        // Kald til metode der tæller ned på hvormange tegn spilleren har sat.
                        UpdateNumberOfSignsRemove();
                        //Kalder metoed i propery ClassTextBoxCollection, som opdatere det property TextBoxen i GUI er Binded til.
                        ClassTextBoxCollection.SetSign(boxID, "");
                    }
                }
            }
            // Retunere en bolsk værdi, der angover om der er fundet en vinder.
            return bolRes;
        }

        /// <summary>
        /// Nulstiller spillet så man kan spille et spil mere hvis det er det man vil.
        /// </summary>
        public void ResetAll()
        {
            InitialiseArray();
            ClassTextBoxCollection.initialisereTextBox();
            gridColor = "Blue";
            intO = 0;
            intX = 0;

        }

        /// <summary>
        /// Sætter baggrundsfarven til den valgte farve som er i dette tilfælde er rød og blå.
        /// </summary>
        private void SetColor()

        {
            if (gridColor == "Blue")
            {
                gridColor = "Red";
            }
            else
            {
                gridColor = "Blue";
            }

        }

        /// <summary>
        /// Metoden her gør at den tæller hver gang der er blevet sat en brik/(X eller O).
        /// </summary>
        private void UpdateNumberOfSignsAdd()

        {
            if (actualSign == "X")
            {
                intX++;
            }
            else
            {
                intO++;
            }

        }

        /// <summary>
        /// Metoden her fjerner den 3 brik så man kan sætte en nyt hvis der ikke er fundet en vinder endnu.
        /// </summary>
        private void UpdateNumberOfSignsRemove()

        {
            if (actualSign == "X")
            {
                intX--;
            }
            else
            {
                intO--;
            }

        }

        /// <summary>
        /// Metoden her tjekker hvormange tegn der er sat ind i spillet og retunerer det tal.
        /// </summary>
        /// <returns>res</returns>
        private int CheckNumberOfSigns()

        {
            int res = 0;

            if (actualSign == "X")
            {
                res = intX;
            }
            else
            {
                res = intO;
            }

            return res;
        }


    }
}

