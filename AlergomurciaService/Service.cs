using AlergomurciaService.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System;

namespace AlergomurciaService
{
    class Service : IService
    {
        
        public List<Section> GetAllSection()
        {
            List<Section> Sec = new List<Section>();
            DbDataReader dr = Consult.returnData("Select id, seccion from seccionespdf");

            while (dr.Read())
            {
                Section s = new Section();
                s.id = int.Parse(dr[0].ToString());
                s.seccion = dr[1].ToString();
               
                Sec.Add(s);
            }
            return Sec;
        }

        public Section GetSectionById(int id)
        {

            DbDataReader dr = Consult.returnData("Select  id, seccion from seccionespdf where id = " + id);
            Section Sec = new Section();
            while (dr.Read())
            {
                Sec.id = int.Parse(dr[0].ToString());
                Sec.seccion = dr[1].ToString();


            }
            return Sec;
        }

        public Section AddSection(Section section)
        {
            DbDataReader dr = Consult.returnData("Insert into seccionespdf (seccion) values ('" + section.seccion + "' )");
            Section Sec = new Section();
            while (dr.Read())
            {
                //Sec.id = int.Parse(dr[0].ToString());
                Sec.seccion = dr[1].ToString();
            }
            return Sec;
        }


        public List<Users> GetAllUsers()
        {
            List<Users> ListUser = new List<Users>();
            DbDataReader dr = Consult.returnData("Select id, nombre, usuario, password from [User]");

            while (dr.Read())
            {
                Users u = new Users();
                u.id = int.Parse(dr[0].ToString());
                u.nombre = dr[1].ToString();
                u.usuario = dr[2].ToString();
                u.password = dr[3].ToString();
                ListUser.Add(u);
            }
            return ListUser;
        }

        public List<Documentos> GetAllDocuments()
        {
            List<Documentos> Doc = new List<Documentos>();
            DbDataReader dr = Consult.returnData("Select fileID, filePath, Createdby, CreatedDt, seccion, title from tblUploadedFiledetails");

            while (dr.Read())
            {
                Documentos d = new Documentos();
                d.fileID = int.Parse(dr[0].ToString());
                d.filePath = dr[1].ToString();
                d.Createdby = dr[2].ToString();
                d.Createdby = dr[3].ToString();
                d.seccion = (dr[4].ToString());
                d.title = dr[5].ToString();
                Doc.Add(d);
            }
            return Doc;
        }

        public List<Reuniones> GetAllReuniones()
        {
            List<Reuniones> Reu = new List<Reuniones>();
            DbDataReader dr = Consult.returnData("Select id, fecha, titulo, lugar, resumen, detalle, enlaces from reuniones");

            while (dr.Read())
            {
                Reuniones d = new Reuniones();
                d.id = int.Parse(dr[0].ToString());
                d.fecha = dr[1].ToString();
                d.titulo = dr[2].ToString();
                d.lugar = dr[3].ToString();
                d.resumen = (dr[4].ToString());
                d.detalle = dr[5].ToString();
                Reu.Add(d);
            }
            return Reu;
        }

        public List<Noticias> GetAllNoticias()
        {
            List<Noticias> Not = new List<Noticias>();
            DbDataReader dr = Consult.returnData("Select id, fecha, titulo, autor, resumen, detalle, documento from noticias");

            while (dr.Read())
            {
                Noticias d = new Noticias();
                d.id = int.Parse(dr[0].ToString());
                d.fecha = dr[1].ToString();
                d.titulo = dr[2].ToString();
                d.autor = dr[3].ToString();
                d.resumen = (dr[4].ToString());
                d.detalle = dr[5].ToString();
                d.documento = dr[6].ToString();
                Not.Add(d);
            }
            return Not;
        }

        public List<Articulos> GetAllArticulos()
        {
            List<Articulos> Art = new List<Articulos>();
            DbDataReader dr = Consult.returnData("Select id, titulo, fecha, usuario, categoria, resumen, documento from articulos");

            while (dr.Read())
            {
                Articulos d = new Articulos();
                d.id = int.Parse(dr[0].ToString());
                d.titulo = dr[1].ToString();
                d.fecha = dr[2].ToString();
                d.usuario = dr[3].ToString();
                d.categoria = (dr[4].ToString());
                d.resumen = dr[5].ToString();
                d.documento = dr[6].ToString();
                Art.Add(d);
            }
            return Art;
        }

    }
}
