using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camshake : MonoBehaviour {
    public Animator camAnim;
    // Use this for initialization
    public void camShake() {
        camAnim.SetTrigger("shake");
    }   
}
