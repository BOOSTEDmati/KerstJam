using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private bool IJ;
    // Start is called before the first frame update
    void Start()
    {
        IJ = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& IJ == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 19, 0);

            IJ = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            IJ = false;
        }

        if (collision.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene("SampleScene");
            ScoreScript.scoreValue = 0;
        }
    }
}
