//empty
//empty
//stSerillization.StreamWriter
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace LIB.st2305221142
{
    /// <summary>
    /// stSerillization.StreamWriter
    /// StreamWriter
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// ТекстовыйФайл
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string fun230522114200(string path)=>Application.dataPath + "/Resources/text/" + path + ".ncs";
        /// <summary>
        /// СОХРАНИТЬ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="LS"></param>
        /// <param name="f"></param>
        static public void fun230522114201<T>(string path, List<T> LS,System.Func<T,string>f)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fun230522114200(path));
            foreach (var s in LS)
                sw.WriteLine(f(s));
            sw.Close();
        }
        /// <summary>
        /// СОХРАНИТЬ
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="path"></param>
        /// <param name="LS"></param>
        /// <param name="fun"></param>
        static public void fun230522114202<T1,T2>(string path, Dictionary<T1, T2> LS, System.Func<T1,T2, string> fun)
        {
            if (LS.Count == 0)
                return;
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fun230522114200(path));
            foreach (var s in LS)
                sw.WriteLine(fun(s.Key,s.Value));

            sw.Close();
        }
        /// <summary>
        /// ЗАГРУЗИТЬ
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fun"></param>
        /// <returns></returns>
        static public bool fun230522114203(string path, System.Action<string> fun)
        {
            var f = fun230522114200(path);
            if (File.Exists(f) == false)
                return false;
            string line = "";
            using (StreamReader sr = new StreamReader(f))
            {
                while ((line = sr.ReadLine()) != null)
                    fun(line);
            }
            return true;
        }
        /// <summary>
        /// СОХРАНИТЬ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="LS"></param>
        static public void fun230522114204<T>(string path,List<T>LS)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fun230522114200(path));
            foreach (var s in LS)
                sw.WriteLine(s.ToString());
            sw.Close();
        }
        /// <summary>
        /// ЗАГРУЗИТЬ
        /// </summary>
        /// <param name="path"></param>
        /// <param name="DELEGATE"></param>
        /// <param name="кнопка"></param>
        /// <param name="delimeter"></param>
        /// <returns></returns>
        static public bool fun230522114205(string path, System.Action<string[]> DELEGATE, bool кнопка = false, char delimeter = ' ')
        {
            if (!stButton_gui.кнопка(кнопка,"LOAD"))
                return false;

            var f= fun230522114200(path);
            if (System.IO.File.Exists(f) == false)
                return false;

            string[] rows = System.IO.File.ReadAllLines(f);
            for (int i = 0; i < rows.Length; i++)
                DELEGATE(rows[i].Split(delimeter));
            return true;
        }
    }
}
