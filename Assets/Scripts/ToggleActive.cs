using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActive : MonoBehaviour
{
    public GameObject ToggleObj;
    
    public void OnClick()
    {
        ToggleObj.SetActive(!ToggleObj.activeInHierarchy);
    }

}
