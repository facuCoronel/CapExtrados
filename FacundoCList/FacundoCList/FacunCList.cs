using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacundoCList.FacundoCList
{

    /*
    Utilice un array tipo Object porque investigando sobre la clase List encontre la siguiente definicion:
    Representa una lista de objetos fuertemente tipados a la que se puede obtener acceso por índice. Proporciona métodos para buscar, ordenar y manipular listas.
    https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-6.0
    
    Quizas lo tome muy literal a la definicion, pero a su vez encontre una fortaleza al utilizar array tipo object para este caso, ya que las casillas vacias van a ser
    igual a null, en contraposicion a un array tipo int que van a ser igual a 0, y dado que 0 es un numero entero y es un valor totalmente valido para insertar,
    se iba a deficultar la resolucion del problema que desde mi punto de vista era innecesario.
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

        
        /*
        Al metodo instanciar lo pense como si fuera un pseudoSingleton.
        la sentencia condicional  if (aList.Length == tam) en todos los casos va a ser verdadero y nos ahorramos el new.
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

        //Agregar a la ultima posicion
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
        
        
        //Insertar elemento indicando el indice
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

        //Buscar elemento segun el indice
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

        //Buscar elemento.
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

        //Eliminar elemento por indice
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


        //Ordenar elementos.
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
