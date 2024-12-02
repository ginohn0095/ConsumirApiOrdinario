using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ConsumirApiOrdinario
{
    public class Acciones
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        // Constructor que recibe la base URL de la API
        public Acciones(string baseUrl)
        {
            _httpClient = new HttpClient();
            _baseUrl = baseUrl.TrimEnd('/');
        }

        /// <summary>
        /// Obtiene todos los personajes de la API de Rick and Morty.
        /// </summary>
        /// <returns>Lista de personajes.</returns>
        public async Task<List<Character>> GetAllCharactersAsync()
        {
            try
            {
                // Hacemos la solicitud a la API de Rick and Morty correctamente con la URL base
                var response = await _httpClient.GetAsync($"{_baseUrl}/api/character");
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var characterResponse = JsonConvert.DeserializeObject<CharacterResponse>(jsonResponse);

                return characterResponse?.Results ?? new List<Character>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener personajes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Character>();
            }
        }

        /// <summary>
        /// Obtiene un personaje de la API por su ID.
        /// </summary>
        /// <param name="id">ID del personaje.</param>
        /// <returns>Objeto de tipo Character.</returns>
        public async Task<Character> GetCharacterByIdAsync(int id)
        {
            try
            {
                // Hacemos la solicitud a la API de Rick and Morty correctamente con la URL base y el ID
                var response = await _httpClient.GetAsync($"{_baseUrl}/api/character/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Personaje con ID {id} no encontrado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var character = JsonConvert.DeserializeObject<Character>(jsonResponse);

                return character;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el personaje: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

    /// <summary>
    /// Modelo para manejar la respuesta de la API, que incluye la paginación de personajes.
    /// </summary>
    public class CharacterResponse
    {
        public List<Character> Results { get; set; }
    }

    /// <summary>
    /// Modelo de personaje basado en la API de Rick and Morty.
    /// </summary>
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public Origin Origin { get; set; }
        public Location Location { get; set; }
        public string Image { get; set; }
        public IEnumerable<string> Episode { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }

    public class Origin
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

}




