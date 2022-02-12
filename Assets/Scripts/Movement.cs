using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    NavMeshAgent characterAgent;
    [SerializeField] GameObject küp;
    void Start()
    {
        characterAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                characterAgent.destination = hit.point;
            }
        }
    }
}
