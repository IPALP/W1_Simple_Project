using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   public int scoreChange;
   public bool doubleScore;
   public int damage;
   public int healAmount;
   void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
            return;
        if(doubleScore)
            PickUp.score *= 2;
        else
            PickUp.score = Mathf.Max(0, PickUp.score+scoreChange);

    PlayerHealth hp = other.GetComponentInParent<PlayerHealth>();
    if(hp != null)
        {
            if(damage > 0) 
                hp.TakeDamage(damage);
            if(healAmount > 0)
                hp.Heal(healAmount);
        }
        Destroy(gameObject);
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }   
}
