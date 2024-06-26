// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace ClangSharp.Interop;

public unsafe partial struct CXIdxClientFile(IntPtr handle) : IEquatable<CXIdxClientFile>
{
    public IntPtr Handle { get; set; } = handle;

    public static explicit operator CXIdxClientFile(void* value) => new CXIdxClientFile((IntPtr)value);

    public static implicit operator void*(CXIdxClientFile value) => (void*)value.Handle;

    public static bool operator ==(CXIdxClientFile left, CXIdxClientFile right) => left.Handle == right.Handle;

    public static bool operator !=(CXIdxClientFile left, CXIdxClientFile right) => left.Handle != right.Handle;

    public override readonly bool Equals(object? obj) => (obj is CXIdxClientFile other) && Equals(other);

    public readonly bool Equals(CXIdxClientFile other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();
}
