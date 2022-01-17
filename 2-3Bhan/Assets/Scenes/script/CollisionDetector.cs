using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class CollisionDetector : MonoBehaviour
{
    EnemyMove enemy;
    private NavMeshAgent agent;
    [SerializeField]
    [Tooltip("Player")]
    private GameObject player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemy.inArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemy.inArea = false;
        }
    }
}
