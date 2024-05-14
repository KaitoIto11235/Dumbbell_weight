using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

/// <summary>
/// 移動速度の制約
/// </summary>
public class PositionChange: TransformConstraint
{
    /// <summary>
    /// 移動の制約
    /// </summary>
    public override TransformFlags ConstraintType => TransformFlags.Move;

    [SerializeField]
    private float PosRatio = 0.5f;

    public override void ApplyConstraint(ref MixedRealityTransform transform)
    {
        Vector3 showposition = transform.Position - worldPoseOnManipulationStart.Position;

        //各軸での座標変換
        Coordinatetransformation(ref showposition.x);
        Coordinatetransformation(ref showposition.y);
        Coordinatetransformation(ref showposition.z);

        //変換後の座標でtransformを書き換える
        transform.Position = showposition + worldPoseOnManipulationStart.Position;
    }

    /// <summary>
    /// 座標変換用関数
    /// </summary>
    private void Coordinatetransformation(ref float Coordinate)
    {
        Coordinate *= PosRatio;
    }
}
