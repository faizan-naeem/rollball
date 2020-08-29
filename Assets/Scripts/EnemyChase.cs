using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{    
    public Transform player;
 
    NavMeshAgent navMeshAgent;
    float delay;
    float playerSpeed;

    void Start()
    {
        delay = Random.Range(1.0f, 3.0f);
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerSpeed = player.gameObject.GetComponent<PlayerControl>().speed;
        navMeshAgent.speed = Random.Range(0.25f * playerSpeed, 0.5f * playerSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > delay)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameStateManager.instance.GameOver();    
        }
    }

}
