using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Mensajes : ClaseMaestra
    {
        public int Id { set; get; }
        public string Email { set; get; }
        public string Asunto { set; get; }
        public string Mensaje { set; get; }
        ConexionDb conexion = new ConexionDb();
        
        public Mensajes(int id, string email, string asunto, string mensaje)
        {
            this.Id = id;
            this.Email = email;
            this.Asunto = asunto;
            this.Mensaje = mensaje;
        }

        public Mensajes()
        {

        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Mensajes (Email, Asunto, Mensaje) Values ('{0}','{1}','{2}') ", this.Email, this.Asunto, this.Mensaje));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Mensajes set Email='{0}', Asunto='{1}', Mensaje='{2}' where Id={3}", this.Email, this.Asunto, this.Mensaje, this.Id));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Delete From Mensajes where Id={0}", this.Id));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Mensajes Where Id=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.Id = (int)dt.Rows[0]["Id"];
                this.Email = dt.Rows[0]["Email"].ToString();
                this.Asunto = dt.Rows[0]["Asunto"].ToString();
                this.Mensaje = dt.Rows[0]["Mensaje"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Mensajes where " + Condicion + ordenar));
        }
    }
}
