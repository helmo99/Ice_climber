using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
  

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(0f, player.transform.position.y + 5);
    }
}
