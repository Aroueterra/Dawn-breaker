using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SO;
namespace SA
{
    [CreateAssetMenu(menuName = "Actions/MonoActions/InputManager")]
    public class InputManager : Action
    {
        public FloatVariable horizontal;
        public FloatVariable vertical;
        public StateManagerVariable playerStates;
        public ActionBatch inputUpdateBatch;
        public override void Execute()
        {
            inputUpdateBatch.Execute();
            if (playerStates.value != null)
            {
                playerStates.value.movementVariables.horizontal = horizontal.value;
                playerStates.value.movementVariables.vertical = vertical.value;
                float moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal.value) + Mathf.Abs(vertical.value));
                playerStates.value.movementVariables.moveAmount = moveAmount;
            }
        }
    }

}