using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHandMeshEventHandler : MonoBehaviour, IMixedRealityHandMeshHandler
{
    public Handedness myHandedness;
    private Mesh myMesh;
    private MeshFilter myMeshFilter;

    public int flag = 0;
    Vector3 inipos;
    public float rate;
    GameObject bar;
    public GameObject bar_sin1;
    public GameObject bar_sin2;
    public GameObject bar_velo3;
    public GameObject bar_8;
    Vector3 barpos, handpos, barpos_1, barpos_2, handpos_1, handpos_2;
    public float T = 120;

    // Start is called before the first frame update
    void Start()
    {
        myMesh = new Mesh();
    }

    private void OnEnable()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityHandMeshHandler>(this);
    }

    private void OnDisable()
    {
        CoreServices.InputSystem?.UnregisterHandler<IMixedRealityHandMeshHandler>(this);
    }

    public void OnHandMeshUpdated(InputEventData<HandMeshInfo> eventData)
    {
        if (eventData.Handedness == myHandedness)
        {
            Transform myTransform = this.transform; // 仮想ハンドのトランスフォーム

            

            

            GetComponent<Renderer>().material.color = new Color32(248, 150, 90, 1);

            if (flag == 0)
            {
                myTransform.position = eventData.InputData.position;
                myTransform.rotation = eventData.InputData.rotation;
            }
            else if (flag == 8)
            {
                Vector3 pos8 = eventData.InputData.position - inipos;
                pos8 *= 0.8f;
                pos8 += inipos;

                myTransform.position = pos8;
                myTransform.rotation = eventData.InputData.rotation;
                GetComponent<Renderer>().material.color = new Color32(248, 100, 90, 1);
            }
            else if (flag == 6)
            {
                Vector3 pos6 = eventData.InputData.position - inipos;
                pos6 *= 0.6f;
                pos6 += inipos;

                myTransform.position = pos6;
                myTransform.rotation = eventData.InputData.rotation;
                GetComponent<Renderer>().material.color = new Color32(248, 100, 90, 1);


            }
            else if (flag == 1)
            {
                myTransform.position = Vector3.Lerp(myTransform.position, eventData.InputData.position, rate);
                myTransform.rotation = Quaternion.Lerp(myTransform.rotation, eventData.InputData.rotation, rate);

            }
            else if(flag == 11)
            {
                barpos = bar.transform.position;
                handpos = eventData.InputData.position;
                barpos.y = (0.999f * barpos.y) + (0.001f * handpos.y);
                bar.transform.position = barpos;
                
            }
            else if(flag == 12)
            {
                barpos = bar.transform.position;
                handpos = eventData.InputData.position;

                float f = (360 / T) * (Time.frameCount - T / 2) * Mathf.Deg2Rad;
                float change = 100 * Mathf.Sin(f);
                barpos.y = 2 * barpos_1.y - barpos_2.y + handpos.y - 2 * handpos_1.y + handpos_2.y + change;
                barpos_2 = barpos_1;
                barpos_1 = barpos;
                handpos_2 = handpos_1;
                handpos_1 = handpos;

                bar.transform.position = barpos;
                
            }
            myMesh.vertices = eventData.InputData.vertices;
            myMesh.normals = eventData.InputData.normals;
            myMesh.triangles = eventData.InputData.triangles;
            if (eventData.InputData.uvs != null && eventData.InputData.uvs.Length > 0)
            {
                myMesh.uv = eventData.InputData.uvs;
            }
            myMeshFilter = gameObject.GetComponent<MeshFilter>();
            myMeshFilter.mesh = myMesh;
        }
    }


     public void Flag8()
    {
        inipos = this.transform.position;
        flag = 8;
    }
    public void Flag6()
    {
        inipos = this.transform.position;
        flag = 6;
    }
    public void Flag0()
    {
        inipos = this.transform.position;
        rate = 0.05f;
        flag = 1;
    }
    public void Flag1()
    {
        inipos = this.transform.position;
        rate = 0.04f;
        flag = 1;
    }
    public void Flag2()
    {
        inipos = this.transform.position;
        rate = 0.03f;//0.02 手が遅い　0.03 手が少しだけ速い
        flag = 1;
    }
    public void Flag3()
    {
        inipos = this.transform.position;
        rate = 0.02f;// 0.015 手が少し遅い
        flag = 1;
    }
    public void Flag_sin1()
    {
        bar = bar_sin1;
        rate = 0.02f;
        flag = 11;
    }
    public void Flag_sin2()
    {
        bar = bar_sin2;
        T = 120;
        flag = 12;
    }
    public void DisFlag()
    {
        flag = 0;
    }

}

