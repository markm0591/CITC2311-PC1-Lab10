namespace CITC2311_PC1_Lab10
{
    public class Incident
    {
        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public string ProductCode { get; set; } = "";
        public int? TechID { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
    }
}
