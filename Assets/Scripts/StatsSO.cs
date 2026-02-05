using System;
using UnityEditor.Overlays;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class StatsSO : ScriptableObject
{
    public int health = 100;
    public int energy = 100;
    public int level = 1;
}
