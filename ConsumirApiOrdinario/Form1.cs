using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ConsumirApiOrdinario
{
    public partial class Form1 : Form
    {
        private Acciones _acciones;

        public Form1()
        {
            InitializeComponent();
            _acciones = new Acciones("https://rickandmortyapi.com"); // URL base de la API
        }

        private async void btnShowAll_Click(object sender, EventArgs e)
        {
            // Llamamos al método para obtener todos los personajes
            List<Character> characters = await _acciones.GetAllCharactersAsync();

            // Mostramos los personajes en el DataGridView
            dgvCharacters.DataSource = characters;
        }

        private async void btnSearchById_Click(object sender, EventArgs e)
        {
            int id = 0;

            // Verificamos si el ID proporcionado es válido
            if (int.TryParse(txtSearchId.Text, out id))
            {
                // Llamamos al método para obtener un personaje por su ID
                Character character = await _acciones.GetCharacterByIdAsync(id);

                // Si encontramos el personaje, mostramos sus datos
                if (character != null)
                {
                    dgvCharacters.DataSource = new List<Character> { character };

                    // Cargar la imagen del personaje en el PictureBox
                    pbCharacterImage.Load(character.Image);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
