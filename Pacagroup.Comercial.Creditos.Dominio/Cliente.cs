using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Creditos.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; }
        
        [DataMember]
        public string Nombre { get; set; }
       
        [DataMember]
        public string ApellidoPaterno { get; set; }
       
        [DataMember]
        public string NumeroDocumento { get; set; }
       
        [DataMember]
        public string EstadoCivil { get; set; }

    }
}
