using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesNo : MonoBehaviour
{
    public GameObject bGround;
    public GameObject bGroundA;
    public GameObject bGroundB;
     // Update is called once per frame
    void Update()
    {
        bGroundA.SetActive(false);
        bGroundA.SetActive(false);
    }

    public void BranchA()
    {
        bGround.SetActive(false);
        bGroundA.SetActive(true);
    }

    public void BranchB()
    {
        bGround.SetActive(false);
        bGroundB.SetActive(true);
    }
}
