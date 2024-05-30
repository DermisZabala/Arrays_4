using System;

namespace Arrays_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            //CREACION DEL ARRAY DE OBJETOS
            Estudiantes[] datos = new Estudiantes[3];

            //RELLENANDO EL ARRAY
            datos[0] = new Estudiantes("Hamel", 19, "Ing. en Sistemas", "5to");
            datos[1] = new Estudiantes("Juan", 20, "Contabilidad", "3ro");
            datos[2] = new Estudiantes("Jamel", 22, "Psicología  ", "9no");

            //RECORRIENDO LOS ELEMENTOS DEL ARRAY DE OBJETOS
            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"{num}. {datos[i].GetInfoEstudiantes()}");
                num++;
            }
            Console.WriteLine("\n");

            //ARRAY IMPLICITO
            var numeros = new[] { 12, 3, 302, 21, 33, 43, 20, 21, 33, 44, 4211, 556, 40, 22, 18, 89, 12, 81 };
            
            //BUCLE FOREACH
            foreach (int recorrer in numeros)
            {
                Console.WriteLine(recorrer);
            }
        }
    }
    class Estudiantes
    {
        //PROPIEDADES
        private String nombres;
        private int edad;
        private String carrera;
        private String cuatrimestre;

        //CONTRUCTOR DE LA CLASE
        public Estudiantes(string nombres, int edad, string carrera, string cuatrimestre)
        {
            this.nombres = nombres;
            this.edad = edad;
            this.carrera = carrera;
            this.cuatrimestre = cuatrimestre;
        }

        //METODO GETTER PARA ACCEDER A LAS PROPIEDADES ENCAPSULADAS
        public String GetInfoEstudiantes()
        {
            return "Nombre: " + nombres + " \t| Edad: " + edad + " \t| Carrera: " + carrera + " \t| Cuatrimestre: " + cuatrimestre; 
        }
    }
}
