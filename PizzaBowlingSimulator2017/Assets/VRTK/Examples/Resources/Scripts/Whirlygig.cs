namespace VRTK.Examples
{
    // Uwaga przerobiony !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    using UnityEngine;

    public class Whirlygig : VRTK_InteractableObject
    {
        Transform rotator;

        public override void StartUsing(GameObject usingObject)
        {
            base.StartUsing(usingObject);
            GetComponent<ChangeImage>().ChangeImageNow();
        }

        public override void StopUsing(GameObject usingObject)
        {
            base.StopUsing(usingObject);
        }

        protected override void Start()
        {
            base.Start();
            rotator = transform.Find("Capsule");
        }
    }
}