//empty
//empty
//собрать регион
using System.Collections.Generic;
using UnityEngine;
namespace LIB.st2305211735
{
    /// <summary>
    /// public interface IRegion10_build : IRegion10_bs
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// ѕостроить«емлю
        /// </summary>
        static public void fun230521173500()
        {

        }
        /// <summary>
        /// «аполнить–егионЅлоками
        /// </summary>
        /// <param name="—уществует¬ершина"></param>
        static public void fun230521173501(this cs2305211723.IClass Reg, bool —уществует¬ершина)
        {
            var R = cs2305211723.IClass.R/*число блоков по оси*/;
            for (var x = 0; x < R; x++)
                for (var y = 0; y < R; y++)
                    for (var z = 0; z < R; z++)
                    {
                        var координата = new Vector3(x, y, z);
                        var id = Reg. оординатаЅлока(координата);
                        var Ёто¬ершина = —уществует¬ершина ? (y == R - 1) : false;
                        var ћодельЅлока = (byte)(Ёто¬ершина ? 51 : 255);
                        fun230521173502/*ƒобавитьЅлок¬—ловарь*/(Reg,id, координата, ћодельЅлока);
                    }
        }
        /// <summary>
        /// ѕостроитьЅлок
        /// </summary>
        /// <param name="Reg"></param>
        /// <param name="id"></param>
        /// <param name="координата"></param>
        /// <param name=" одЅлока"></param>
        /// <returns></returns>
        static public byte fun230521173502(this cs2305211723.IClass Reg, uint id, Vector3 координата, byte  одЅлока)
        {
            var b = Reg.—уществуетЅлок(id);
            //ƒобавить код блока
            if (!b) Reg.Ѕлоки–егиона.Add(id,  одЅлока);
            return Reg.Ѕлоки–егиона[id];
        }
        /// <summary>
        /// —обрать
        /// </summary>
        /// <param name="Reg"></param>
        static public void fun230521173503(this cs2305211723.IClass Reg)
        {
            if (Reg.Ѕлоки–егиона.Count == 0) return;
            //spBuild.IVertices.–ед оординатаЅлока = stRegion_curr.“ек¬ектор;

            var ms = new List<Mesh>();
            foreach (var b in Reg.Ѕлоки–егиона)
            {
                ms.Add(st2305161619.Class.fun230516161902("block" + b.Value.ToString()));
            }
            var mesh = st2305072045.Class.fun230507204503(ms);
            st2305072046.Class.fun230507204600_ѕрив€затьћеш ќбъекту(mesh,(Reg as MonoBehaviour).gameObject);
        }
    }
}
