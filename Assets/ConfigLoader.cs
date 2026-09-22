using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class ConfigLoader : MonoBehaviour
{
    public static GameConfig Config { get; private set; }

    public Image localLogo;

    public Image backgroundPanel;
    public TMP_Text[] uiTexts;
    public Button[] uiButtons;

    void Start()
    {
        StartCoroutine(LoadConfig());
    }

    IEnumerator LoadConfig()
    {
        string path = System.IO.Path.Combine(
            Application.streamingAssetsPath,
            "config.json"
        );

        using (UnityWebRequest request = UnityWebRequest.Get(path))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Config = JsonUtility.FromJson<GameConfig>(
                    request.downloadHandler.text
                );

                Debug.Log("CONFIG LOADED SUCCESSFULLY!");

                yield return StartCoroutine(LoadLogo());

                ApplyColors();
            }
            else
            {
                Debug.LogError("CONFIG ERROR: " + request.error);
            }
        }
    }

    IEnumerator LoadLogo()
    {
        string logoPath = System.IO.Path.Combine(
            Application.streamingAssetsPath,
            Config.logo
        );

        using (UnityWebRequest request =
               UnityWebRequestTexture.GetTexture(logoPath))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Texture2D texture =
                    DownloadHandlerTexture.GetContent(request);

                Sprite sprite = Sprite.Create(
                    texture,
                    new Rect(0, 0, texture.width, texture.height),
                    new Vector2(0.5f, 0.5f)
                );

                localLogo.sprite = sprite;

                Debug.Log("LOGO LOADED SUCCESSFULLY!");
            }
            else
            {
                Debug.LogError("LOGO ERROR: " + request.error);
            }
        }
    }

    void ApplyColors()
    {
        if (Config == null)
            return;

        if (ColorUtility.TryParseHtmlString(
            Config.primaryColor,
            out Color primary))
        {
            backgroundPanel.color = primary;
        }

        if (ColorUtility.TryParseHtmlString(
            Config.secondaryColor,
            out Color secondary))
        {
            foreach (TMP_Text text in uiTexts)
            {
                if (text != null)
                {
                    text.color = secondary;
                }
            }
            foreach (Button button in uiButtons)
            {
                if (button != null)
                {
                    ColorBlock colors = button.colors;
                    colors.normalColor = secondary;
                    button.colors = colors;
                }
            }
        }

        Debug.Log("COLORS APPLIED SUCCESSFULLY!");
    }
}