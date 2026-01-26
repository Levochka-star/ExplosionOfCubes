using UnityEngine;

public class Cube : MonoBehaviour
{
    [field:SerializeField] public float SpawnChance { get; private set; }
    
    public void SetSpawnChance(float valueChance)
    {
        SpawnChance = valueChance;
    }

    public void SetScale(Vector3 vector3)
    {
        transform.localScale = vector3;
       
    }
}
