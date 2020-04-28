using brokfy.dashboard.api.data.ViewModel;
using brokfy.dashboard.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brokfy.dashboard.api.Helpers
{
    public class FormSerializer
    {
        public dynamic Serialize(List<FormSerialize> Data, string Module)
        {

				switch (Module)
				{
					case "PolizaAuto":
						return new PolizaAuto
						{
							NoPoliza = Data.Where(x => x.name == "noPoliza").FirstOrDefault().value,
							FormaPago = Data.Where(x => x.name == "formaPago").FirstOrDefault().value,
							ProximoPago = DateTime.TryParse(Data.Where(x => x.name == "proximoPago").FirstOrDefault().value, out DateTime f1) ? f1 : DateTime.Now,
							FechaInicio = DateTime.TryParse(Data.Where(x => x.name == "proximoPago").FirstOrDefault().value, out DateTime f2) ? f2 : DateTime.Now,
							FechaFin = DateTime.TryParse(Data.Where(x => x.name == "fechaFin").FirstOrDefault().value, out DateTime f3) ? f3 : DateTime.Now,
							IdAseguradoras = int.Parse(Data.Where(x => x.name == "idAseguradoras").FirstOrDefault().value),
							Costo = double.Parse(Data.Where(x => x.name == "costo").FirstOrDefault().value),
							Username = Data.Where(x => x.name == "username").FirstOrDefault().value,
							ProductoId = int.Parse(Data.Where(x => x.name == "productoId").FirstOrDefault().value),
							Habilitada = Data.Where(x => x.name == "habilitada").FirstOrDefault().value,
							NoAsegurado = Data.Where(x => x.name == "noAsegurado").FirstOrDefault().value,
							PolizaPropia = Data.Where(x => x.name == "polizaPropia").FirstOrDefault().value,
							PolizaPdf = Data.Where(x => x.name == "polizaPdf").FirstOrDefault().value,
							ReciboPdf = Data.Where(x => x.name == "reciboPdf").FirstOrDefault().value,
							RcUsaCanada = Data.Where(x => x.name == "rcUsaCanada").FirstOrDefault().value,
							CostoPrimerRecibo = Data.Where(x => x.name == "costoPrimerRecibo").FirstOrDefault().value,
							CostoRecibosSubsecuentes = Data.Where(x => x.name == "costoRecibosSubsecuentes").FirstOrDefault().value,
							Marca = Data.Where(x => x.name == "marca").FirstOrDefault().value,
							Modelo = Data.Where(x => x.name == "modelo").FirstOrDefault().value,
							Ano = int.Parse(Data.Where(x => x.name == "ano").FirstOrDefault().value),
							Placas = Data.Where(x => x.name == "placas").FirstOrDefault().value,
							Clave = Data.Where(x => x.name == "clave").FirstOrDefault().value,
							CodigoPostal = Data.Where(x => x.name == "codigoPostal").FirstOrDefault().value
						};
					default:
						break;
				}
			return null; 

        }
    }
}
