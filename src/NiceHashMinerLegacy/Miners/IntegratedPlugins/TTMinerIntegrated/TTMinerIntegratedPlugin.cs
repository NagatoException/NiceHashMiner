﻿using MinerPlugin;

namespace NiceHashMiner.Miners.IntegratedPlugins
{
    public class TTMinerIntegratedPlugin : TTMiner.TTMinerPlugin, IntegratedPlugin
    {
        public TTMinerIntegratedPlugin() : base("TTMiner")
        { }

        public bool Is3rdParty => true;
    }
}