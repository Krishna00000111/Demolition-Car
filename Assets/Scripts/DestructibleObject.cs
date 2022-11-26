using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour
{
    public GameObject destructedObject;

    public Bomb bombScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeDestroyable();
    }

    void MakeDestroyable()
    {
        if (bombScript.droped)
        {
            Instantiate(destructedObject, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
