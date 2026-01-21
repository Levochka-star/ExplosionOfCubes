using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _spawnShance = 100f;

    private int _minChanceSpawn = 0;
    private int _maxChanceSpawn = 6;

    private float _multipleSpawnShance = 0.5f;
    private float _multipleScale = 0.5f;


    private void Work()
    {
        if (RoolChanceSpawn(_spawnShance))
        {
            for (int i = 0; i < Random.Range(_minChanceSpawn, _maxChanceSpawn); i++)
            {
                Spawn();
            }
        }

        Destroy(_prefab);
    }

    private void Spawn()                          
    {
        GameObject clone = Instantiate(_prefab, transform.position, transform.rotation);

        clone.transform.localScale *= _multipleScale;
        clone.name += Random.Range(0, 10).ToString();

        if (clone.TryGetComponent(out SpawnObjects spawn))
        {
            spawn.SetSpawnChance(_spawnShance * _multipleSpawnShance);
        }
    }

    private bool RoolChanceSpawn(float chance)
    {
        int minRollShance = 0;
        int maxRollShance = 100;

        return Random.Range(minRollShance, maxRollShance) <= chance;
    }

    private void SetSpawnChance(float chance)
    {
        _spawnShance = chance;
    }

    public void TriggerSpawn()
    {
        Work();
    }
}