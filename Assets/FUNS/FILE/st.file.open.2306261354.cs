//fun.FILE.ОткрытьФайл
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306261354
{
    /// <summary>
    ///ОткрытьФайл
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        ///ОткрытьФайл
        /// </summary>
        static public void fun230626135400_ОткрытьФайл(this string commandText)
        {
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
        ///exit
    }
}
