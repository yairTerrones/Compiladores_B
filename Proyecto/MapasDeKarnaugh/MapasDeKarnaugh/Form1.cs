using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapasDeKarnaugh
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para accionar el boton de simplificar funciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimplificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textVariables.Text))//Por mientras. (Aqui va lo que nos entrega la gramatica (Llista)).
            {

            }
        }

        /// <summary>
        /// Método para saber la cantidad de letras que hay en la lista que se genera en el esquema de traducción.
        /// </summary>
        /// <param name="l_Variables">Lista generada en el esquema de traducción.</param>
        /// <returns></returns>
        public int getCantidadLetras(List<string> l_Variables)
        {
            List<char> l_Aux = new List<char>();

            try
            {
                foreach (string str in l_Variables)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (!l_Aux.Contains(str[i]))
                            l_Aux.Add(str[i]);

                        if (l_Aux.Count > 4)//Modificar para el proyecto
                            return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            return l_Aux.Count;
        }


    }
}
