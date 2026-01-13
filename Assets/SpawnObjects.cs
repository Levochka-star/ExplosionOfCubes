using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _spawnChance = 100f;

    private void Work()
    {
        if (RoolChanceSpawn(_spawnChance))
        {
            for (int i = 0; i < Random.Range(2, 6); i++)
            {
                Spawn();
            }
        }

        Destroy(_prefab);
    }

    private void Spawn()
    {
        GameObject clone = Instantiate(_prefab, transform.position, transform.rotation);

        clone.transform.localScale *= 0.5f;
        clone.name = _prefab.name + Random.Range(0, 6).ToString();

        if (clone.TryGetComponent(out SpawnObjects spawn))
        {
            spawn.SetSpawnChance(_spawnChance * 0.5f);
        }
    }

    private bool RoolChanceSpawn(float chance)
    {
        return Random.Range(0f, 100f) <= chance;
    }

    private void SetSpawnChance(float chance)
    {
        _spawnChance = chance;
    }

    public void TriggerSpawn()
    {
        Work();
    }
}