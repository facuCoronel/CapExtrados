using FacundoCList.FacundoCList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacundoCList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FacunCList List = new FacunCList();

            //--------------------------------------------------------------------------List--------------------------------------------------------------------------------------





            List.Push(1);
            List.Push(-256);
            List.Push(-2147483648);
            List.Push(5);
            List.Push(2);
            List.Push(990);
            List.Push(0);
            List.Push(7);
            List.Push(6);

            Console.WriteLine("Listado del push (Verificiacion) ---------------------------------------");
            for(int i = 0; i < List.aList.Length; i++)
            {
                Console.WriteLine(List.aList[i]);
            }
            Console.WriteLine("Listado del push ---------------------------------------");
            //List.Insert(2, 8);

            List.RemoveAt(2);
            List.RemoveAt(400);

            //List.FindElement(6);
            List.Insert(5, 2900);
            
            //List.FindIndex(1);
            List.FindIndex(5);

            List.FindElement(6);

            

            List.Sort();
            ////for(int i = 0; i < List.aList.Length; i++)
            ////{
            ////    Console.WriteLine(List.aList[i]);
            //}
            //List.Push(6);
            //List.Push(7);
            //List.Push(8);
            //List.Push(9);

            //List.Insert(1, 7465);
            //List.Insert(3, 65641);
            //List.Insert(5, 5654654);
            //List.Insert(6, 233333);
            //List.Insert(0, 32454);
            //List.Insert(9, 254333);
            //List.Insert(10, 23453433);


            //List.FindIndex(5);
            //List.FindIndex(9);
            //List.FindIndex(0);

            //List.FindElement(5);
            //List.FindElement(7465);
            //List.FindElement(9);


            //List.RemoveAt(2);

            //List.Push(5);

            //List.RemoveAt(3);
            //--------------------------------------------------------------------------LinkedList--------------------------------------------------------------------------------------

            //FacunCLinkedList oNumero = new FacunCLinkedList();

            //oNumero.Agregar(1);
            //oNumero.Agregar(2);
            //oNumero.Agregar(3);
            //oNumero.Agregar(4);
            //oNumero.Agregar(5);
            //oNumero.Agregar(6);
            //oNumero.Agregar(7);
            //oNumero.Agregar(8);
            //oNumero.AgregarPorIndice(0, 5);
            //oNumero.AgregarPorIndice(15, 48);
            //oNumero.AgregarPorIndice(5, 5652);


            //oNumero.Eliminar(1);


            //for (int i = 0; i < oNumero.aNumero.Length; i++)
            //{ 
            //    if(oNumero.aNumero[i] != null)
            //    {
            //        Console.WriteLine(oNumero.aNumero[i]);
            //    }

            //}




        }
    }
}
