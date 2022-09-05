using System;

namespace Evalua{
    public class Error : Exception{
        public Error(String mensaje, StreamWriter log) {
            Console.WriteLine(mensaje);
            log.WriteLine(mensaje);
        }
    }
}