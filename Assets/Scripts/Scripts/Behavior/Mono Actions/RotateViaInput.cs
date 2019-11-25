using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;
namespace SA
{
    [CreateAssetMenu(menuName = "Actions/MonoActions/RotateViaInput")]
    public class RotateViaInput : Action
    {
        public FloatVariable targetFloat;
        public TransformVariable targetTransform;
        public float angle;
        public float speed = 9;
        public bool negative;
        public bool clamp;
        public float minClamp = -35;
        public float maxClamp = 35;
        public RotateAxis targetAxis;

        public override void Execute()
        {
            if (!negative)
                angle += targetFloat.value * speed;
            else
                angle -= targetFloat.value * speed;

            if (clamp)
            {
                angle = Mathf.Clamp(angle, minClamp, maxClamp);
            }
            switch (targetAxis)
            {
                case RotateAxis.x:
                    targetTransform.value.localRotation = Quaternion.Euler(angle, 0, 0);
                    break;
                case RotateAxis.y:
                    targetTransform.value.localRotation = Quaternion.Euler(0, angle, 0);
                    break;
                case RotateAxis.z:
                    targetTransform.value.localRotation = Quaternion.Euler(0, 0, angle);
                    break;
            }
        }
        public enum RotateAxis
        {
            x,y,z

        }
    }

}