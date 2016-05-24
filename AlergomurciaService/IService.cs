using AlergomurciaService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AlergomurciaService
{
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        List<Section> GetAllSection();

        [OperationContract]
        Section GetSectionById(int id);

        [OperationContract]
        Section AddSection(Section section);


        [OperationContract]
        List<Users> GetAllUsers();

        [OperationContract]
        List<Documentos> GetAllDocuments();

        [OperationContract]
        List<Reuniones> GetAllReuniones();

        [OperationContract]
        List<Noticias> GetAllNoticias();

        [OperationContract]
        List<Articulos> GetAllArticulos();

    }
}
