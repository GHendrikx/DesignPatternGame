public struct Limbs
{
    public float Length;
    public LimbType limbInfo;

    public Limbs(float _length, LimbType _limbInfo)
    {
        Length = _length;
        limbInfo = _limbInfo;
    }
}

public enum LimbType
{
    Leg,
    Arms
}
