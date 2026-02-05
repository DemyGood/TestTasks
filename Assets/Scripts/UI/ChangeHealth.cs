using UnityEngine;

public class ChangeHealth : MonoBehaviour, IEncreaseStat, IReduceStat
{
    public void EnceaseButton()
    {
        CharacterStatsController.HealthInstance.ModifyHealth(10);
    }
    public void ReduceButton()
    {
        CharacterStatsController.HealthInstance.ModifyHealth(-10);
    }
}
