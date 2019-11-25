using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;

namespace SA
{
    [CreateAssetMenu(menuName ="Actions/MonoActions/Follow Transform")]
    public class FollowTransform : Action
    {
        public TransformVariable targetTransform;
        public TransformVariable currentTransform;
        public FloatVariable delta;

        public float speed = 20;

        
        // Start is called before the first frame update
        public override void Execute()
        {
            if(targetTransform.value == null)
                return;
            if (currentTransform.value == null)
                return;
            Vector3 up = targetTransform.value.position;
            up.y += 150;
            Vector3 targetPosition = Vector3.Lerp(currentTransform.value.position, targetTransform.value.position, delta.value * speed);
            //targetPosition.y += 100;
            currentTransform.value.position = targetPosition;


        }
    }

}
