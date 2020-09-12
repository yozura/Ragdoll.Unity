using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusRoDah : MonoBehaviour
{
    [SerializeField]
    Rigidbody rigid;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(new Vector3(0f, 300f, -300f), ForceMode.Impulse);
        }
    }
}
