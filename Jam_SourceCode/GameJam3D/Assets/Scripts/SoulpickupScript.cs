using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulpickupScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            var hasSomethinginfront = Physics.Raycast(transform.position, transform.forward, out RaycastHit hitinfo, 1.5f);

            if(hasSomethinginfront && hitinfo.collider.CompareTag("Player"))
            {

            }
        }
    }
}
