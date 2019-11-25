using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Inputs/Axis")]
    public class InputAxis : Action
    {
        public string targetString;
        public float value;
        public SO.FloatVariable variable;
        public override void Execute()
        {
            value = Input.GetAxis(targetString);
            if (variable != null)
            {
                variable.value = value;
            }
        }

    }
}
