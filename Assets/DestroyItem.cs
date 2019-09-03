using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {

    private GameObject unitychan;

    private float unityPos;

    private float itemPos;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        this.unitychan = GameObject.Find("unitychan");

        this.unityPos = unitychan.transform.position.z;

        this.itemPos = this.gameObject.transform.position.z;

        if (unityPos - itemPos > 5)
        {

            Destroy(this.gameObject);
        }
	}
}
