using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Grab8 : MonoBehaviour
{
    public void Grabed()
    {
        GameObject child = GameObject.Find("MyHandMesh");
        child.GetComponent<MyHandMeshEventHandler>().Flag8();
        //child.transform.parent = this.gameObject.transform;
    }
    public void Lelesed()
    {
        GameObject child = GameObject.Find("MyHandMesh");
        child.GetComponent<MyHandMeshEventHandler>().DisFlag();
        //child.transform.parent = null;
    }
}
