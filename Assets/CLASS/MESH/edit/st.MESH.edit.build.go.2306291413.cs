﻿//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306291413
{
    /// <summary>
    ///
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// Построить МЕШ по функции и привязать к GO
        /// </summary>
        static public void fun230629141300_ПостроитьИПривязать(System.Action<cs2305141215.IClass> ФункцияПостройки,GameObject go)
        {
            var param_build = new cs2307031203_ПараметрыПостройки.Struct(ФункцияПостройки);
            cs2305141208.IClass edit = new cs2306291123.Class(go, param_build);
            edit.Закрыть();
        }
        ///exit
    }
}
