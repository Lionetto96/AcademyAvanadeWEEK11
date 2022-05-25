using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClassLibrary_Biblioteca_Core.Entities
{
    [DataContract]
    public class Prestito
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdLibro { get; set; }
        [DataMember]
        public string Utente { get; set; }

        [DataMember]
        public DateTime DataPrestito { get; set; }
        [DataMember]
        public DateTime? DataReso { get; set; }

        public Libro1 Libro { get; set; }

    }
}
