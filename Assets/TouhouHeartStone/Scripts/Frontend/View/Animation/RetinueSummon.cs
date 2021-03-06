﻿using System;
using UnityEngine;
using IGensoukyo.Utilities;

namespace TouhouHeartstone.Frontend.View.Animation
{
    public class RetinueSummon : CardAnimation
    {
        public override string AnimationName => "RetinueSummon";

        public override void PlayAnimation(object sender, EventArgs args, GenericAction callback)
        {
            var arg = Utilities.CheckType<CardPositionEventArgs>(args);
            var gv = Card.GetComponentInParent<GlobalView>();

            Card.gameObject.SetActive(true);
            var pos = gv.CardPositionCalculator.GetServantPosition(arg.GroupID, arg.GroupCount);
            Card.GetOrAddComponent<PositionAnimation>().Play(new Vector3[2]
            {
                pos.Position,
                pos.Position
            }, new Vector3[2] {
                pos.Rotation,
                pos.Rotation
            }, callback);
        }
    }

    public class RetinueMove : CardAnimation
    {
        public override string AnimationName => "RetinueMove";

        public override void PlayAnimation(object sender, EventArgs args, GenericAction callback)
        {
            var arg = Utilities.CheckType<CardPositionEventArgs>(args);
            var gv = Card.GetComponentInParent<GlobalView>();

            var pos = gv.CardPositionCalculator.GetServantPosition(arg.GroupID, arg.GroupCount);
            Card.GetOrAddComponent<PositionAnimation>().Play(new Vector3[2]
            {
                Card.transform.localPosition,
                pos.Position
            }, new Vector3[2] {
                Card.transform.localRotation.eulerAngles,
                pos.Rotation
            }, callback);
        }
    }
}
