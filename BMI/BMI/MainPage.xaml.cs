using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        double peso, altura,resultado;
        int Edad;
        IMC categoria;
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary> Este metodo es el que se utiliza cuando se presiona el boton "Btn_generar"
        /// <para>El metodo solo espera a que el evento sea lanzado al presionar el boton.
        /// Ejecutara los metodos externos y los llamara.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_generar_Clicked(object sender, EventArgs e)
        {
            peso = double.Parse(txt_peso.Text);
            altura = double.Parse(txt_altura.Text);
            Double imc = calcularIMC(peso,altura);

            lbl_Resultado.Text = imc.ToString();
            lbl_Categoria.Text = getBMICategoria(imc);
        }
        /// <summary> Metodo utilizado para calcula el IMC
        /// <para> Este metodo recibe 2 parametros: uno para peso y el otro para altura,
        /// Se llega a el imc mediante la formula dentro y devuelve ese valor
        /// </para>
        /// </summary>
        /// <param name="pesoDbl"></param>
        /// <param name="estaturaDbl"></param>
        /// <returns></returns>
        private Double calcularIMC(Double pesoDbl, Double estaturaDbl)
        {
            Double imc = pesoDbl / (estaturaDbl * estaturaDbl);
            return imc;
        }
        /// <summary>Metodo utilizadp para obtener la categoria, de acuerdo a tu imc
        /// <para>Este metodo recibe un valor tipo double, con el cual obtiene la categoria en la que tre encuentras,
        /// esto de acuerdo a la clase IENUM donde se guardan varios valores para ser devueltos como string.
        /// </para>
        /// </summary>
        /// <param name="imc"></param>
        /// <returns></returns>
        private String getBMICategoria(Double imc)
        {
           
            Edad = int.Parse(txt_edad.Text);
            string op = PickerSexo.SelectedItem.ToString();
            if (op == "Hombre")
            {
                if (Edad >= 1 && Edad < 5)
                {
                    if (imc < 5.7)
                    {
                        categoria = IMC.VERY_SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.0)
                    {
                        categoria = IMC.SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.2)
                    {
                        categoria = IMC.UNDER_WEIGHT;
                    }
                    else if (imc < 7.0)
                    {
                        categoria = IMC.NORMAL;
                    }
                    else if (imc < 7.8)
                    {
                        categoria = IMC.OVER_wEIGHT;
                    }
                    else if (imc < 8.7)
                    {
                        categoria = IMC.MODERATELY_OBESE;
                    }
                    else if (imc < 8.9)
                    {
                        categoria = IMC.SEVERELY_OBESE;
                    }
                    else
                    {
                        categoria = IMC.VERY_SEVERELY_OBESE;
                    }

                }
                else if (Edad >= 5 && Edad <= 11)
                {
                    if (imc < 5.7)
                    {
                        categoria = IMC.VERY_SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.0)
                    {
                        categoria = IMC.SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.2)
                    {
                        categoria = IMC.UNDER_WEIGHT;
                    }
                    else if (imc < 7.0)
                    {
                        categoria = IMC.NORMAL;
                    }
                    else if (imc < 7.8)
                    {
                        categoria = IMC.OVER_wEIGHT;
                    }
                    else if (imc < 8.7)
                    {
                        categoria = IMC.MODERATELY_OBESE;
                    }
                    else if (imc < 8.9)
                    {
                        categoria = IMC.SEVERELY_OBESE;
                    }
                    else
                    {
                        categoria = IMC.VERY_SEVERELY_OBESE;
                    }
                }
                else if (Edad >= 12 && Edad <= 19)
                {
                    if (imc < 5.7)
                    {
                        categoria = IMC.VERY_SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.0)
                    {
                        categoria = IMC.SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.2)
                    {
                        categoria = IMC.UNDER_WEIGHT;
                    }
                    else if (imc < 7.0)
                    {
                        categoria = IMC.NORMAL;
                    }
                    else if (imc < 7.8)
                    {
                        categoria = IMC.OVER_wEIGHT;
                    }
                    else if (imc < 8.7)
                    {
                        categoria = IMC.MODERATELY_OBESE;
                    }
                    else if (imc < 8.9)
                    {
                        categoria = IMC.SEVERELY_OBESE;
                    }
                    else
                    {
                        categoria = IMC.VERY_SEVERELY_OBESE;
                    }
                }
                else if (Edad >= 20 && Edad <= 59)
                {
                    if (imc < 5.7)
                    {
                        categoria = IMC.VERY_SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.0)
                    {
                        categoria = IMC.SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.2)
                    {
                        categoria = IMC.UNDER_WEIGHT;
                    }
                    else if (imc < 7.0)
                    {
                        categoria = IMC.NORMAL;
                    }
                    else if (imc < 7.8)
                    {
                        categoria = IMC.OVER_wEIGHT;
                    }
                    else if (imc < 8.7)
                    {
                        categoria = IMC.MODERATELY_OBESE;
                    }
                    else if (imc < 8.9)
                    {
                        categoria = IMC.SEVERELY_OBESE;
                    }
                    else
                    {
                        categoria = IMC.VERY_SEVERELY_OBESE;
                    }
                }
                else if (Edad >= 60 && Edad >= 70)
                {
                    if (imc < 5.7)
                    {
                        categoria = IMC.VERY_SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.0)
                    {
                        categoria = IMC.SEVERELY_UNDER_WEIGHT;
                    }
                    else if (imc < 6.2)
                    {
                        categoria = IMC.UNDER_WEIGHT;
                    }
                    else if (imc < 7.0)
                    {
                        categoria = IMC.NORMAL;
                    }
                    else if (imc < 7.8)
                    {
                        categoria = IMC.OVER_wEIGHT;
                    }
                    else if (imc < 8.7)
                    {
                        categoria = IMC.MODERATELY_OBESE;
                    }
                    else if (imc < 8.9)
                    {
                        categoria = IMC.SEVERELY_OBESE;
                    }
                    else
                    {
                        categoria = IMC.VERY_SEVERELY_OBESE;
                    }
                }


            }
            else
            {
                if (Edad >= 1 && Edad < 5)
                {

                }
                else if (Edad >= 5 && Edad <= 11)
                {

                }
                else if (Edad >= 12 && Edad <= 19)
                {

                }
                else if (Edad >= 20 && Edad <= 59)
                {

                }
                else if (Edad >= 60 && Edad >= 70)
                {

                }

            }

            return IENUM.getValue(categoria);
        }
    }
}
