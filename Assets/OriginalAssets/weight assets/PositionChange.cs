using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

/// <summary>
/// �ړ����x�̐���
/// </summary>
public class PositionChange: TransformConstraint
{
    /// <summary>
    /// �ړ��̐���
    /// </summary>
    public override TransformFlags ConstraintType => TransformFlags.Move;

    [SerializeField]
    private float PosRatio = 0.5f;

    public override void ApplyConstraint(ref MixedRealityTransform transform)
    {
        Vector3 showposition = transform.Position - worldPoseOnManipulationStart.Position;

        //�e���ł̍��W�ϊ�
        Coordinatetransformation(ref showposition.x);
        Coordinatetransformation(ref showposition.y);
        Coordinatetransformation(ref showposition.z);

        //�ϊ���̍��W��transform������������
        transform.Position = showposition + worldPoseOnManipulationStart.Position;
    }

    /// <summary>
    /// ���W�ϊ��p�֐�
    /// </summary>
    private void Coordinatetransformation(ref float Coordinate)
    {
        Coordinate *= PosRatio;
    }
}
