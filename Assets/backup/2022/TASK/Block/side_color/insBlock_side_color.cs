//Bo52_1803202111575813.Block.INS.
//Bo52_1803202111575813.Block
namespace task2022
{
    using UnityEditor;
    using UnityEngine;
    /// <summary>
    /// COLOR.SIDE
    /// изменить цвет стороны
    /// </summary>
    public class insBlock_side_color
    {
        static public bool but=false;
        static public byte ТиповойИндекс;
        static public byte ТекущийИндекс = 0;
        static public string[] ТиповыеИмена = { "down","zero", "up" };
        static public Color[] ЦветаСторон = { Color.gray, Color.gray, Color.gray };
        static public GUILayoutOption[] w = new GUILayoutOption[] { GUILayout.Width(55) };
        static public void ИНСПЕКТОР_БЛОК(Vector3Int ВекторБлока)
        {
            stFoldout_gui.Foldout(() => {
                GUILayout.BeginVertical();
                for (byte i = 0; i < ЦветаСторон.Length; i++)
                {
                    GUILayout.BeginHorizontal();
                    var b = ТекущийИндекс == i;
                    if (stBool_gui.ЛОГИЧЕСКИЙ(ref b,"",20))
                        ТекущийИндекс = i;
                    ЦветаСторон[i] = EditorGUILayout.ColorField(ТиповыеИмена[i], ЦветаСторон[i],w);
                    GUILayout.EndHorizontal();
                }
                GUILayout.EndVertical();

            }, "Блок=" + ВекторБлока, ref but);
        }
    }
}
