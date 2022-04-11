/*Vamos a programar un algoritmo que permita al usuario convertir una cantidad de dinero en pesos argentinos 
 a su equivalente en moneda extranjera. Se debe poder ingresar por Inspector el monto a convertir y una letra 
 correspondiente a la moneda extranjera que se quiere convertir, las opciones son:

D, para dólares
R, para reales
E, para euros

(La cotización de la moneda será investigada por quien realice el examen).

El programa debe cumplir los siguientes requerimientos:
Si se ingresa otra cosa que no sea “D”, “R” o “E” se debe mostrar el mensaje “Opción de moneda extranjera no válida”.

Si la cantidad de dinero de dinero a convertir es menor que 1000, mostrar el mensaje “El monto mínimo es $1000”. 

Si los valores ingresados son válidos devolver el mensaje 
"[monto a convertir] pesos argentinos equivalen a [cantidad covertida] [moneda elegida] ". Ejemplo: "1000 pesos equivalen a 3 dólares".
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1 : MonoBehaviour
{

    public int montoAConvertir;
    public string monedaElegida;
    int cantidadConvertida;

    void Start()
    {
        if (monedaElegida != "D" && monedaElegida != "E" && monedaElegida != "R")
        {
            Debug.Log("Opción de moneda extranjera no válida");
        }
        else if (montoAConvertir < 1000)
        {
            Debug.Log("El monto minimo es $1000");
        }
        else if (monedaElegida == "D")
        {
            cantidadConvertida = montoAConvertir / 112;
            Debug.Log(montoAConvertir + " pesos equivalen a " + cantidadConvertida + " " + monedaElegida);
        }
        else if (monedaElegida == "E")
        {
            cantidadConvertida = montoAConvertir / 122;
            Debug.Log(montoAConvertir + " pesos equivalen a " + cantidadConvertida + " " + monedaElegida);
        }
        else if (monedaElegida == "R")
        {
            cantidadConvertida = montoAConvertir / 23;
            Debug.Log(montoAConvertir + " pesos equivalen a " + cantidadConvertida + " " + monedaElegida);
        }
    }

    void Update()
    {
        
    }
}
