using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private string playerTag;
    [SerializeField] private float Speed;
    private void Awake()
    {
        if (this.playerTransform == null)
        {
            if (this.playerTag == "")
            {
                this.playerTag = "Player";
            }
            this.playerTransform = GameObject.FindGameObjectWithTag(this.playerTag).transform;
        }
        this.transform.position = new Vector3(this.playerTransform.position.x, this.playerTransform.position.y, this.playerTransform.position.z - 10);
    }
    private void Update() 
    {
        if (this.playerTransform)
        {
            Vector3 target = new Vector3(this.playerTransform.position.x, this.playerTransform.position.y, this.playerTransform.position.z - 10);
            Vector3 pos = Vector3.Lerp(this.transform.position, target, this.Speed * Time.deltaTime);
            this.transform.position = pos;
        }
    }
}
