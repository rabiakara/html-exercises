using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0.37f,3.14f,-0.41f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position + new Vector3(0.5f,3.4f,0.4f);
        transform.position = player.transform.position + offset;
    }
}
