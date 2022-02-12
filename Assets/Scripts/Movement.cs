using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    [SerializeField] GameObject Checkpoint;
    NavMeshAgent characterAgent;
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
                Checkpoint.SetActive(true);
                Checkpoint.transform.position = hit.point;
                characterAgent.destination = hit.point;
                
            }
        }
        //Vector3 checpointVec = new Vector3(hit.point.x, 0, hit.point.z);
        //Vector3 charVec = new Vector3(transform.position.x, 0, transform.position.z);
        if (characterAgent.hasPath)
        {
            Debug.Log(5);
            Checkpoint.SetActive(false);
        }
    }
}
