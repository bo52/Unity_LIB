using go2023;
using mb2023;
using spBuild.Block;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using utility2023;

namespace spBuild.Region
{
    public class mbRegion_edit : MonoBehaviour
    {
        #region object
        static public Vector3  оордината“екущего–егиона => (mbBlock_edit.Ёкз.GetComponent<mbPosition_step>(). оордината / IVertices.MAX).ќкруглить¬ектор_вниз();
        static private string _name = "Region";
        static mbRegion_edit _ins;
        static public mbRegion_edit Ёкз
        {
            get
            {
                if (_ins == null || _ins.ToString() == "null")
                {
                    GameObject.Find(_name)?.”даление();
                    var go = new GameObject();
                    go.name = _name;
                    _ins = go.AddComponent<mbRegion_edit>();
                }
                return _ins;
            }
            #endregion
        }
    }
}