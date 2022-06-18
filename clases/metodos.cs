using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1JoseVillegasCamacho
{
    internal class metodos
    {
        static String[] nombre = new String[10];
        static int[] edad = new int[10];
        static int[] sexo = new int[10];
        static String[] domicilio = new String[10];
        static int[] telefono = new int[10];
        static int[] seguro = new int[10];

        static int indiceGlobal = 0;

        public metodos()
        {

        }

        protected void inicializar()
        {

            for (int i = 0; i < 12; i++)
            {
                nombre[i] = "";
                edad[i] = 0;
                sexo[i] = 0;
                domicilio[i] = "";
                telefono[i] = 0;
                seguro[i] = 0;

            }
            Console.WriteLine("Variables incializadas"+ "\n");
        }



        private void agregarPacientes()
        {

            int opcion = 0;

            do
            {
                Console.WriteLine("Esta agregando pacientes!!"+ "\n");

                Console.WriteLine("Digite el nombre del paciente");
                nombre[indiceGlobal] = Console.ReadLine();

                Console.WriteLine("Digite la edad del paciente");
                edad[indiceGlobal] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el sexo del paciente, 1- Masculino, 2-Femenino (Digite el numero)");
                sexo[indiceGlobal] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el domicilio del paciente (ciudad por ejemplo)");
                domicilio[indiceGlobal] = Console.ReadLine();

                Console.WriteLine("Digite el telefono del paciente");
                telefono[indiceGlobal] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite 1- Si el paciente tiene seguro, 2- Si el paciente no tiene seguro");
                seguro[indiceGlobal] = int.Parse(Console.ReadLine());
                

                indiceGlobal++;

                Console.WriteLine("Desea ingresar mas pacientes ? 1-Si o 2-No" + "\n");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion != 2);


        }


        private void listarNombres()
        {
            Console.WriteLine("A continuacion se muestran los nombres de los pacientes hospitalizados: ");
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < indiceGlobal; i++)
            {
                Console.WriteLine(nombre[i]);
            }
            Console.WriteLine("--------------------------------------------------------------");
        }


        private void porcentajeEdades()
        {
            int nihnos = 0;
            int jovenes = 0;
            int adultos = 0;
            int total = 0;
            double porcentajeNihnos, porcentajeJovenes, porcentajeAdultos = 0;

            for (int i = 0; i < indiceGlobal; i++)
            {
                if (edad[i] <= 13)
                {
                    nihnos++;
                }
                else if (edad[i] >13 && edad[i] <= 30)
                {
                    jovenes++;
                }
                else
                {
                    adultos++;
                }
            }

            total = nihnos + jovenes + adultos;

            porcentajeNihnos = (nihnos * 100) / total;
            porcentajeJovenes = (jovenes * 100) / total;
            porcentajeAdultos = (adultos * 100) / total;

            Console.WriteLine("El porcentaje de niños es de: " + porcentajeNihnos+"%");
            Console.WriteLine("El porcentaje de jovenes es de: " + porcentajeJovenes + "%");
            Console.WriteLine("El porcentaje de adultos es de: " + porcentajeAdultos + "%" + "\n");
        }




        private void porcentajeSexo()
        {
            int hombres = 0, mujeres = 0, total=0;
            double porcentajeHombres = 0, porcentajeMujeres = 0;

            for (int i = 0; i < indiceGlobal; i++)
            {

                if (sexo[i] == 1)
                {
                    hombres++;
                }
                else if (sexo[i] == 2)
                {
                    mujeres++;
                }
            }

            total = hombres + mujeres;
            porcentajeHombres = (hombres * 100) / total;
            porcentajeMujeres = (mujeres * 100) / total;

            Console.WriteLine("El porcentaje de hombres es de: " + porcentajeHombres+"%");
            Console.WriteLine("El porcentaje de mujeres es de: " + porcentajeMujeres + "%"+"\n");
        }

        private void consultaPorNombre()
        {
            String busqueda = "";
            int indiceDetalle = 0;

            Console.WriteLine("Ingrese el nombre del paciente del que desea informacion");
            busqueda = Console.ReadLine();

            while ((indiceDetalle < indiceGlobal) && (busqueda != (nombre[indiceDetalle])))
            {
                indiceDetalle++;
            }

            if (indiceDetalle > indiceGlobal - 1)
            {
                Console.WriteLine("El articulo no existe" + "\n");
            }
            else
            {
                Console.WriteLine("Nombre: " + nombre[indiceDetalle]);
                Console.WriteLine("Edad: " + edad[indiceDetalle]);
                if (sexo[indiceDetalle] == 1)
                {
                    Console.WriteLine("Sexo: Masculino");
                }
                else
                {
                    Console.WriteLine("Sexo: Femenino");
                }
                Console.WriteLine("Domicilio: " + domicilio[indiceDetalle]);
                Console.WriteLine("telefono: " + telefono[indiceDetalle]);
                if (seguro[indiceDetalle] == 1)
                {
                    Console.WriteLine("Seguro: El paciente SI cuenta con seguro");
                }
                else
                {
                    Console.WriteLine("Seguro: El paciente NO cuenta con seguro");
                }
                
                Console.WriteLine("---------------------------------" + "\n");
            }
        }

        private void porcentajeConSeguro()
        {
            int siPosee = 0, noPosee = 0, total = 0;
            double porcentajeNo = 0, porcentajeSi = 0;

            for (int i = 0; i < indiceGlobal; i++)
            {

                if (seguro[i] == 1)
                {
                    siPosee++;
                }
                else if (seguro[i] == 2)
                {
                    noPosee++;
                }
            }

            total = siPosee + noPosee;
            porcentajeNo = (noPosee * 100) / total;
            porcentajeSi = (siPosee * 100) / total;

            Console.WriteLine("El porcentaje de pacientes que si poseen seguro medico es de: " + porcentajeSi+"%"+ "\n");
        }



        public void menu()
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("Bienvenido al Hospital, que desea hacer ?");
                Console.WriteLine("1- Inicializar");
                Console.WriteLine("2- Agregar pacientes");
                Console.WriteLine("3- Listar los nombres de todos los pacientes hospitalizados");
                Console.WriteLine("4- Porcentaje de pacientes por edades");
                Console.WriteLine("5- Porcentaje de hombres y mujeres hospitalizados");
                Console.WriteLine("6- consultar pacientes por nombre");
                Console.WriteLine("7- Consultar porcentaje de pacientes con seguro medico");
                Console.WriteLine("8- Salir"+"\n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        inicializar();
                        break;
                    case 2:
                        agregarPacientes();
                        break;
                    case 3:
                        listarNombres();
                        break;
                    case 4:
                        porcentajeEdades();
                        break;
                    case 5:
                        porcentajeSexo();
                        break;
                    case 6:
                        consultaPorNombre();
                        break;
                    case 7:
                        porcentajeConSeguro();
                        break;

                }
            } while (opcion != 8);

        }
    }
}
