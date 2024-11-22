/*El ejercicio consiste en simular la función de un cajero automático en
donde el cliente debe autenticarse ante el sistema para que le permita
realizar cualquier tipo de operación.
Las operaciones disponibles en el cajero corresponden a:
Consulta de saldo,retiros, solo si el saldo es mayor a la cantidad solicitada y si no supera
el tope diario de retiros establecidos por el banco. Es decir que no
podrá retirar más de dos millones de pesos diarios.
Transferencias entre cuentas del mismo banco, para ello debe validar si
existe la cuenta destino.
Consulta de puntos ViveColombia
Canje de puntos ViveColombia
Se debe diseñar bajo el paradigma de la Programación Orientada a
Objetos utilizando métodos, herencia y excepciones en un lenguaje de
Programación Orientada a Objetos.

Autor: Maicol David Siachoque Cubides


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paso5_MaicolSiachoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario User = new Usuario(); // 2 clases Herencia
            Options Option = new Options(); 
            int ID, Password, ValueOne = -1, ValueTwo = -1; //Variables

            do //ciclo
            {
                try 
                {
                    Option.Titulo();  // metodo creado en options
                    Console.Write("Digite su cedula:");
                   
                    ID = int.Parse(Console.ReadLine());
                    
                    Console.Write("Digite su clave:");
                    
                    Password = int.Parse(Console.ReadLine());
                    ValueOne = User.ValidarCed(ID);
                    ValueTwo = User.ValidarPass(Password);

                    if (ValueOne !=-1 && ValueTwo !=-1 && ValueOne == ValueTwo) // tienen que ser diferente a -1
                    {
                        Console.Clear();
                        Console.WriteLine("Verificacion de usuario exitoso. bienvenido!");
                        Option.OptionUsuario(ValueOne);
                    }
                    else 

                    {
                        Console.WriteLine("Verificacion de usuarion no exitoso");
                    }
                }
                catch(FormatException excep)
                {
                    Console.WriteLine("Se introdujo un simbolo No valido");
                    ValueOne = -1;
                }
            }
            while (ValueOne == -1); // debe ser igual a -1

        }
    }
}
