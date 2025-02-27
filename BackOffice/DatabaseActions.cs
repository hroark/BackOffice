using Microsoft.Data.SqlClient;
using System.Data;

namespace BackOffice
{
    public static class DatabaseActions
    {
        internal static string connectionString = "Data Source=19-001257\\SQLEXPRESS;Initial Catalog=BackOffice;Trusted_Connection=True;";

        public static DataTable ExecuteProcedure(string procName, Dictionary<string, string> parameters)
        {
            DataTable _result = new DataTable();
            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                using (SqlCommand _cmd = new SqlCommand(procName, _conn))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, string> _param in parameters)
                        {
                            _cmd.Parameters.AddWithValue(_param.Key, _param.Value);
                        }
                    }
                    _conn.Open();
                    _result.Load(_cmd.ExecuteReader());
                }
            }
            return _result;
        }
    }
}
