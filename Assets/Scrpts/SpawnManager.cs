using UnityEngine;
public class SpawnManager: MonoBehaviour
{
    public GameObject[] items;
    public float spawnRange = 20f;
    public float interval = 1.5f;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, interval);
    }
    void Spawn()
    {
        GameObject chosen = items[Random.Range(0, items.Length)];
        Vector3 pos = new Vector3(Random.Range(-spawnRange, spawnRange), 0.5f, Random.Range(-spawnRange, spawnRange));
        Instantiate(chosen, pos, chosen.transform.rotation);
    }
    void Update()
    {
        
    }
}