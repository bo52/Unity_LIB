/// <summary>
/// вырезать текст
/// </summary>
namespace scr2022
{
    static public class stText_cut
    {
        static public string INFO = "Вырезать";
        static public string ДваждыВырезать(string s)=>Вырезать(ВырезатьПоследний(s));
        static public string Вырезать(string s)
        {
            var i = s.IndexOf('.');
            return i == -1 ? s : s.Substring(i + 1);
        }
        static public string ВырезатьПоследний(string s, string d = "\\")
        {
            var i = s.LastIndexOf(d);
            return i == -1 ? s : s.Substring(i + 1);
        }
        static public string ВырезатьРасширение(string s, string d = ".prefab")
        {
            var i = s.LastIndexOf(d);
            return i == -1 ? s : s.Substring(0,i);
        }
    }
}
