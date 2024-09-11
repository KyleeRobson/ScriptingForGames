using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var z = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, z);
        transform.position = p;
       

        // Rotate the target GameObject
        transform.Rotate(new Vector3(60, 30, 20) * Time.deltaTime);
    }
}
