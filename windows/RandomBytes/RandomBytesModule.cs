using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Windows.Security.Credentials.UI;

using Microsoft.ReactNative.Managed;
using Microsoft.ReactNative;
using Windows.Networking;
using Windows.Networking.Connectivity;
using Windows.Devices.Power;
using Windows.ApplicationModel;
using Windows.System;

namespace RandomBytes
{
    [ReactModule("RandomBytes")]
    class RandomBytesModule
    {
        [ReactMethod]
        public async void randomBytes(IReactPromise<string> promise)
        {
            promise.Resolve("TEST");
        }
    }
}
