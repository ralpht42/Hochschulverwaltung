﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hochschulverwaltung
{
    public partial class ResourcenAnlegen : UserControl
    {

        
        UserControl auswahl = null;

        public ResourcenAnlegen()
        {
            InitializeComponent();

            
            auswahl = new ResourcenAnlegen_Student();
            layoutResourcenAnlegen.Controls.Add(auswahl);
        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dropDown.Text)
            {
                case "Dozent":
                    auswahl = new ResourcenAnlegen_Dozent();

                    break;

                case "Lerngruppe":
                    auswahl = new ResourcenAnlegen_Lerngruppe();
                    break; 

                case "Student":
                    auswahl = new ResourcenAnlegen_Student();
                    break;
                case "Kurs":
                    auswahl = new ResourcenAnlegen_Kurs();

                    break;

                default: break;
            }

            if (auswahl != null)
            {
                if (layoutResourcenAnlegen.Controls.Count > 0)
                {
                    layoutResourcenAnlegen.Controls.RemoveAt(layoutResourcenAnlegen.Controls.Count - 1);
                }
                layoutResourcenAnlegen.Controls.Add(auswahl);
                
            }
        }
    }
}
