using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTempleteController : MonoBehaviour
{
    private float movement = 1f;
    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x = transform.position.x + movement * Time.deltaTime;
        transform.position = pos;
    }
}
