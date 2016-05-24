using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlergomurciaService
{
    [DataContract]
    public class Documentos
    {
        [DataMember]
        public int fileID { get; set; }
        [DataMember]
        public string filePath { get; set; }

        [DataMember]
        public string Createdby { get; set; }
        [DataMember]
        public string CreatedDt { get; set; }
        [DataMember]
        public string seccion { get; set; }
        [DataMember]
        public string title { get; set; }
    }
}
