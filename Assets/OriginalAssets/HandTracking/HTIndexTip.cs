using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class HTIndexTip : MonoBehaviour
{
    //表示するオブジェクトを定義
    GameObject handjoint;

    // Start is called before the first frame update
    void Start()
    {
        handjoint = GameObject.Find("Bone.006_end");
    }

    // Update is called once per frame
    void Update()
    {
        //右手の人差し指の指先の位置情報を取得
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose pose))
        {
            Vector3 trpos = pose.Position;
            trpos.y *= 0.5f;
            Quaternion rot = Quaternion.AngleAxis(-90, Vector3.right);
            handjoint.transform.position = trpos; //座標を設定
            handjoint.transform.rotation = pose.Rotation * rot; //回転を設定
        }
    }
}
