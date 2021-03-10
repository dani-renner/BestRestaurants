namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}