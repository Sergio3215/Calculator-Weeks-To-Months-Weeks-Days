using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate_to_week_to_day_or_months_or_weeks
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 0, semana = 0, semana1 = 0, meses = 0, count = 0;
            bool danger = false;
            Console.WriteLine("Do you want calculate?\n1.Days\n2.Weeks");
            string rta = "";
            rta = Console.ReadLine();
            try
            {
                switch (rta)
                {
                    case "1":
                        Console.WriteLine("Ingrese la cantidad deseada");

                        dia = int.Parse(Console.ReadLine());

                        int dia1 = 0, mes=0;

                        while (semana1 != dia&&semana1<dia)
                        {
                            dia1++;
                            mes++;
                            if (dia1 == 7)
                            {
                                count++;
                                semana1 += dia1;
                                dia1 = 0;
                            }
                            
                            if (mes==30)
                            {
                                meses++;
                                semana1 += dia1;
                                count = 0;
                                dia1 = 0;
                                mes = 0;
                            }
                        }
                        dia = dia1;
                        break;
                    case "2":
                        Console.WriteLine("Ingrese la cantidad deseada");

                        semana = int.Parse(Console.ReadLine());

                        while (semana1 != semana)
                        {
                            dia++;
                            if (dia == 7)
                            {
                                count++;
                                dia = 0;
                            }
                            if (count == 4)
                            {
                                meses++;
                                semana1 += count;
                                count = 0;
                                dia = 0;
                            }
                        }
                        break;
                    default: Console.WriteLine("Error"); break;
                }
            }
            catch
            {
                danger = true;
            }

            //Comprobar si el usuario se equivoco
            if (!danger)
                Console.WriteLine("Dias: " + dia + " Semana: " + count + " Meses: " + meses);
            else
                Console.WriteLine("Error Key");
            Console.Read();
        }
    }
}
