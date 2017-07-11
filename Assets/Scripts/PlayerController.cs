
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private int count;
    public int wincount;
    void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * moveVertical * speed / 2);
        //transform.localPosition = new Vector3(transform.position.x + speed * moveHorizontal/50, transform.position.y, transform.position.z + speed * moveVertical / 50);
        transform.Rotate(transform.up, moveHorizontal * Time.deltaTime * speed * 8);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;

            if (count == wincount) Time.timeScale = 0f;

            float new_x,new_z;
            new_x = Random.Range(-7.0f,7.0f);
            new_z = Random.Range(-7.0f,7.0f);
            
            other.gameObject.transform.position = new Vector3(new_x,0.5f,new_z);
            other.gameObject.SetActive(true);
        }
        if(other.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 0f;
        }
    }
}
