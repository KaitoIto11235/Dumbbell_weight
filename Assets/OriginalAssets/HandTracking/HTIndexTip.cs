using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class HTIndexTip : MonoBehaviour
{
    //�\������I�u�W�F�N�g���`
    GameObject handjoint;

    // Start is called before the first frame update
    void Start()
    {
        handjoint = GameObject.Find("Bone.006_end");
    }

    // Update is called once per frame
    void Update()
    {
        //�E��̐l�����w�̎w��̈ʒu�����擾
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose pose))
        {
            Vector3 trpos = pose.Position;
            trpos.y *= 0.5f;
            Quaternion rot = Quaternion.AngleAxis(-90, Vector3.right);
            handjoint.transform.position = trpos; //���W��ݒ�
            handjoint.transform.rotation = pose.Rotation * rot; //��]��ݒ�
        }
    }
}
