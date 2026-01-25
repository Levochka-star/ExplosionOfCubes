using UnityEngine;

public class Detonator : MonoBehaviour
{
    [SerializeField] private SpawnObjects _spawnObjects;
    
    [SerializeField] private float _radius = 500.0F;
    [SerializeField] private float _power = 1000.0F;

    private void OnEnable()
    {
        _spawnObjects.CubeDestroed += Work;
    }

    private void OnDisable()
    {
        _spawnObjects.CubeDestroed -= Work;
    }

    private void Work(RaycastHit hit)
    {
        Vector3 explosionPos = hit.point;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, _radius);

        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(_power, explosionPos, _radius, 3.0F);
        }
    }
}