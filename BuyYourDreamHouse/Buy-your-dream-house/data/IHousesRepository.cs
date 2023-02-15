using Buy_your_dream_house.Models;

namespace Buy_your_dream_house.data;

public interface IHousesRepository
{
   bool SaveChanges();
   House GetOneHouse(int id);
   IEnumerable<House> GetAllHouses();
   House Create(House house);
   House Update(int id, House house);
}