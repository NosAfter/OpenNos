﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using System.Collections.Generic;

namespace OpenNos.GameObject
{
    [PacketHeader("mtlist")]
    public class MultiTargetListPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte TargetsAmount { get; set; }

        [PacketIndex(1, RemoveSeparator = true)]
        public List<MultiTargetListSubPacket> Targets { get; set; }

        #endregion
    }
}