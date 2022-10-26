using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListVSLinkedList.Dominio
{
    internal class Numero
    {
        public int numero { get; set; }
        public List<Numero> lNumero { get; set; }
        public LinkedList<Numero> lkNumero { get; set; }


        public Numero()
        {
            numero = 0;
            lkNumero = new LinkedList<Numero>();
            lNumero = new List<Numero>();

        }

        //array, contador, tamanio array.

        public void AgregarNumero(Numero oNumero)
        {
            lNumero.Add(oNumero);
        }

        public void EliminarNumero(int indice)
        {
            lNumero.RemoveAt(indice);
        }


    }
}
