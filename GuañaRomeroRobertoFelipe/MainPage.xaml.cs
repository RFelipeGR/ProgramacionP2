using System;
using System.IO;

namespace RecargaApp
{
    public partial class MainPage : ContentPage
    {
        private const string ArchivoRecarga = "RobertoGuaña.txt";
        private readonly object rguaña_entryNombre;
        private object rguaña_labelResultado;
        private object rguaña_entryTelefono;

        public MainPage()
        {
            InitializeComponent();
            CargarUltimaRecarga();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void OnRecargarClicked(object sender, EventArgs e)
        {
            string nombre = (string)rguaña_entryNombre;
            string telefono = (string)rguaña_entryTelefono;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono))
            {
                await DisplayAlert("Error", "Debe ingresar todos los campos.", "OK");
                return;
            }

            string informacionRecarga = $"Nombre: {nombre}, Teléfono: {telefono}, Fecha: {DateTime.Now}";
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ArchivoRecarga);

            // Guardar información en archivo
            File.WriteAllText(rutaArchivo, informacionRecarga);

            // Mostrar Toast o mensaje de confirmación
            await DisplayAlert("Éxito", "Recarga realizada con éxito.", "OK");

            // Recargar página
            CargarUltimaRecarga();
        }

        private void CargarUltimaRecarga()
        {
            throw new NotImplementedException();
        }
    }
}
