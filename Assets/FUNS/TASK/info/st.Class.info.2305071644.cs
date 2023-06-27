//empty
//empty
//получить информацию о классе
namespace LIB.st2305071644
{
    /// <summary>
    /// stClass_info
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// КонвертированиеТипа
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static public System.Type fun230507164400(this string s)
        {
            var i = s.IndexOf("(");
            if (i != -1)
            {
                s = s.Substring(i + 1);
                i = s.IndexOf(")");
                s = s.Substring(0, i);
            }
            return System.Type.GetType(s);
        }
        /// <summary>
        /// PRODUCT
        /// </summary>
        /// <param name="тип"></param>
        /// <returns></returns>
        static public string fun230507164401(this System.Type тип) => (string)тип.GetField("PRODUCT").GetValue(null);
        /// <summary>
        /// Теги
        /// </summary>
        /// <param name="тип"></param>
        /// <returns></returns>
        static public string fun230507164402(this string тип) => fun230507164401(fun230507164400(тип));
        /// <summary>
        /// Информация
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static public string fun230507164403(this string s)
        {
            var тип = fun230507164400(s);
            return (string)тип.GetField("INFO").GetValue(null) + "\n" + fun230507164401(fun230507164400(s));
        }
        ///exit
    }
}
