#region License

/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

#endregion

using System;
using System.Collections.Generic;

namespace Gremlin.Net.Process.Traversal
{
#pragma warning disable 1591

    public class Scope : EnumWrapper
    {
        private Scope(string enumValue)
            : base("Scope", enumValue)
        {
        }

        public static Scope Global => new Scope("global");

        public static Scope Local => new Scope("local");

        private static readonly IDictionary<string, Scope> Properties = new Dictionary<string, Scope>
        {
            { "global", Global },
            { "local", Local },
        };

        /// <summary>
        /// Gets the Scope enumeration by value.
        /// </summary>
        public static Scope GetByValue(string value)
        {
            if (!Properties.TryGetValue(value, out var property))
            {
                throw new ArgumentException($"No matching Scope for value '{value}'");
            }
            return property;
        }
    }


#pragma warning restore 1591
}