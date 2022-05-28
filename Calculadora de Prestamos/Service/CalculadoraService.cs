using Calculadora_de_Prestamos.Enums;
using Calculadora_de_Prestamos.Models;
using System;

namespace Calculadora_de_Prestamos.Service
{

    public class CalculadoraService
    {
        public void Calcular(CalculadoraViewModel cvm)
        {

            switch (cvm.TipoPrestamos)
            {

                case (int)TipoPrestamos.Personal:

                    double TasaInteres = (cvm.Monto * 22 / (100));

                    if(cvm.TipoPrestamos == 1 && cvm.Meses == 1)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 12), 2);
                    }

                    else if(cvm.TipoPrestamos == 1 && cvm.Meses == 2)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 18), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 3)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 24), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 4)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 30), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 5)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 36), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 6)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 42), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 7)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 48), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 8)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 54), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 9)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 60), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 10)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 66), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 11)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 72), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 12)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 78), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 13)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 84), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 14)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 90), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 15)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 96), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 16)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 102), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 17)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 108), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 18)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 114), 2);
                    }

                    else if (cvm.TipoPrestamos == 1 && cvm.Meses == 19)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 120), 2);
                    }
                    break;


                    // Intereses Automovil

                case (int)TipoPrestamos.Automovil:

                    TasaInteres = (cvm.Monto * 12 / (100));

                    if (cvm.TipoPrestamos == 2 && cvm.Meses == 1)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 12), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 2)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 18), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 3)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 24), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 4)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 30), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 5)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 36), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 6)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 42), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 7)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 48), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 8)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 54), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 9)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 60), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 10)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 66), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 11)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 72), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 12)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 78), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 13)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 84), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 14)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 90), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 15)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 96), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 16)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 102), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 17)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 108), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 18)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 114), 2);
                    }

                    else if (cvm.TipoPrestamos == 2 && cvm.Meses == 19)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 120), 2);
                    }
                    break;



                // Intereses Hipotecario

                case (int)TipoPrestamos.Hipotecario:

                    TasaInteres = (cvm.Monto * 8 / (100));

                    if (cvm.TipoPrestamos == 3 && cvm.Meses == 1)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 12), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 2)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 18), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 3)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 24), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 4)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 30), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 5)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 36), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 6)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 42), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 7)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 48), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 8)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 54), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 9)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 60), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 10)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 66), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 11)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 72), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 12)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 78), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 13)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 84), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 14)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 90), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 15)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 96), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 16)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 102), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 17)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 108), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 18)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 114), 2);
                    }

                    else if (cvm.TipoPrestamos == 3 && cvm.Meses == 19)
                    {
                        cvm.Result = Math.Round(((cvm.Monto + TasaInteres) / 120), 2);
                    }

                    break;
            }

        }

    }
}
