using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinalRendiciones.Models
{
    public class GestorRendiciones
    {
        public void Agregar(Viatico nuevoViatico)
        {
            SqlConnection conn = new SqlConnection("data source=DESKTOP-E8FRIUV\\SQLEXPRESS;initial catalog=FinalViaticos;user id=sa;password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO Viatico(legajo, concepto, importe) VALUES (@legajo, @concepto, @importe)", conn);

            comm.Parameters.Add(new SqlParameter("@legajo", nuevoViatico.Legajo));
            comm.Parameters.Add(new SqlParameter("@concepto", nuevoViatico.Concepto));
            comm.Parameters.Add(new SqlParameter("@importe", nuevoViatico.Importe));

            comm.ExecuteNonQuery();
            conn.Close();
        }

        public List<Empleado>ObtenerNombres()
        {
            List<Empleado> lista = new List<Empleado>();

            SqlConnection conn = new SqlConnection("data source=DESKTOP-E8FRIUV\\SQLEXPRESS;initial catalog=FinalViaticos;user id=sa;password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM Empleado", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while(dr.Read())
            {
                int legajo = dr.GetInt32(0);
                string nombre = dr.GetString(1);

                Empleado E = new Empleado(legajo, nombre);
                lista.Add(E);
            }
            conn.Close();
            return lista;
        }

        public List<ViaticoDto>Listar()
        {
            List<ViaticoDto> lista = new List<ViaticoDto>();

            SqlConnection conn = new SqlConnection("data source=DESKTOP-E8FRIUV\\SQLEXPRESS;initial catalog=FinalViaticos;user id=sa;password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT v.idViatico, e.nombre, v.concepto, v.importe FROM Viatico v INNER JOIN Empleado e ON v.legajo=e.legajo ORDER BY e.nombre ASC, v.importe DESC", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int idViatico = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                string concepto = dr.GetString(2);
                float importe = dr.GetFloat(3);

                ViaticoDto V = new ViaticoDto(idViatico, nombre, concepto, importe);
                lista.Add(V);
            }
            conn.Close();
            return lista;
        }
    }
}