namespace IT_Lab1;

class DataBase
{
    public string dbName;
    public List<Table> dbTablesList;

    public DataBase(string dbname)
    {
        dbName = dbname;
        dbTablesList = new List<Table>();
    }
}