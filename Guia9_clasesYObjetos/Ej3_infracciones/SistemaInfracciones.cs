using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3_infracciones
{
    class SistemaInfracciones
    {
        #region nomenclador de infracciones
        int CODIGO_1_INFRACCION = 1;
        string DESC_1_INFRACCION = "Sin luces bajas, ley 25….";
        int UD_1_INFRACCION = 25;
        //
        int CODIGO_2_INFRACCION = 2;
        string DESC_2_INFRACCION = "alta de Matafuego, ley 2…";
        int UD_2_INFRACCION = 30;
        //
        int CODIGO_3_INFRACCION = 3;
        string DESC_3_INFRACCION = "Sobrevelocidad...";
        int UD_3_INFRACCION = 100;
        //
        int CODIGO_4_INFRACCION = 4;
        string DESC_4_INFRACCION = "Falta de cinturón de seguridad (>2 ejes) o falta de casco (1 eje)";
        int UD_4_INFRACCION = 85;
        //
        int CODIGO_5_INFRACCION = 5;
        string DESC_5_INFRACCION = "Falta de respeto A la autoridad...";
        int UD_5_INFRACCION = 1500;



        #endregion

        #region atributos generales de sistema

        public double BaseMonetaria { get; private set; }

        public double Recaudacion { get; private set; }

        
        #endregion

        #region atributos por cada acta
        int DniActa;
        string nombre;
        public double totalAPagar;
        #endregion

        #region atributos por cada infraccion
        int codigoInfraccion;
        string descInfraccion;
        double montoInfraccion;
        #endregion

        #region método del sistema
        public SistemaInfracciones(double Basemonetaria)
        {
            this.BaseMonetaria = Basemonetaria;

        }
        #endregion

        #region métodos por acta
        public void IniciarActa(int dni, string nombre)
        {
            this.DniActa = dni;
            this.nombre = nombre;
            totalAPagar = 0;
        }

        public double RegistrarInfraccion(int codigo)
        {
            switch (codigo)
            {
                case 1:
                    {
                        montoInfraccion = UD_1_INFRACCION * BaseMonetaria;
                    }
                    break;
                case 2:
                    {
                        montoInfraccion = UD_2_INFRACCION * BaseMonetaria;
                    }
                    break;

                case 3:
                    {

                        montoInfraccion = UD_3_INFRACCION * BaseMonetaria;

                    }
                    break;

                case 4:
                    {

                        montoInfraccion = UD_4_INFRACCION * BaseMonetaria;

                    }
                    break;

                case 5:
                    {

                        montoInfraccion = UD_5_INFRACCION * BaseMonetaria;

                    }
                    break;
            }
            totalAPagar += montoInfraccion;
            return montoInfraccion;
        }

        public double TotalApagar(double totalAPagar)
        {
            return totalAPagar;
        }
        public void FinalizarActa(bool pagaEnElLugar)
        {
            Recaudacion += totalAPagar;
        }
        #endregion


       

    }
}
