﻿using System;
using System.Collections.Generic;

namespace Archipelago.MultiClient.Net.BounceFeatures.DeathLink
{
    public static class DeathLinkProvider
    {
        // ReSharper disable once UnusedMember.Global
        /// <summary>
        ///     creates and returns a <see cref="DeathLinkService"/> for this <paramref name="session"/>.
        /// </summary>
        public static DeathLinkService CreateDeathLinkService(this ArchipelagoSession session)
        {
            return new DeathLinkService(session.Socket, session.ConnectionInfo, session.DataStorage);
        }
    }
}