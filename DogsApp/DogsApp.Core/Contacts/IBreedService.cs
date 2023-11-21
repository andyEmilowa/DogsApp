using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DogsApp.Infrastructure.Data.Domain;

namespace DogsApp.Core.Contacts
{
    public interface IBreedService
    {
        List<Breed> GetBreeds();
        Breed GetBreedById(int breedId);
        List<Dog> GetDogsByBreed(int breedId);
    }
}
