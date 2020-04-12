using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class DatosVerificacionMati
    {
        public string Username { get; set; }
        public string FotoDelantera { get; set; }
        public string FotoTrasera { get; set; }
        public string Selfie { get; set; }
        public string FullName { get; set; }
        public string Direccion { get; set; }
        public string Emision { get; set; }
        public string NumDocumento { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaExpiracion { get; set; }
        public string Curp { get; set; }
        public string OcrNumber { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string NacionalidadIdentificacion { get; set; }
        public string TipoDocumento { get; set; }
    }
}
