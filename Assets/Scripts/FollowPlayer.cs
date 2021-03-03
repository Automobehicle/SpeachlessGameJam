using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    GameObject player;
    public float moveSpeed = 1f;
    public float minDistance = 2f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float step = moveSpeed * Time.deltaTime;
        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance > minDistance && !CommandEscort.hiding)
        {
            transform.position = Vector2.Lerp(transform.position, player.transform.position, step);
        }
        else 
        {
            
        }
    }
}
