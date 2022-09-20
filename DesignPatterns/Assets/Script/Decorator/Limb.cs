using UnityEngine;

public struct Limb
{
    public float Length;
    public LimbType limbType;

    public Limb(float _length, LimbType _limbType)
    {
        Length = Mathf.Max(1, _length);
        limbType = _limbType;
    }
}

public enum LimbType
{
    Leg,
    Arm
}
