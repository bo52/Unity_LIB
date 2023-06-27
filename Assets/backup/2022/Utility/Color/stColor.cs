using UnityEngine;

namespace utility2022
{
    /// <summary>
    /// Color
    /// используемые цвета
    /// </summary>
    static public class stColor
    {
        static public string INFO = "÷¬≈“";
        static public Color  ќ–»„Ќ≈¬џ… = new Color(0.85f, 0.7f, 0.4f);
        static public float «начениеяркости = 1.0f;
        /// <summary>
        /// яркость
        /// изменить €ркость цвета
        /// </summary>
        /// <param name="c"></param>
        /// <param name="изменить"></param>
        /// <returns></returns>
        static public float яркость(this ref Color c, sbyte изменить)
        {
            float h, s, dv;
            Color.RGBToHSV(c, out h, out s, out dv);
            if (изменить != 0)
            {
                «начениеяркости = изменить < 0 ? «начениеяркости - 0.01f : «начениеяркости + 0.01f;
                if («начениеяркости < 0) «начениеяркости = 0.01f;
                if («начениеяркости > 1) «начениеяркости = 1.0f;
            }
            c = Color.HSVToRGB(h, s, «начениеяркости);
            return «начениеяркости;
        }
    }
}