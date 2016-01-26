﻿using OpenStack.Compute.v2_1;
using OpenStack.Synchronous.Extensions;

// ReSharper disable once CheckNamespace
namespace OpenStack.Synchronous
{
    /// <summary />
    public static class KeypairExtensions_v2_1
    {
        /// <inheritdoc cref="KeyPair.DeleteAsync" />
        public static void Delete(this KeyPair keypair)
        {
            keypair.DeleteAsync().ForceSynchronous();
        }
    }
}
