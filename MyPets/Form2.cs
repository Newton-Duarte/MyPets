using MyPets.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyPets.Services.DogService;

namespace MyPets
{
    public partial class BuscarPets : Form
    {
        private readonly static List<DogBreed> DogBreeds = new List<DogBreed>();

        public BuscarPets()
        {
            InitializeComponent();
        }

        private void BuscarPets_Load(object sender, EventArgs e)
        {
            var response = DogService.GetDogBreeds();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = JsonSerializer.Deserialize<DogBreedsResponse>(response.Content);

                foreach (var breed in json.data)
                {
                    DogBreeds.Add(breed);
                    racaComboBox.Items.Add(breed.attributes.name);
                }
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedBreed = racaComboBox.SelectedItem;
            var findBreed = DogBreeds.Find((breed) => breed.attributes.name == selectedBreed.ToString());

            if (findBreed != null)
            {
                lblDescricaoContent.Text = findBreed.attributes.description;
            }
        }
    }
}
