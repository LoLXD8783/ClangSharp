// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClangSharp.Extensions;
internal static class StringBuilderExtensions
{
    public static StringBuilder AppendInvariant(this StringBuilder builder, [InterpolatedStringHandlerArgument("builder")] ref StringBuilder.AppendInterpolatedStringHandler str)
    {
        return builder.Append(CultureInfo.InvariantCulture,ref str);
    }
}
