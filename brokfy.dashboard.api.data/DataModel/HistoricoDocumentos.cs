using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class HistoricoDocumentos
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string TipoDocumento { get; set; }
        public string FotoDelantera { get; set; }
        public string FotoTrasera { get; set; }
        public string Selfie { get; set; }
        public string FullName { get; set; }
        public string Direccion { get; set; }
        public string Emision { get; set; }
        public string NumDocumento { get; set; }
        public string DocNumber { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaExpiracion { get; set; }
        public string Curp { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string Expeditor { get; set; }
        public string LugarNacimiento { get; set; }
        public string Authority { get; set; }
        public string State { get; set; }
        public string Locality { get; set; }
        public string ElectorId { get; set; }
        public string RegistryYear { get; set; }
        public string Municipality { get; set; }
        public string Section { get; set; }
        public string CrcSection { get; set; }
    }
}
