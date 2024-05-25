using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatGyattttttt : MonoBehaviour
{

    public Transform kaicenat;
    private int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += 1;
        if (x == 250) {
            x = 0;
            kaicenat.position = new Vector3(kaicenat.position.x + 1, kaicenat.position.y, kaicenat.position.z);
        }
    }
}
