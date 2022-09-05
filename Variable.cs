using System;
using System.Collections.Generic;

namespace Evalua{
    public class Variable{
        
        public enum tipoDato{
            Char, Int, Float
        }
        string nombre = "";
        float valor = 0;
        tipoDato tipo;

        public Variable(string nombre, tipoDato tipo){
            this.nombre = nombre;
            this.tipo = tipo;
            valor = 0;
        }

        protected void setValor(float valor){
            this.valor = valor;
        }

        protected void setNombre(string nombre){
            this.nombre = nombre;
        }

        protected void setTipo(tipoDato tipo){
            this.tipo = tipo;
        }

        public double getValor(){
            return this.valor;
        }

        public string getNombre(){
            return this.nombre;
        }

        public tipoDato getTipo(){
            return this.tipo;
        }
    }
}