using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class HTPinkyDistalJoint : MonoBehaviour
{
    //�\������I�u�W�F�N�g���`
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
        //�Y������֐߂̈ʒu�����擾
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Right, out MixedRealityPose pose))
        {
            Quaternion rot = Quaternion.AngleAxis(-90, Vector3.right);
            Vector3 vpos = pose.Position;
            vpos.y -= n;
            handjoint.transform.position = vpos; //���W��ݒ�
            handjoint.transform.rotation = pose.Rotation * rot; //��]��ݒ�
        }
    }
}
