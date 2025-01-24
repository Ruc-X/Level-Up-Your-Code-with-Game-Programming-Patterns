using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnrefactoredPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string inputAxisName;
    [SerializeField] private float positionMultiplier;
    private float yPosition;

    private AudioSource bounceSfx;
    void Start()
    {
        bounceSfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float delta  = Input.GetAxis(inputAxisName) * Time.deltaTime;
        yPosition = Mathf.Clamp(yPosition + delta, -1,1);
        transform.position = new Vector3(transform.position.x,yPosition * positionMultiplier,transform.position.z);
    }
    private void OnTriggerEnter(Collider other) {
        bounceSfx.Play();
    }

}
