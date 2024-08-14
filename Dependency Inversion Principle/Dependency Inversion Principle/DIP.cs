namespace Dependency_Inversion_Principle
{
    public interface IDataAccessLayer
    {
        void SaveData(string data);
    }

    public class SqlDataAccessLayer : IDataAccessLayer
    {
        public void SaveData(string data)
        {

            Console.WriteLine("Data is saved in SQL archives.");
        }
    }

    public class FileDataAccessLayer : IDataAccessLayer
    {
        public void SaveData(string data)
        {
            Console.WriteLine("Data saved to file.");
        }
    }

    public class DataManager
    {
        private readonly IDataAccessLayer dataAccessLayer;

        public DataManager(IDataAccessLayer dataAccessLayer)
        {
            this.dataAccessLayer = dataAccessLayer;
        }

        public void SaveData(string data)
        {
            this.dataAccessLayer.SaveData(data);
        }
    }
}
