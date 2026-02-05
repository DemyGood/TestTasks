using UnityEngine;

public class ResetStats : MonoBehaviour
{
    [SerializeField] private StatsSO _statsSO;

    public void ResetToBase() //считаем разницу базового и текущего значения характеристики и уменьшаем/увеличиваем её на нужное число
    {
        int healthDelta = _statsSO.health - CharacterStatsController.HealthInstance.Health;
        CharacterStatsController.HealthInstance.ModifyHealth(healthDelta);

        int energyDelta = _statsSO.energy - CharacterStatsController.EnergyInstance.Energy;
        CharacterStatsController.EnergyInstance.ModifyEnergy(energyDelta);

        int levelDelta = _statsSO.level - CharacterStatsController.LevelInstance.Level;
        CharacterStatsController.LevelInstance.SetLevel(levelDelta);
    }
}
