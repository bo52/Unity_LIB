//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.st2305221410
{
    /// <summary>
    /// stCube_build_start
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// X
        /// стартовые координаты
        /// </summary>
        static private int field230522141000 = 0;
        /// <summary>
        /// Y
        /// </summary>
        static private int field230522141001 = 0;
        /// <summary>
        /// Z
        /// </summary>
        static private int field230522141002 = 0;
        /// <summary>
        /// W
        /// </summary>
        static private byte field230522141003 = 0;
        /// <summary>
        /// H
        /// </summary>
        static private byte field230522141004 = 0;
        /// <summary>
        /// ЭтоБазовыйБлок
        /// </summary>
        /// <param name="build"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        static public bool fun230522141005(this cs2305221415.IClass build, int x, int y, int z = 0) => build.mb.СобранныеТочки.GetPixel(x, y, z).a == 1.0f;
        /// <summary>
        /// Добавить
        /// </summary>
        /// <param name="build"></param>
        static public void fun230522141006(this cs2305221415.IClass build)
        {
            var part = build.Части.Find((x) => {
                var v0 = x.Начало;
                return x.Высота == field230522141004/*H*/ && x.Длинна == field230522141003/*W*/ && v0.x == field230522141000/*X*/ && v0.y == field230522141001/*Y*/ && v0.z + x.Ширина == field230522141002/*Z*/;
            });
            if (part == null)
                build.Части.Add(new cs2305221354.Class(new Vector3Int(field230522141000/*X*/, field230522141001/*Y*/, field230522141002/*Z*/), field230522141004/*H*/, field230522141003/*W*/));
            else
                part.Ширина += 1;

        }
        /// <summary>
        /// ОпределитьДлину
        /// </summary>
        /// <param name="build"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        static public byte fun230522141007(cs2305221415.IClass build, int z)
        {
            byte w = 1;
            field230522141004 = 1;
            var x = field230522141000 + 1;
            var MAX = st2305221401.Class.field230522140100;
            while (x < MAX)
            {
                if (build.ЦИКЛ[x, field230522141001, z]) break;
                build.ЦИКЛ[x, field230522141001, z] = true;
                if (!fun230522141005(build,x, field230522141001, z))
                    break;
                w += 1;

                x += 1;
            }
            return w;
        }
        /// <summary>
        /// ОпределитьВысоту
        /// </summary>
        /// <param name="build"></param>
        /// <returns></returns>
        static public byte fun230522141008(cs2305221415.IClass build)
        {
            var y = field230522141001/*Y*/ + 1;
            byte h = 1;
            var MAX = st2305221401.Class.field230522140100;
            while (y < MAX)
            {
                var x = field230522141000;
                while (x < field230522141000 + field230522141003)
                {
                    if (build.ЦИКЛ[x, y, field230522141002/*Z*/]) return h;
                    build.ЦИКЛ[x, y, field230522141002/*Z*/] = true;
                    if (!fun230522141005(build,x, y, field230522141002))
                        return h;
                    x += 1;
                }
                h += 1;
                y += 1;
            }
            return h;
        }
        /// <summary>
        /// ОпределитьНачало
        /// </summary>
        /// <param name="build"></param>
        static public void fun230522141009(this cs2305221415.IClass build)
        {
            var MAX = st2305221401.Class.field230522140100;
            while (field230522141001/*Y*/ < MAX)
            {
                field230522141000/*X*/ = 0;
                while (field230522141000/*X*/ < MAX)
                {
                    if (!build.ЦИКЛ[field230522141000/*X*/, field230522141001/*Y*/, field230522141002/*Z*/])
                    {
                        build.ЦИКЛ[field230522141000/*X*/, field230522141001/*Y*/, field230522141002/*Z*/] = true;
                        if (fun230522141005/*pixel.a==1*/(build, field230522141000/*X*/, field230522141001/*Y*/, field230522141002/*Z*/))
                        {
                            field230522141003/*W*/ = fun230522141007/*ОпределитьДлинну*/(build, field230522141002/*Z*/);
                            field230522141004/*H*/ = fun230522141008/*ОпределитьВысоту*/(build);
                            fun230522141006(build);
                            //X += W;                               
                            return;
                        }
                    }
                    field230522141000/*X*/ += 1;
                }
                field230522141001/*Y*/ += 1;
            }
        }
        /// <summary>
        /// Обойти
        /// </summary>
        /// <param name="build"></param>
        static public void fun230522141010(this cs2305221415.IClass build)
        {
            build.Части.Clear();
            field230522141002 = 0;
            var MAX = st2305221401.Class.field230522140100;
            while (field230522141002/*Z*/ < MAX)
            {
                field230522141001/*Y*/ = 0;
                while (field230522141001/*Y*/ < MAX)
                {
                    field230522141000/*X*/ = 0;
                    while (field230522141000/*X*/ < MAX)
                    {
                        if (!build.ЦИКЛ[field230522141000/*X*/, field230522141001/*Y*/, field230522141002/*Z*/])
                            fun230522141009/*ОпределитьНачало*/(build);
                        field230522141000/*X*/++;
                    }
                    field230522141001/*Y*/++;
                }
                field230522141002/*Z*/++;
            }
        }
        /// <summary>
        /// Показать
        /// </summary>
        /// <param name="mb"></param>
        /// <param name="z"></param>
        static public void fun230522141011(this go2305221347.IInspector mb, byte z)
        {
            var MAX = st2305221401.Class.field230522140100;
            for (var y = MAX - 1; y >= 0; y--)
            {
                GUILayout.BeginHorizontal(new GUILayoutOption[] { GUILayout.Width(18) });
                for (var x = 0; x < MAX; x++)
                {
                    GUILayout.BeginVertical();
                    GUILayout.BeginHorizontal(new GUILayoutOption[] { GUILayout.Width(10) });
                    var val = mb.СобранныеТочки.GetPixel(x, y, z).a == 1.0f;
                    var new_val = EditorGUILayout.Toggle("", val, new GUILayoutOption[] { GUILayout.Width(18) });
                    if (val != new_val)
                    {
                        mb.СобранныеТочки.SetPixel(x, y, z, new_val ? new Color(0, 0, 0, 1) : new Color(0, 0, 0, 0));

                        var edit = new cs2305221415.Class(mb);
                        edit.Собрать(mb.Моно.gameObject);
                    }
                    GUILayout.EndHorizontal();
                    GUILayout.EndVertical();
                }
                GUILayout.EndHorizontal();
            }
        }
        ///exit
    }
}
