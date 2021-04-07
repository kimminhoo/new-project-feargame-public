using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed); // 프레임마다 오브젝트를 로컬좌표상에서 뒤로(back) * speed의 힘만큼 날아가라
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mgi")
        {
            Debug.Log("적 죽음");
            Destroy(enemy);
        }
    }
}
