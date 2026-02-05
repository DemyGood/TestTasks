
public class CharacterStatsController: IHealth, IEnergy, ILevel
{
    public static IHealth HealthInstance = new CharacterStatsController();
    public static IEnergy EnergyInstance = new CharacterStatsController();
    public static ILevel LevelInstance = new CharacterStatsController();

    private int _health = 100;
    private int _maxHealth = 100;


    private int _energy = 100;
    private int _maxEnergy = 100;

    private int _level = 1;

    public int Health => _health;
    public int Energy => _energy;
    public int Level => _level;

    public void ModifyHealth(int amount)
    {
        _health += amount;
        if (_health >=_maxHealth)
        {
            _health = 100;
        }

        if (_health < 0)
        {
            _health = 0;
        }
        EventManager.OnHealthChanged();
    }

    public void ModifyEnergy(int amount)
    {
        _energy += amount;
        if (_energy >= _maxEnergy)
        {
            _energy = 100;
        }
        if (_energy < 0)
        {
            _energy = 0;
        }
        EventManager.OnEnergyChanged();
    }

    public void SetLevel(int newLevel)
    {
        _level += newLevel;
        if (_level<=0)
        {
            _level = 0;
        }
        EventManager.OnLevelChanged();
    }
}
