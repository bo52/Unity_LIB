//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306271146
{
    /// <summary>
    ///
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        public Vector3 v0;
        public cs2306271320.Class hlw;
        public byte R;
        public Class(byte R, cs2306271320.Class hlw, Vector3 v0)
        {
            this.R = R;
            this.v0 = v0;
            this.hlw = hlw;
        }
        private bool СуществуетВершина(Vector3 v)
        {
            if (v.x < v0.x || v.x > v0.x + hlw.Длинна) return false;
            if (v.y < v0.y || v.y > v0.y + hlw.Высота) return false;
            if (v.z < v0.z || v.z > v0.z + hlw.Ширина) return false;
            return true;
        }
        //собрать
        public void СобратьЧанк(GameObject go, bool Сохранить = false)
        {
            Vector3 v;
            byte code;
            var edit = new cs2305141202.Class(go);
            for (var x = 0; x <= R; x++)
                for (var y = 0; y <= R; y++)
                    for (var z = 0; z <= R; z++)
                    {
                        //получитьКод
                        v = new Vector3(x, y, z);
                        code = st2306271209.Class.fun230627120900_СформироватьКодБлока(v, СуществуетВершина);
                        edit.ИзменитьТекущийБлокИПостроить(new cs2306262134.Class(v, code));
                    }
            if (Сохранить)
                st2305161716.Class.fun230516171605_СохранитьМешПоИмениОтРедактора(edit, hlw.ИмяЧанка, hlw.PATH + "/");
            else st2305072046.Class.fun230507204601_ПривязатьМешОтРедактора(edit);
        }
    }
}
