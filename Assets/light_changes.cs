using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_changes : MonoBehaviour
{
    public GameObject sun;
    void FixedUpdate()
    {
        sun.transform.Rotate(0.1f, 0, 0);
    }
}
