using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class LookingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public FixedTouchField TouchField;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps=GetComponent<RigidbodyFirstPersonController>();
        fps.mouseLook.LookAxis=TouchField.TouchDist;

    }
}
