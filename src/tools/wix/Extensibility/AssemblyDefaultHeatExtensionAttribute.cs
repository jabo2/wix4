// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Tools
{
    using System;

    /// <summary>
    /// Represents a custom attribute for declaring the type to use
    /// as the default heat extension in an assembly.
    /// </summary>
    public class AssemblyDefaultHeatExtensionAttribute : Attribute
    {
        private readonly Type extensionType;

        /// <summary>
        /// Instantiate a new AssemblyDefaultHeatExtensionAttribute.
        /// </summary>
        /// <param name="extensionType">The type of the default heat extension in an assembly.</param>
        public AssemblyDefaultHeatExtensionAttribute(Type extensionType)
        {
            this.extensionType = extensionType;
        }

        /// <summary>
        /// Gets the type of the default heat extension in an assembly.
        /// </summary>
        /// <value>The type of the default heat extension in an assembly.</value>
        public Type ExtensionType
        {
            get { return this.extensionType; }
        }
    }
}
