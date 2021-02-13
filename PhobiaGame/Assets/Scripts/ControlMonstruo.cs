using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlMonstruo : MonoBehaviour
{
    NavMeshAgent agenteNavMesh;
    public Transform objetivo;

    void Start()
    {
        agenteNavMesh = GetComponent<NavMeshAgent>();
        

    }

    // Update is called once per frame
    void Update()
    {
        agenteNavMesh.destination = objetivo.position;
    }
}
