namespace Buy_your_dream_house.Models;

public class House
{
    public int Id { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }
    public int Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int HouseSize { get; set; }
    public string Image { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime PostedAt { get; set; }
    
}