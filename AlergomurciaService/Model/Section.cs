using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlergomurciaService
{
    [DataContract]
    public class Section
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string seccion { get; set; }
    }
}
