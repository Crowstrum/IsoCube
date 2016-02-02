using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour {
    [SerializeField]
    FauxGravityAttractor _attractor;
    [SerializeField]
    Transform[] points;
    Transform _myTransform;


	// Use this for initialization
	void Start () {
        _myTransform = transform;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;

    }
	
	// Update is called once per frame
	void Update () {
      //  _attractor.Attract(_myTransform);

        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position = points[1].position;
        }
	}
}
