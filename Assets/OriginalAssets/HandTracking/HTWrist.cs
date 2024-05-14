using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;


public class HTWrist : MonoBehaviour
{
    //表示するオブジェクトを定義
    GameObject handjoint;

    // Start is called before the first frame update
    void Start()
    {
        handjoint = GameObject.Find("Wrist");
    }

    // Update is called once per frame
    void Update()
    {
        float n = HTWrist.WristNow();
        //該当する関節の位置情報を取得
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose pose1) && HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMetacarpal, Handedness.Right, out MixedRealityPose pose2))
        {
            Vector3 vpos1 = pose1.Position;
            Vector3 vpos2 = pose2.Position;
            Vector3 pos = vpos1;
            pos.x += vpos1.x - vpos2.x;
            pos.y += vpos1.y - vpos2.y;
            pos.z += vpos1.z - vpos2.z;

            Quaternion rot = Quaternion.AngleAxis(-90, Vector3.right);
            pos.y -= n;
            handjoint.transform.position = pos; //座標を設定
            handjoint.transform.rotation = pose1.Rotation * rot; //回転を設定
        }
    }
    //VHの現在のWristのズレを出力
    static public float WristNow()
    {
        HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose pose);
        Vector3 vpos = pose.Position;
        Vector3 trpos = vpos;
        trpos.y *= 0.5f;
        return vpos.y - trpos.y;
    }
}
