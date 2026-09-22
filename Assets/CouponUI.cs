using UnityEngine;
using TMPro;
using System.Collections;

public class CouponUI : MonoBehaviour
{
    public GameObject finalPage;
    public GameObject claimPage;

    public TMP_Text scoreText;
    public TMP_Text couponText;
    public TMP_Text couponCodeText;

    public GameObject claimButton;

    public void ShowClaimPage()
    {
        finalPage.SetActive(false);
        claimPage.SetActive(true);
        if (couponCodeText != null)
        {
            couponCodeText.text = "COD: " + GenerateCouponCode();
        }
    }

    public void ShowFinalPage()
    {
        claimPage.SetActive(false);
        finalPage.SetActive(true);
    }

    public void SetResult(int score)
    {
        scoreText.text = "SCORUL TĂU: " + score;

        string coupon = "FĂRĂ CUPON";
        int minimumScore = int.MaxValue;

        if (ConfigLoader.Config != null &&
            ConfigLoader.Config.couponThresholds != null &&
            ConfigLoader.Config.couponThresholds.Length > 0)
        {
            foreach (CouponThreshold threshold in ConfigLoader.Config.couponThresholds)
            {
                if (threshold.score < minimumScore)
                {
                    minimumScore = threshold.score;
                }

                if (score >= threshold.score)
                {
                    coupon = threshold.coupon;
                }
            }
        }

        if (score < minimumScore)
        {
            couponText.text = "FĂRĂ CUPON";
            claimButton.SetActive(false);
        }
        else
        {
            couponText.text = "CUPON CÂȘTIGAT: " + coupon;
            claimButton.SetActive(true);
        }
    }

    public void ShowFinalResult(int realScore)
    {
        SetResult(realScore);
    }

    IEnumerator Start()
    {
        while (ConfigLoader.Config == null)
        {
            yield return null;
        }

        SetResult(1270);
    }
    string GenerateCouponCode()
    {
        return "G1-" + Random.Range(1000, 9999);
    }
}