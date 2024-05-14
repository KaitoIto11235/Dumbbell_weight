using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Grab0 : MonoBehaviour
{
    public void Grabed()
    {
        GameObject MyHandMesh = GameObject.Find("MyHandMesh");
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().Flag0();
    }
    public void Lelesed()
    {
        GameObject MyHandMesh = GameObject.Find("MyHandMesh");
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().DisFlag();
    }
}
