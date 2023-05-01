namespace E_TEST.Models
{
    public class Region
    {
        public int id { get; set; }
        public int? parent_id { get; set; }
        public string region_kir { get; set; }
        public string region_lat { get; set; }
        public string region_rus { get; set; }
    }
}
