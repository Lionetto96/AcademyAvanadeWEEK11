using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClassLibrary_Biblioteca_Core.Entities
{
    [DataContract]
    public class Libro1
    {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string ISBN { get; set; }
        [DataMember]
        public string Titolo { get; set; }
        [DataMember]
        public string Sommario { get; set; }
        [DataMember]
        public string Autore { get; set; }
        public List<Prestito> Prestiti { get; set; }
    }
}
