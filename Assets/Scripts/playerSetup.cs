using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSetup : MonoBehaviour
{
    public Movement movement;
    public GameObject camera;

    public void IslocalPlayer()
    {
        Debug.Log("IslocalPlayer() called on " + gameObject.name);
        movement.enabled = true;
        camera.SetActive(true);
    }
}
