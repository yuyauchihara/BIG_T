using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyChase : MonoBehaviour
{
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    public void OnDetectObject(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            _agent.destination = collider.transform.position;
        }
    }

}
