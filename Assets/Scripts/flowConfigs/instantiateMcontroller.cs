using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateMcontroller : MonoBehaviour
{
    public GameObject mconPrefab;
    private GameObject Mcontroller;

    void Start(){
        Mcontroller = Instantiate(mconPrefab);
    }
}
