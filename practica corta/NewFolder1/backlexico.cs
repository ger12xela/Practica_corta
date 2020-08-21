using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_corta.NewFolder1
{
    /// <summary>
    /// clase principal del reconocimeinto de lexemas
    /// </summary>
    class backlexico
    {
        public backlexico(){
   
        }

        string palabra = "";
        String palabraSuelta;// para el paso 2 

        /// <summary>
        /// este paso separa las palabras de la horacion "cada que encuentra un espacio"
        /// </summary>
        /// <param name="oracion"="cadena"></param>
        /// <returns> String; las plabras con tipo de lexema </returns>
        public String Peso1(String cadena)
        {
        String retorno = " ";
            int numero = cadena.Length;
               
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

        /// <summary>
        /// sirbe para memoria para guardar las plabras como una sola cadena
        /// </summary>
        /// <param name="palabra del paso 1"></param>
        /// <returns>toda la lista de palabras con el tipo de lexema</returns>
        public String paso2(String palabra) {
            palabraSuelta += paso3(palabra) +"\n";
            return palabraSuelta;
        }

        /// <summary>
        /// este se encarga de saber que tipo es cada uno de los caracteres
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns>el tipo de palabra </returns>
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
            if (contador_numero == palabra.Length - 1 && palabra[0].Equals('-')) {
                respuesta = palabra + " --> es un Entero Negativo";
            } 

            if (contador_punto == 1 && contador_numero == (palabra.Length - 1)) {
                respuesta = palabra + " --> es un Decimal";
                int a = palabra.Length-1;
                if (palabra[a].Equals('.')){
                    respuesta = palabra + " -->es un entero"; 
                }
            }
            if (contador_numero == (palabra.Length - 2) && contador_punto == 1 && palabra[0].Equals('Q')) {
                respuesta = palabra + " --> es una Moneda";
            }

            return respuesta;
        }
    }
}
