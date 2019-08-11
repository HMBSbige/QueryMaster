#region License
/*
Copyright (c) 2015 Betson Roy

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/
#endregion

using QueryMaster.Steam.Interfaces;

namespace QueryMaster.Steam
{
    /// <summary>
    /// Represents Steam's web api interface.
    /// </summary>
    public class SteamQuery
    {
        /// <summary>
        /// Initializes Steam's web api interface. 
        /// </summary>
        /// <param name="apiKey">Api key.</param>
        public SteamQuery(string apiKey = "")
        {
            ApiKey = apiKey;
        }
        /// <summary>
        /// Api key.
        /// </summary>
        public string ApiKey { get { return SteamUrl.ApiKey; } set { SteamUrl.ApiKey = value; } }
        private ISteamApps iSteamApps;
        /// <summary>
        /// Represents the ISteamApps interface.
        /// </summary>
        public ISteamApps ISteamApps { get { if (iSteamApps == null) iSteamApps = new ISteamApps(); return iSteamApps; } }

        private ISteamNews iSteamNews;
        /// <summary>
        /// Represents the ISteamNews interface.
        /// </summary>
        public ISteamNews ISteamNews { get { if (iSteamNews == null) iSteamNews = new ISteamNews(); return iSteamNews; } }

        private ISteamUser iSteamUser;
        /// <summary>
        /// Represents the ISteamUser interface.
        /// </summary>
        public ISteamUser ISteamUser { get { if (iSteamUser == null) iSteamUser = new ISteamUser(); return iSteamUser; } }

        private ISteamUserStats iSteamUserStats;
        /// <summary>
        /// Represents the ISteamUserStats interface.
        /// </summary>
        public ISteamUserStats ISteamUserStats { get { if (iSteamUserStats == null) iSteamUserStats = new ISteamUserStats(); return iSteamUserStats; } }

        private ISteamWebApiUtil iSteamWebApiUtil;
        /// <summary>
        /// Represents the ISteamWebAPIUtil interface.
        /// </summary>
        public ISteamWebApiUtil ISteamWebApiUtil { get { if (iSteamWebApiUtil == null) iSteamWebApiUtil = new ISteamWebApiUtil(); return iSteamWebApiUtil; } }

        private ISteamDirectory iSteamDirectory;
        /// <summary>
        /// Represents the ISteamDirectory interface.
        /// </summary>
        public ISteamDirectory ISteamDirectory { get { if (iSteamDirectory == null) iSteamDirectory = new ISteamDirectory(); return iSteamDirectory; } }

        private IPlayerService iPlayerService;
        /// <summary>
        /// Represents the IPlayerService interface.
        /// </summary>
        public IPlayerService IPlayerService { get { if (iPlayerService == null) iPlayerService = new IPlayerService(); return iPlayerService; } }
        private ISteamGroup iSteamGroup;
        /// <summary>
        ///  Represents the ISteamGroup interface(not part of steam's web api).
        /// </summary>
        public ISteamGroup ISteamGroup { get { if (iSteamGroup == null) iSteamGroup = new ISteamGroup(); return iSteamGroup; } }

    }
}
