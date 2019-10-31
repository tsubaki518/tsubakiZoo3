using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSearchFlashing : MonoBehaviour
{

    float time = 0f;
    public GameObject PlayeSearch;          //Player
    public GameObject PlayeSearch2;         //Player2

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //点滅
        time += Time.deltaTime;
        if (0.7f < time)
        {
            //Player
            time = 0f;
            PlayeSearch.SetActive(!PlayeSearch.activeInHierarchy);

            //Player2
            time = 0f;
            PlayeSearch2.SetActive(!PlayeSearch2.activeInHierarchy);
        }

    }

}