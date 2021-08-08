using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Point point))
        {
            Destroy(point.gameObject);
        }
    }
}
