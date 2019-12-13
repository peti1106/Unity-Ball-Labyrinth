using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndContoller : MonoBehaviour
{

    public GameObject endEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            Debug.Log("You have won!");
            endEffect.SetActive(true);
            Destroy(other.gameObject);
        }
    }

}
