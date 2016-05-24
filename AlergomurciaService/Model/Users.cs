using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AlergomurciaService
{
    [DataContract]
    public class Users
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string usuario { get; set; }
        [DataMember]
        public string password { get; set; }       
    }
}
