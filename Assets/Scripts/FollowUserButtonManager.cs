using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUserButtonManager : MonoBehaviour
{
    public bool followOn;

    private int n;
    public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
   }
}