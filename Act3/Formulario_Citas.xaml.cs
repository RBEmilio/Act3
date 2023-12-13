using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Act3
{
    public partial class Formulario_Citas : Window
    {
        public Cita cita;
        private int index;
        public Formulario_Citas()
        {
            InitializeComponent();
            this.index = -1;
            cita = new Cita();
            this.DataContext = cita;
        }
        public Formulario_Citas (int index)
        {
            InitializeComponent();
            this.index = index;
            cita = new Cita();
            this.DataContext = Citas.logica.listacitas.ElementAt(index);
        }

        public void Agregar(object sender, RoutedEventArgs e)
        {
            if (index > -1)
            {
                cita = new Cita(mi_nombre.Text, mi_apellidos.Text, mi_grupo.Text, (DateTime)mi_fecha.SelectedDate, mi_ciudad.Text, mi_sala.Text);
                Citas.logica.EditarCita(index, cita);
                this.Close();
            }
            else
            {
                Citas.logica.AgregarCita(cita);
            }
            cita = new Cita();
            this.DataContext= cita;
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                cita.errores++;
            else
                cita.errores--;

            if (cita.errores == 0)
                Aceptar.IsEnabled = true;
            else
                Aceptar.IsEnabled = false;        }
    }
}
