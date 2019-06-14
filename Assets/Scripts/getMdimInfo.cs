using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Data.Text;

public class getMdimInfo : MonoBehaviour
{
    public TextMeshProUGUI fDimData_InputedAsMesh;
    private String fDimData_InputedAsString;
    
    public void moveData(){
        fDimData_InputedAsString = fDimData_InputedAsMesh.text;

        int[] dim = dimsFromStringToArray(fDimData_InputedAsString);
        
        //PlayerPrefs.SetQuaternionArray("Mdim",dim);//no se como coño se hace
        //print(PlayerPrefs);
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

}
