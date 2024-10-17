using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class EjemploBucle : MonoBehaviour
 {
        public int[] arrayNumeros;
        void Start()
        {
            // for(int variable; variable < numero(arrayNumeros.Length); variable++ - primer comandy for, dlya petli

            int sumaDeNotas = 0;
            int notaMasBaja = arrayNumeros[0];
            int notaMasAlta = arrayNumeros[0];
            
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                sumaDeNotas += arrayNumeros[i];

                if (notaMasBaja > arrayNumeros[1])
            {
                notaMasBaja = arrayNumeros[1];
            }
               
            
            // k i pribavlyayetsya po odnoy edinitse s kazhdym sravneniyem
                if (notaMasAlta < arrayNumeros[i])
                {
                notaMasAlta = arrayNumeros[i];
                }

                Debug.Log("Nota en el ejercicio " + i + " = " + arrayNumeros[i]);
                

                

                /*int minNum = arrayNumeros[1];
                Debug.Log("El número mínimo es: " + minNum);*/

            }

            // Srednyee chislo nomerov kotoryye est vsego v arrayNumeros
            int notaMedia = sumaDeNotas / arrayNumeros.Length;
            Debug.Log("Nota media " + notaMedia);

            Debug.Log("Nota más baja: " + notaMasBaja);

            Debug.Log("Nota más alta: " + notaMasAlta);



    }


        void Update()
        {

        }
 }
