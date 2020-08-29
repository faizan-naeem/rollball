using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    
    public GameObject enemyPrefab;
    public Transform player;

    public int noOfEnemies;

    void Start()
    {
        for(int i = 0; i < noOfEnemies; i++)
        {
            Vector3 enemyPosition = new Vector3(Random.Range(-9.0f, 9.0f), 0.5f, Random.Range(-9.0f, 9.0f));
            GameObject enemy = Instantiate(enemyPrefab, enemyPosition, Quaternion.Euler(0, 0, 0)) as GameObject;    
            enemy.transform.SetParent(gameObject.transform);
            enemy.GetComponent<EnemyChase>().player = player;
        }
    }

}
