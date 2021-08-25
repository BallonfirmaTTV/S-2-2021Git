using Repository;

namespace BIZ
{
    public class ClassBIZ
    {
        

        private ClassBackgrundColor _colorData;

        /// <summary>
        /// Default Consturctor for ClassBackgrundColor.
        /// Her initialiseres de nødvændige elementer i ClassBackgrundColor.
        /// </summary>
        public ClassBIZ()
        {
            colorData = new ClassBackgrundColor();
        }
        /// <summary>
        /// En simpel property af datatypen ClassBackgrundColor, der skal 
        /// give adgang til de metoder og property der er i ClassBackgrundColor.
        /// Det er gennem dette property der fortages Binding på GUI til div. slides
        /// </summary>
        public ClassBackgrundColor colorData
        {
            get { return _colorData; }
            set
            {
                if (_colorData != value)
                {
                    _colorData = value;
                }
            }
        }
    }
}
