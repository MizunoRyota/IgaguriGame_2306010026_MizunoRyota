using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static System.TimeZoneInfo;

public class IgaguriController : MonoBehaviour
{
    public float DestroyTime;

    private float elapsedTime;
    // Update is called once per frame
    void Start()
    {
        DestroyTime = 0.3f;
        elapsedTime = 0f;
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 200, 2000));
    }
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= DestroyTime)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
}
