using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carandbomb : MonoBehaviour
{
    public GameObject theBomb;

    private bool hasBomb = false;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Cube")
        {
            hasBomb = true;
            GiveBomb();
            Destroy(collision.gameObject);
        }
    }

    void GiveBomb()
    {
            Instantiate(theBomb, transform.position + offset, Quaternion.identity);
    }

}
