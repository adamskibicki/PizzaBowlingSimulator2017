using System.Collections.Generic;
using UnityEngine;

public class SkladnikController : MonoBehaviour
{
    public static SkladnikController Instance;

    public List<GameObject> skladniki;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
