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
	public class Temas
	{
		int id_album;
		int id_autor;
		int id_tema;
		string titulo;
		int duracion;
		string observaciones;

        public int IdAlbum
        {
            set { id_album = value; }
            get { return id_album; }
        }
        
        public int IdTema
        {
            set { id_tema = value; }
            get { return id_tema; }
        }
        
        public int IdAutor
        {
            set { id_autor = value; }
            get { return id_autor; }
        }

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }

        public int Duracion
        {
            set { duracion = value; }
            get { return duracion; }
        }
        
        public string Observaciones
        {
            set { observaciones = value; }
            get { return observaciones; }
        }

        public Temas()
        {
            titulo = "";
            duracion = 0;
            observaciones = "";
            id_album=0;
            id_autor=0;
            id_tema=0;
        }
	}
	
	public class Grupos
		{
			int id_compania;
			int id_grupo;
			string descripcion;
			byte integrantes;
			byte solista_cunjunto;
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
		
		public string Descripcion
		{
            set { descripcion = value; }
            get { return descripcion; }
        }
		
		public byte Integrantes
        {
            set { integrantes = value; }
            get { return integrantes; }
        }
		
		public byte SolistaConjunto
		{
            set { solista_cunjunto = value; }
            get { return solista_cunjunto; }
        }
		
		public Grupos()
			{
			id_compania=0;
			integrantes=0;
			id_grupo=0;
			descripcion="";
			solista_cunjunto=0;
			}
		}
	}
