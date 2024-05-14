using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Grab1 : MonoBehaviour
{
    public void Grabed()
    {
        GameObject MyHandMesh = GameObject.Find("MyHandMesh");
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().Flag1();
    }
    public void Lelesed()
    {
        GameObject MyHandMesh = GameObject.Find("MyHandMesh");
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().DisFlag();
    }
}
