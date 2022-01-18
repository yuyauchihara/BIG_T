using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class EnemyMove : MonoBehaviour
{
    private RaycastHit[] _raycastHits = new RaycastHit[10];
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;


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
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();

    }
    public void OnDetectObject(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            var positionDiff = collider.transform.position - transform.position;
            var distance = positionDiff.magnitude;
            var direction = positionDiff.normalized;
            var hitCount = Physics.RaycastNonAlloc(transform.position, direction, _raycastHits, distance);
            Debug.Log("hitCount: " + hitCount);
            if (hitCount <= 1)
            {
                agent.isStopped = false;
                agent.destination = collider.transform.position;
            }
            else
            {
                agent.isStopped = true;
                agent.isStopped = false;
            }
        }
    }
}
