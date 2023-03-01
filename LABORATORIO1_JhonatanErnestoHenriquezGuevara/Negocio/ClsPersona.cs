using LABORATORIO1_JhonatanErnestoHenriquezGuevara.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace LABORATORIO1_JhonatanErnestoHenriquezGuevara.Negocio
{
    public class ClsPersona
    {
        public String calcularIMC(Persona data) {
            
            if (data.Peso / Math.Pow(data.Altura, 2) < 24)
            {
                return $"{data.Nombre} a tus {data.Edad} años tu peso es ideal";
            }
            else {
                return $"{data.Nombre} a tus {data.Edad} años tienes sobre peso";
            }

             
        }
        public String esMayorDeEdad(Persona data)
        {
            
            if ( data.Edad > 18)
            {
                return $"{data.Nombre} tienes {data.Edad} años por lo tanto eres mayor de edad";
            }
            else {
                return $"{data.Nombre} tienes {data.Edad} años por lo tanto eres menor de edad";
            }
        }
    }
}
