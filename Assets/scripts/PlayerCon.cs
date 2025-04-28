using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerCon : MonoBehaviour
{
    //CharacterController cc;
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 1f;
    public ScoreManager scoreManager;

    Vector3 mousePos, worldPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        var MouseRotate = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);
        var bbb = MouseRotate.eulerAngles;
        transform.eulerAngles = new Vector3(0f, 0f, Mathf.LerpAngle(transform.eulerAngles.z, bbb.z, Time.deltaTime * 4));
        this.transform.position += transform.up * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Triangle"))
        {
            moveSpeed = moveSpeed + 0.5f;
            scoreManager.AddScore(10);
        }
        else
        {
            moveSpeed = moveSpeed - 0.5f;
        }
    }

}
