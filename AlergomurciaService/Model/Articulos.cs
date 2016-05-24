using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlergomurciaService.Model
{
    [DataContract]
    public class Articulos
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string titulo { get; set; }

        [DataMember]
        public string fecha { get; set; }

        [DataMember]
        public string usuario { get; set; }

        [DataMember]
        public string categoria { get; set; }

        [DataMember]
        public string resumen { get; set; }

        [DataMember]
        public string documento { get; set; }

    }
}
