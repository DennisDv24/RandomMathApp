using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class calcMdimInfo : MonoBehaviour
{
    public TextMeshProUGUI fDimData_InputedAsMesh;
    private String fDimData_InputedAsString;

    public GameObject Mcontroller;
        private McontrollerConfig config;

    public void moveData(){
        
            fDimData_InputedAsString = fDimData_InputedAsMesh.text;

            int[] dim = dimsFromStringToArray(fDimData_InputedAsString);

        if (dim[0]==0 || dim[1]==0) print("E: the matrix cannot have 0 rows or cols");

        else newMatrix(dim); 
            
    }

    int[] dimsFromStringToArray(String stringTOconvert){
            int lim = stringTOconvert.IndexOf("x");

                    int deltaTOm = lim; //careful, the arguments of the method "Substring" are the beginning of the arrangement and its increase.
                int m = int.Parse(stringTOconvert.Substring(0,deltaTOm));
                    int deltaTOn = stringTOconvert.Length-(lim+1);
                int n = int.Parse(stringTOconvert.Substring(lim+1, deltaTOn));

            int[] dim = {m,n};

        return dim;
    }

    public void newMatrix(int[] dim){
        config = Mcontroller.GetComponent<McontrollerConfig>();
        config.DefEmpty();
        config.setDim(config.getLastIndex(), dim);
    }

}
