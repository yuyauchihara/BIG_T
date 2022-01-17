using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class EnemyMove : MonoBehaviour
{
    public bool inArea = false;
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    [SerializeField]
    [Tooltip("Player")]
    private GameObject player;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        if (inArea == false)
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GotoNextPoint();
        }
        if(inArea == true)
        {
            agent.destination = player.transform.position;
        }
    }
    public void OnDetectObject(Collider Collider)
    {
        if (Collider.CompareTag("Player"))
        {
            agent.destination = Collider.transform.position;
        }
    }
}
