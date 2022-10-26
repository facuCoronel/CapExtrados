using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacundoCList.FacundoCList
{

    /*
    Utilizo array de objects porque segui la definicion de List 
    "Representa una lista de objetos fuertemente tipados a la que se puede obtener acceso por índice. Proporciona métodos para buscar, ordenar y manipular listas."
    https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-6.0
    
    Quizas tome muy literal a "lista de objectos" por su definicion. Pero a su vez encontre una fortaleza al usar arrays tipo object ya que, las casillas vacias 
    van a ser igual a null (en caso de un array int seria igual a 0, y dado que 0 es un numero entero, se me iba a dificultar al saber si 0 era un numero ingresado 
    o una casilla vacia dentro de la matriz)
    
    
    
    */
    internal class FacunCList
    {
        public object[] aList { get; set; }
        public object Valor { get; set; }
        int tam = 0;
        int contador = 0;

        public FacunCList()
        {
            aList = new object[tam];
        }

        /*Al metodo instanciar lo pense como un pseudoSingleton ya siempre va a dar true la primera validacion 
        (aList.Length == tam) y no lo multiplique por dos al array aAux porque no vi que sea necesario.
        */
        private object[] Instanciar()
        {
            if (aList.Length == tam)
            {
                tam = tam + 1;

                object[] aAux = new object[tam];
                
                for (int i = 0; i < aList.Length; i++)
                {
                    aAux[i] = aList[i];
                }
                aList = new object[tam];
                for (int i = 0; i < aList.Length; i++)
                {
                    aList[i] = aAux[i];
                }
                return aList;
            }
            else return aList;
        }

        // Metodo push, inserta en la ultima posicion del array
        public void Push(object valor)
        {
            if (tam == contador)
            {
                Instanciar();
                aList[contador] = valor;
            }
            else
            {
                aList[contador] = valor;
            }
            contador++;
        }
        
        // Metodo insert, inserta en el indice indicado algun valor deseado.
        public void Insert(object indice, object valor)
        {
            if (tam == aList.Length)
            {
                Instanciar();
            }
            if (indice == null)
            {
                aList[(int)indice] = valor;
            }
            else
            {
                object[] aAux = new object[tam];
                for (int j = 0; j < aAux.Length; j++)
                {
                    aAux[j] = aList[j];
                }
                for (int i = (int)indice; i < aList.Length; i++)
                {
                    if (i + 1 >= aList.Length)
                    {
                        break;
                    }
                    aList[i + 1] = aAux[i];

                }
                aList[(int)indice] = valor;
            }
        }

        //Metodo FindIndex, busca algun valor del array indicando el indice
        public void FindIndex(int index)
        {
            if (index >= 0)
            {
                int find = (int)aList[index];
                Console.WriteLine(find);


            }
            else if (index < 0)
            {
                Console.WriteLine("Debe ser un indice mayor o igual a 0");
            }


        }

        //Metodo FindElement busca el elemento indicado como parametro
        public void FindElement(object elemento)
        {
            for (int i = 0; i < aList.Length; i++)
            {
                if (aList[i] == null)
                {
                    break;
                }
                if ((int)aList[i] == (int)elemento)
                {
                    Console.WriteLine("Valor {0} posicion {1}", aList[i], i);

                }
            }
        }

        
        //Metodo RemoveAt elimina un elemento pasandole como parametro el indice, corriendo una posicion a partir de ese indice para que no
        //quede ninguna casilla continua en null
        public void RemoveAt(int index)
        {
            if(index > tam)
            {
                Console.WriteLine("el indice es mas grande que el existente");
                return;
            }
            if (index == -1)
            {
                Console.WriteLine("Debe ser un indice mayor o igual a 0");
            }
            else
            {
                aList[index] = null;
                object[] aAux = new object[tam];

                for (int i = 0; i < aList.Length; i++)
                {
                    aAux[i] = aList[i];
                }
                for (int i = index; i < aAux.Length; i++)
                {
                    if (i + 1 >= aList.Length)
                    {
                        break;
                    }
                    aAux[index] = aAux[index + 1];
                }

                for (int j = 0; j < aAux.Length; j++)
                {
                    if (j + 1 >= aList.Length)
                    {
                        break;
                    }

                    if (aAux[j] != null && aAux[j + 1] == null)
                    {
                        aAux[j] = null;
                        break;
                    }
                }


                aList = new object[tam];
                for (int i = 0; i < aAux.Length; i++)
                {
                    aList[i] = aAux[i];
                }
            }
            Console.WriteLine("Se elimino correctamente el elemento");
        }


        //Ordena de los elementos de un array
        public void Sort()
        {
            object[] aAux = new object[tam];
            object[] aOrden = new object[tam];


            for (int j = 0; j < aList.Length - 1; j++)
            {
                int min = 0;
                for (int i = 0; i < aList.Length - 1; i++)
                {
                    if (Convert.ToInt32(aList[i]) > Convert.ToInt32(aList[i + 1]) && aList[i + 1] != null)
                    {
                        min = Convert.ToInt32(aList[i + 1]);
                        aList[i + 1] = aList[i];
                        aList[i] = min;
                    }
                }
            }

            for (int k = 0; k < aList.Length; k++)
            {
                Console.WriteLine(aList[k]);
            }

        }






        // Prueba -----------------------------------------------------

        //public object[] aList { get; set; }
        //public object Valor { get; set; }
        //int tam = 0;
        //int contador = 0;

        //public FacunCList()
        //{
        //    aList = new object[tam];
        //}


        //private object[] Instanciar()
        //{



        //    if (aList.Length == tam)
        //    {
        //        tam = tam * 2;

        //        object[] aAux = new object[tam];
        //        for (int i = 0; i < aList.Length; i++)
        //        {
        //            aAux[i] = aList[i];
        //        }
        //        aList = new object[tam];
        //        for (int i = 0; i < aList.Length; i++)
        //        {
        //            aList[i] = aAux[i];
        //        }
        //        return aList;
        //    }
        //    else return aList;

        //}



        //public void Push(object valor)
        //{
        //        Instanciar();
        //        aList[tam] = valor;



        //}

        //public void Insert(object indice, object valor)
        //{
        //    if(tam == aList.Length)
        //    {
        //        Instanciar();
        //    }
        //    if (indice == null)
        //    {
        //        aList[(int)indice] = valor;
        //    }
        //    else
        //    {
        //        object[] aAux = new object[tam];
        //        for (int j = 0; j < aAux.Length; j++)
        //        {
        //            aAux[j] = aList[j];
        //        }
        //        for (int i = (int)indice; i < aList.Length; i++)
        //        {
        //            if (i + 1 >= aList.Length)
        //            {
        //                break;
        //            }
        //            aList[i + 1] = aAux[i];

        //        }
        //        aList[(int)indice] = valor;
        //    }
        //}


        //public void FindIndex(int index)
        //{
        //    if(index >= 0)
        //    {
        //        int find = (int)aList[index];
        //        Console.WriteLine(find);


        //    }else if (index < 0)
        //    {
        //        Console.WriteLine("Debe ser un indice mayor o igual a 0");
        //    }


        //}


        //public void FindElement(object elemento)
        //{
        //    for(int i = 0; i < aList.Length; i++)
        //    {
        //        if(aList[i] == null)
        //        {
        //            break;
        //        }
        //        if((int)aList[i] == (int)elemento)
        //        {
        //            Console.WriteLine("Valor {0} posicion {1}",aList[i],i);

        //        }
        //    }
        //}


        //public void RemoveAt(int index)
        //{
        //    if(index == -1)
        //    {
        //        Console.WriteLine("Debe ser un indice mayor o igual a 0");
        //    }
        //    else
        //    {
        //        aList[index] = null;
        //        object[] aAux = new object[tam];

        //        for(int i = 0; i < aList.Length; i++)
        //        {

        //            aAux[i] = aList[i];
        //        }
        //        for(int i = index; i < aAux.Length; i++)
        //        {
        //            if (i + 1 >= aList.Length)
        //            {
        //                break;
        //            }
        //            aAux[index] = aAux[index + 1];
        //        }

        //        for (int j = 0; j < aAux.Length; j++)
        //        {
        //            if (aAux[j] != null && aAux[j + 1] == null)
        //            {
        //                aAux[j] = null;
        //                break;
        //            }
        //        }


        //        aList = new object[tam];
        //        for(int i = 0; i < aAux.Length; i++)
        //        {
        //            aList[i] = aAux[i];
        //        }
        //    }
        //}



        //public void Sort()
        //{
        //    object[] aAux = new object[tam];
        //    object[] aOrden = new object[tam];


        //    for (int j = 0; j < aList.Length - 1; j++)
        //    {
        //        int min = 0;
        //        for (int i = 0; i < aList.Length - 1; i++)
        //        {
        //            if (Convert.ToInt32(aList[i]) > Convert.ToInt32(aList[i + 1]) && aList[i + 1] != null)
        //            {
        //                min = Convert.ToInt32(aList[i + 1]);
        //                aList[i + 1] = aList[i];
        //                aList[i] = min;
        //            }
        //        }
        //    }

        //    for (int k = 0; k < aList.Length; k++)
        //    {
        //        Console.WriteLine(aList[k]);
        //    }

        //}

    }
}
