using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
   public class ClassBox : ClassNotify
    {

        private ClassMaterial _boxMaterial;

        public ClassBox()
        {
            _boxMaterial = new ClassMaterial();
            boxBouyancy = 0D;
            boxDepth = 0D;
            boxHeight = 0D;
            boxVolume = 0D;
            boxWeight = 0D;
            boxWide = 0D;
            strBoxDepth = "";
            strBoxHeight = "";
            strBoxWide = "";
        }

        public ClassBox(ClassBox inClassBox)
        {
            boxMaterial = new ClassMaterial(inClassBox.boxMaterial);
            boxBouyancy = inClassBox.boxBouyancy;
            boxDepth = inClassBox.boxDepth;
            boxHeight = inClassBox.boxHeight;
            boxVolume = inClassBox.boxVolume;
            boxWeight = inClassBox.boxWeight;
            boxWide = inClassBox.boxWeight;
            strBoxWide = inClassBox.strBoxWide;
            strBoxHeight = inClassBox.strBoxHeight;
            strBoxDepth = inClassBox.strBoxDepth;        
        }

        public ClassBox(ClassBox inClassBox, ClassMaterial inClassMaterial)
        {
            
        }

        private double _boxBouyancy;

        public double boxBouyancy
        {
            get { return _boxBouyancy; }
            set
            {
                if (_boxBouyancy != value)
                {
                    _boxBouyancy = value;
                }
                Notify("boxBouyancy");
            }
        }

        private double _boxDepth;

        public double boxDepth
        {
            get { return _boxDepth; }
            set
            {
                if (_boxDepth != value)
                {
                    _boxDepth = value;
                }
                Notify("boxDepth");
            }
        }

        private double _boxHeight;

        public double boxHeight
        {
            get { return _boxHeight; }
            set
            {
                if (_boxHeight != value)
                {
                    _boxHeight = value;
                }
                Notify("boxHeight");
            }
        }

        public ClassMaterial boxMaterial
        {
            get { return _boxMaterial; }
            set
            {
                if (_boxMaterial != value)
                {
                    _boxMaterial = value;
                }
                Notify("boxMaterial");
            }
        }
        private double _boxVolume;

        public double boxVolume
        {
            get { return _boxVolume; }
            set
            {
                if (_boxVolume != value)
                {
                    _boxVolume = value;
                }
                Notify("boxVolume");
            }
        }

        private double _boxWeight;

        public double boxWeight
        {
            get { return _boxWeight; }
            set
            {
                if (_boxWeight != value)
                {
                    _boxWeight = value;
                }
                Notify("boxWeight");
            }
        }

        private double _boxWide;

        public double boxWide
        {
            get { return _boxWide; }
            set
            {
                if (_boxWide != value)
                {
                    _boxWide = value;
                }
                Notify("boxWide");
            }
        }

        private string _strBoxDepth;

        public string strBoxDepth
        {
            get { return _strBoxDepth; }
            set
            {
                if (_strBoxDepth != value)
                {
                    _strBoxDepth = value;
                }
                Notify("strBoxDepth");
            }
        }

        private string _strBoxHeight;

        public string strBoxHeight
        {
            get { return _strBoxHeight; }
            set
            {
                if (_strBoxHeight != value)
                {
                    _strBoxHeight = value;
                }
                Notify("strBoxHeight");
            }
        }

        private string _strBoxWide;

        public string strBoxWide
        {
            get { return _strBoxWide; }
            set
            {
                if (_strBoxWide != value)
                {
                    _strBoxWide = value;
                }
                Notify("strBoxWide");
            }
        }
    }
}
