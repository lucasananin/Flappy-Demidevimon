using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeAutoDestroyer : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        if (transform.position.x < 0)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
