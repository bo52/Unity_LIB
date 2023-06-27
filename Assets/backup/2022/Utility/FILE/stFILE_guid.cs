//Bo52_17022021125527741.SYS.FILE.
namespace utility2022
{
    using UnityEditor;
    /// <summary>
    /// замена кода в строке произвольного файла
    /// </summary>
    public class stFILE_guid
    {
        static public void ЗаменитьГУИ(string F, string Source, string guid)
        {
            var sw = new System.IO.StreamWriter(F);
            var rows = System.IO.File.ReadAllLines(Source);
            for (var i = 0; i < rows.Length; i++)
            {
                sw.WriteLine(rows[i].IndexOf("#bo52#")==-1 ? rows[i]: "m_Script: { fileID: 11500000, guid: " + guid + ", type: 3}");
            }
            sw.Close();
            AssetDatabase.Refresh();
        }
    }
}
