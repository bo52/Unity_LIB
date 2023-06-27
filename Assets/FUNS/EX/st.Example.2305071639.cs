//class2022
//class2022.ex
//экземпляр класса
using UnityEngine;
namespace LIB.st2305071639
{
    /// <summary>
    /// stExample
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// GetObject
        /// создание обстрактного экземпляра
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        /// <returns></returns>
        static public T fun230507163900<T>(params object[] args) => (T)System.Activator.CreateInstance(typeof(T), args);
        /// <summary>
        /// МоноМодуль
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <returns></returns>
        static public T fun230507163901<T>(this object ex) => ex.ИгровойОбъект().GetComponent<T>();
        /// <summary>
        /// ПолноеИмяТипа
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <returns></returns>
        static public string fun230507163902<T>(this T ex) => new stExample_struct(ex).ID(1);
        /// <summary>
        /// ИгровойОбъект
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <returns></returns>
        static public GameObject fun230507163903<T>(this T ex) => (GameObject)ex.GetType().GetField("GO").GetValue(ex);
        /// <summary>
        /// ПутьКФайлу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <returns></returns>
        static public string fun230507163904<T>(this T ex)
        {
            //Module mod = typeof(Simple).Assembly.GetModules () [0];
            return ex.GetType().Assembly.Location;
            // получаем имя вызываемого метода
            //return this.GetType().FullName;
        }
        ///exit
    }
}