﻿
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

using System;

namespace QueryMaster.GameServer.DataObjects
{
    /// <summary>
    /// Contains information about the Mod.
    /// </summary>
    /// <remarks>Present only in Obsolete server responses.</remarks>
    [Serializable]
    public class ModInfo : DataObject
    {
        /// <summary>
        /// URL to mod website. 
        /// </summary>
        public string Link { get; internal set; }
        /// <summary>
        /// URL to download the mod. 
        /// </summary>
        public string DownloadLink { get; internal set; }
        /// <summary>
        /// Version of mod installed on server. 
        /// </summary>
        public long Version { get; internal set; }
        /// <summary>
        /// Space (in bytes) the mod takes up. 
        /// </summary>
        public long Size { get; internal set; }
        /// <summary>
        /// Indicates the type of mod.
        /// </summary>
        public bool IsOnlyMultiPlayer { get; internal set; }
        /// <summary>
        /// Indicates whether mod uses its own DLL.
        /// </summary>
        public bool IsHalfLifeDll { get; internal set; }

    }
}
