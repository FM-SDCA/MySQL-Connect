using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_Connect
{
    public partial class Form1 : Form
    {
        MySQL_control mysql;

        public Form1()
        {
            InitializeComponent();

            var userid = "picklog";
            var password = "picklog";
            var database = "picklog_db";
            var Host = "127.0.0.1";
            var tablename = "log_tbl";

            // MySQL操作ライブラリのインスタンス、ログイン情報付与
            mysql = new MySQL_control(userid, password, database, Host, tablename);

            // 指定したパラメータのMySQLサーバーへ接続
            mysql.connectServer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // データ表示
            dataGridView1.DataSource = mysql.get_DataTable();
        }
    }
}
