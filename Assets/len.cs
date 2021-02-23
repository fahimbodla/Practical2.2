using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class len : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform d;
   public Text cms;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float cm = -100* (transform.position.y- d.position.y);
        cms.text = cm.ToString("");
        cms.text += " cm";
    }
}
