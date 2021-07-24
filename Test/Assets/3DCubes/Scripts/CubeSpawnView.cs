using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnView : MonoBehaviour
{
    [SerializeField] private CubeSpawner _spawner;

    public void OnSpeedChanged(string value)
    {
        _spawner.Speed = float.Parse(value);
    }

    public void OnDistanceChanged(string value)
    {
        _spawner.Distance = float.Parse(value);
    }

    public void OnSpawnDelayChanged(string value)
    {
        _spawner.SpawnDelay = float.Parse(value);
    }
}
