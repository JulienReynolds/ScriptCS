using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ia : MonoBehaviour {
    Transform playerTransform;
    private float NextCheck;
    UnityEngine.AI.NavMeshAgent myNavMesh;
    public float CheckRate = 0.01f;
    


    void Start () {
        if(GameObject.FindGameObjectWithTag("Player"))
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        myNavMesh= gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update () {
       if (Time.time > NextCheck)
       {
      NextCheck = Time.time + CheckRate;
       }
FollowPlayer();

    }
    void FollowPlayer () {
        {
        myNavMesh.transform.LookAt(playerTransform);
        myNavMesh.destination = playerTransform.position;
    }
}
}
