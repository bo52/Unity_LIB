//TransformPoint.Сцена
//empty
//Bo52_16032021918209.INS.TransformPoint.
using UnityEditor;
using UnityEngine;
namespace LIB.st2305231603
{
    /// <summary>
    /// stTransformPoint
    /// </summary>
    static public class Class
    {
        static public string INFO = "INSPECTOR";
        static public string PRODUCT = "инспектор по управлению точек Блоков";
        /// <summary>
        /// управляющий элемент
        /// handleTransform
        /// </summary>
        static public Transform field230523160300;
        /// <summary>
        /// угол управляющего элемента
        /// handleRotation
        /// </summary>
        static public Quaternion field230523160301 = Quaternion.identity;
        /// <summary>
        /// radius
        /// </summary>
        static public float field230523160302 = 0.02f;
        /// <summary>
        /// pull
        /// </summary>
        static public float field230523160303 = 0.3f;
        /// <summary>
        /// handleSize
        /// </summary>
        static public float field230523160304 = 0.0065f;
        /// <summary>
        /// moveVertexPoint
        /// </summary>
        static public bool field230523160305 = true;
        /// <summary>
        /// ОбновитьУправляющийЭлемент
        /// </summary>
        /// <param name="go"></param>
        static public void fun230523160306(this GameObject go)
        {
            field230523160300 = go.transform;
            field230523160301 = Tools.pivotRotation == PivotRotation.Local ? field230523160300.rotation : Quaternion.identity;
        }
        /// <summary>
        /// ПоказатьТочку
        /// </summary>
        /// <param name="Блок"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        static public bool fun230523160307_PointView(this bool СуществуетВершина, Vector3 v, Vector3 Координата = default, float Дельта = 1)
        {
            Handles.color = СуществуетВершина ? Color.yellow : Color.grey;
            //go.transform.position
            Vector3 point = field230523160300.TransformPoint(Координата + Дельта * v - 0.5f * Vector3.one);
            return Handles.Button(point, field230523160301, 2.5f * field230523160304, field230523160304, Handles.SphereHandleCap);
        }
    }
}
