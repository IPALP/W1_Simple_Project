using UnityEngine;
public class PickUp:MonoBehaviour
{
    public static int score;
    public int points = 10;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            score = score + points;
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}