using UnityEngine;
using System.Collections;

namespace SA
{
    [CreateAssetMenu(menuName ="Actions/MonoActions/ActionBatch")]
    public class ActionBatch : Action
    {
        public Action[] actions;
        public override void Execute()
        {
            for(int i =0; i< actions.Length; i++)
            {
                actions[i].Execute();
            }
        }
    } 
}
