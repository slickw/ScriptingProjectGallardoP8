using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
        public Stuff myStuff = new Stuff(10, 7, 25);
        public float speed;
        public float turnSpeed;
        public Rigidbody bulletPrefab;
        public Transform firePosition;
        public float bulletSpeed;

       // Start is called before the first frame update
       void Movement ()
        {
            float fowardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        }

        // Update is called once per frame
        void Update()
        {
            Movement();
            Shoot();
        }

        void Shoot ()
        {
            if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
            {
                Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
                bulletInstance.AddForce(firePosition.forward * bulletSpeed);
                myStuff.bullets--;
            }
        }
    }
}
