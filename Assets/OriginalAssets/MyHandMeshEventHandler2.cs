using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHandMeshEventHandler2 : MonoBehaviour, IMixedRealityHandMeshHandler
{
    public Handedness myHandedness;
    private Mesh myMesh;
    private MeshFilter myMeshFilter;

    
    Vector3 prehandpos1;
    Quaternion prehandrot1;

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

            if (Time.frameCount % 5 == 0)
            {
                myTransform.position = eventData.InputData.position + 2 * (eventData.InputData.position - prehandpos1);
                prehandpos1 = eventData.InputData.position;
            }
            myTransform.rotation = Quaternion.Lerp(prehandrot1, eventData.InputData.rotation, 1f);

            myMesh.vertices = eventData.InputData.vertices;
            myMesh.normals = eventData.InputData.normals;
            myMesh.triangles = eventData.InputData.triangles;
            if (eventData.InputData.uvs != null && eventData.InputData.uvs.Length > 0)
            {
                myMesh.uv = eventData.InputData.uvs;
            }

            myMeshFilter = gameObject.GetComponent<MeshFilter>();
            myMeshFilter.mesh = myMesh;

            prehandrot1 = eventData.InputData.rotation;

            

        }
    }
}
