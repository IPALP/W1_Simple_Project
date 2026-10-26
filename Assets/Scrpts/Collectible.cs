using UnityEngine;

public class Collectible : MonoBehaviour
{
   public int scoreChange;
   public bool doubleScore;
   void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;
        if(doubleScore)
            PickUp.score *= 2;
        else
            PickUp.score = Mathf.Max(0, PickUp.score+scoreChange);

        Destroy(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
