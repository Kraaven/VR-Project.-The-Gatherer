using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FruitCollection : MonoBehaviour
{
    public GameObject apple;
    public GameObject banana;
    public GameObject grape;
    public GameObject orange;

    private int applecount = 0;
    private int bananacount = 0;
    private int orangecount = 0;
    private int grapecount = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            applecount++;
            apple.GetComponent<TMP_Text>().text = "Apple: " + applecount + "/20";
        }
        if (other.gameObject.tag == "Grape")
        {
            grapecount++;
            grape.GetComponent<TMP_Text>().text = "Grape: " + grapecount+ "/20";
        }
        if (other.gameObject.tag == "Banana")
        {
            bananacount++;
            banana.GetComponent<TMP_Text>().text = "Banana: " + bananacount+ "/20";
        }
        if (other.gameObject.tag == "Orange")
        {
            orangecount++;
            orange.GetComponent<TMP_Text>().text = "Orange: " + orangecount+ "/20";
        }
    }
}
