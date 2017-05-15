using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargeting : MonoBehaviour {

    [SerializeField] Transform target;

    private void Awake()
    {
        target = GameObject.Find("Enemy").transform;
    }

    // Update is called once per frame
    void Update ()
    {
        transform.LookAt(target);
	}
}
