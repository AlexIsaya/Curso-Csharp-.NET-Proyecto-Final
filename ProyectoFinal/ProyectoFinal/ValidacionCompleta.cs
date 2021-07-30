using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Validacion1
{
    class ValidacionCompleta
    {
        public void Limpiar(object obj)
        {
            if (obj is GroupBox)
            {
                foreach (var ctrol in ((GroupBox)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        Limpiar(ctrol);
                    }
                }
            }

            if (obj is TextBox)
            {
                ((TextBox)obj).Clear();
            }
        }
        public void soloNumeros(KeyPressEventArgs e)
            //, string texto)
        {
            Regex rex = new Regex("^[0-9]+$");

            if (rex.IsMatch(e.KeyChar.ToString()) || char.IsControl(e.KeyChar))
            {
                //if (e.KeyChar == ',' && texto.Contains(','))
                //{
                //    e.Handled = true;
                //}
                //else 
                e.Handled = false;
            }
            else e.Handled = true;
        }

        public  void soloLetras(KeyPressEventArgs e)
        {
            
            Regex rex = new Regex("^[a-zA-Z]+$");
           
            if (rex.IsMatch(e.KeyChar.ToString())||char.IsControl(e.KeyChar))
                /*
                 * true || true = true
                 * true || false = true
                 * false || true = true
                 * false || false = false
                 * 
                 * true && true = true
                 * true && false = false
                 * false && true false
                 * false $$ false = false
                 * 
                 * 
                 * */

                e.Handled = false;

           else e.Handled = true;
        }
        public void NumerosYPunto(KeyPressEventArgs e, string cq)
        {
            if (e.KeyChar == 44)
            {
                e.KeyChar = '.';
            }
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 08 || e.KeyChar == 44 || e.KeyChar == 46)
            {
                if (e.KeyChar == 46)
                {
                    if (cq.Contains('.'))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
