using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Cube _prefabCube;

    [SerializeField] private Raycast _raycast;

    private int _minChanceSpawn = 0;
    private int _maxChanceSpawn = 6;

    private float _multipleSpawnShance = 0.5f;
    private float _multipleLocalScale = 0.5f;

    private void OnEnable()
    {
        _raycast.UserClicedOnCube += Work;
    }

    private void OnDisable()
    {
        _raycast.UserClicedOnCube -= Work;
    }


    private void Work(RaycastHit hit)
    {
        if (hit.collider.TryGetComponent(out Cube cube))
        {
           if (RoolChanceSpawn(cube.SpawnChance))
            {
                int nuber = Random.Range(_minChanceSpawn, _maxChanceSpawn);

                for (int i = 0; i < nuber; i++)
                {
                    Spawn(hit, cube.SpawnChance);
                }
            }
        }

        Destroy(hit.collider.gameObject);
    }

    private void Spawn(RaycastHit hit, float SpawnChance)
    {
        SpawnChance *= _multipleSpawnShance;

        Cube clone = Instantiate(_prefabCube, hit.point, hit.collider.gameObject.transform.rotation);

        clone.SetSpawnChance(SpawnChance);
        clone.SetScale(hit.transform.localScale * _multipleLocalScale);
    }

    private bool RoolChanceSpawn(float chance)
    {
        int minRollShance = 0;
        int maxRollShance = 100;

        return Random.Range(minRollShance, maxRollShance) <= chance;
    }
}