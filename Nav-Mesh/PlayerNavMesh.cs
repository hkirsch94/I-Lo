using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
// public float rotationSpeed;

    [SerializeField] private Transform movePositionTransform;

    private NavMeshAgent navMeshAgent;

    private void Awake() 
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); 
    }

    private void Update()
    {
// float horizontalInput = Input.GetAxis("Horizontal");
// float verticalInput = Input.GetAxis("Vertical");

// Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
// movementDirection.Normalize();

        navMeshAgent.destination = movePositionTransform.position;

    //if (movementDirection != Vector3.zero)
      //  {
        //    Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
        //
        //    movePositionTransform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
      //  }
        
    }
}
