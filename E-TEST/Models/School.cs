namespace E_TEST.Models
{
    public class School
    {
        public int id { get; set; }
        public int organization_id { get; set; }
        public int company_id { get; set; }
        public int region_id { get; set; }
        public string branch_name_kir { get; set; }
        public string branch_name_lat { get; set; }
        public string branch_name_ru { get; set; }
        public string? address { get; set; }
        public string short_name_lat { get; set; }
        public string short_name_kir { get; set; }
        public string short_name_ru { get; set; }
    }
}
