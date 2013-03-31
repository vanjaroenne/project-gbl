using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Project_gbl.Functions
{
    public class FunctionsController
    {
        private static FunctionsController instance = new FunctionsController();
        public static FunctionsController Instance { get { return instance; } }

        private GameObject objectOnScreen;

        //public delegate void UpdateObjectPosition(float x, float y);
        //public UpdateObjectPosition PositionUpdater = delegate(float x, float y) { Debug.Log("x: " + x + " y: " + y); };

        private FunctionsController() { }

        public void RestartGame() { }

        private void UpdateUser(ZigTrackedUser inputUser)
        {
            if (inputUser == null)
                return;
            foreach (ZigInputJoint joint in inputUser.Skeleton)
            {
                if (joint.Id == ZigJointId.Torso)
                {
                    var normalized = joint.Position.normalized;
                    //Debug.Log("Position: x: " + normalized.x + " y: " + normalized.y + " z: " + normalized.z);
                    if (objectOnScreen != null)
                    {
                        var currentPosition = objectOnScreen.transform.localPosition;
                        objectOnScreen.transform.localPosition = new Vector3(normalized.x, normalized.y, normalized.z) * 7;
                    }
                }
            }
        }

        public void UpdateZigInformation(ZigInput input)
        {
            foreach (ZigTrackedUser user in input.TrackedUsers.Values)
            {
                UpdateUser(user);
            }
        }

        public void UpdateObjectOnScreen(GameObject gameObject)
        {
            this.objectOnScreen = gameObject;
        }



    }
}
