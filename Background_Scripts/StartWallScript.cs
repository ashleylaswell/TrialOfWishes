using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWallScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != MyTags.PLAYER_TAG)
        {
            collision.gameObject.SetActive(false);
        }
    }
}
