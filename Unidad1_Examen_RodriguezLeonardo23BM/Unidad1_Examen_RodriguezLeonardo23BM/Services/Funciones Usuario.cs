using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad1_Examen_RodriguezLeonardo23BM.Entities;

namespace Unidad1_Examen_RodriguezLeonardo23BM.Services
{
    public class Funciones_Usuario
    {
        Funciones f = new Funciones();
        bool ok = false;

        public void Agregarusuario(Usuario cliente)
        {
            

            do
            {
                f.impt(ConsoleColor.DarkYellow, ">> Ingrese su nombre: ");
                cliente.Nombre = Console.ReadLine();
                if (string.IsNullOrEmpty(cliente.Nombre))
                    f.merror();
                else
                    ok = true;
            } while(!ok);
            ok = false;
            do
            {
                f.impt(ConsoleColor.DarkYellow, "\n>> Ingrese su correo electrónico: ");
                cliente.Correo = Console.ReadLine();
                if (string.IsNullOrEmpty(cliente.Correo))
                    f.merror();
                else
                    ok = true;
            } while (!ok);
        }

        public void ingenvio(Usuario cliente)
        {
            string respuesta;
            int ans;
            f.impt(ConsoleColor.Red, "\n\t ---- Ingresará los datos de envío ----");
            do
            {
                f.impt(ConsoleColor.DarkYellow, "\n>> Ingrese la SuperManzana: ");
                cliente.Smza = Console.ReadLine();
                if (string.IsNullOrEmpty(cliente.Nombre))
                    f.merror();
                else
                    break;
            } while (!ok);

            do
            {
                f.impt(ConsoleColor.DarkYellow, "\n>> Ingrese la Manzana: ");
                respuesta = Console.ReadLine();
                if (string.IsNullOrEmpty(respuesta))
                    f.merror();
                else
                    cliente.Mza = respuesta;
                    break;
            } while (!ok);
            
            do
            {
                f.impt(ConsoleColor.DarkYellow, "\n>> Ingrese el Lote: ");
                respuesta = Console.ReadLine();
                if (string.IsNullOrEmpty(respuesta))
                    f.merror();
                else
                    cliente.Lt = respuesta;
                    break;
            } while (!ok);
            cliente.Fecha = DateTime.Now;
        }


    }
}
