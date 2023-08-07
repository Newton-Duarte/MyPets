using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyPets.Services
{
    internal class DogService
    {
        private const string DOG_API_URL = "https://dogapi.dog/api/v2";

        public static RestResponse GetDogBreeds()
        {
            var client = new RestClient($"{DOG_API_URL}/breeds");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            return response;
        }

        public class DogBreedsResponse
        {
            public List<DogBreed> data { get; set; }
        }

        public class DogBreed
        {
            public string id { get; set; }
            public BreedAttributes attributes { get; set; }
        }

        public class BreedAttributes
        {
            public string name { get; set; }
            public string description { get; set; }
        }
    }
}
