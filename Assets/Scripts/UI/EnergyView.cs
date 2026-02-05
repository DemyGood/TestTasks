using UnityEngine.UI;

public class EnergyView : StatView
{
    private void Awake()
    {
        statText = GetComponent<Text>();
        statText.text = "Energy: " + CharacterStatsController.EnergyInstance.Energy + "/100";
        EventManager.EnergyChanged += UpdateStat;
    }

    private void OnDestroy()
    {
        EventManager.EnergyChanged -= UpdateStat;
    }

    public override void UpdateStat()
    {
        statText.text = "Energy: " + CharacterStatsController.EnergyInstance.Energy + "/100";
    }
}
