namespace LeMedicine.Helpers
{
    public class SQLiteBase
    {
        private string pathDB;
        public SQLiteConnection connection;
        public SQLiteBase()
        {
            pathDB = FileAccessHelper.GetPathFile("LeMedicine.s3db");
            if (connection != null) return;
            connection = new SQLiteConnection(pathDB);
            connection.CreateTable<PatientModel>();
            connection.CreateTable<ProfessionalModel>();
        }
    }
}
