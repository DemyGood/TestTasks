using UnityEngine;
using UnityEngine.UI;

public class HealthView : StatView
{
    private void Awake()
    {
        statText = GetComponent<Text>();
        statText.text = "Health: " + CharacterStatsController.HealthInstance.Health + "/100";
        EventManager.HealthChanged += UpdateStat;
    }

    private void OnDestroy()
    {
        EventManager.HealthChanged -= UpdateStat;
    }

    public override void UpdateStat()
    {
        statText.text = "Health: " + CharacterStatsController.HealthInstance.Health + "/100";
    }
}
