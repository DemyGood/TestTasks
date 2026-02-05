using System;

public class EventManager
{
    public static event Action HealthChanged;

    public static event Action EnergyChanged;

    public static event Action LevelChanged;

    public static void OnHealthChanged()
    {
        HealthChanged?.Invoke();
    }

    public static void OnEnergyChanged()
    {
        EnergyChanged?.Invoke();
    }

    public static void OnLevelChanged()
    {
        LevelChanged?.Invoke();
    }

}