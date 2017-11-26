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
        private List<string> ls;
        private Mapa mapaKarnaugh;
        private List<char> l_Aux;
        private int cantidadLetras;

        /// <summary>
        /// El metodo getCantidadLetras se inicia primero
        /// Las producciones 3 y 4 crean el objeto tipo Mapa (solo una vez) y de parametro se le pasaran 
        /// la cantidad de letras y la lista de letras.
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            cantidadLetras = this.getCantidadLetras("ABCD");
        }

        /// <summary>
        /// Método para accionar el boton de simplificar funciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimplificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textVariables.Text) && l_Aux != null)//Por mientras. (Aqui va lo que nos entrega la gramatica (Lista)).
                {
                    mapaKarnaugh = new Mapa(cantidadLetras,l_Aux);
                    mapaKarnaugh.inicializaDataGridview(dataKarnaugh);
                    if (mapaKarnaugh.ubicaTermino("A!B!C"))
                        MessageBox.Show("Termino ubicado correctamente");
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Método para saber la cantidad de letras que hay en la lista que se genera en el esquema de traducción.
        /// </summary>
        /// <param name="l_Variables">Lista generada en el esquema de traducción.</param>
        /// <returns></returns>
        public int getCantidadLetras(string unaPalabra)
        {
            l_Aux = new List<char>();

            try
            {
                for (int i = 0; i < unaPalabra.Length; i++)
                {
                    if (!l_Aux.Contains(unaPalabra[i]) && unaPalabra[i] != '!')
                        l_Aux.Add(unaPalabra[i]);

                    if (l_Aux.Count > 4)//Modificar para el proyecto
                        return -1;
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
