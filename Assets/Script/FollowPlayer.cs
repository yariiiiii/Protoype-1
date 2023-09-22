using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

private Vector3 offset = new Vector3(1.2f, 4.3f, -2.4f);

    public Vector3 Offset { get => offset; set => offset = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+ offset;
    }
}
