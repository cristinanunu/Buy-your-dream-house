using System.Text;
using System.Text.Json;
using Buy_your_dream_house.Models;

namespace Buy_your_dream_house.data;

public class JSONReader : IJSONReader
{
    public List<House> Read()
    {
        var path = Path.Join($"{Environment.CurrentDirectory}/data", "listHouses.json");
        var json = File.ReadAllText(path);
        var houses = JsonSerializer.Deserialize<List<House>>(json);
        return houses;
    }

}