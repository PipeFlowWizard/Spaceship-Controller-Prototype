﻿using UnityEngine;

namespace Racing.Ship
{
    [CreateAssetMenu]
    public class ShipStats : ScriptableObject
    {
        public AudioClip engineClip;
        public AudioClip boostClip;
        public AudioClip brakeClip;



        public float maxVelocity;
        public float maxAngularVelocity = 7f;
        public float maxAcceleration;
        public float boostModifier;

        public float maxDrag;
        public float minDrag;

        public AnimationCurve accelerationCurve;
        public AnimationCurve boostCurve;
        public float yawSpeed;
        public float rollSpeed;
        public float pitchSpeed;

    }
}