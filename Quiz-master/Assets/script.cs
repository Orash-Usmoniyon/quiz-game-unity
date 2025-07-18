using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject AD;

    public void Start(){
        if(PlayerPrefs.GetInt("RetryPressed",0)==1){
            EnableAd();
        }
        PlayerPrefs.SetInt("RetryPressed",0);
    }

    public void EnableAd(){
        AD.SetActive(true);
        Invoke("Disable",1.1f);
    }

    public void Disable(){
        AD.SetActive(false);
    }

}
