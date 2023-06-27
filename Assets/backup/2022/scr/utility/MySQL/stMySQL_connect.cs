namespace scr2022
{
    /// <summary>
    /// CONNECT
    /// соединение с базой данных
    /// </summary>
    static public class stMySQL_connect
    {
        static MySql.Data.MySqlClient.MySqlConnection CONN;
        static string pathSql = "server=127.0.0.1;user id=mysql;database=adventure;port=3306;password=mysql;charset=utf8;pooling=false;";
        static public void connect(bool кнопка)
        {
            if (кнопка)
            {
                if (CONN == null || CONN.State != System.Data.ConnectionState.Open)
                {
                    if (stButton_gui.кнопка("MySQL", 50) == false)
                        return;
                }
                else
                if (close(кнопка)) 
                    return;
            }

            CONN = new MySql.Data.MySqlClient.MySqlConnection(pathSql);
            CONN.Open();
        }
        static public bool close(bool кнопка)
        {
            if (кнопка)
            if (stButton_gui.кнопка("выйти из MySQL", 110)==false)
                return false;
            CONN.Close();
            return true;
        }
    }
}