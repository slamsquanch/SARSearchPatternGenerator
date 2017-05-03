using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SARSearchPatternGenerator
{
    /*
     * The Display class is a panel with zero or more sections.
     * It is meant to be added to the window as a panel to display
     * all the sections it contains.
     */
    public class Display : Panel
    {
        //A list of sections that are on this panel.
        private List<Panel> sections;

        /*
         * Default constructor for a Display.
         */
        public Display() : base()
        {
            sections = new List<Panel>();
        }

        /*
         * Adds another Panel to the list of sections
         * contained within this Display, and adds it
         * to the Display.
         * 
         * @param newPanel - The Panel to be added to
         *                   the display.
         */
        public void addSection(Panel newPanel)
        {
            sections.Add(newPanel);
            this.Controls.Add(newPanel);
        }
    }
}
