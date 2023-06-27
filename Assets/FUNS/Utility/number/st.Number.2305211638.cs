using UnityEngine;
namespace LIB.st2305211638
{
    /// <summary>
    /// ЧИСЛО
    /// stNumber
    /// Уникальный
    /// </summary>
    static public class CLASS
    {
        /// <summary>
        /// Уникальный
        /// </summary>
        /// <returns></returns>
        static public string fun230521163800()
        {
            string s = System.DateTime.Now.ToString();
            s = s.Replace(":", "");
            //s = s.Replace(" ", "");
            s = s.Replace("/", "");
            s = s.Replace("PM", "");
            s = s.Replace("AM", "");
            s = s.Replace(" ", "");
            s = s.Replace(".", "");
            return s + Random.Range(0, 1000);
        }
    }
}