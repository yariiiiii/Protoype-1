using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

private Vector3 offset = new Vector3(1.2f, 4.3f, -5.4f);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = player.transform.position+ offset;

    }
}
 