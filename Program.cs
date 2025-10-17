using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Estructuras_de_Control__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------- Ejecicio 1 ---------------------------//
            //Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés es
            //del 5 % anual, se debe solicitar el monto del préstamo y se desea calcular la siguiente
            //información.
            //• Cuanto dinero se ha pagado de intereses en un año.
            //• Cuanto dinero se ha pagado de intereses en el tercer trimestre del año.
            //• Cuanto dinero se ha pagado de intereses en el primer mes.
            //• Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses

            //float prestamo, prestamo_trimestre, prestamo_mes , prestamoTotal, prestamo_deuda;
            //const float INTERES = 0.05F;
            //Console.WriteLine("Ingrese el valor del prestamo: ");

            //prestamo = float.Parse(Console.ReadLine());
            //prestamo_deuda = prestamo;

            //prestamo *= INTERES;
            //Console.WriteLine($"Los intereces de un año son ${prestamo} ");

            //// Inicializar las variables antes de usarlas
            //prestamo_trimestre = prestamo / 4; // O asignar el valor del préstamo original
            //prestamo_trimestre *= 3;
            //Console.WriteLine($"Los intereces en el tercer trimestre son ${prestamo_trimestre}");

            //prestamo_mes = prestamo / 12; // O asignar el valor del préstamo original
            //prestamo_mes *= 1;
            //Console.WriteLine($"Los intereces en el primer mes son ${prestamo_mes}");

            //prestamoTotal = prestamo_deuda + (prestamo * 5);
            //Console.WriteLine($"Pago total de prestamo es ${prestamoTotal}");

            //Console.ReadLine();

            //----------------- Ejecicio 2 ---------------------------//

            //Desarrollar un algoritmo que permita generar la colilla de pago de los empleados de una
            //empresa.La colilla debe mostrar:
            //● El Salario del Empleado
            //● El Valor de Ahorro mensual programado.
            //● La suma a deducir por aporte a la Salud(EPS) 12,5 %
            //● La suma a deducir por aporte al Fondo de Pensiones 16 %
            //● Total a Recibir
            //● Toda la información que debe proveer el usuario del programa es el Salario del
            //Empleado y el Valor de Ahorro mensual programado. El programa debe calcular y
            //devolver el resto de los datos.4


            //double salario;
            //double ahorro;
            //double aporteSalud;
            //double aportePensiones;
            //double totalRecibir;

            //// Solicitar entradas al usuario
            //Console.WriteLine("Ingrese el salario del empleado: ");
            //salario = double.Parse(Console.ReadLine());  // Lee el salario como un número decimal

            //Console.WriteLine("Ingrese el valor de ahorro mensual programado: ");
            //ahorro = double.Parse(Console.ReadLine());  // Lee el ahorro como un número decimal

            //// Realizar cálculos
            //aporteSalud = salario * 0.125;  // 12,5% del salario
            //aportePensiones = salario * 0.16;  // 16% del salario
            //totalRecibir = salario - aporteSalud - aportePensiones - ahorro;  // Total después de deducciones

            //// Mostrar la colilla de pago en formato claro
            //Console.WriteLine("          COLILLA DE PAGO DEL EMPLEADO          ");
            //Console.WriteLine($"Salario del Empleado: {salario.ToString("F2")}");  // Formateado a 2 decimales
            //Console.WriteLine($"Valor de Ahorro mensual programado: {ahorro.ToString("F2")}");
            //Console.WriteLine($"Suma a deducir por aporte a la Salud (EPS): {aporteSalud.ToString("F2")}");
            //Console.WriteLine($"Suma a deducir por aporte al Fondo de Pensiones: {aportePensiones.ToString("F2")}");
            //Console.WriteLine($"Total a Recibir: {totalRecibir.ToString("F2")}");
            //Console.WriteLine("--------------------------------------------------");

            //// Pausa para que el usuario vea la salida
            //Console.WriteLine("Presione cualquier tecla para salir...");
            //Console.ReadKey();











        }
    }
}
