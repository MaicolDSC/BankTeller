using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paso5_MaicolSiachoque
{
    internal class Usuario
    {
        public int[] ID = { 1024591623, 52614882, 79624813 };//metodos y variables publicos
        public int[] Password = { 1298, 1496, 6515 };
        public int[] Balance = { 4000000, 2000000, 7000000 };
        public int[] Points = { 1000000, 2000000, 3000000 };

        public int ValidarCed(int cedula) // verificar que la cuenta existe por lo tanto recibe la cedula
        {
            int answer = -1; // se define variable
            for (int i =0; i  < ID.Length; i++)
            {
                if (ID[i] == cedula) // el id en la posicion que se esta interando sea igual a cedula que estamo recibiendo   
                {
                    answer = i; // si concuerdan la respuesta pasa a tener el valor de la iterable
                }
            }
            return answer;// y se retorna la iterable
        }

        public int ValidarPass(int clave) 
        {
            int answer = -1;
            for (int i = 0; i < Password.Length; i++) 
            {
                if (Password[i] == clave)// se itera el password 
                {
                    answer = i;
                }
            }
            return answer;
        }
    }
}
