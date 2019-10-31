using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    float alfa = 200;
    bool isFade = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<TextMesh>().color = new Color(255, 255, 255, alfa);

        if(alfa<=0)
        {
            isFade = true;
        }
        else if(alfa>=255)
        {
            isFade = false;
        }
        
        if(isFade==true)
        {
            alfa += 1;
        }
        else if(isFade==false)
        {
            alfa -= 1;
        }

    }

}
