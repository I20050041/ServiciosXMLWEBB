using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ObtenerDatosDesdeAPI();
        }

        static async Task ObtenerDatosDesdeAPI()
        {
            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    HttpResponseMessage respuesta = await cliente.GetAsync("https://localhost:44369/");

                    if (respuesta.IsSuccessStatusCode)
                    {
                        string datosXML = await respuesta.Content.ReadAsStringAsync();
                        Console.WriteLine("Datos obtenidos correctamente:");
                        Console.WriteLine(datosXML);
                    }
                    else
                    {
                        Console.WriteLine($"Error al obtener datos. Código de estado: {respuesta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
