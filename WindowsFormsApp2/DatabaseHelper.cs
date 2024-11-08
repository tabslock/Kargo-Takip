using System;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static readonly string connectionString =
        @"Data Source=localhost\SQLEXPRESS;Initial Catalog=KargoTakipDB;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
