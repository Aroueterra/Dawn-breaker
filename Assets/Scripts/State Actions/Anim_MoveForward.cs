using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/State Actions/Anim_MoveForward")]
    public class Anim_MoveForward : StateActions
    {
        public override void Execute(StateManager states)
        {
            states.anim.SetFloat(states.hashes.vertical,states.movementVariables.moveAmount, 0.2f, states.delta);

        }
    }

}