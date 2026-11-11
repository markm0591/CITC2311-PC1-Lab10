namespace CITC2311_PC1_Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Incident> incidentList = IncidentDB.GetIncidents();
            List<Technician> technicianList = TechnicianDB.GetTechnicians();

            var closedIncidents = from incident in incidentList
                                  join tech in technicianList
                                  on incident.TechID equals (int?)tech.TechID
                                  where incident.DateClosed != null
                                  orderby tech.Name, incident.DateOpened
                                  select new
                                  {
                                      tech.Name,
                                      incident.ProductCode,
                                      incident.DateOpened,
                                      incident.DateClosed,
                                      incident.Title
                                  };

            IncidentsListBx.Items.Add("Technician".PadRight(15) + "Product".PadRight(10) +
                "Date Opened".PadRight(13) + "Date Closed".PadRight(13) + "Title");

            string lastName = "";
            foreach (var incident in closedIncidents)
            {
                string name = "";
                if (incident.Name != lastName)
                {
                    name = incident.Name;
                    lastName = incident.Name;
                }

                IncidentsListBx.Items.Add(name.PadRight(15) +
                    incident.ProductCode.Trim().PadRight(10) +
                    incident.DateOpened.ToShortDateString().PadRight(13) +
                    incident.DateClosed?.ToShortDateString().PadRight(13) +
                    incident.Title);
            }
        }
    }
}
