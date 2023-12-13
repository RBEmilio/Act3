using System;
using System.Collections.ObjectModel;

    public class Logica
    {
        public ObservableCollection<Cita> listacitas {  get; set; }

        public Logica()
        {
            listacitas = new ObservableCollection<Cita>();
            listacitas.Add(new Cita("Pepe", "Gutierrez", "Si", DateTime.Now, "Sevilla", "Sala 3"));
        }

        public void AgregarCita(Cita cita)
        {
            listacitas.Add(cita);
        }
        public void EliminarCita(int Index)
        {
            listacitas.RemoveAt(Index);
        }
        public void EditarCita(int index,  Cita cita)
        {
            listacitas[index] = cita;
        }
  }