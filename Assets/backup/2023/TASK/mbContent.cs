using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace scene.content.obj
{
public class mbContent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    [CustomEditor(typeof(mbContent))]
    public class gui : Editor
    {
        
    }

}
}