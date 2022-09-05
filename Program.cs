using System;

namespace Evalua{
    public class Program{

        static void Main(string[] args){

            try{
                Lenguaje a = new Lenguaje("C:\\Users\\Fernando Hernandez\\Desktop\\ITQ\\5to Semestre\\Lenguajes y Automatas II\\Evalua\\prueba.cpp");

                a.Programa();
                /*while(!a.FinArchivo()){
                    a.NextToken();
                }*/
                a.Cerrar();
            }
            catch(Exception){

            }
        }
    }
}