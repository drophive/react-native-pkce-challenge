using System;
using Microsoft.ReactNative.Managed;

namespace RandomBytes
{
    [ReactModule("RandomBytes")]
    class RandomBytesModule
    {
        [ReactMethod]
        public void randomBytes(IReactPromise<string> promise)
        {
            promise.Resolve("TEST");
        }
    }
}
