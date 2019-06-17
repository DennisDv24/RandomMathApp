using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mInputDisplay : MonoBehaviour
{
    public char dataTOadd;//It depends on the last button pressed before pressing the equal button
    
    private GameObject Mcontroller;
        private McontrollerConfig ControlerConfig;
            private GameObject M;
                private Mconfig Mconfig;

    void Start(){
        Mcontroller = GameObject.Find("Mcontroller(Clone)");
            ControlerConfig = Mcontroller.GetComponent<McontrollerConfig>();
                M = ControlerConfig.M[ControlerConfig.getLastIndex()];
                    Mconfig = M.GetComponent<Mconfig>();
    }


    public void addTOscreen(){ //Do if the input button is pressed (in unity ispector)
        Mconfig.AddData(dataTOadd);
        Mconfig.Display();
        Mconfig.Refresh();
        
    }



}
