//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306232108
{
    /// <summary>
    /// Универсально вычислить вершину соседнего блока
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// количество возможных расположений вершин куба
        /// </summary>
        static public readonly uint[] field230623210801 = new uint[2] { byte.MaxValue, 134217727 };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="КОД">число</param>
        /// <param name="n">2^n номер вершины</param>
        /// <param name="уровень"></param>
        /// <returns></returns>
        static public bool fun230623210800(uint КОД,byte n,byte уровень=1)
        {
            switch (n)
            {
                case 0: return КОД % 2 != 0;
                case 26: return КОД >= 67108864;
                default:
                    var min = (uint)((float)(КОД) / 2);
                    return false;
            }
            var pow = Mathf.Pow(2, n);
            var next = pow - 1;
            var pow2 = 2 * pow;
            if (fun230623210802(КОД, ref pow))
                return true;
            while (pow < field230623210801[уровень])
                if (fun230623210802(КОД, ref pow))
                    return true;
            return false;
        }
        static public bool fun230623210802(uint КОД, ref float pow)
        {       
            if (КОД >= pow && КОД < 2*pow) return true;
            pow += pow2;
            return false;
        }
        /// <summary>
        /// код не чётный
        /// ПервыйИндексКодаСуществует
        /// </summary>
        /// <param name="КОД"></param>
        /// <returns></returns>
        static public bool fun230623210803(this uint КОД) => (КОД % 2) != 0;
        ///exit
    }
}
