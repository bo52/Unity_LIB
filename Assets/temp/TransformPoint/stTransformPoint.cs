//Bo52_16032021918209.INS.TransformPoint.
namespace utility2022
{
    using UnityEditor;
    using UnityEngine;
    namespace Backup {
        static public class stTransformPoint
        {
            static public string INFO = "INSPECTOR";
            static public string PRODUCT = "инспектор по управлению точек Блоков";
            /// <summary>
            /// управляющий элемент
            /// </summary>
            static public Transform handleTransform;
            /// <summary>
            /// угол управляющего элемента
            /// </summary>
            static public Quaternion handleRotation = Quaternion.identity;
            /// <summary>
            /// 
            /// </summary>
            static public float radius = 0.02f;
            /// <summary>
            /// 
            /// </summary>
            static public float pull = 0.3f;
            /// <summary>
            /// 
            /// </summary>
            static public float handleSize = 0.0065f;
            /// <summary>
            /// 
            /// </summary>
            static public bool moveVertexPoint = true;
            /// <summary>
            /// ОбновитьУправляющийЭлемент
            /// </summary>
            /// <param name="go"></param>
            static public void ОбновитьУправляющийЭлемент(this GameObject go)
            {
                handleTransform = go.transform;
                handleRotation = Tools.pivotRotation == PivotRotation.Local ? handleTransform.rotation : Quaternion.identity;
            }
            /// <summary>
            /// ПоказатьТочку
            /// </summary>
            /// <param name="Блок"></param>
            /// <param name="v"></param>
            /// <returns></returns>
            static public bool ПоказатьТочку(this IBlock8_vs Блок, Vector3 v)
            {
                Handles.color = Блок.СуществуетВершина(v) ? Color.yellow : Color.grey;
                //go.transform.position
                Vector3 point = handleTransform.TransformPoint(spBuild.Block.Int_ins.КоординатаБлока + LIB.cs2305181649.IClass.Дельта/*spBuild.IVertices.Дельта*/*v - 0.5f * Vector3.one);
                return Handles.Button(point, handleRotation, 2.5f * handleSize, handleSize, Handles.SphereHandleCap);
            }
        }
    }
}
