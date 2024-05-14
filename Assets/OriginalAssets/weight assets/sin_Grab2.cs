using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sin_Grab2 : MonoBehaviour
{
    public GameObject MyHandMesh;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Grab()
    {
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().Flag_sin2();
    }

    public void Lelese()
    {
        MyHandMesh.GetComponent<MyHandMeshEventHandler>().DisFlag();
    }
}
