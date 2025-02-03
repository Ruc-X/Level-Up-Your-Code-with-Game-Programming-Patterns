using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectPool{
    public class ExampleGun : MonoBehaviour{
        [Tooltip("Prefab to shoot")]
        [SerializeField] private GameObject _projectile;

        [Tooltip("Projectile force")]
        [SerializeField] private float _muzzleVelocity = 700f;
        [Tooltip("End point of gun where shots appear")]
        [SerializeField] private Transform _muzzleTransform;
        [Tooltip("Time between shots / smaller = higher rate of fire")]
        [SerializeField] float _cooldownWindow = 0.1f;

        [Tooltip("Reference to Object Pool")]
        [SerializeField] ObjectPool _objectPool;


        private float nextTimeToShoot = 0f;

        private void FixedUpdate(){
            if(Input.GetMouseButtonDown(0) && Time.time > nextTimeToShoot && _objectPool != null){
                GameObject bulletObject = _objectPool.getPooledObject().gameObject;
                if(bulletObject == null){
                    return;
                }
                bulletObject.gameObject.SetActive(true);

                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 10;
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                bulletObject.transform.SetPositionAndRotation(_muzzleTransform.position+new Vector3(worldPosition.x,worldPosition.y,0f),_muzzleTransform.rotation);
                bulletObject.GetComponent<Rigidbody>().AddForce(bulletObject.transform.up*_muzzleVelocity,ForceMode.Acceleration);

                ExampleProjectile projectile =  bulletObject.GetComponent<ExampleProjectile>();
                projectile.Deactivate();
                nextTimeToShoot = Time.time + _cooldownWindow;
                Debug.Log("fire a bullet!! "+"nextTimeToShoot: "+nextTimeToShoot);
            }
        }
    }
}
