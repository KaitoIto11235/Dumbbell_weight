using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class HTPinkyDistalJoint : MonoBehaviour
{
    //表示するオブジェクトを定義
    GameObject handjoint;

    // Start is called before the first frame update
    void Start()
    {
        handjoint = GameObject.Find("Little3");
    }

    // Update is called once per frame
    void Update()
    {
        float n = HTWrist.WristNow();
        //該当する関節の位置情報を取得
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Right, out MixedRealityPose pose))
        {
            Quaternion rot = Quaternion.AngleAxis(-90, Vector3.right);
            Vector3 vpos = pose.Position;
            vpos.y -= n;
            handjoint.transform.position = vpos; //座標を設定
            handjoint.transform.rotation = pose.Rotation * rot; //回転を設定
        }
    }
}
