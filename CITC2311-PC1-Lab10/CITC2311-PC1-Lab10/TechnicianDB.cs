namespace CITC2311_PC1_Lab10
{
    public static class TechnicianDB
    {
        private const string Dir = @"..\..\..\";
        private const string Path = Dir + "Technicians.txt";

        public static List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new List<Technician>();

            using (StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.Open, FileAccess.Read)))
            {
                while (textIn.Peek() != -1)
                {
                    string? row = textIn.ReadLine();
                    if (row == null || row == "")
                    {
                        continue;
                    }

                    string[] columns = row.Split('|');
                    Technician technician = new Technician();
                    technician.TechID = Convert.ToInt32(columns[0]);
                    technician.Name = columns[1].Trim();
                    technicians.Add(technician);
                }
            }

            return technicians;
        }
    }
}
