using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTorch : MonoBehaviour
{
    public Transform theDest;

    private void Start()
    {
        theDest = GameObject.Find("Destination").transform;
    }

    void OnMouseDown()
    {
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().isKinematic = true;
        this.transform.position = theDest.position;
        this.transform.rotation = theDest.rotation;
        this.transform.parent = GameObject.Find("Destination").transform;

    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.right*700);


        GetComponent<CapsuleCollider>().enabled = true;
    }
}
