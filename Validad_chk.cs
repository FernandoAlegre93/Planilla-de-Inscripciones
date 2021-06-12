using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Pantalla_de_Inscripciones
{
    class Validad_chk
    {
        public void Valid(GroupBox grupo, CheckBox chk)
        {
            int contador = 0;
            int total = 0;

            foreach (Control G in grupo.Controls)
            {
                if ((G is CheckBox))
                {
                    if (((CheckBox)G).Checked == true)
                    {contador = contador + 1;}
                        total = total + 1;
                    
                }

            }
            if (contador == 0) { chk.CheckState = CheckState.Unchecked; }
            if (contador == total) { chk.CheckState = CheckState.Checked; }
            if (contador <total && contador > 0) { chk.CheckState = CheckState.Indeterminate; }
        }
    }
}