﻿// Copyright (c) Samuel Cragg.
//
// Licensed under the MIT license. See LICENSE file in the project root for
// full license information.

namespace Crest.Host.Engine
{
    using System;
    using System.Reflection;

    /// <summary>
    /// PRovides information about a route to match.
    /// </summary>
    public sealed class RouteMetadata
    {
        /// <summary>
        /// Gets or sets the factory to use to create an instance of the object
        /// that <see cref="Method"/> is invoked on.
        /// </summary>
        public Func<object> Factory { get; set; }

        /// <summary>
        /// Gets or sets the method to invoke when the route is matched.
        /// </summary>
        public MethodInfo Method { get; set; }

        /// <summary>
        /// Gets or sets the URL to match.
        /// </summary>
        public string RouteUrl { get; set; }

        /// <summary>
        /// Gets or sets the HTTP verb to match.
        /// </summary>
        public string Verb { get; set; }
    }
}
