using UnityEngine;

public class ChangeLevel: MonoBehaviour, IEncreaseStat
{
    public void EnceaseButton()
    {
        CharacterStatsController.LevelInstance.SetLevel(1);
    }
}