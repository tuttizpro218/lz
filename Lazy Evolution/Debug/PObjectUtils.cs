﻿/*
This file is part of LazyBot - Copyright (C) 2011 Arutha

    LazyBot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LazyBot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with LazyBot.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using LazyLib.Wow;

namespace LazyEvo.Debug
{
    internal class PObjectUtils : PObject
    {
        public PObjectUtils(uint baseAddress)
            : base(baseAddress)
        {
        }

        public List<NameValuePair> GetNameValuePairs()
        {
            Boolean flag = BaseAddress != 0;
            var nvList = new List<NameValuePair>();
            nvList.Add(new NameValuePair("PObject", ""));
            nvList.Add(new NameValuePair("GUID", flag ? "" + GUID : ""));
            nvList.Add(new NameValuePair("Type", flag ? "" + Type : ""));
            nvList.Add(new NameValuePair("X", flag ? "" + X : ""));
            nvList.Add(new NameValuePair("Y", flag ? "" + Y : ""));
            nvList.Add(new NameValuePair("Z", flag ? "" + Z : ""));
            nvList.Add(new NameValuePair("Facing", flag ? "" + Facing : ""));
            nvList.Add(new NameValuePair("IsMe", flag ? "" + IsMe : ""));
            return nvList;
        }
    }
}