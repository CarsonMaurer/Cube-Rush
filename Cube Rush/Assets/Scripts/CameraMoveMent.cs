using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveMent : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ObjectToFollow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ObjectToFollow.position.x,transform.position.y, transform.position.z);
    }
}
