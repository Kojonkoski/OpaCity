using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransparenyScript : MonoBehaviour
{
    public GameObject transparencySpriteObj;

    public float minusOpacity = 0.05f;

    public float currentOpacity;

    public TimerScript timerScript;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentOpacity = transparencySpriteObj.GetComponent<SpriteRenderer>().color.a;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
           transparencySpriteObj.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, currentOpacity - minusOpacity);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("endWall"))
        {
            SceneManager.LoadScene("gameOver");
            print("osuma");
        }

        if (other.gameObject.CompareTag("TimerStartHere"))
        {
            timerScript.StartTimer();
            other.gameObject.SetActive(false);

        }
    }

}
