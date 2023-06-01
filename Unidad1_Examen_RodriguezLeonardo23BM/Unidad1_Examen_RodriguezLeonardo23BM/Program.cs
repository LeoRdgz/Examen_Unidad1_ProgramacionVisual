using System;
using System.Xml.Schema;
using Unidad1_Examen_RodriguezLeonardo23BM.Entities;
using Unidad1_Examen_RodriguezLeonardo23BM.Services;

namespace Unidad1_Examen_RodriguezLeonardo23BM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funciones f=new Funciones();
            Funciones_Usuario fs= new Funciones_Usuario();
            Usuario cliente = new Usuario();
            string promo;
            int compra;
            bool ok = false;

            f.bienvenida();
            fs.Agregarusuario(cliente);
            compra = f.totcom();
            fs.ingenvio(cliente);
            promo = f.promocion(compra);
            f.impt(ConsoleColor.Yellow, promo);
            f.impenvio(cliente);
        }
    }
}
