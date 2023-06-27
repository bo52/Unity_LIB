//empty
//empty
//имя типа по шаблону bo52.group.section.id
/// <summary>
/// stExample.struct
/// </summary>
namespace LIB.cs2305071641
{
    /// <summary>
    /// stExample.struct
    /// </summary>
    struct Class
    {
        public string group;
        public string section;
        public string id;
        public Class(object obj)
        {
            var ПолныйТип = obj.GetType().ToString();
            var rows = ПолныйТип.Split('.');
            id = rows[0].Substring(rows[0].IndexOf("_") + 1);
            if (rows.Length == 2)
            {
                group = rows[1];
                section = rows[1];
            }
            else
            {
                group = rows[1];
                section = rows[2];
            }
        }
        public string ID(byte key = 0)
        {
            switch (key)
            {
                case 0: return "Bo52_" + id + "." + group + "." + section + "_" + id;
                case 1: return "Bo52_" + id + "." + group + "_" + id;
            }
            return "";
        }
    }
}