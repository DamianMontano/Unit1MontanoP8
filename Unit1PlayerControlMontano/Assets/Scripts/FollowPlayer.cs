using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
