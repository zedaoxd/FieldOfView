using Unity.Mathematics;
using UnityEngine;

public static class FieldOfViewUtils
{
    public static bool IsInsideFieldOfView(Vector2 fovOrigin, Vector2 target, float viewDistance, float viewAngle)
    {
        if (target.y < fovOrigin.y) return false;

        float distanceOriginToTarget = Mathf.Sqrt(Mathf.Pow(target.x - fovOrigin.x, 2) + Mathf.Pow(target.y - fovOrigin.y, 2));
        if (distanceOriginToTarget > viewDistance) return false;

        float sin = Mathf.Abs(fovOrigin.x - target.x) / distanceOriginToTarget;
        float sinViewAngle = Mathf.Sin(Mathf.Deg2Rad * viewAngle / 2);
        if (sin > sinViewAngle) return false;

        return true;
    }
}
