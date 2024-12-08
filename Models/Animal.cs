namespace MyDynamicWebsite.Models{
 public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public bool IsAdopted { get; set; } // Sahiplendirme
    public string HealthStatus { get; set; }
    public DateTime ArrivalDate { get; set; }
}

}