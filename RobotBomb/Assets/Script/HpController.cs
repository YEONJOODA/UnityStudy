using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{
    GameObject hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HpImage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HpControl()
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f;

        if(hp.GetComponent<Image>().fillAmount <= 0)
        {
            //Death 애니메이션 실행


            // 씬 전환
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
