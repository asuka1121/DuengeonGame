using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLevel : MonoBehaviour
{
    Text txt;
    public GameObject Portal;
    private int currentlevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt = gameObject.GetComponent<Text>();
        currentlevel = Portal.GetComponentInChildren<ToNextLvl>().levels;
        txt.text = "level" + currentlevel;
        Debug.Log(currentlevel);
    }
}
