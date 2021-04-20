﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.VisualStudio
{
    using System;
    using System.Collections.Generic;
    using WixToolset.Extensibility;

    public class VSExtensionFactory : BaseExtensionFactory
    {
        protected override IReadOnlyCollection<Type> ExtensionTypes => new[]
        {
            typeof(VSCompiler),
            typeof(VSExtensionData),
            typeof(VSWindowsInstallerBackendBinderExtension),
        };
    }
}
