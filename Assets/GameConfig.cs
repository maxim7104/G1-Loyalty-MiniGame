using UnityEngine;

[System.Serializable]
public class CouponThreshold
{
    public int score;
    public string coupon;
}

[System.Serializable]
public class GameConfig
{
    public string logo;
    public string primaryColor;
    public string secondaryColor;
    public CouponThreshold[] couponThresholds;
}