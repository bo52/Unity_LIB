//empty
//empty
//работа со свойством у экземпляра
namespace LIB.st2305071642
{
    /// <summary>
    /// СВ
    /// stExample.prop
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// СВ
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public object fun230507164200(this object obj, string name) => obj.GetType().GetProperty(name).GetValue(obj);
        ///exit
    }
}