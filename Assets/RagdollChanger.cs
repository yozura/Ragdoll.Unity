using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollChanger : MonoBehaviour
{
    public GameObject charObj;
    public GameObject ragdollObj;

    public Rigidbody spine;

    void Start()
    {
            
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeRagdoll();
        }
    }

    public void ChangeRagdoll()
    {
        CopyCharacterTransformToRagdoll(charObj.transform, ragdollObj.transform);

        charObj.SetActive(false);
        ragdollObj.SetActive(true);

        spine.AddForce(new Vector3(0f, 0f, -200f), ForceMode.Impulse);
    }

    public void CopyCharacterTransformToRagdoll(Transform origin, Transform ragdoll)
    {
        for (int i = 0; i < origin.childCount; i++)
        {
            if(origin.childCount != 0)
            {
                CopyCharacterTransformToRagdoll(origin.GetChild(i), ragdoll.GetChild(i));
            }

            ragdoll.GetChild(i).localPosition = origin.GetChild(i).localPosition;
            ragdoll.GetChild(i).localRotation = origin.GetChild(i).localRotation;
        }
    }

}
