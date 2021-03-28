using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scenes : MonoBehaviour
{

    public GameObject Ending;

    public void click_start()
    {
        SceneManager.LoadScene("大廳");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "玩家")
        {
            if (gameObject.name == "傳送門(大門)")
            {
                SceneManager.LoadScene("大門口");
            }
            else if (gameObject.name == "傳送門(廊道)")
            {
                SceneManager.LoadScene("廊道");
            }
            else if (gameObject.name == "傳送門(大廳)")
            {
                SceneManager.LoadScene("大廳");
            }
            else if (gameObject.name == "委託者")
            {
                Ending.SetActive(true);
            }

        }
    }

    public void click_menu()
    {
        SceneManager.LoadScene("遊憩開始畫面");
    }

    public void click_end()
    {
        Application.Quit();
    }
}
