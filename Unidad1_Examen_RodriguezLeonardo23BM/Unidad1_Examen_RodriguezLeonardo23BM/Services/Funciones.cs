using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad1_Examen_RodriguezLeonardo23BM.Entities;

namespace Unidad1_Examen_RodriguezLeonardo23BM.Services
{
    public class Funciones
    {
        bool ok = false;
        public string promocion(int precio)
        {
            string promo="", decision;
            if (precio < 1000)
                promo = $"\nSu total es de: ${precio+250} más envío.";
            if (precio > 1000)
            {
                impt(ConsoleColor.Green, "\n\t>->- Se le han ofrecido 3 meses sin intereses -<-<\n\tEscriba Y para aceptarlos ó N para rechazarlos: ");
                do
                {
                    decision = Console.ReadLine();
                    if (string.IsNullOrEmpty(decision))
                        merror();
                    else if (decision == "Y" || decision == "y" || decision == "N" || decision == "n")
                        ok = true;
                    else
                        merror();
                } while (!ok);
                ok=false;
                if (decision == "Y" || decision == "y")
                    promo = $"\nSu total es de: ${precio / 3} por 3 meses (sin intereses) con envío gratis.";
                else
                    promo = $"\nSu total es de: ${precio} con envío gratis.";
            }
            return promo;
        }

        public int totcom()
        {
            int total=0;
            string respuesta;
            do
            {
                impt(ConsoleColor.Blue, "\n¿Cuál fue el total de su compra?: ");
                respuesta = Console.ReadLine();
                if (string.IsNullOrEmpty(respuesta))
                    merror();
                else if (int.TryParse(respuesta, out total) == false)
                    merror();
                else
                    ok = true;
            } while (!ok);
            ok=false;
            return total;
        }

        public void impenvio(Usuario cliente)
        {
            impt(ConsoleColor.Green, $"\nEl pedido será enviado a: ");
            Console.Write(cliente.Nombre);
            impt(ConsoleColor.Green,"\nCorreo: ");
            Console.Write(cliente.Correo);
            impt(ConsoleColor.Green, "\n\t> SuperManzana: ");
            Console.Write(cliente.Smza);
            impt(ConsoleColor.Green, "\n\t> Manzana: ");
            Console.Write(cliente.Mza);
            impt(ConsoleColor.Green, "\n\tLote: ");
            Console.Write(cliente.Lt);
            impt(ConsoleColor.Green, "\n\t--- Compra realizada el ");
            Console.Write(cliente.Fecha);
            impt(ConsoleColor.Green, " ---");
        }

        public void impt(ConsoleColor color, string texto)
        {
            Console.ForegroundColor= color;
            Console.Write(texto);
            Console.ResetColor();
        }

        public void merror()
        {
            impt(ConsoleColor.Red, "\t>>> Ha ocurrido un error <<<\n");
        }

        public void bienvenida()
        {
            impt(ConsoleColor.Cyan, "\t\t---------------------------------\n\t\t-\t¡¡BIENVENID@!!\t\t-\n\t\t---------------------------------\n");
        }
    }
}
