using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
    /// <summary>
    /// Conjunto de valores predefinidos para IMC
    /// </summary>
    enum IMC
    {
        VERY_SEVERELY_UNDER_WEIGHT, SEVERELY_UNDER_WEIGHT, UNDER_WEIGHT, NORMAL, OVER_wEIGHT, MODERATELY_OBESE, SEVERELY_OBESE, VERY_SEVERELY_OBESE
    }
    class IENUM
    {
        private IMC imc;
        public IENUM(IMC imc) {this.imc = imc; }
        /// <summary>
        /// Metodo por el cual se obtendra el valor de tipo string para ser reflejado en la aplicacion como categoria
        /// </summary>
        /// <param name="imc"></param>
        /// <returns></returns>
        public static String getValue(IMC imc)
        {
            String imcStr = "Sin valor";
            switch (imc)
            {
                case IMC.VERY_SEVERELY_UNDER_WEIGHT:
                    imcStr = "Muy severamente bajo de peso";
                    break;
                case IMC.SEVERELY_UNDER_WEIGHT:
                    imcStr = "Severamente bajo de peso";
                    break;
                case IMC.UNDER_WEIGHT:
                    imcStr = "Bajo de peso";
                    break;
                case IMC.NORMAL:
                    imcStr = "Peso normal";
                    break;
                case IMC.OVER_wEIGHT:
                    imcStr = "Sobre peso";
                    break;
                case IMC.MODERATELY_OBESE:
                    imcStr = "Moderadamente obeso";
                    break;
                case IMC.SEVERELY_OBESE:
                    imcStr = "Severamente obeso";
                    break;
                case IMC.VERY_SEVERELY_OBESE:
                    imcStr = "Muy severamente obeso";
                    break;
                default:
                    break;
            }
            return imcStr;
        }
    }
}
