﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Monty.Xdt
{
    public class Locator
    {
        public string Kind { get; set; }
        public string Value { get; set; }

        public static Locator Parse(string locator)
        {
            var match = Regex.Match(locator, @"(\w*)\((.*)\)");

            if (!match.Success)
                throw new InvalidOperationException(String.Format("Invalid Locator attribute '{0}'.", locator));

            return new Locator
            {
                Kind = match.Groups[1].Value,
                Value = match.Groups[2].Value
            };
        }
    }
}