using System.Windows.Media;

namespace Repository
{
    /// <summary>
    ///  Denne class indeholder de metoder og property, der har ansvaret for logikken i programmet.
    /// </summary>
    public class ClassBackgrundColor : ClassNotify
    {
        /// <summary>
        /// Fields der knytter sig til property.
        /// </summary>
     
        private string _hexValue;
        private int _redValue;
        private int _greenValue;
        private int _blueValue;
        private int _trnsValue;

        /// <summary>
        /// Indeholder standart baggrundsfarven på GUI'en.
        /// </summary>
        public ClassBackgrundColor()
        {
            hexValue = "808080";
            redValue = 128;
            greenValue = 128;
            blueValue = 128;
            trnsValue = 255;
        }
        /// <summary>
        /// Indeholder Den værdi som gør farven mere eller mindre gennemsigtig.
        /// </summary>
        public int trnsValue
        {
            get { return _trnsValue; }
            set
            {
                if (_trnsValue != value)
                {
                    if (value < 0)
                    {
                        value = 0;
                    }
                    if (value > 255)
                    {
                        value = 255;
                    }
                    _trnsValue = value;
                    ConvertToHex();
                }
                Notify("trnsValue");
            }
        }

        /// <summary>
        /// Indeholder Den værdi som gør farven mere eller mindre blå.
        /// </summary>
        public int blueValue
        {
            get { return _blueValue; }
            set
            {
                if (_blueValue != value)
                {
                    if (value < 0)
                    {
                        value = 0;
                    }
                    if (value > 255)
                    {
                        value = 255;
                    }
                    _blueValue = value;
                    ConvertToHex();
                }
                Notify("blueValue");
            }
        }

        /// <summary>
        /// Indeholder Den værdi som gør farven  mere eller mindre grøn.
        /// </summary>
        public int greenValue
        {
            get { return _greenValue; }
            set
            {
                if (_greenValue != value)
                {
                    if (value < 0)
                    {
                        value = 0;
                    }
                    if (value > 255)
                    {
                        value = 255;
                    }
                    _greenValue = value;
                    ConvertToHex();
                }
                Notify("greenValue");
            }
        }

        /// <summary>
        /// Indeholder Den værdi som gør farven mere eller mindre  rød.
        /// </summary>
        public int redValue
        {
            get { return _redValue; }
            set
            {
                if (_redValue != value)
                {
                    if (value < 0)
                    {
                        value = 0;
                    }
                    if (value > 255)
                    {
                        value = 255;
                    }
                    _redValue = value;
                    ConvertToHex();
                }
                Notify("redValue");
            }
        }

        /// <summary>
        /// Indeholder Hexværdien af farven.
        /// </summary>
        public string hexValue
        {
            get { return "#" + _hexValue; }
            set
            {
                if (_hexValue != value)
                {
                    _hexValue = value;
                }
                Notify("hexValue");
            }
        }

        /// <summary>
        /// Convatere (Rød,Blå og Grøns value) om til HEX og RGB.
        /// </summary>

        private void ConvertToHex()
        {
            Color myColor = Color.FromArgb((byte)trnsValue, (byte)redValue, (byte)greenValue, (byte)blueValue);
            hexValue = myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
        }
    }
}
