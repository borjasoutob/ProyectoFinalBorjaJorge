using Negocio;
using System.Data;
namespace Presentacion.Datos
{
    public class DS_Modelo
    {
        private DS_negocio dataset_negocio = new DS_negocio();

        public DataSet Pasar_dataset_Modelo()
        {
            DataSet dataset_modelo = dataset_negocio.Pasar_dataset_negocio();
            return dataset_modelo;
        }
    }
}
