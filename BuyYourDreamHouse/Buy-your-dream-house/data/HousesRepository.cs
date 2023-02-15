using Buy_your_dream_house.Models;

namespace Buy_your_dream_house.data;

public class HousesRepository : IHousesRepository
{
    private readonly IJSONReader _data;

    public HousesRepository(IJSONReader data)
    {
        _data = data;
    }

    public bool SaveChanges()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<House> GetAllHouses()
    {
        return _data.Read();
    }
    
    public House GetOneHouse(int id)
    {
        return _data.Read().Find(house => house.Id == id);
    }
    
    public House Create(House house)
    {
        throw new NotImplementedException();
    }

    public House Update(int id, House house)
    {
        throw new NotImplementedException();
    }
}