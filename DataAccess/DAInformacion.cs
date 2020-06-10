using DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAInformacion
    {
        public int AgregarArchivo(Archivo archivo)
        {
            IDbConnection _conn = DASoftColitas.Conexion();
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("SP_MANT_ARCHIVO", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@NOMBRE", archivo.Nombre));
            _Comand.Parameters.Add(new SqlParameter("@ARCHIVO ", archivo.Imagen));
            int Resultado = _Comand.ExecuteNonQuery();
            _conn.Close();
            return Resultado;
        }

        public List<Archivo> ConsultarArchivos()
        {
            IDbConnection _conn = DASoftColitas.Conexion();
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("SP_CONSULTAR_ARCHIVOS", _conn as SqlConnection);
            IDataReader _reader = _Comand.ExecuteReader();
            List<Archivo> _list = new List<Archivo>();
            while (_reader.Read())
            {
                Archivo archivo = new Archivo();
                archivo.Nombre = _reader.GetString(0);
                _list.Add(archivo);
            }
            _conn.Close();
            return _list;
        }

        public Archivo ObtenerArchivo(string nombre)
        {

            Archivo archivo = new Archivo();
            IDbConnection _conn = DASoftColitas.Conexion();
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("SP_OBTENER_ARCHIVO", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
            IDataReader _reader = _Comand.ExecuteReader();
            while (_reader.Read())
            {
                archivo.ID = _reader.GetInt32(0);
                archivo.Nombre = _reader.GetString(1);
                archivo.Imagen = (byte[])_reader.GetValue(2);
            }
            _conn.Close();
            return archivo;
        }
    }
}
