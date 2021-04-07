using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mgi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 0.01f);
    }

    /*
    public static void newwObject(GameObject Mgii)
    {
        GameObject mgi = Instantiate(Mgii) as GameObject;
        mgi.transform.localPosition = Vector3.zero;
    }
    */
}
