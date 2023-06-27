using UnityEditor;
using UnityEngine;
namespace utility2022
{
    /// <summary>
    /// GUI управление цветом
    /// </summary>
    static public class stColor_ins
    {
        static public string INFO = "”ѕ–ј¬Ћ≈Ќ»≈";
        static public sbyte –јƒ»”— = 1;
        static public Color matColor = stColor. ќ–»„Ќ≈¬џ…;
        static public bool drawing;
        static public bool ÷вет(this ref Color с)
        {
            Color new_color = EditorGUILayout.ColorField(с);
            if (new_color != с)
            {
                с = new_color;
                return true;
            }
            return false;
        }
        static public void —÷≈Ќј_ нопки”правлени€÷ветом(ref Color c)
        {
            if (!drawing)
                return;
            if (Event.current.keyCode == KeyCode.F1)
                stColor.яркость(ref c, -1);
            if (Event.current.keyCode == KeyCode.F2)
                stColor.яркость(ref c, 1);

            if (Event.current.keyCode == KeyCode.F3)
                –јƒ»”—++;
            if (Event.current.keyCode == KeyCode.G)
            {
                c = Color.green;
                stColor.яркость(ref c, 0);
            }

            if (Event.current.keyCode == KeyCode.Keypad1)
            {
                c = Color.red;
                stColor.яркость(ref c, 0);
            }

            if (Event.current.keyCode == KeyCode.F4)
                –јƒ»”—--;

            if (Event.current.keyCode == KeyCode.B)
            {
                c = Color.blue;
                stColor.яркость(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.Y)
            {
                c = Color.yellow;
                stColor.яркость(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.K)
            {
                c = stColor. ќ–»„Ќ≈¬џ…;
                stColor.яркость(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.C)
            {
                c = Color.cyan;
                stColor.яркость(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.Keypad0)
            {
                c = Color.gray;
                stColor.яркость(ref c, 0);
            }
        }

        static public bool »Ќ—ѕ≈ “ќ–_÷вета() => ÷вета(ref matColor, ref drawing);
        static public bool ÷вета(ref Color c, ref bool drawing)
        {
            if (!drawing)
            {
                return false;
                //Bo52_30122020123429952.REGION.ќбновитьћатериал();
            }

            c = EditorGUILayout.ColorField("New Color", c);
            var old_c = c;
            //€ркость
            var new_v = stColor.«начениеяркости;
            if (new_v != stColor.«начениеяркости)
            {
                stColor.яркость(ref c, 0);
                stColor.«начениеяркости = new_v;
            }

            stSlider_gui.ползунок(ref –јƒ»”—, 0, 100);
            GUILayout.BeginHorizontal();
            GUI.color = Color.black;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = Color.gray;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = Color.green;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = Color.blue;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = Color.cyan;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = Color.yellow;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = Color.magenta;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = Color.red;
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            GUI.color = new Color(0.85f, 0.7f, 0.4f);
            if (stButton_gui.кнопка("", 50))
                c = GUI.color;
            if (old_c != c)
                stColor.яркость(ref c, 0);

            GUI.color = Color.white;
            GUILayout.EndHorizontal();
            return true;
        }
    }
}
