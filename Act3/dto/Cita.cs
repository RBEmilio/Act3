using System;
using System.ComponentModel;
using System.Windows.Controls;


    public class Cita:INotifyPropertyChanged, IDataErrorInfo
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Grupo { get; set; }
        public DateTime Fecha { get; set; }
        public String Ciudad { get; set; }
        public String Sala { get; set; }

        public string Error => null;

        public int errores;

        public Cita()
        {
            Grupo = "Si";
            Fecha = DateTime.Now;
            Sala = "Sala 1";

        }
        public Cita(string nombre, string apellidos, String grupo, DateTime fecha, String ciudad, String sala)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Grupo = grupo;
            Fecha = fecha;
            Ciudad = ciudad;
            Sala = sala;
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                    {
                        result = "Debe introducir el nombre";
                    }
                }
                if (columnName == "Apellido")
                {
                    if (string.IsNullOrEmpty(Apellidos))
                    {
                        result = "Debe introducir los apellidos";
                    }
                }
                if (columnName == "Ciudad")
                {
                    if (string.IsNullOrEmpty(Ciudad))
                    {
                        result = "Debe introducir la ciudad";
                    }
                }
                return result;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
