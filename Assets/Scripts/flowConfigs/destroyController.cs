using System.Collections;
using UnityEngine;

public class destroyController : MonoBehaviour
{
    public static destroyController state;

        void Awake(){
            if(state == null){
                state = this;
                DontDestroyOnLoad(gameObject);
            }else if (state != this) Destroy(gameObject);//Is this good for something?

        }

}
