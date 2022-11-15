using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
    private bool star_1;
    private bool star_2;
    private bool star_3;


    // Start is called before the first frame update
    void Start()
    {
        star_1 = star_2 = star_3 =  false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CollectedStars()
    {
        if (!star_1)
        {
            star_1 = true;

        }
        else if (!star_2)
        {
            star_2 = true;
        }
        else
        {
            star_3 = true;
        }
    }
}
