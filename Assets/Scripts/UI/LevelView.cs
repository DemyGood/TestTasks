using UnityEngine;
using UnityEngine.UI;

public class LevelView : StatView
{
    private void Awake()
    {
        statText = GetComponent<Text>();
        statText.text = "Level: " + CharacterStatsController.LevelInstance.Level;
        EventManager.LevelChanged += UpdateStat;
    }

    private void OnDestroy()
    {
        EventManager.LevelChanged -= UpdateStat;
    }

    public override void UpdateStat()
    {
        statText.text = "Level: " + CharacterStatsController.LevelInstance.Level;
    }
}
