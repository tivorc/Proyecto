﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio;

namespace Capa4_Persistencia
{
    public class TipoHabitacionDAO
    {
        private GestorDAOSQL gestorDAOSQL;
        public TipoHabitacionDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }
        public int guardar(TipoHabitacion tipohabitacion)
        {
            int registro_afectados;
            string sentenciaSQL = "inset into TipoHabitacion(nombre, descripcion, precio) values(@nombre, @descripcion, @precio)";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@nombre", tipohabitacion.Nombre);
                comando.Parameters.AddWithValue("@descripcion", tipohabitacion.Descripcion);
                comando.Parameters.AddWithValue("@precio", tipohabitacion.Precio);
                registro_afectados = comando.ExecuteNonQuery();
                return registro_afectados;


            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public int modificar(TipoHabitacion tipoHabitacion)
        {
            int registros_afectados;
            string sentenciaSQL = "update TipoHabitacion set nombre=@nombre,descripcion=@descripcion,precio=@precio where id_tipo_habitacion = @id_tipo_habitacion";
            return 1;
        }
    }
}
