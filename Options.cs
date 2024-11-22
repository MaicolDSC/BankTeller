using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paso5_MaicolSiachoque
{
    internal class Options
    {
        int setUsuario, Limit = 2000000;// se definen las variables
        int contadorSal = 0;
        int contadorPun = 0;
        Usuario User = new Usuario();// herencia 


        public void OptionUsuario(int Value)
        {
            do
            {
                Titulo();
                
                Console.WriteLine("Escoja la opcion a realizar");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Retiros");
                Console.WriteLine("3. Transferencias");
                Console.WriteLine("4. Consultar Puntos VivaColombia");
                Console.WriteLine("5. Canjear Puntos ViveColombia");
                Console.WriteLine("6. Salir");
                
                setUsuario = int.Parse(Console.ReadLine());// la opcion que elige el usuario

                switch (setUsuario)
                {
                    case 1:
                        Console.Clear();
                        ConSaldo(Value);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Retiro(Value);
                        break;
                    case 3:
                        Console.Clear();
                        Trans(Value);
                        break;
                    case 4:
                        Console.Clear();
                        ConPuntos(Value);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        break;
                    case 5:
                        Console.Clear();
                        CanjPuntos(Value);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opcion de transaccion no valida");
                        break;

                        
                }
            } while (setUsuario != 6);// se esta evaluando sobre esta condicion el siclo

        }
        //se empiezan a definir todos los metodos
        private void ConSaldo(int value)
        {
            Titulo(); 
            Console.WriteLine("Opcion 1 ---- consulta saldo");
            Console.WriteLine($"su saldo es ${User.Balance[value]}");// se imprime en consola el saldo de usuario
        }
        private void Retiro(int Value)

        {
            Console.WriteLine("Opcion 2 ------ Retiros");
            Console.WriteLine("Por favor seleccione la cantidad a retirar");
            Console.WriteLine("1. $ 100,000");
            Console.WriteLine("2. $ 250,000");
            Console.WriteLine("3. $ 300,000");
            Console.WriteLine("4. $ 450,000");
            
            int selCan = int.Parse(Console.ReadLine());//la opcion del usuario alamcenada
           
            switch (selCan)// se evalua mediante un switch
            {
                case 1:
                    if (1000000 <= User.Balance[Value])
                    {
                        contadorPun += 1000000;// se suman las variables
                        contadorSal += 1000000;
                        if (contadorSal <= Limit)
                        {
                            User.Balance[Value] -= 1000000;
                            Console.WriteLine("Por favor retire su dinero");
                            Console.WriteLine($" Saldo actual : {User.Balance[Value]}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad maxima para retirar $2.000.000 diarios");
                            contadorSal -= 100000;
                            contadorPun -= 100000;
                        }

                    }
                    else
                    {
                        Console.WriteLine("saldo insuficiente");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        OptionUsuario(Value);
                    }
                    break;
                case 2:

                    if (250000 <= User.Balance[Value])
                    {
                        contadorPun += 2000000;
                        contadorPun += 2000000;
                        if (contadorSal <= Limit)
                        {
                            User.Balance[Value] -= 2000000;
                            Console.WriteLine("Por favor retire su dinero");
                            Console.WriteLine($" Saldo actual : {User.Balance[Value]}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad maxima para retirar $2.000.000 diarios");
                            contadorSal -= 200000;
                            contadorPun -= 200000;
                        }

                    }
                    else
                    {
                        Console.WriteLine("saldo insuficiente");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        OptionUsuario(Value);
                    }
                    break;
                case 3:
                    if (300000 <= User.Balance[Value])
                    {
                        contadorPun += 3000000;
                        contadorPun += 3000000;
                        if (contadorSal <= Limit)
                        {
                            User.Balance[Value] -= 3000000;
                            Console.WriteLine("Por favor retire su dinero");
                            Console.WriteLine($" Saldo actual : {User.Balance[Value]}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad maxima para retirar $2.000.000 diarios");
                            contadorSal -= 300000;
                            contadorPun -= 300000;
                        }

                    }
                    else
                    {
                        Console.WriteLine("saldo insuficiente");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        OptionUsuario(Value);
                    }
                    break;
                case 4:
                    if (450000 <= User.Balance[Value])
                    {
                        contadorPun += 4500000;
                        contadorPun += 4500000;
                        if (contadorSal <= Limit)
                        {
                            User.Balance[Value] -= 450000;
                            Console.WriteLine("Por favor retire su dinero");
                            Console.WriteLine($" Saldo actual : {User.Balance[Value]}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad maxima para retirar $2.000.000 diarios");
                            contadorSal -= 450000;
                            contadorPun -= 450000;
                        }

                    }
                    else
                    {
                        Console.WriteLine("saldo insuficiente");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        OptionUsuario(Value);
                    }
                    break;

                    Console.WriteLine("Opcion no valida");
                    break;

            }

        }
        public void Trans(int Value)
        {
            
            Console.Write("Digite el numero de cedula del titular para realizar la transaccion:");
            int DataOne = int.Parse(Console.ReadLine());
            int ValCuentaExiste = User.ValidarCed(DataOne);

            if (ValCuentaExiste != -1) Console.WriteLine("Cuenta validada correctamente");
            else Console.WriteLine("Cuenta no existe");

            Console.WriteLine("Por favor seleccione la cantidad a transferir");
            Console.WriteLine("1. 100.000");
            Console.WriteLine("2. 200.000");
            Console.WriteLine("3. 300.000");
            Console.WriteLine("4. 400.000");
            
            int DataTwo = int.Parse(Console.ReadLine());
            int Verificar = User.ValidarCed(DataOne);
            

            switch (DataTwo)
            {
                case 1:
                    if (100000 <= User.Balance[Value])
                    {
                        Console.WriteLine("Transferencia exitosa");
                        User.Balance[Value] -= 100000;
                        Console.WriteLine($"Cantidad tranferida ---- $100.000 a numero de cuenta de {User.ID[Verificar]}");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        ConSaldo(Value);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("saldo insuficiente");
                    break;
                case 2:
                    if (200000 <= User.Balance[Value])
                    {
                        Console.WriteLine("Transferencia exitosa");
                        User.Balance[Value] -= 200000;
                        Console.WriteLine($"Cantidad tranferida ---- $100.000 a numero de cuenta de {User.ID[Verificar]}");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        ConSaldo(Value);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("saldo insuficiente");
                    break;
                case 3:
                    if (300000 <= User.Balance[Value])
                    {
                        Console.WriteLine("Transferencia exitosa");
                        User.Balance[Value] -= 300000;
                        Console.WriteLine($"Cantidad tranferida ---- $100.000 a numero de cuenta de {User.ID[Verificar]}");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        ConSaldo(Value);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("saldo insuficiente");
                    break;
                case 4:
                    if (400000 <= User.Balance[Value])
                    {
                        Console.WriteLine("Transferencia exitosa");
                        User.Balance[Value] -= 400000;
                        Console.WriteLine($"Cantidad tranferida ---- $100.000 a numero de cuenta de {User.ID[Verificar]}");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        ConSaldo(Value);
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("saldo insuficiente");
                    break;

                    Console.WriteLine("Opcion de trasferencia no valida");
                    break;

            }


        }
        private void ConPuntos(int Value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Opcion 4 -----Consulta sobre puntos ViveColombia");
            Console.WriteLine($" Puntos actuales: {User.Points[Value]}");
        }
        private void CanjPuntos(int Value)
        {

            Console.WriteLine($"Puntos actuales {User.Points[Value]}");
            
            Console.WriteLine("Seleccione los puntos a canjear");
            Console.WriteLine("1. 100.000 puntos");
            Console.WriteLine("2. 200.000 puntos");
            Console.WriteLine("3. 300.000 puntos");
            Console.WriteLine("4. 400.000 puntos");
            
            int selePun = int.Parse(Console.ReadLine());

            switch (selePun)
            {
                case 1:
                    if (100000 <= User.Points[Value] && 100000 <= User.Balance[Value])
                    {
                        contadorPun += 100000;
                        contadorSal += 100000;
                        if (contadorPun <= Limit && 100000 <= User.Balance[Value])
                        {
                            User.Points[Value] -= 100000;
                            User.Balance[Value] -= 100000;
                            Console.WriteLine("Por favor retire sus puntos");
                            Console.WriteLine($"Puntos Actual: $ {User.Points[Value]}");

                        }
                        else
                        {
                            Console.WriteLine("Maximo de puntos por cajear diario 2.000.000");
                            contadorSal -= 100000;
                            contadorPun -= 100000;
                        }
                    }
                    else Console.WriteLine("Saldo insuficiente, no puede canjear puntos");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    OptionUsuario(Value);
                    break;
                case 2:
                    if (200000 <= User.Points[Value] && 200000 <= User.Balance[Value])
                    {
                        contadorPun += 200000;
                        contadorSal += 200000;
                        if (contadorPun <= Limit && 200000 <= User.Balance[Value])
                        {
                            User.Points[Value] -= 200000;
                            User.Balance[Value] -= 200000;
                            Console.WriteLine("Por favor retire sus puntos");
                            Console.WriteLine($"Puntos Actual: $ {User.Points[Value]}");

                        }
                        else
                        {
                            Console.WriteLine("Maximo de puntos por cajear diario 2.000.000");
                            contadorSal -= 200000;
                            contadorPun -= 200000;
                        }
                    }
                    else Console.WriteLine("Saldo insuficiente, no puede canjear puntos");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    OptionUsuario(Value);
                    break;
                case 3:
                    if (300000 <= User.Points[Value] && 300000 <= User.Balance[Value])
                    {
                        contadorPun += 300000;
                        contadorSal += 300000;
                        if (contadorPun <= Limit && 300000 <= User.Balance[Value])
                        {
                            User.Points[Value] -= 300000;
                            User.Balance[Value] -= 300000;
                            Console.WriteLine("Por favor retire sus puntos");
                            Console.WriteLine($"Puntos Actual: $ {User.Points[Value]}");

                        }
                        else
                        {
                            Console.WriteLine("Maximo de puntos por cajear diario 2.000.000");
                            contadorSal -= 300000;
                            contadorPun -= 300000;
                        }
                    }
                    else Console.WriteLine("Saldo insuficiente, no puede canjear puntos");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    OptionUsuario(Value);
                    break;
                case 4:
                    if (400000 <= User.Points[Value] && 400000 <= User.Balance[Value])
                    {
                        contadorPun += 400000;
                        contadorSal += 400000;
                        if (contadorPun <= Limit && 400000 <= User.Balance[Value])
                        {
                            User.Points[Value] -= 400000;
                            User.Balance[Value] -= 400000;
                            Console.WriteLine("Por favor retire sus puntos");
                            Console.WriteLine($"Puntos Actual: $ {User.Points[Value]}");

                        }
                        else
                        {
                            Console.WriteLine("Maximo de puntos por cajear diario 2.000.000");
                            contadorSal -= 400000;
                            contadorPun -= 400000;
                        }
                    }
                    else Console.WriteLine("Saldo insuficiente, no puede canjear puntos");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    OptionUsuario(Value);
                    break;

                    Console.WriteLine("Opcion de canjeo incorrecto");
                    break;
            }


        }
        public void Titulo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Cajero Banco Nacional de Colombia"); 
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
    

