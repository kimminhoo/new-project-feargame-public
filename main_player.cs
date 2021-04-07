using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_player : MonoBehaviour
{
    public GameObject player;
    public GameObject Mgii;
    public GameObject a;

    public int mgimax = 30;

    public float jump = 1.5f;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            //Mgi.newwObject(Mgii);
            Debug.Log("무기생성");
            newObject();
        }

        if (Input.GetKeyDown("r"))
        {
            Invoke("mgich", 1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("die");
            player.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ground")
        {
            Debug.Log("땅");
            if (Input.GetKey("space"))
            {
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jump, ForceMode.Impulse);
            }
        }
    }

    public void newObject()
    {
        if(mgimax < 31 && mgimax > 0)
        {
            GameObject mgi = Instantiate(Mgii) as GameObject;
            //mgi.transform.localPosition = Vector3.zero;
            mgi.transform.position = a.transform.position;
            Destroy(mgi, 2);
            mgimax--;
        }
        else
        {
            // 애니메이션 실행
            Invoke("mgich", 1f);
        }
    }

    public void mgich()
    {
        mgimax = 30;
    }
}

/*
 * int speed = 5;

	// Use this for initialization

	void Start () {

	

	}

	

	// Update is called once per frame

	void Update () {

		moveObject ();

	}



	void moveObject()

	{

		float keyHorizontal = Input.GetAxis("Horizontal");

		float keyVertical = Input.GetAxis("Vertical");



		transform.Translate(Vector3.right * speed * Time.smoothDeltaTime * keyHorizontal , Space.World);

		transform.Translate(Vector3.forward * speed * Time.smoothDeltaTime * keyVertical , Space.World);

	}

	void OnTriggerEnter(Collider other) {

		if (other.transform.tag == "Cube") {

			Destroy(other.gameObject);

		}


	}

}
*/
