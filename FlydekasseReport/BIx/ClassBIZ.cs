using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
  public class ClassBIZ : ClassNotify
    {
        public ClassBIZ()
        {

        }

        private ClassMaterial _selectedMaterial;

        private ClassBox _selectedBox;

        private List<ClassMaterial> _listSelectedMaterial;

        private ObservableCollection<ClassBox> _listSelectedBoxes;

        private ObservableCollection<ClassMaterial> _classMaterials;

        public ObservableCollection<ClassMaterial> ClassMaterials
        {
            get { return _classMaterials; }
            set
            {
                if (_classMaterials != value)
                {
                    _classMaterials = value;
                }
                Notify("ClassMaterials");
            }
        }

        public ObservableCollection<ClassBox> listSelectedBoxes
        {
            get { return _listSelectedBoxes; }
            set
            {
                if (_listSelectedBoxes != value)
                {
                    _listSelectedBoxes = value;
                }
                Notify("listSelectedBoxes");
            }
        }

        public List<ClassMaterial> listSelectedMaterial
        {
            get { return _listSelectedMaterial; }
            set
            {
                if (_listSelectedMaterial != value)
                {
                    _listSelectedMaterial = value;
                }
                Notify("listSelectedMaterial");
            }
        }
        public ClassBox selectedBox
        {
            get { return _selectedBox; }
            set
            {
                if (_selectedBox != value)
                {
                    _selectedBox = value;
                }
                Notify("selectedBox");
            }
        }

        
        public ClassMaterial selectedMaterial
        {
            get { return _selectedMaterial; }
            set
            {
                if (_selectedMaterial != value)
                {
                    _selectedMaterial = value;
                }
                Notify("selectedMaterial");
            }
        }

        public void AddBoxToSelecedList() 
        { 
        
        }

        public void AddMaterialToSelectedList() 
        {
        
        }

        public void MakeReportFile() 
        {
        
        }

        private string CalculatePercentageAboveTheWaterSurface(ClassBox inBox)
        {

            return "";
        }

        private void SetUpMateriallist() 
        {
        
        }
    }
}
