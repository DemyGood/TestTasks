using UnityEngine;

public class ChangeEnergy : MonoBehaviour, IEncreaseStat, IReduceStat
{
    public void EnceaseButton()
    {
        CharacterStatsController.EnergyInstance.ModifyEnergy(10);
    }
    public void ReduceButton()
    {
        CharacterStatsController.EnergyInstance.ModifyEnergy(-10);
    }
}
