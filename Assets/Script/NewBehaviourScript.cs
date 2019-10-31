using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    float time = 0f;
    int cursorPos = 1;

    public GameObject OptionButton;
    public GameObject StartButton;
    public GameObject DatabaseButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //カーソルの移動
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            //カーソルの移動範囲
            if (cursorPos < 2)
            {
                cursorPos++;    //右に移動
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            //カーソルの移動範囲
            if (cursorPos > 0)
            {
                cursorPos--;    //左に移動
            }
        }

        /*
        //次のシーンへ
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Scene2");
        }
        */

        //カーソルの表示 
        if (cursorPos == 1)
        {
            //オプション時、カーソルを表示。（※点滅）
            time += Time.deltaTime;
            if (0.7f < time)
            {
                time = 0f;
                StartButton.SetActive(!StartButton.activeInHierarchy);
            }
            //次のシーンへ
            if (Input.GetKeyDown(KeyCode.Return))
            {
                FadeManager.Instance.LoadScene("Scene2", 2.0f);
            }

        }
        else
        {
            //カーソルのPositionが0以外なら非表示
            StartButton.SetActive(false);
        }

        if (cursorPos == 0)
        {
            //オプション時、カーソルを表示（※点滅）
            time += Time.deltaTime;
            if (0.7f < time)
            {
                time = 0f;
                OptionButton.SetActive(!OptionButton.activeInHierarchy);
            }
        }
        else
        {
            //カーソルのPositionが0以外なら非表示
            OptionButton.SetActive(false);
        }

        if (cursorPos == 2)
        {
            //オプション時、カーソルを表示（※点滅）
            time += Time.deltaTime;
            if (0.7f < time)
            {
                time = 0f;
                DatabaseButton.SetActive(!DatabaseButton.activeInHierarchy);
            }
        }
        else
        {
            //カーソルのPositionが0以外なら非表示
            DatabaseButton.SetActive(false);
        }

    }

}