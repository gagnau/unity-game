using UnityEngine;

public class Remove : MonoBehaviour
{
    private Rigidbody body;

    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("Click");
        this.body.AddForce(new Vector3(150, 0, 100));
    }
}
