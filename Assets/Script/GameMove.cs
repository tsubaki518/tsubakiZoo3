﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //次のシーンへ
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("");                     //ゲーム本編のSceneを挿入。
        }
    }
}
