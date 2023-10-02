using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movGiratorio : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 85 * Time.deltaTime, Space.Self);
    }
}
