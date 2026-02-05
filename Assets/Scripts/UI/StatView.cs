using UnityEngine;
using UnityEngine.UI;

public abstract class StatView : MonoBehaviour
{
    public Text statText;
    public abstract void UpdateStat();
}
