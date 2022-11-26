using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float explosionRadius, explosionPower;
    public bool droped;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
            KnockBack();
            droped = true;
        }

    }

    void KnockBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider nearby in colliders)
        {
            Rigidbody otherRb = nearby.GetComponent<Rigidbody>();
            if(otherRb != null)
            {
                otherRb.AddExplosionForce(explosionPower  * 50, transform.position, explosionRadius);
            }
        }
    }
}
