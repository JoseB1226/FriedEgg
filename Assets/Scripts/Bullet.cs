using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class Bullet : MonoBehaviour
{
    public int damage = 10;
    public float speed = 50f;
    public float lifetime = 3f;

    private void Start()
    {
        Destroy(gameObject, lifetime); // auto-destroy after some time
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>())
        {
            other.GetComponent<PhotonView>().RPC("TakeDamage", RpcTarget.All, damage);
        }

        Destroy(gameObject); // destroy bullet on impact
    }
}