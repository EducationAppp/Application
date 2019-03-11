using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//「プロジェクト」タブ→「参照の追加」
//アセンブリ：フレームワーク内にある「System.Configuration」にチェックを入れる
using System.Configuration;

//↓SqlConnectionクラスを使用するため
using System.Data.SqlClient;

//↓DataTableクラスを使用するため
using System.Data;


namespace ApplicationEducation
{
    class DatabaseAcceser
    {       
       

        public void ConnectStringGetter() { }

        public DataTable DatabaseConnecter()
        {
            // 接続文字列の取得
            var connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;

            using (var connection = new SqlConnection(connectionString)) 
            using (var command = connection.CreateCommand()) {
                try
                {
                    var table = new DataTable();

                    // データベースの接続開始
                    connection.Open();
                    command.CommandText = @"use Education SELECT * FROM ItemMaster";

                    // SQLの実行
                    //DataAdapter…SQLを実行し結果をDataSetやDataTableに格納します。
                    //DataSet…SELECT文の結果を格納します。
                    //Fill()でOpen/Closeを自動で行ってくれる
                    //(DataReaderを使用したときはOpen()、Close()を呼び出していたが不要)
                    //DataTableが保持している値が変更されるだけで実際のデータベースの値が変更されるわけではありません。
                    // http://okwakatta.net/code/ado06.html
                    // http://rucio.a.la9.jp/main/VBdotNet/Database/Database4.htm
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);

                    return table;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
            }
            
        }
    }
}
