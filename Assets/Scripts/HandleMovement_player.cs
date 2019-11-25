using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class HandleMovement_Player : MonoBehaviour
    {
        StateManager states;
        Rigidbody rb;
        public bool doAngleCheck = false;
        [SerializeField]
        bool useDot = true;
        bool overrideForce;
        bool inAngle;
    }

}
