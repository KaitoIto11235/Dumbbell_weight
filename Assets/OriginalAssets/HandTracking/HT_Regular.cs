using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class HT_Regular: MonoBehaviour
{
    //•\¦‚·‚éƒIƒuƒWƒFƒNƒg‚ğ’è‹`
    GameObject[] handjoint = new GameObject[21];
    
    // Start is called before the first frame update
    void Start()
    {
        handjoint[0] = GameObject.Find("Wrist1");
        handjoint[1] = GameObject.Find("Wrist");
        handjoint[2] = GameObject.Find("ThumbProximalJoint");
        handjoint[3] = GameObject.Find("ThumbDistalJoint");
        handjoint[4] = GameObject.Find("ThumbTip");
        handjoint[5] = GameObject.Find("IndexKnuckle");
        handjoint[6] = GameObject.Find("IndexMiddleJoint");
        handjoint[7] = GameObject.Find("IndexDistalJoint");
        handjoint[8] = GameObject.Find("IndexTip");
        handjoint[9] = GameObject.Find("MiddleKnuckle");
        handjoint[10] = GameObject.Find("MiddleMiddleJoint");
        handjoint[11] = GameObject.Find("MiddleDistalJoint");
        handjoint[12] = GameObject.Find("MiddleTip");
        handjoint[13] = GameObject.Find("RingKnuckle");
        handjoint[14] = GameObject.Find("RingMiddleJoint");
        handjoint[15] = GameObject.Find("RingDistalJoint");
        handjoint[16] = GameObject.Find("RingTip");
        handjoint[17] = GameObject.Find("PinkyKnuckle");
        handjoint[18] = GameObject.Find("PinkyMiddleJoint");
        handjoint[19] = GameObject.Find("PinkyDistalJoint");
        handjoint[20] = GameObject.Find("PinkyTip");
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = Quaternion.AngleAxis(90, Vector3.right);
        // ŠY“–‚·‚éŠÖß‚ÌˆÊ’uî•ñ‚ğæ“¾
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose pose) && HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMetacarpal, Handedness.Right, out MixedRealityPose pose0))
        {
            Vector3 vpos1 = pose.Position;
            Vector3 vpos2 = pose0.Position;
            Vector3 pos = vpos1;
            pos.x += vpos1.x - vpos2.x;
            pos.y += vpos1.y - vpos2.y;
            pos.z += vpos1.z - vpos2.z;

            handjoint[0].transform.position = pos; //À•W‚ğİ’è
            handjoint[0].transform.rotation = pose.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose pose1))
        {
            handjoint[1].transform.position = pose1.Position; //À•W‚ğİ’è
            handjoint[1].transform.rotation = pose1.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbProximalJoint, Handedness.Right, out MixedRealityPose pose2))
        {
            handjoint[2].transform.position = pose2.Position; //À•W‚ğİ’è
            handjoint[2].transform.rotation = pose2.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbDistalJoint, Handedness.Right, out MixedRealityPose pose3))
        {
            handjoint[3].transform.position = pose3.Position; //À•W‚ğİ’è
            handjoint[3].transform.rotation = pose3.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose pose4))
        {
            handjoint[4].transform.position = pose4.Position; //À•W‚ğİ’è
            handjoint[4].transform.rotation = pose4.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexKnuckle, Handedness.Right, out MixedRealityPose pose5))
        {
            handjoint[5].transform.position = pose5.Position; //À•W‚ğİ’è
            handjoint[5].transform.rotation = pose5.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMiddleJoint, Handedness.Right, out MixedRealityPose pose6))
        {
            handjoint[6].transform.position = pose6.Position; //À•W‚ğİ’è
            handjoint[6].transform.rotation = pose6.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexDistalJoint, Handedness.Right, out MixedRealityPose pose7))
        {
            handjoint[7].transform.position = pose7.Position; //À•W‚ğİ’è
            handjoint[7].transform.rotation = pose7.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose pose8))
        {
            handjoint[8].transform.position = pose8.Position; //À•W‚ğİ’è
            handjoint[8].transform.rotation = pose8.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleKnuckle, Handedness.Right, out MixedRealityPose pose9))
        {
            handjoint[9].transform.position = pose9.Position; //À•W‚ğİ’è
            handjoint[9].transform.rotation = pose9.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMiddleJoint, Handedness.Right, out MixedRealityPose pose10))
        {
            handjoint[10].transform.position = pose10.Position; //À•W‚ğİ’è
            handjoint[10].transform.rotation = pose10.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleDistalJoint, Handedness.Right, out MixedRealityPose pose11))
        {
            handjoint[11].transform.position = pose11.Position; //À•W‚ğİ’è
            handjoint[11].transform.rotation = pose11.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose pose12))
        {
            handjoint[12].transform.position = pose12.Position; //À•W‚ğİ’è
            handjoint[12].transform.rotation = pose12.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingKnuckle, Handedness.Right, out MixedRealityPose pose13))
        {
            handjoint[13].transform.position = pose13.Position; //À•W‚ğİ’è
            handjoint[13].transform.rotation = pose13.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingMiddleJoint, Handedness.Right, out MixedRealityPose pose14))
        {
            handjoint[14].transform.position = pose14.Position; //À•W‚ğİ’è
            handjoint[14].transform.rotation = pose14.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingDistalJoint, Handedness.Right, out MixedRealityPose pose15))
        {
            handjoint[15].transform.position = pose15.Position; //À•W‚ğİ’è
            handjoint[15].transform.rotation = pose15.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose pose16))
        {
            handjoint[16].transform.position = pose16.Position; //À•W‚ğİ’è
            handjoint[16].transform.rotation = pose16.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyKnuckle, Handedness.Right, out MixedRealityPose pose17))
        {
            handjoint[17].transform.position = pose17.Position; //À•W‚ğİ’è
            handjoint[17].transform.rotation = pose17.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyMiddleJoint, Handedness.Right, out MixedRealityPose pose18))
        {
            handjoint[18].transform.position = pose18.Position; //À•W‚ğİ’è
            handjoint[18].transform.rotation = pose18.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Right, out MixedRealityPose pose19))
        {
            handjoint[19].transform.position = pose19.Position; //À•W‚ğİ’è
            handjoint[19].transform.rotation = pose19.Rotation * rot; //‰ñ“]‚ğİ’è
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose pose20))
        {
            handjoint[20].transform.position = pose20.Position; //À•W‚ğİ’è
            handjoint[20].transform.rotation = pose20.Rotation * rot; //‰ñ“]‚ğİ’è
        }
    }
}
