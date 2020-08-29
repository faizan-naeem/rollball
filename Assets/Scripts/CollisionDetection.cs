using UnityEngine;


public class CollisionDetection : MonoBehaviour
{
    int score;
    int pickupCount;
    
   
    void Start()
    {
        score = 0;
        pickupCount = GameObject.FindGameObjectsWithTag("pickup").Length;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pickup"))
        {
            Destroy(other.gameObject);
            score++;
            GameStateManager.instance.ManageScore(score, pickupCount);
        }
    }

    
}
