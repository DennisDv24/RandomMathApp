using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class McontrollerConfig : MonoBehaviour
{

    public GameObject mEmptyPrefab;
        List<GameObject> M;

    public McontrollerConfig(){
        M = new List<GameObject>();
        //print("se ha instanciado");
    }

    public void DefEmpty(){

        M.Add(Instantiate(mEmptyPrefab));
        M[getLastIndex()].transform.parent = gameObject.transform;
    }

    public int getLastIndex(){
        return M.Count -1;
    }

    public void setDim(int index, int[] dim){
        M[index].GetComponent<Mconfig>().dim = dim;
    }
    public int[] getDim(int index){
        return M[index].GetComponent<Mconfig>().dim;
    }


}
