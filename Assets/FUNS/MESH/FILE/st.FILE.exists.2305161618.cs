//empty
//stFILE_exists
//проверка на сохранение меша Bo52_0403202112543953.STAT.FILE.
namespace LIB.st2305161618
{
    /// <summary>
    /// Проверка
    /// файл сохранен?
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// Сохранён
        /// </summary>
        /// <param name="asset"></param>
        /// <returns></returns>
        static public bool fun230516161800(string asset) => (asset != "" && System.IO.File.Exists(asset) == true);
        ///exit
    }
}
