using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject target;
    public float speed;
    
    // Use this for initialization
    void Start () {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target.transform.position)
            
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
    }
}
