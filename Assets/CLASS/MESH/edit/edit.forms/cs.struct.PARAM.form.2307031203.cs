//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307031203_ПараметрыПостройки
{
    /// <summary>
    /// ПараметрыПостройки
    /// </summary>
    public struct Struct
    {
        static public string INFO = "INFO";
        public System.Action<cs2305141215.IClass> ФункцияПостройки;
        public byte НомерРедактора;
        public Struct(System.Action<cs2305141215.IClass> ФункцияПостройки, byte НомерРедактора = 1)
        {
            this.ФункцияПостройки = ФункцияПостройки;
            this.НомерРедактора = НомерРедактора;
        }
        public Struct(System.Action<cs2305141215.IClass> ФункцияПостройки, cs2305141208.IClass.Редактор Редактор)
        {
            this.ФункцияПостройки = ФункцияПостройки;
            this.НомерРедактора = (byte)Редактор;
        }
    }
}
