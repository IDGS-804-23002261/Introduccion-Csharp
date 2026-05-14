using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionC_.Models
{
    public class Multiplicacion
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public int Resultado { get; set; }

        public string Proceso { get; set; }


        public void Multiplicar()
        {
            Resultado = 0;

            Proceso = "";

            for (int i = 1; i <= Num1; i++)
            {
                Resultado += Num2;

                Proceso += Num2;

                if (i < Num1)
                {
                    Proceso += "+";
                }
            }
        }
    }
}