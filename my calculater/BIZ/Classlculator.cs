using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Classlculator : ClassNotify
    {

        private double _resPlus;

        private double _resMinus;

        private double _resGange;

        private double _resDivi;
       
        private string _tal1;

        private string _tal2;
        public Classlculator()
        {
            tal1 = "0";
            tal2 = "0";
            tal1dubb = 0D;
            tal2dubb = 0D;
        }

        private double tal2dubb { get; set; }
        private double tal1dubb { get; set; }
        public string tal1
        {
            get { return _tal1; }
            set
            {
                if (_tal1 != value)
                {
                    if (value.Trim() == "-")
                    {
                        _tal1 = "-";

                        tal1dubb = 0;

                        StartCalck();
                    }
                    if (value.Trim() == "")
                    {
                        _tal1 = "";

                        tal1dubb = 0;

                        StartCalck();
                    }
                    if (double.TryParse(value, out double x))
                    {
                        _tal1 = value;

                        tal1dubb = x;

                        StartCalck();
                    }
                }
                Notify("tal1");
            }
        }
        public string tal2
        {
            get { return _tal2; }
            set
            {
                if (_tal2 != value)
                {
                    if (value.Trim() == "-")
                    {
                        _tal2 = "-";

                        tal2dubb = 0;

                        StartCalck();
                    }
                    if (value.Trim() == "")
                    {
                        _tal2 = "";

                        tal2dubb = 0;

                        StartCalck();
                    }
                    if (double.TryParse(value, out double x))
                    {
                        _tal2 = value;

                        tal2dubb = x;

                        StartCalck();
                    }
                }
                Notify("tal2");
            }
        }
        public double resDivi
        {
            get { return _resDivi; }
            set
            {
                if (_resDivi != value)
                {
                    _resDivi = value;
                }
                Notify("resDivi");
            }
        }
        public double resPlus
        {
            get { return _resPlus; }
            set
            {
                if (_resPlus != value)
                {
                    _resPlus = value;
                }
                Notify("resPlus");
            }
        }
        public double resGange
        {
            get { return _resGange; }
            set
            {
                if (_resGange != value)
                {
                    _resGange = value;
                }
                Notify("resGange");
            }
        }
        public double resMinus
        {
            get { return _resMinus; }
            set
            {
                if (_resMinus != value)
                {
                    _resMinus = value;
                }
                Notify("resMinus");
            }
        }

        private void StartCalck()
        {
            resPlus = MakeResPlus();
            resMinus = MakeResMinus();
            resGange = MakeResGange();
            resDivi = MakeResDivi();
        }

        private double MakeResPlus() 
        
        {
            return tal1dubb + tal2dubb;
        }

        private double MakeResMinus()

        {
            return tal1dubb - tal2dubb;
        }

        private double MakeResGange()

        {
            return tal1dubb * tal2dubb;
        }

        private double MakeResDivi()

        {
            double res = 0D;

            if (tal2dubb != 0D)
            {
                res = tal1dubb / tal2dubb;
            }

            return res;

        }

    }
}
