using System.IO;
using UnityEngine;

public class StatsParser : MonoBehaviour
{
    [SerializeField] private StatsSO _currentStats;
    private string _path = Application.streamingAssetsPath + "/CharacterStats.json";
    private void Awake()
    {
        LoadStats();

        EventManager.LevelChanged += SaveStats;
        EventManager.EnergyChanged += SaveStats;
        EventManager.HealthChanged += SaveStats;
    }
    public void SaveStats() 
    {
        _currentStats.health = CharacterStatsController.HealthInstance.Health;
        _currentStats.energy = CharacterStatsController.EnergyInstance.Energy;
        _currentStats.level = CharacterStatsController.LevelInstance.Level;

        string json = JsonUtility.ToJson(_currentStats);
        File.WriteAllText(_path, json);
    }
    public void LoadStats()
    {
        if (File.Exists(_path)) //обновление значений характеристик при наличии сохраненного файла
        {
            string json = File.ReadAllText(_path);
            JsonUtility.FromJsonOverwrite(json, _currentStats);

            int levelDelta = _currentStats.level - CharacterStatsController.LevelInstance.Level;
            CharacterStatsController.LevelInstance.SetLevel(levelDelta);

            int energyDelta = _currentStats.energy - CharacterStatsController.EnergyInstance.Energy;
            CharacterStatsController.EnergyInstance.ModifyEnergy(energyDelta);


            int healthDelta = _currentStats.health - CharacterStatsController.HealthInstance.Health;
            CharacterStatsController.HealthInstance.ModifyHealth(healthDelta);
        }
        else
        {
            _currentStats.health = CharacterStatsController.HealthInstance.Health;
            _currentStats.energy = CharacterStatsController.EnergyInstance.Energy;
            _currentStats.level = CharacterStatsController.LevelInstance.Level;
        }
        
    }
}