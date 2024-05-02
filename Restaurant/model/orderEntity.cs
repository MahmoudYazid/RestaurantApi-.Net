namespace Restaurant.model
{
    public class orderEntity
    {
        public int id { get; set; }
        public List<menuItemEntity> order { get; set; }
        public int Price { get; set; }
        public Person orderOwner { get; set; }
        public DateTime DateTime { get; set; }




    }
}
