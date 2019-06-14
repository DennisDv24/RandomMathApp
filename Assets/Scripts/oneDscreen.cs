using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class oneDscreen : MonoBehaviour
{
    public char dataTOadd;

    public TextMeshProUGUI textToChange;
        private String fText;
    public Boolean erease = false;

    void Update(){////////////PENDIENTE DE TESTEAR
        if(Input.touchCount == 1){
            textToChange.text.Remove(0);
            textToChange.fontSize = 100;
        }

    }

        public void addTOscreen(){
            fText = textToChange.text;

                if(erease && fText.Length>0){
                    fText = fText.Remove(fText.Length-1);
                }
                else if(erease == false){
                    if(dataTOadd.ToString() == "x"){
                        fText = fText.Replace(dataTOadd.ToString(),"");
                    }
                        fText += dataTOadd.ToString();  
                }

            textToChange.text = fText;

        }
 
}
