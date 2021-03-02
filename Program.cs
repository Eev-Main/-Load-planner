using System;

namespace Proyecto_Load_planner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Objeto B = new Objeto(70f, "Barril ");
            Objeto BC = new Objeto(20f, "Bolsa de Chatarra ");
            Objeto BP = new Objeto(3f, "Bolsa con plantas ");
            Objeto C1 = new Objeto(5f, "Caja ligera ");
            Objeto C2 = new Objeto(15f, "Caja pesada ");
            Objeto C3 = new Objeto(0.2f, "Caja vacía ");
            Objeto S = new Objeto(4f, "Silla ");
            //esquinas que no se pueden usar y las denominamos como vacio
            Objeto vacio = new Objeto(0f, "espacio vacio");

            //creacion del inventario como array
            //Valores a modificar 
            Objeto[,] inventario = new Objeto[3,4]{{BC, BC, C3, vacio}, {C1, B, BP, S}, {C2, B, BP, S}};
            //{vacio, BC, C3, vacio}
            //{C1, B, BP, S}
            //{C2, B, BP, S}
            int CoordenadaX = inventario.GetLength(0);
            int CoordenadaY = inventario.GetLength(1);

            // proseso para el output del inventario
            for (int i = 0; i < CoordenadaX; i++)
            {
                 for (int j = 0; j < CoordenadaY; j++)
                 {
                     Console.Write(string.Format("{0} ", inventario[i, j].peso));
                 }
            Console.Write(Environment.NewLine + Environment.NewLine);
            }
       
        // Detectar objetos pesados
            if (inventario[0,0].peso == 0 && inventario[0,3].peso == 0)
            {
            if (inventario[1,0].peso > inventario[2,0].peso)
            {
                Console.WriteLine(inventario[2,0].nombre + "Esta aplastado/a");
            } 
            else if (inventario[0,1].peso > inventario[1,1].peso)
            {
                Console.WriteLine(inventario[1,1].nombre + "Esta aplastado/a");
            }
            else if (inventario[1,1].peso > inventario[2,1].peso)
            {
                Console.WriteLine(inventario[2,1].nombre + "Esta aplastado/a");
            }
            else if (inventario[0,2].peso > inventario[1,2].peso)
            {
                Console.WriteLine(inventario[1,2].nombre + "Esta aplastado/a");
            }
            else if (inventario[1,2].peso > inventario[2,2].peso)
            {
                Console.WriteLine(inventario[2,2].nombre + "Esta aplastado/a");
            }
            else if (inventario[0,3].peso > inventario[1,3].peso)
            {
                Console.WriteLine(inventario[1,3].nombre + "Esta aplastado/a");
            }
            else if (inventario[1,3].peso > inventario[2,3].peso)
            {
                Console.WriteLine(inventario[2,3].nombre + "Esta aplastado/a");
            }
            else
            {
                 Console.WriteLine("Todo esta en orden");
            }
            }
            else
            {
                Console.WriteLine("Hay un objeto en una o mas esquinas superiores");
            }
    }
}
}