using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace BIZ
{
    public class ClassCountDrawAndRegister : ClassNotify
    {

        /// <summary>
        /// 2 dimensionalarray med 3 rækker og 3 koloner.
        /// </summary>
        protected string[,] strSignPlacement = new string[3, 3];// strsignplacement blir brugt til at se hvor og hvilket tegn der er blevet sat.

        /// <summary>
        /// Default constuctor 
        /// Sætter alt værdi som standart til 0.
        /// Initialiser strSignPlacement.
        /// </summary>
        public ClassCountDrawAndRegister()
        {
            intX = 0;
            intO = 0;
            intScoreCountX = 0;
            intScoreCountO = 0;
            InitialiseArray();
        }

        /// <summary>
        /// simple property som holder værdier til at holde styr
        /// på hvormange X og O der er sat.
        /// </summary>

        protected int intX { get; set; }

        protected int intO { get; set; }

        protected int intScoreCountX { get; set; }

        protected int intScoreCountO { get; set; }

        /// <summary>
        /// Metoden initialisere det 2 dimensionalarray strSignPlacement.
        /// Metoden gør så man ikke kan sætte mere end de 3 tegn ad gangen
        /// og sørger for det antal ikke bliver overskredet.
        /// </summary>

        protected void InitialiseArray()
        {

            for (int i = 0; i < 3; i++)
            {

                for (int x = 0; x < 3; x++)
                {
                    strSignPlacement[i, x] = "";
                }
            }
        }
    }
}
