using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class ClassMaterial : ClassNotify
    {

        private int _materialDim;

        private string _materialName;

        private double _materialWeight;

        public ClassMaterial()
        {
            MaterialDim = 0;
            MaterialName = "";
            MaterialWeight = 0D;

        }

        public ClassMaterial(ClassMaterial inMaterial)
        {
            MaterialDim = inMaterial.MaterialDim;
            MaterialName = inMaterial.MaterialName;
            MaterialWeight = inMaterial.MaterialWeight;
        }

        public ClassMaterial(string inName, double inWeight, int inDim)
        {
            MaterialDim = inDim;
            MaterialName = inName;
            MaterialWeight = inWeight;
        }


        public double MaterialWeight
        {
            get { return _materialWeight; }
            set
            {
                if (_materialWeight != value)
                {
                    _materialWeight = value;
                }
                Notify("materialWeight");
            }
        }

        public string MaterialName
        {
            get { return _materialName; }
            set
            {
                if (_materialName != value)
                {
                    _materialName = value;
                }
                Notify("materialName");
            }
        }
        public int MaterialDim
        {
            get { return _materialDim; }
            set 
            {
                if (_materialDim != value)
                {
                    _materialDim = value;
                }
                Notify("materialDim");
            }
        }

    }
}
