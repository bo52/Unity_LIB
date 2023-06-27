using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using utility2022;

namespace mesh2023
{
    public class mbBlock8_test : MonoBehaviour
    {
        [CustomEditor(typeof(mbBlock8_test))]
        public class gui : Editor
        {
            //private void OnSceneGUI() => MESH.Test.Block.сцена((target as mbBlock8_test).gameObject);
            //public override void OnInspectorGUI() => MESH.Test.Block.инс((target as mbBlock8_test).gameObject);
        }
    }
}
