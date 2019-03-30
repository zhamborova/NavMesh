using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{

    public NavMeshAgent red;
    public GameObject redCube;

    public NavMeshAgent yellow;
    public GameObject yellowCube;

    public NavMeshAgent green;
    public GameObject greenCube;

    public NavMeshAgent blue;
    public GameObject blueCube;
    // Start is called before the first frame update
    void Start()
    {
        helper(redCube,red);
        helper(yellowCube, yellow);
        helper(greenCube, green);
        helper(blueCube, blue);

    }

    // Update is called once per frame
    void Update()
    {
    }



    void helper(GameObject cube, NavMeshAgent ag)
    {
        ag.isStopped = false;
        ag.SetDestination(cube.transform.position);
    }
}
