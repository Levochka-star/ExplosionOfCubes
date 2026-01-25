using UnityEngine;

public class Cube : MonoBehaviour
{
    [field:SerializeField] public float SpawnChance { get; private set; }
    
    public void SetSpawnChance(float valueChance)
    {
        SpawnChance = valueChance;
    }

    public void SetTransform(Vector3 valueScale)
    {
        transform.localScale = valueScale;
       
    }
}
