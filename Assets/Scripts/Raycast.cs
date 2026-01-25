using System;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private InputUser _inputUser;

    public event Action<RaycastHit> UserClicedOnCube;

    private Ray _ray = new Ray();

    private void OnEnable()
    {
        _inputUser.Clicking += Work;
    }

    private void OnDisable()
    {
        _inputUser.Clicking -= Work;
    }
    private void Work(Vector3 vector3)
    {
        _ray = _camera.ScreenPointToRay(vector3);

        if (Physics.Raycast(_ray, out RaycastHit hit))
        {
            Debug.Log("logic raycast true");

            if (hit.collider.gameObject.TryGetComponent<Cube>(out var cube))
                UserClicedOnCube?.Invoke(hit);
        }
    }
}
