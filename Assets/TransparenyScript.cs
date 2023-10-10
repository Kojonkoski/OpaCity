using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparenyScript : MonoBehaviour
{
    public GameObject transparencySpriteObj;

    public float minusOpacity = 0.05f;

    public float currentOpacity;

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

}
