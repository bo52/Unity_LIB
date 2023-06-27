using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class mb : MonoBehaviour
{
    [CustomEditor(typeof(mb))]
    public class gui : Editor
    {
        public override void OnInspectorGUI()
        {
            var test = spBuild.Block.mbBlock_edit.έκη;

        }
    }
}
