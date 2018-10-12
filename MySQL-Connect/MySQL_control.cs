using System;
using MySql.Data.MySqlClient;
using System.Data;

public class MySQL_control
{
    string userid;
    string password;
    string database;
    string Host;
    string tablename;
    MySqlConnection conn;

    public MySQL_control(string userid, string password, string database, string Host, string tablename)
	{
        this.userid = userid;
        this.password = password;
        this.database = database;
        this.Host = Host;
        this.tablename = tablename;
    }
    string conststr = "userid=picklog; password=picklog; database=picklog_db; Host=127.0.0.1";

    public bool connectServer()
    {
        var message = "userid=" + userid + "; password=" + password + "; database=" + database + "; Host=" + Host;
        try
        {
            conn = new MySqlConnection(message);
            conn.Open();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public DataTable get_DataTable()
    {
        var dt = new DataTable();
        
        // SQL文と接続情報を指定し、データアダプタを作成
        var da = new MySqlDataAdapter("select * from " + this.tablename, conn);
        da.Fill(dt);
        return dt;
    }

    public string[][] get_by2DArray()
    {
        var dt = new DataTable();
        var da = new MySqlDataAdapter("select * from" + this.tablename, conn);
        da.Fill(dt);
        List<DataRow> list = new List<DataRow>();



        string[,] array2d = new string[dt.Rows.Count, dt.Columns.Count];

        for(int i = 0; i < dt.Rows.Count; i++)
        {
            for(int j = 0; j < dt.Rows.Count; j++)
            {
                array2d[i,j] = dt.Rows.IndexOf[]
            }

        }
    }
}
