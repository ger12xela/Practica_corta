using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_corta.NewFolder1
{
    class backlexico
    {
        public backlexico(){
            

        }

        string palabra = "";
        public String Peso1(String cadena)
        {
        String retorno = " ";
            int numero = cadena.Length;
                Console.WriteLine ("los caracteres son " + numero);
               
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i].Equals(' '))
                {

                    paso2(palabra);
                    palabra = "";
                }
                else {
                    palabra += cadena[i].ToString();

                }
            }
            retorno =paso2(palabra);
            palabra = "";
            return retorno;
        }

        // paso 2 

        String palabraSuelta;
        public String paso2(String palabra) {
            palabraSuelta += paso3(palabra) +"\n";
            return palabraSuelta;
        }

        public String paso3(String palabra) {
            String respuesta = palabra + " No identifica ";
            String letras = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            String numeros = "1234567890";


            int contador_letra = 0;
            int contador_numero = 0;
            int contador_punto = 0;

            bool verdad_palabra = false;
            bool verdad_Entero = false;
            bool verdad_decimal = false;
            bool verdad_moneda = false;

            // comparacion letras del alfabeto espanio 
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 0; j < letras.Length; j++)
                {
                    if (palabra[i].Equals(letras[j]))
                    {
                        contador_letra++;
                        Console.WriteLine(contador_letra);
                    }
                }
        
            }
            // comparacion numeros digitos
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (palabra[i].Equals(numeros[j]))
                    {
                        contador_numero++;
                    }
                }

            }

            // comparacion puntos
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i].Equals('.')){ 
                contador_punto++;
                Console.WriteLine("hay un punto");
                }

            }

            // comparaciones 
            if (contador_letra == palabra.Length) {
                respuesta = palabra + " --> es una Palabra ";
            }

            if (contador_numero == palabra.Length)
            {
                respuesta = palabra + " --> es un Entero";
            }

            if (contador_punto == 1 && contador_numero == (palabra.Length - 1)) {
                respuesta = palabra + " --> es un Decimal";
            }
            if (contador_numero == (palabra.Length - 2) && contador_punto == 1 && palabra[0].Equals('Q')) {
                respuesta = palabra + " --> es una Moneda";
            }

            return respuesta;
        }
    }
}
