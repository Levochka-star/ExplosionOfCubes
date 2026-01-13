using UnityEngine;

public class RaycastEx : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private InputUser _inputUser;

    private Ray _ray = new Ray();

    private void OnEnable()
    {
        _inputUser.OnCliced += Work;
    }

    private void OnDisable()
    {
        _inputUser.OnCliced -= Work;
    }

    private void Work(Vector3 vector3)
    {
        _ray = _camera.ScreenPointToRay(vector3);

        if (Physics.Raycast(_ray, out RaycastHit hit))
        {
            hit.collider.GetComponent<SpawnObjects>()?.TriggerSpawn();
        }
    }
}
