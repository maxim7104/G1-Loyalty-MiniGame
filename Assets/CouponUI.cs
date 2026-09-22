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
        // SCOR
        scoreText.text =
            "<color=#FFFFFF>Scorul Tău: </color>" +
            "<color=#FFD42A>" + score + "</color>";

        string coupon = "Fără Cupon";
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
            couponText.text = "Fără Cupon";
            claimButton.SetActive(false);
        }
        else
        {
            couponText.text =
                "<color=#7A2E00>Cupon Câștigat: </color>" +
                "<color=#7A2E00>" + coupon + "</color>";

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
        const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        string part1 = "";
        string part2 = "";

        for (int i = 0; i < 4; i++)
        {
            part1 += characters[Random.Range(0, characters.Length)];
            part2 += characters[Random.Range(0, characters.Length)];
        }

        return "G1-" + part1 + "-" + part2;
    }
}