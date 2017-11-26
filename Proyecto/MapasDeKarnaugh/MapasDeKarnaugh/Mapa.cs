using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapasDeKarnaugh
{
    class Mapa
    {
        private int dimensionX, dimensionY;
        private List<char> listaLetras;
        private List<string> listaPares;
        private int[,] matriz, matriz2;
        private int[] valor;

        public Mapa(int unaDimension, List<char> l_Aux)
        {
            this.validaDimension(unaDimension);
            this.listaLetras = l_Aux;
        }

        /// <summary>
        /// Método para inicializar el datagridview.
        /// </summary>
        /// <param name="unDatagridView"></param>
        public void inicializaDataGridview(DataGridView unDatagridView)
        {
            int index = 0;
            string num = "";
            try
            {
                unDatagridView.Rows.Clear();
                unDatagridView.Columns.Clear();
                unDatagridView.ColumnCount = dimensionX;
                unDatagridView.RowCount = dimensionY;
                foreach (DataGridViewColumn columna in unDatagridView.Columns)
                {
                    //num = Convert.ToInt32((index.ToString()), 2).ToString();
                    index = index + 1;
                    columna.Name = num;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Verifica la dimension.
        /// </summary>
        /// <param name="unaDimension"></param>
        public void validaDimension(int unaDimension)
        {
            try
            {
                if (unaDimension % 2 != 0 && unaDimension != 1)
                {
                    this.dimensionX = unaDimension + 1;
                    this.dimensionY = unaDimension - 1;
                    matriz = new int[dimensionX, dimensionY];
                    matriz2 = new int[dimensionX, dimensionY];
                    valor = new int[(dimensionX * dimensionY)];
                    //Ordenar la lista.
                    this.listaLetras.Sort();
                }
                else
                {
                    this.dimensionX = unaDimension;
                    this.dimensionY = unaDimension;
                    matriz = new int[dimensionX, dimensionY];
                    matriz2 = new int[dimensionX, dimensionY];
                    valor = new int[(dimensionX * dimensionY)];
                    //Ordenar la lista.
                    this.listaLetras.Sort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Método para ubicar el texto en la matriz
        /// </summary>
        public bool ubicaTermino(string unaCadena)
        {
            string cadBinario = "";
            long numero = 0, contAux = 0;

            try
            {
                //Obtenemos la cadena binaria.
                for (int i = 0; i < unaCadena.Length; i++)
                {
                    if (char.IsLetter(unaCadena[i]))
                        cadBinario += 1;
                    else
                    {
                        cadBinario += 0;
                        i++;
                    }
                }
                //Volteamos la cadena.
                char[] arreglo = cadBinario.ToCharArray();
                Array.Reverse(arreglo);
                cadBinario = new string(arreglo);
                //Obtenemos el numero decimal.
                for (int i = 0; i < cadBinario.Length; i++)
                    numero += (long)Math.Pow(2, i) * int.Parse(cadBinario[i].ToString());
                //Ubicamos en la matriz.
                for (int i = 0; i < dimensionX; i++)
                {
                    for (int j = 0; j < dimensionY; j++)
                    {
                        if (numero == contAux)
                        {
                            matriz[i, j] = 1;
                            matriz2[i, j] = 1;
                            return true;
                        }
                        contAux++;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
    }
}
