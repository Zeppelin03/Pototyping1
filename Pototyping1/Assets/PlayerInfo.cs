using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public bool SphereIn = false, BoxIn = false, CapsuleIn = false, reset = false;
    public Text Qs;
    List<string> questions = new List<string>();
    public   int x;

    // Start is called before the first frame update
    void Start()
    {
        Qs.gameObject.SetActive(false);
        questions.Add("What is your name");
        questions.Add("What is your age");
        questions.Add("Where do you live");
        questions.Add("What type of music do you like");
        questions.Add("What are your hobbies");
        questions.Add("What is your favourite movie/TV show");
        x = 0;

    }

    // Update is called once per frame
    void Update()
    {


        if (SphereIn == true && BoxIn == true && CapsuleIn == true && reset == false)
        {
            reset = true;
            Qs.gameObject.SetActive(true);
            Qs.text = questions[x];
            x++;
            x = x % 6;
            returnObjects();
        }
    }

    void returnObjects()
    {
        GameObject.FindGameObjectWithTag("SpherePickUp").GetComponent<Transform>().position = GameObject.FindGameObjectWithTag("SpherePickUp").GetComponent<PickUp>().original.position;
        GameObject.FindGameObjectWithTag("CubePickUp").GetComponent<Transform>().position = GameObject.FindGameObjectWithTag("CubePickUp").GetComponent<PickUp>().original.position;
        GameObject.FindGameObjectWithTag("CapsulePickUp").GetComponent<Transform>().position = GameObject.FindGameObjectWithTag("CapsulePickUp").GetComponent<PickUp>().original.position;

        reset = false;
        Debug.Log("kjucbhasdbefc");
        SphereIn = false;
        BoxIn = false;
        CapsuleIn = false;
    }
}
