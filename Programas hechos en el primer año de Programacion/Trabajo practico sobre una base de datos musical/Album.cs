/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 03/11/2009
 * Hora: 04:04 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Trabajo_practico_sobre_una_base_de_datos_musical
{
	/// <summary>
	/// Description of Album.
	/// </summary>
	public class Album
	{int id_album;
		int id_genero;
		int id_disqueria;
		int id_compania;
		int id_grupo;
		byte varios;
		string titulo;
		double precio;
		string fecha_terminado;
		string fecha_lanzamiento;
		byte canciones;
		int duracion;
		string observaciones;

        public int IdAlbum
        {
            set { id_album = value; }
            get { return id_album; }
        }

        public int IdGenero
        {
            set { id_genero = value; }
            get { return id_genero; }
        }

        public int IdDisquera
        {
            set { id_disqueria = value; }
            get { return id_disqueria; }
        }

        public int IdCompania
        {
            set { id_compania = value; }
            get { return id_compania; }
        }

        public int IdGrupo
        {
            set { id_grupo = value; }
            get { return id_grupo; }
        }

        public byte Varios
        {
            set { varios = value; }
            get { return varios; }
        }

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }

        public byte Variados
        {
            set { varios = value; }
            get { return varios; }
        }

        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }

        public string FechaTerminacion
        {
            set { fecha_terminado = value; }
            get { return fecha_terminado; }
        }

        public string FechaLanzamiento
        {
            set { fecha_lanzamiento = value; }
            get { return fecha_lanzamiento; }
        }

        public byte Canciones
        {
            set { canciones = value; }
            get { return canciones; }
        }

        public int Duracion
        {
            set { duracion = value; }
            get { return duracion; }
        }

        public Album()
        {
            id_genero = 0;
            id_disqueria = 0;
            id_compania = 0;
            id_grupo = 0;
            varios = 0;
            titulo = "";
            precio = 0;
            fecha_terminado = "";
            fecha_lanzamiento = "";
            canciones = 0;
            duracion = 0;
            observaciones = "";
        }
	}
}
