namespace DesignPatterns.FactoryMethod
{
    public class ExecutionFactoryMethod
    {
        public static void Execute()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                                 .CreateConnector("mySqlServerConnStrg")
                                 .Connect();

            sqlCn.ExecuteCommand("select * from sqlTable");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(DataBase.Oracle)
                                    .CreateConnector("myOracleConnStrg")
                                    .Connect();

            oracleCn.ExecuteCommand("select * from sqlOracle");
            oracleCn.Close();
        }
    }
}