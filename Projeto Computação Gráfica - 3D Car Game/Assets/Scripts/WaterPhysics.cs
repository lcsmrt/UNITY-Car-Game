using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

public class WaterPhysics : MonoBehaviour
{
    private Vector3 buoyantForce = new Vector3();
    private Vector3 dragForce = new Vector3();
    private GameObject gObject;
    public float waterDensity;
    private Collider t1;

    private void OnTriggerEnter(Collider collider)
    {
        gObject = GameObject.Find("Water Volume");
        t1 = collider;
    }
    private void FixedUpdate()
    {
        if (gObject.GetComponent<BoxCollider>().bounds.Contains(t1.transform.position))
        {
            buoyantForce.Set(0, t1.attachedRigidbody.mass * UnityEngine.Physics.gravity.y * waterDensity, 0);
            dragForce = (t1.attachedRigidbody.velocity * waterDensity) * -1;
            t1.attachedRigidbody.AddForce(buoyantForce);
            t1.attachedRigidbody.AddForce(dragForce);
            //Debug.Log("Buoyant force applied on " + t1.gameObject.name + ": " + buoyantForce);
            //Debug.Log("Drag force applied on " + t1.gameObject.name + ": " + dragForce);
        }
    }
}

*/

//Lembrete: Talvez se eu fizer um array de colliders e usar um foreach no lugar desse if fique melhor, vou testar depois.