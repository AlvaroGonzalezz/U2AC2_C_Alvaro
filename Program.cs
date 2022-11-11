using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace U2AC2_C_Alvaro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Administracion de Perfil

            // Declaramos variables como su nombre, apellido paterno, apellido materno, edad, fecha de nacimiento, usuario y contraseña

            string nombre, apPaterno, apMateno, edad, usuarioNombre, contraseña, confirmarContraseña;


            // Solicitamos datos al usuario

            Console.WriteLine("INICIO DE SESION \n");
            Console.WriteLine("Escriba su nombre (s): ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su apellido paterno:");
            apPaterno = Console.ReadLine();
            Console.WriteLine("Escriba su apellido materno: ");
            apMateno = Console.ReadLine();
            Console.WriteLine("Escribe tu edad: ");
            edad = Console.ReadLine();
            Console.WriteLine("Escriba su Usuario: ");
            usuarioNombre = Console.ReadLine();
            Console.WriteLine("Escriba su contraseña: ");
            contraseña = Console.ReadLine();
            Console.WriteLine("Vuelve a escribir tu contraseña: ");
            confirmarContraseña = Console.ReadLine();

            // usamos if para determinar si las contraseñas son iguales
            if (contraseña == confirmarContraseña)
            {
                // limpiamos la consola
                Console.Clear();
                // mostramos la informacion del perfil
                Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                Console.WriteLine("Tu información de tu perfil: \n");
                Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                Console.WriteLine("Edad: {0}", edad);
                Console.WriteLine("Usuario: {0}", usuarioNombre);
                Console.WriteLine("Contraseña: {0}", contraseña);


                // le damos opcion de personalizar la consola
                Console.WriteLine("\n \t \t MENU DE PERSONALIZACIÓN DE CONSOLA\n");
                Console.WriteLine("\n¿Deseas personalizar la consola? (si/no)");
                string decisionUsuario = Console.ReadLine();

                // usamos if para saber la desicion del usuario
                if (decisionUsuario == "si")
                {
                    Console.Clear();
                    // mostramos la informacion del perfil
                    Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                    Console.WriteLine("Tu información de tu perfil: \n");
                    Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                    Console.WriteLine("Edad: {0}", edad);
                    Console.WriteLine("Usuario: {0}", usuarioNombre);
                    Console.WriteLine("Contraseña: {0}", contraseña);
                    Console.WriteLine("\n \t \t MENU DE PERSONALIZACIÓN DE CONSOLA\n");
                    Console.WriteLine("¿Que deseas personalizar?, las opciones son: color, tamaño o titulo.");
                    string cambiarConsola = Console.ReadLine();

                    // usamos if para saber que desea cambiar el usuario
                    if (cambiarConsola == "color")
                    {
                        Console.Clear();
                        Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                        Console.WriteLine("Tu información de tu perfil: \n");
                        Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                        Console.WriteLine("Edad: {0}", edad);
                        Console.WriteLine("Usuario: {0}", usuarioNombre);
                        Console.WriteLine("Contraseña: {0}", contraseña);
                        // le preguntamos en que desea cambiar el color
                        Console.WriteLine("\n \t \t MENU DE PERSONALIZACIÓN DE CONSOLA\n");
                        Console.WriteLine("\n¿En que deseas cambiar el color?, las opciones son: fondo o letra");
                        string opColor = Console.ReadLine();
                        // usamos if para saber su desicion
                        if (opColor == "fondo")
                        {
                            Console.Clear();
                            Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                            Console.WriteLine("Tu información de tu perfil: \n");
                            Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                            Console.WriteLine("Edad: {0}", edad);
                            Console.WriteLine("Usuario: {0}", usuarioNombre);
                            Console.WriteLine("Contraseña: {0}", contraseña);
                            // le preguntamos al usuario de que color desea realizar los cambios
                            Console.WriteLine("\n \t \t MENÚ DE PERSONALIZACIÓN DE CONSOLA\n");
                            Console.WriteLine("\nEscribe a que color deseas cambiar el fondo de la consola (las opciones son: rojo, azul, verde)");
                            string tipoColor = Console.ReadLine();

                            // usamos if y else if para cada color
                            if (tipoColor == "rojo")
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("\tCONSOLA DE ADMINISTRACIÓN \n");
                                Console.WriteLine("Tu información de tu perfil: \n");
                                Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                                Console.WriteLine("Edad: {0}", edad);
                                Console.WriteLine("Usuario: {0}", usuarioNombre);
                                Console.WriteLine("Contraseña: {0}", contraseña);

                                Console.WriteLine("\nListo, los cambios se han realizado con exito.");

                            }
                            else if (tipoColor == "azul")
                            {

                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("\tCONSOLA DE ADMINISTRACIÓN \n");
                                Console.WriteLine("Tu información de tu perfil: \n");
                                Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                                Console.WriteLine("Edad: {0}", edad);
                                Console.WriteLine("Usuario: {0}", usuarioNombre);
                                Console.WriteLine("Contraseña: {0}", contraseña);
                                Console.WriteLine("\nListo, los cambios se han realizado con exito.");
                            }
                            else if (tipoColor == "verde")
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                Console.WriteLine("\tCONSOLA DE ADMINISTRACIÓN \n");
                                Console.WriteLine("Tu información de tu perfil: \n");
                                Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                                Console.WriteLine("Edad: {0}", edad);
                                Console.WriteLine("Usuario: {0}", usuarioNombre);
                                Console.WriteLine("Contraseña: {0}", contraseña);
                                Console.WriteLine("\nListo, los cambios se han realizado con exito.");
                            }
                            else // mostramos else para indicarle al usuario que tecleo erroneamente
                            {
                                Console.WriteLine("Tecleaste erroneamente la opción, vuelve a intentarlo");
                                Thread.Sleep(2000);
                                Console.WriteLine("Saliendo....");
                                Thread.Sleep(2000);
                                Console.WriteLine("Saliendo....");
                                Thread.Sleep(2000);
                                Console.WriteLine("Saliendo....");
                                return;
                            }
                        }
                        // usamos else if por si no cumple if 
                        else if (opColor == "letra")
                        {
                            Console.Clear();
                            Console.WriteLine("\tCONSOLA DE ADMINISTRACIÓN \n");
                            Console.WriteLine("Tu información de tu perfil: \n");
                            Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                            Console.WriteLine("Edad: {0}", edad);
                            Console.WriteLine("Usuario: {0}", usuarioNombre);
                            Console.WriteLine("Contraseña: {0}", contraseña);
                            // le pedimos a que color desea cambiar
                            Console.WriteLine("\n \t \t MENÚ DE PERSONALIZACIÓN DE CONSOLA\n");
                            Console.WriteLine("\nEscribe a que color deseas cambiar la fuente de la consola (las opciones son: rojo, negro, blanco): ");
                            string tipoColor = Console.ReadLine();

                            //usamos if y else if para cada color
                            if (tipoColor == "rojo")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                                Console.WriteLine("Tu información de tu perfil: \n");
                                Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                                Console.WriteLine("Edad: {0}", edad);
                                Console.WriteLine("Usuario: {0}", usuarioNombre);
                                Console.WriteLine("Contraseña: {0}", contraseña);
                                Console.WriteLine("\nListo, los cambios se han realizado con exito.");

                            }
                            else if (tipoColor == "negro")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();
                                Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                                Console.WriteLine("Tu información de tu perfil: \n");
                                Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                                Console.WriteLine("Edad: {0}", edad);
                                Console.WriteLine("Usuario: {0}", usuarioNombre);
                                Console.WriteLine("Contraseña: {0}", contraseña);
                                Console.WriteLine("\nListo, los cambios se han realizado con exito.");
                            }
                            else if (tipoColor == "blanco")
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                                Console.WriteLine("Tu información de tu perfil: \n");
                                Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                                Console.WriteLine("Edad: {0}", edad);
                                Console.WriteLine("Usuario: {0}", usuarioNombre);
                                Console.WriteLine("Contraseña: {0}", contraseña);
                                Console.WriteLine("\nListo, los cambios se han realizado con exito.");
                            }


                        }
                    }
                    // else if si la decision fue cambiar el tamaño de la consola
                    else if (cambiarConsola == "tamaño")
                    {
                        Console.Clear();
                        Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                        Console.WriteLine("Tu información de tu perfil: \n");
                        Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                        Console.WriteLine("Edad: {0}", edad);
                        Console.WriteLine("Usuario: {0}", usuarioNombre);
                        Console.WriteLine("Contraseña: {0}", contraseña);
                        // le preguntamos que tamaño desea modificar
                        Console.WriteLine("\n \t \t MENÚ DE PERSONALIZACIÓN DE CONSOLA\n");
                        Console.WriteLine("\n¿Deseas modificar la anchura o la altura?");
                        string tamano = Console.ReadLine();
                        // usamos if si la respuesta fue cambiar la anchura
                        if (tamano == "anchura")
                        {
                            Console.Clear();
                            Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                            Console.WriteLine("Tu información de tu perfil: \n");
                            Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                            Console.WriteLine("Edad: {0}", edad);
                            Console.WriteLine("Usuario: {0}", usuarioNombre);
                            Console.WriteLine("Contraseña: {0}", contraseña);
                            Console.WriteLine("\n \t \t MENÚ DE PERSONALIZACIÓN DE CONSOLA\n");
                            Console.WriteLine("\nTeclea el valor que le quieres dar a la anchura (0-210)");
                            int anchura = Convert.ToInt32(Console.ReadLine()); // lo convertimos a int porque string no se puede poner en windowwidth
                            Console.WindowWidth = anchura;
                            Console.Clear();
                            Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                            Console.WriteLine("Tu información de tu perfil: \n");
                            Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                            Console.WriteLine("Edad: {0}", edad);
                            Console.WriteLine("Usuario: {0}", usuarioNombre);
                            Console.WriteLine("Contraseña: {0}", contraseña);
                            Console.WriteLine("\nListo, los cambios se han realizado con exito");
                        }
                        // else if si la respuesta fue altura
                        else if (tamano == "altura")
                        {
                            Console.Clear();
                            Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                            Console.WriteLine("Tu información de tu perfil: \n");
                            Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                            Console.WriteLine("Edad: {0}", edad);
                            Console.WriteLine("Usuario: {0}", usuarioNombre);
                            Console.WriteLine("Contraseña: {0}", contraseña);
                            Console.WriteLine("\n \t \t MENÚ DE PERSONALIZACIÓN DE CONSOLA\n");
                            Console.WriteLine("\nTeclea el valor que le quieres dar a la altura (0-61)");
                            int altura = Convert.ToInt32(Console.ReadLine());
                            Console.WindowHeight = altura;
                            Console.Clear();
                            Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                            Console.WriteLine("Tu información de tu perfil: \n");
                            Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                            Console.WriteLine("Edad: {0}", edad);
                            Console.WriteLine("Usuario: {0}", usuarioNombre);
                            Console.WriteLine("Contraseña: {0}", contraseña);
                            Console.WriteLine("\nListo, los cambios se han realizado con exito");
                        }
                    }

                    else if (cambiarConsola == "titulo")
                    {
                        Console.Clear();
                        Console.WriteLine("\t CONSOLA DE ADMINISTRACIÓN \n");
                        Console.WriteLine("Tu información de tu perfil: \n");
                        Console.WriteLine("Nombre: {0} {1} {2}.", nombre, apPaterno, apMateno);
                        Console.WriteLine("Edad: {0}", edad);
                        Console.WriteLine("Usuario: {0}", usuarioNombre);
                        Console.WriteLine("Contraseña: {0}", contraseña);
                        Console.WriteLine("\n \t \t MENÚ DE PERSONALIZACIÓN DE CONSOLA\n");
                        Console.WriteLine("\nTeclea el nombre que le deseas asignar al título de la consola: ");
                        string titulo = Console.ReadLine();
                        Console.Title = titulo;
                        Console.WriteLine("\nLos cambios se han realizado con exito.");

                    }


                    // else para decirle al usuario que tecleo mal
                    else
                    {

                        Console.WriteLine("Tecleaste erroneamente la opción, vuelve a intentarlo");
                        Thread.Sleep(2000);
                        Console.WriteLine("Saliendo....");
                        Thread.Sleep(2000);
                        Console.WriteLine("Saliendo....");
                        Thread.Sleep(2000);
                        Console.WriteLine("Saliendo....");
                        return;
                    }


                }
                // else para decirle al usuario que tecleo mal

                else
                {
                    Console.WriteLine("Tecleaste erroneamente la opción, vuelve a intentarlo");
                    Thread.Sleep(2000);
                    Console.WriteLine("Saliendo....");
                    Thread.Sleep(2000);
                    Console.WriteLine("Saliendo....");
                    Thread.Sleep(2000);
                    Console.WriteLine("Saliendo....");
                    return;
                }

            }

            else
            {
                Console.WriteLine("Las contraseñas no coinciden, vuelve a intentarlo");
                Thread.Sleep(2000);
                Console.WriteLine("Saliendo....");
                Thread.Sleep(2000);
                Console.WriteLine("Saliendo....");
                Thread.Sleep(2000);
                Console.WriteLine("Saliendo....");
                return;
            }
            Console.ReadKey();
        }
    }
}
