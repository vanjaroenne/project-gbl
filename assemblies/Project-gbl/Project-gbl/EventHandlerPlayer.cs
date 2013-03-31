using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Project_gbl.Eventhandlers
{
    public class EventHandlerPlayer : MonoBehaviour
    {

        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Bang");
        }


    }
}
