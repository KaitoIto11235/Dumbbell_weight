using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class IndexDistalJoint : MonoBehaviour
{
    //表示するオブジェクトを定義
    GameObject handjoint;

    // Start is called before the first frame update
    void Start()
    {
        handjoint = GameObject.Find("IndexDistalJoint");
    }

    // Update is called once per frame
    void Update()
    {
        //float n = HTWrist.WristNow();
        //該当する関節の位置情報を取得
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexDistalJoint, Handedness.Right, out MixedRealityPose pose1) && HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMiddleJoint, Handedness.Right, out MixedRealityPose pose2))
        {
            Vector3 pos1 = pose1.Position;
            Vector3 pos2 = pose2.Position;
            Vector3 pos = new Vector3(0, 0, 0);
            pos.x = (pos1.x + pos2.x) / 2;
            pos.y = (pos1.y + pos2.y) / 2;
            pos.z = (pos1.z + pos2.z) / 2;
            Quaternion rot = Quaternion.AngleAxis(90, Vector3.right);
            //pos.y -= n;
            handjoint.transform.position = pos; //座標を設定
            handjoint.transform.rotation = pose1.Rotation * rot; //回転を設定
        }
    }
}
