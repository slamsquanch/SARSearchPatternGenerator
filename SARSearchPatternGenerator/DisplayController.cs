using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SARSearchPatternGenerator
{
    /*
     * The DisplayController class controls the Display view, constructing a 
     * base DisplayController will create a default blank Display. This class
     * is meant to be extended by different controllers for different displays.
     */
    public class DisplayController
    {
        //The display that this object controls.
        private Display display;
        
        /*
         * The default constructor for a DisplayController.
         */
        public DisplayController()
        {
            display = new Display();
        }

        /*
         * @return - Returns the Display this object
         *           controls. 
         */
        public Display getDisplay()
        {
            return display;
        }
    }
}
