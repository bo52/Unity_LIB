//Bo52_01122020125806355.FUN.
namespace task2022
{
    using UnityEngine;
    using MySql.Data;
    using MySql.Data.MySqlClient;
    static public class stTexture2d_mysql_blob
    {
        //static string pathSql = "host=127.0.0.1;port=3306;Uid=mysql;password=mysql;database=adventure;CharSet=UTF8;";
        static string pathSql = "server=127.0.0.1;user id=mysql;database=adventure;port=3306;password=mysql;charset=utf8;pooling=false;";
        static public void СохранитьПустуюТектсуру(MySqlConnection con)
        {
            Texture2D empty = new Texture2D(128, 128);
            byte[] bt_empty = empty.EncodeToPNG();
            string sql = "INSERT INTO `b_forms` (`m0`) VALUES('" + bt_empty + "');";
            //Debug.Log(cmd.ExecuteScalar());

            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.Add("@empty", MySqlDbType.Blob).Value = bt_empty;
                cmd.ExecuteNonQuery();
            }
        }

        static public void ЗаменитьТекстуру(MySqlConnection con, int id)
        {
            Texture2D tex = new Texture2D(128, 128, TextureFormat.ARGB32, false);
            for (var x=0; x < tex.width; x++)
                for (var y = 0; y < tex.height; y++)
                {
                    tex.SetPixel(x, y, new Color(0,0,0,1));
                }
            Color color1 = Color.HSVToRGB(1, 0, 0);
            Color color2 = Color.HSVToRGB(0, 1, 0);
            tex.SetPixel(0, 0, Color.red);
            tex.SetPixel(1, 1, Color.green);
            tex.Apply();

            byte[] bt_tex = tex.EncodeToPNG();

            string sql = "UPDATE `b_forms` SET `m0`=@tex WHERE (id="+id+");";
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.Add("@tex", MySqlDbType.Blob).Value = bt_tex;
                cmd.ExecuteNonQuery();
            }
        }

        static public void ПолучитьТектсуру(MySqlConnection con, int id)
        {
            Texture2D tex = new Texture2D(128, 128, TextureFormat.ARGB32, false);
            Debug.Log(tex.GetPixel(0, 0));
            Debug.Log(tex.GetPixel(1, 0));
            Debug.Log(tex.GetPixel(1, 1));

            string sql = "SELECT*FROM `b_forms` WHERE (id=" + id + ");";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = con;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var bytes = (byte[])reader["m0"];
                tex.LoadImage(bytes);
            }
            Debug.Log(tex.GetPixel(0, 0));
            Debug.Log(tex.GetPixel(1, 0));
            Debug.Log(tex.GetPixel(1, 1));
        }

        static public void test()
        {
            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(pathSql);
            con.Open();
            ПолучитьТектсуру(con,1);
            //ЗаменитьТекстуру(con, 1);
            con.Close();
        }
    }
}
