using System;
using System.Collections.Generic;
using System.Text;

namespace Project_gbl.Model
{
    public class ModelPlayer
    {
        /// <summary>
        /// LeftRightPosition should be between 0 (Left) and 99 (Right) (Both inclusive)
        /// </summary>
        public int LeftRightPosition { get; set; }

        /// <summary>
        /// VerticalPosition should be between 0 (on ground) and 99 (feet on top of screen) (Both inclusive)
        /// </summary>

        public int VerticalPosition { get; set; }


    }
}
