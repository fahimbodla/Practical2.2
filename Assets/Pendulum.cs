using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    Quaternion start, end;
    public static float unghi = 0;
    public static  float viteza = 0;
    public float timpStart = 0;
    private float ung;
    // Use this for initialization
    void Start()
    {
        start = PendulRote(unghi);
        end = PendulRote(-unghi);
        ung = unghi;
    }
    // unghi = angle
    // viteza = speed
    // Update is called once per frame
    int frame = 0;
    void Update()
    {
        timpStart += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(start, end, (Mathf.Sin(timpStart * viteza + Mathf.PI / 2) + 1.0f) / 2.0f);
        if (ung != unghi)
        {
            start = PendulRote(unghi);
            end = PendulRote(-unghi);
            ung = unghi;
        }
        frame++;
        if(frame%30==0)
        {
            if (unghi > 0 )
            {
                unghi--;
            }
            if (viteza > 0 && frame % 300 ==0)
            {
       //         viteza--;
            }
        }
    }


    void ResetTimer()
    {
        timpStart = 0;
    }

    Quaternion PendulRote(float ung)
    {
        var PendulRote = transform.rotation;
        var unghiZ = PendulRote.eulerAngles.z + ung;
        if (unghiZ > 180) unghiZ -= 360;
        else if (unghiZ < -180) unghiZ += 360;
        PendulRote.eulerAngles = new Vector3(PendulRote.eulerAngles.x, PendulRote.eulerAngles.y, unghiZ);
        return PendulRote;
    }
}
