using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public bool SphereIn = false, BoxIn = false, CapsuleIn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (SphereIn == true && BoxIn == true && CapsuleIn == true)
        {

        }
    }
}
