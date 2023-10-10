using UnityEngine;
using System.Collections;
//--------------------------------------------------------------------
//Small class to rotate an object with a certain velocity. Used for moving platforms in levels.
//--------------------------------------------------------------------
public class Rotator : MonoBehaviour
{
    public float speed = 0f;
    public float maxspeed = 500f;
    public float acceleration = 1f;
    public float rotation;

    public float addSpeed;

    public Timer timerScrpit;

    public bool isSpinning = true;

    void FixedUpdate()
    {
        rotation = transform.rotation.z;

        if (isSpinning)
        {
            transform.Rotate(Vector3.forward, Time.fixedDeltaTime * speed);


        }
    }

    public void onTimerEnd()
    {
        speed = +addSpeed;
        print("toimii");
        timerScrpit.Awake();

    }
}
