using UnityEngine;

class Vector3Utils
    {
        public static Vector3 MoveTowards(Vector3 current, Vector3 target, float speed)
        {
            var newX = Mathf.MoveTowards(current.x, target.x, speed * Time.deltaTime);
            var newY = Mathf.MoveTowards(current.y, target.y, speed * Time.deltaTime);
            var newZ = Mathf.MoveTowards(current.z, target.z, speed * Time.deltaTime);
            return new Vector3(newX, newY, newZ);
        }
    }

