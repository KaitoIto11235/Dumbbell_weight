using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Grab3 : MonoBehaviour
{
    public void Grabed()
    {
        GameObject MyHandMesh = GameObject.Find("MyHandMesh");
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().Flag3();
    }
    public void Lelesed()
    {
        GameObject MyHandMesh = GameObject.Find("MyHandMesh");
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().DisFlag();
    }
}
