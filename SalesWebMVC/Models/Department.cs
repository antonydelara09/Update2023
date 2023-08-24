namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /*
        public void addSeller(Seller seler)
        {

        }
        */
        public double totalSales(DateTime initial, DateTime final)
        {
            return 0;
        }
    }
}
