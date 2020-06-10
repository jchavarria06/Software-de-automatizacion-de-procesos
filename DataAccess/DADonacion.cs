using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccess
{
    public  class DADonacion
    {
        public int AgregarDonacion(Donacion donacion)
        {
            int Resultado = 0 ;
            try
            {
                IDbConnection _conn = DASoftColitas.Conexion();
                _conn.Open();
                SqlCommand _Comand = new SqlCommand("SP_AGREGAR_DONACION", _conn as SqlConnection);
                _Comand.CommandType = CommandType.StoredProcedure;
                _Comand.Parameters.Add(new SqlParameter("@MONTO", donacion.monto));
                _Comand.Parameters.Add(new SqlParameter("@FECHA", donacion.fecha));
                _Comand.Parameters.Add(new SqlParameter("@COD_ANIMAL", donacion.codigoAnimal));
                _Comand.Parameters.Add(new SqlParameter("@IDUSUARIO", donacion.idUsuario));
                 Resultado = _Comand.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Resultado;
        }
        public List<Donacion> ConsultarDonacionesID(string id)
        {
            IDbConnection _conn = DASoftColitas.Conexion();
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("SP_DONACIONES_ID", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@COD_ANIMAL", id));
            IDataReader _reader = _Comand.ExecuteReader();
            List<Donacion> _list = new List<Donacion>();
            while (_reader.Read())
            {
                Donacion donacion = new Donacion();
                donacion.idDonacion = _reader.GetInt32(0);
                donacion.monto = _reader.GetDecimal(1);
                donacion.fecha = Convert.ToDateTime(_reader.GetValue(2));
                donacion.codigoAnimal = _reader.GetString(3);
                donacion.idUsuario = _reader.GetInt32(4);
                _list.Add(donacion);
            }
            _conn.Close();
            return _list;
        }
    }
}
