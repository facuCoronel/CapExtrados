using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////forma 0 ---------------------------------------------------------------------------------------------------------

            ////Carga en memoria
            //int[] NroEmpleado = { 100, 101, 102, 103, 104 };
            //string[] Nombre = { "Juan Perez", "Pedro Bianchi", "Facundo Lobo", "Jose Ciscar", "Pepe Calderon" };
            //string[] FechaNac = { "11/11/96", "01/04/95", "06/07/89", "15/11/98", "18/03/92" };
            //string[] EmpleadosACargo = new string[5];
            //string[] SucursalesACargo = new string[5];

            //EmpleadosACargo[3] = "2 Emp a cargo";
            //EmpleadosACargo[1] = "1 Emp a cargo";
            //SucursalesACargo[4] = "2 Suc. a cargo";


            ////Auxiliares
            //int Opcion;
            //int AuxAscenso;

            ////Desarrollo
            //Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            //Opcion = Convert.ToInt32(Console.ReadLine());



            //do
            //{
            //    if (Opcion == 1)
            //    {
            //        //Console.WriteLine("Nro de empleado  |  Nombre  |  Fecha Nacimiento  |  Empleado a Cargo (si es que tiene)  |  Sucursales a Cargo (si es que tiene");
            //        Console.WriteLine("Nro | Nombre | Cant Emp | Cant Suc");

            //        for (int i = 0; i < NroEmpleado.Length; i++)
            //        {
            //            if (EmpleadosACargo[i] == " ")
            //            {
            //                EmpleadosACargo[i] = "  ";
            //            }
            //            Console.WriteLine(Convert.ToString(NroEmpleado[i]) + "  " + Nombre[i] + "  " + FechaNac[i] + "  " + EmpleadosACargo[i] + "  " + SucursalesACargo[i]);
            //        }
            //    }
            //    else if (Opcion == 2)
            //    {
            //        Console.WriteLine("A que puesto desea ascender? 1- Supervisor // 2- Encargado regional");
            //        AuxAscenso = Convert.ToInt32(Console.ReadLine());

            //            if (AuxAscenso == 1)
            //            {
            //                Console.WriteLine("Estos son los empleados que puede ascender");
            //                for (int i = 0; i < EmpleadosACargo.Length; i++)
            //                {

            //                    if (EmpleadosACargo[i] == null )
            //                    {
            //                        if(SucursalesACargo[i] == null)
            //                        {
            //                            Console.WriteLine(Convert.ToString(NroEmpleado[i]) + "  " + Nombre[i] + "  " + FechaNac[i] + "  " + EmpleadosACargo[i] + "  " + SucursalesACargo[i]);
            //                        }
            //                    }
            //                }

            //                Console.WriteLine("Ingrese el numero de empleado que desea ascender");
            //                int Ascenso = Convert.ToInt32(Console.ReadLine());
            //                for (int k = 0; k < NroEmpleado.Length; k++)
            //                {
            //                    if (NroEmpleado[k] == Ascenso)
            //                    {
            //                        Console.WriteLine("Indicar la cantidad de empleados a cargo");
            //                        EmpleadosACargo[k] = Console.ReadLine() + "  Emp a cargo";
            //                        Console.WriteLine("Se actualizo con exito!!!!");
            //                        Console.WriteLine("Lista actualizada");
            //                    }
            //                }

            //            }
            //            else if (AuxAscenso == 2) { Console.WriteLine("Por el momento no se puede ascender al cargo: Encargado Regional"); }
            //            //Console.WriteLine("Debe seleccionar una opcion que sea valido.");
            //            //Console.WriteLine("A que puesto desea ascender? 1- Supervisor // 2- Encargado regional");
            //            //AuxAscenso = Convert.ToInt32(Console.ReadLine());
            //    }



            //    //switch (Opcion)
            //    //{
            //    //    case 1:
            //    //        Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            //    //        Opcion = Convert.ToInt32(Console.ReadLine()); break;
            //    //    case 2:
            //    //        Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            //    //        Opcion = Convert.ToInt32(Console.ReadLine()); break;
            //    //    case 3:
            //    //        Console.WriteLine("Debe elegir una opcion valida");
            //    //        Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            //    //        Opcion = Convert.ToInt32(Console.ReadLine()); break;
            //    //        default: Console.WriteLine("Debe elegir otra opcion"); Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            //    //        Opcion = Convert.ToInt32(Console.ReadLine()); break;
            //    //}
            //    if (Opcion == 3)
            //    {
            //        Console.WriteLine("Esta seguro que desea salir? ");
            //        Console.WriteLine("Presione 3 de vuelta para salir o escriba: 1- Listar a todo el personal, 2-Ascender a una persona");
            //        Opcion = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (Opcion != 1 || Opcion != 2)
            //    {


            //        //Console.WriteLine("Debe elegir una opcion valida");
            //        Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            ////        Opcion = Convert.ToInt32(Console.ReadLine());
            //if (Opcion == 3)
            //{
            //    Console.WriteLine("Esta seguro que desea salir? ");
            //    Console.WriteLine("Presione 3 de vuelta para salir o escriba: 1- Listar a todo el personal, 2-Ascender a una persona");
            //    Opcion = Convert.ToInt32(Console.ReadLine());
            //}
            //    }

            //} while (Opcion == 1 || Opcion == 2 || Opcion > 3);








            //forma .5 ---------------------------------------------------------------------------------------------------------


            //Arrays
            string[] EmpleadosACargo = new string[5];
            string[] Sucursalesacargo = new string[5];


            string[,] Personas = new string[,] {{"100", "Juan Perez" ,"11/11/96"},
                                                {"101","Pedro Bianchi", "01/04/95" },
                                                {"102",  "Facundo Lobo", "06/07/89" },
                                                {"103", "Jose Ciscar", "15/11/98" },
                                                {"104","Pepe Calderon",  "18/03/92"} };


            EmpleadosACargo[3] = "2 Emp a cargo";
            EmpleadosACargo[1] = "1 Emp a cargo";
            Sucursalesacargo[4] = "2 Suc. a cargo";



            // Auxiliares;

            int Opcion = 0;
            int AuxAscenso = 0;
            bool AuxBool;

            //Metodos
            void Listar()
            {
                // Itera en i para listar los empleados.
                for (int i = 0; i < Personas.GetLength(0); i++)
                {
                    //Por cada posicion en i.
                    Console.WriteLine(Personas[i, 0] + "  " + Personas[i, 1] + "  " + Personas[i, 2] + "  " + EmpleadosACargo[i] + "  " + Sucursalesacargo[i]);

                }
            }

            void ListarSoloEmpleados()
            {
                // Iteracion en i para matriz "Principal"
                for (int i = 0; i < Personas.GetLength(0); i++)
                {
                    //Validaciones para empleados, si EmpleadosACargo y Sucursalescargo es == null, quiere decir que el es un empleado sin jerarquia.
                    if (EmpleadosACargo[i] == null && Sucursalesacargo[i] == null)
                    {
                        Console.WriteLine(Personas[i, 0] + "  " + Personas[i, 1] + "  " + Personas[i, 2] + "  " + EmpleadosACargo[i] + "  " + Sucursalesacargo[i]);
                    }

                }
            }

            void AscenderEmpleado(int Asc, bool validacion)
            {
                if (validacion == true)
                {
                    //itera en k para la matriz "principal"
                    for (int k = 0; k < Personas.GetLength(0); k++)
                    {
                        if (Convert.ToInt32(Personas[k, 0]) == Asc && EmpleadosACargo[k] == null && Sucursalesacargo[k] == null)
                        {
                            Console.WriteLine("Indicar la cantidad de empleados a cargo");
                            EmpleadosACargo[k] = Console.ReadLine() + "  Emp a cargo";
                            Console.WriteLine("Se actualizo con exito!!!!");
                            break;
                        }

                    }
                    // si es falso, es porque el empleado ya tiene un cargo jerarquico y no se puede ascender
                }
                else if (validacion == false)
                {
                    Console.WriteLine("El id del empleado ya tiene un cargo jerarquico o no existe");
                }



            }

            //Validacion de existencia de empleado por nro ID
            bool ExisteEmpleado(int Asc)
            {
                for (int k = 0; k < Personas.GetLength(0); k++)
                {
                    if (Convert.ToInt32(Personas[k, 0]) == Asc)
                    {
                        return true;

                    }
                }
                return false;
            }


            //Menu de opciones para salir.
            int ElegirOpcion()
            {
                if (Opcion == 3)
                {
                    Console.WriteLine("Esta seguro que desea salir? ");
                    Console.WriteLine("Presione 3 de vuelta para salir o escriba: 1- Listar a todo el personal, 2-Ascender a una persona");
                    Opcion = Convert.ToInt32(Console.ReadLine());
                }
                else if (Opcion != 1 || Opcion != 2)
                {
                    Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
                    Opcion = Convert.ToInt32(Console.ReadLine());
                    if (Opcion == 3)
                    {
                        Console.WriteLine("Esta seguro que desea salir? ");
                        Console.WriteLine("Presione 3 de vuelta para salir o escriba: 1- Listar a todo el personal, 2-Ascender a una persona");
                        Opcion = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return Opcion;
            }


            // Desarrollo --------------------------------------------------------------------------------------------------------------------------


            //El usuario ingresa opcion
            Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            Opcion = Convert.ToInt32(Console.ReadLine());

            //inicio del bucle do while.
            do
            {
                //Evaluador de la expresion opcion.
                if (Opcion == 1)
                {
                    //Invoco metodo listar
                    Listar();
                }
                else if (Opcion == 2)
                {
                    //Solicito al usuario que ingrese a que puesto desearia ascender.
                    Console.WriteLine("A que puesto desea ascender? 1- Supervisor // 2- Encargado regional");
                    AuxAscenso = Convert.ToInt32(Console.ReadLine());

                    //Evaluador de expresion AuxAscenso.
                    if (AuxAscenso == 1)
                    {
                        Console.WriteLine("Estos son los empleados que puede ascender");

                        //Lista los empleados que pueden ascender a Supervisor.
                        //Invoco metodo ListarSoloEmpleados.
                        ListarSoloEmpleados();

                        //Solicita a usuario el numero de id.
                        Console.WriteLine("Ingrese el numero de id del empleado");
                        int Ascenso = Convert.ToInt32(Console.ReadLine());

                        //Invoco AscenderEmpleado con parametros, ascenso (nro ID, y validacion con ExisteEmpleado.    
                        AscenderEmpleado(Ascenso, ExisteEmpleado(Ascenso));
                    }
                    else if (AuxAscenso == 2) { Console.WriteLine("Por el momento no se puede ascender al cargo: Encargado Regional"); }
                }

                //Invoco metodo ElegirOpcion.
                ElegirOpcion();

            } while (Opcion == 1 || Opcion == 2 || Opcion > 3);




            ////forma .51 ---------------------------------------------------------------------------------------------------------


            ////Arrays
            //string[] EmpleadosACargo = new string[5];
            //string[] Sucursalesacargo = new string[5];


            //string[,] Personas = new string[,] {{"100", "Juan Perez" ,"11/11/96"},
            //                                    {"101","Pedro Bianchi", "01/04/95" },
            //                                    {"102",  "Facundo Lobo", "06/07/89" },
            //                                    {"103", "Jose Ciscar", "15/11/98" },
            //                                    {"104","Pepe Calderon",  "18/03/92"} };


            //EmpleadosACargo[3] = "2 Emp a cargo";
            //EmpleadosACargo[1] = "1 Emp a cargo";
            //Sucursalesacargo[4] = "2 Suc. a cargo";



            //// Auxiliares;

            //int Opcion = 0;
            //int AuxAscenso = 0;
            //bool AuxBool;

            ////Metodos
            //void Listar()
            //{
            //    // Itera en i para listar los empleados.
            //    for (int i = 0; i < Personas.GetLength(0); i++)
            //    {
            //        //Por cada posicion en i, es decir por cada fila, se listara segun la 
            //        Console.WriteLine(Personas[i, 0] + "  " + Personas[i, 1] + "  " + Personas[i, 2] + "  " + EmpleadosACargo[i] + "  " + Sucursalesacargo[i]);

            //    }
            //}

            //void ListarSoloEmpleados()
            //{
            //    // Iteracion en i para matriz "Principal"
            //    for (int i = 0; i < Personas.GetLength(0); i++)
            //    {
            //        //Validaciones para empleados, si EmpleadosACargo y Sucursalescargo es == null, quiere decir que el es un empleado sin jerarquia.
            //        if (Sucursalesacargo[i] == null)
            //        {
            //            Console.WriteLine(Personas[i, 0] + "  " + Personas[i, 1] + "  " + Personas[i, 2] + "  " + EmpleadosACargo[i] + "  " + Sucursalesacargo[i]);
            //        }

            //    }
            //}

            //void AscenderEmpleado(int Asc, bool validacion)
            //{
            //    bool VBool = false;
            //    if (validacion == true)
            //    {
            //        //itera en k para la matriz "principal"
            //        for (int k = 0; k < Personas.GetLength(0); k++)
            //        {
            //            if (Convert.ToInt32(Personas[k, 0]) == Asc && Sucursalesacargo[k] == null)
            //            {
            //                Console.WriteLine("Indicar la cantidad de empleados a cargo");
            //                EmpleadosACargo[k] = Console.ReadLine() + "  Emp a cargo";
            //                Console.WriteLine("Se actualizo con exito!!!!");
            //                break;
            //            }

            //        }
            //        // si es falso, es porque el empleado ya tiene un cargo jerarquico y no se puede ascender
            //    }
            //    else if (validacion == false)
            //    {
            //        Console.WriteLine("El id del empleado ya tiene un cargo jerarquico o no existe");
            //    }



            //}

            ////Validacion de existencia de empleado por nro ID
            //bool ExisteEmpleado(int Asc)
            //{
            //    for (int k = 0; k < Personas.GetLength(0); k++)
            //    {
            //        if (Convert.ToInt32(Personas[k, 0]) == Asc)
            //        {
            //            return true;

            //        }
            //    }
            //    return false;
            //}


            ////Menu de opciones para salir.
            //int ElegirOpcion()
            //{
            //    if (Opcion == 3)
            //    {
            //        Console.WriteLine("Esta seguro que desea salir? ");
            //        Console.WriteLine("Presione 3 de vuelta para salir o escriba: 1- Listar a todo el personal, 2-Ascender a una persona");
            //        Opcion = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (Opcion != 1 || Opcion != 2)
            //    {
            //        Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            //        Opcion = Convert.ToInt32(Console.ReadLine());
            //        if (Opcion == 3)
            //        {
            //            Console.WriteLine("Esta seguro que desea salir? ");
            //            Console.WriteLine("Presione 3 de vuelta para salir o escriba: 1- Listar a todo el personal, 2-Ascender a una persona");
            //            Opcion = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    return Opcion;
            //}


            //// Desarrollo --------------------------------------------------------------------------------------------------------------------------


            ////El usuario ingresa opcion
            //Console.WriteLine("Escribe una opcion: 1- Listar a todo el personal, 2-Ascender a una persona, 3- Salir del programa");
            //Opcion = Convert.ToInt32(Console.ReadLine());

            ////inicio del bucle do while.
            //do
            //{
            //    //Evaluador de la expresion opcion.
            //    if (Opcion == 1)
            //    {
            //        //Invoco metodo listar
            //        Listar();
            //    }
            //    else if (Opcion == 2)
            //    {
            //        //Solicito al usuario que ingrese a que puesto desearia ascender.
            //        Console.WriteLine("A que puesto desea ascender? 1- Supervisor // 2- Encargado regional");
            //        AuxAscenso = Convert.ToInt32(Console.ReadLine());

            //        //Evaluador de expresion AuxAscenso.
            //        if (AuxAscenso == 1)
            //        {
            //            Console.WriteLine("Estos son los empleados que puede ascender");

            //            //Lista los empleados que pueden ascender a Supervisor.
            //            //Invooco metodo ListarSoloEmpleados.
            //            ListarSoloEmpleados();

            //            //Solicita a usuario el numero de id
            //            Console.WriteLine("Ingrese el numero de id del empleado");
            //            int Ascenso = Convert.ToInt32(Console.ReadLine());

            //            //Invoco AscenderEmpleado con parametros, ascenso (nro ID, y validacion con ExisteEmpleado.    
            //            AscenderEmpleado(Ascenso, ExisteEmpleado(Ascenso));
            //        }
            //        else if (AuxAscenso == 2) { Console.WriteLine("Por el momento no se puede ascender al cargo: Encargado Regional"); }
            //    }

            //    //Invoco metodo ElegirOpcion.
            //    ElegirOpcion();

            //} while (Opcion == 1 || Opcion == 2 || Opcion > 3);




            //////forma 1-------------------------------------------------------------------------------------------------------- -
            ////Variables----------------------
            //int TipoPersonal;
            //int NroEmpleado = 100;
            //string Nombre = string.Empty;
            ////string NomEmpleado = string.Empty;
            ////string NomEncargado = string.Empty;
            ////string NomSupervisor = string.Empty;
            //string FechaNac = string.Empty;
            //int PersonalACargo = 0;
            //int SucursalesACargo = 0;
            //string tipo = string.Empty;

            ////Arrays-----------------------------

            //int[] ANroEmpleado = new int[100];
            //string[] ANombreEmpleado = new string[100];
            //string[] ANombreSupervisor = new string[100];
            //string[] ANombreEncargado = new string[100];
            //string[] AFechaNac = new string[100];
            //int[] APersonalACargo = new int[100];
            //int[] ASucursalACargo = new int[100];
            //string[,] Atotal = new string[5, 4];

            ////string[,,,] Resultado = new string[,,,];

            //ArrayList ALTotal = new ArrayList();
            //List<string> lTotal = new List<string>();

            ////Auxiliares-------------------------
            //int aux = 0;
            //int Iterar = 0;
            //string AuxiliarPersonalSucursal = string.Empty;
            //string SNroEmp;

            ////Metodos-------------------------------------

            //string[,] AagregarElemento = new string[5, 4];
            //string[,] agregarElemento(string numero, string nombre, string fechaNacimiento, string aCargo)
            //{

            //    if (AagregarElemento == null)
            //    {
            //        AagregarElemento[0,0] = numero;
            //        AagregarElemento[0,1] = nombre;
            //        AagregarElemento[0,2] = fechaNacimiento;
            //        AagregarElemento[0,3] = aCargo; 
            //    }




            //    return AagregarElemento;
            //}


            //do
            //{
            //    Console.WriteLine("Que personal desea cargar?");
            //    Console.WriteLine("1- Empleado, 2- Supervisor, 3- Encargado Regional");

            //    TipoPersonal = Convert.ToInt32(Console.ReadLine());




            //    if (TipoPersonal == 1)
            //    {

            //        Console.WriteLine("Elegiste Empleado");
            //        Console.WriteLine("Escribe el nombre del empleado");
            //        //NomEmpleado = Console.ReadLine();
            //        Nombre = Console.ReadLine();
            //        Console.WriteLine("Escribe su fecha de nacimiento");
            //        FechaNac = Console.ReadLine();


            //        tipo = "Empleado";

            //        SNroEmp = Convert.ToString(NroEmpleado);
            //        agregarElemento(SNroEmp, Nombre, FechaNac, tipo);
            //        Console.WriteLine(AagregarElemento[0, 0] + AagregarElemento[0, 1] + AagregarElemento[0, 2] + AagregarElemento[0, 3]);

            //    }
            //    else if (TipoPersonal == 2)
            //    {
            //        Console.WriteLine("Elegiste Supervisor");
            //        Console.WriteLine("Escribe el nombre del Supervisor");
            //        Nombre = Console.ReadLine();

            //        Console.WriteLine("Escribe su fecha de nacimiento");
            //        FechaNac = Console.ReadLine();

            //        Console.WriteLine("Escribe la cantidad de personal que tiene a cargo");
            //        PersonalACargo = Convert.ToInt32(Console.ReadLine());
            //        tipo = "Supervisor";
            //    }
            //    else if (TipoPersonal == 3)
            //    {
            //        Console.WriteLine("Elegiste Encargado");
            //        Console.WriteLine("Escribe el nombre del Encargado");
            //        Nombre = Console.ReadLine();

            //        Console.WriteLine("Escribe su fecha de Encargado");
            //        FechaNac = Console.ReadLine();

            //        Console.WriteLine("Escribe la cantidad de sucursales que tiene a cargo");
            //        SucursalesACargo = Convert.ToInt32(Console.ReadLine());
            //        tipo = "Encargado Reg";
            //    }

            //    //Contador para id empleado.
            //    NroEmpleado += 1;

            //    if (PersonalACargo >= 1)
            //    {
            //        AuxiliarPersonalSucursal = Convert.ToString(PersonalACargo) + "Supervisor";
            //    }
            //    else if (SucursalesACargo >= 1)
            //    {
            //        AuxiliarPersonalSucursal = Convert.ToString(PersonalACargo) + "Encargado";
            //    }
            //    else AuxiliarPersonalSucursal = "Empleado";






            //    Console.WriteLine("Desea salir? 0- Si / 1-No");
            //    aux = Convert.ToInt32(Console.ReadLine());



            //} while (aux == 1);



        }
    }
}
