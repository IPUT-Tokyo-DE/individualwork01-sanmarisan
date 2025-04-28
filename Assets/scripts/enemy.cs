using System.Collections;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Camera maincam;
    private float delayTime = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 viewportPos = maincam.WorldToViewportPoint(transform.position);

        if(viewportPos.x < 0f || viewportPos.x > 1f || viewportPos.y < 0f || viewportPos.y > 1f)
        {
            StartCoroutine(DestroyAfterDelay(delayTime));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(this.gameObject);
        Destroy(this.gameObject);
    }

    IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(this.gameObject);
    }
}
