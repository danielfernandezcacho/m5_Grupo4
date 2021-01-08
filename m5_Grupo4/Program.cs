using System;

namespace m5_Grupo4
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arrayObjetos = new object[7];

            Boss ejemplo1 = new Boss();
            arrayObjetos[0] = ejemplo1;
            ejemplo1.Pedir();

            Manager ejemplo2 = new Manager();
            arrayObjetos[1] = ejemplo2;
            ejemplo2.Pedir();

            Employee ejemplo3 = new Employee();
            arrayObjetos[2] = ejemplo3;
            ejemplo3.Pedir();

            Volunteer ejemplo4 = new Volunteer();
            arrayObjetos[3] = ejemplo4;
            ejemplo4.Pedir();

            Junior ejemplo5 = new Junior();
            arrayObjetos[4] = ejemplo5;
            ejemplo5.Pedir();

            Mid ejemplo6 = new Mid();
            arrayObjetos[5] = ejemplo6;
            ejemplo6.Pedir();

            Senior ejemplo7 = new Senior();
            arrayObjetos[6] = ejemplo7;
            ejemplo7.Pedir();

            EmetreBonusPlantilla(arrayObjetos);

        }

        public static void EmetreBonusPlantilla(object[] arrayObjetos)
        {
            foreach(object objeto in arrayObjetos)
            {
                string tipoObjeto = objeto.GetType().Name;

                if(tipoObjeto == "Boss")
                {
                    Boss ejemplo = (Boss)objeto;
                    ejemplo.BonoSalarial();
                }
                else if(tipoObjeto == "Manager")
                {
                    Manager ejemplo = (Manager)objeto;
                    ejemplo.BonoSalarial();
                }
                else if (tipoObjeto == "Employee")
                {
                    Employee ejemplo = (Employee)objeto;
                    ejemplo.BonoSalarial();
                }
                else if (tipoObjeto == "Volunteer")
                {
                    Volunteer ejemplo = (Volunteer)objeto;                   
                }
                else if (tipoObjeto == "Senior")
                {
                    Senior ejemplo = (Senior)objeto;
                    ejemplo.BonoSalarial();
                }
                else if (tipoObjeto == "Mid")
                {
                    Mid ejemplo = (Mid)objeto;
                    ejemplo.BonoSalarial();
                }
                else if (tipoObjeto == "Junior")
                {
                    Junior ejemplo = (Junior)objeto;
                    ejemplo.BonoSalarial();
                }
            }
        }
    }
}
