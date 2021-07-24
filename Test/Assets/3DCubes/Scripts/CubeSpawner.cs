using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private Vector3 _startPosition;

    public float Speed { get; set; }
    public float Distance { get; set; }
    public float SpawnDelay { get; set; }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitUntil(() => Speed != 0);

            var cube = Instantiate(_cubePrefab, _startPosition, Quaternion.identity);
            cube.GetComponent<Rigidbody>().AddForce(Vector3.right * Speed, ForceMode.VelocityChange);
            cube.LifeDistance = Distance;

            yield return new WaitForSeconds(SpawnDelay);
        }
    }
}
