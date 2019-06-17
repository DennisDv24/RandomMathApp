using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Data.Text;

public class Mconfig : MonoBehaviour
{
    public String name;
    public int[] dim;

    public void Display(){
        //Display the matrix as a LaTex texture with the actual data of the matrix
    }
        public void Refresh(){
            //Refresh te matrix with new data
                //Can be the same as Destroy the last Display and display the matrix again
        }
    public void AddData<T>(T a){
        if (dim == null) print("E: the matrix dont have dimensions"); 
        else{
            //Add only a one generic variable to the matrix
        }

    }


}
