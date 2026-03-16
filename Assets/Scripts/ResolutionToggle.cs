using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class ResolutionToggle : MonoBehaviour
{
    private float timer;
    private Label resolutionLabel;
    private const float MinWidth = 400f;
    private const float MaxWidth = 700f;
    private const float CycleDuration = 3f;
    private int lastWidth;

    void Start()
    {
        Screen.SetResolution((int)MinWidth, 400, false);
        resolutionLabel = GetComponent<UIDocument>().rootVisualElement.Q<Label>("resolution-label");
    }

    void Update()
    {
        if (resolutionLabel != null)
            resolutionLabel.text = $"{Screen.width} x {Screen.height}";

        timer += Time.deltaTime;
        float t = Mathf.PingPong(timer / CycleDuration, 1f);
        int width = (int)Mathf.Lerp(MinWidth, MaxWidth, t);
        if (width != lastWidth)
        {
            lastWidth = width;
            Screen.SetResolution(width, 400, false);
        }
    }
}
