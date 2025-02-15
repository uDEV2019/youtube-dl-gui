﻿namespace murrty.structs;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Sequential)]
public struct Size {
    /// <summary>
    /// Represents an empty Size value.
    /// </summary>
    public static readonly Size Empty = new(0, 0);
    /// <summary>
    /// The width of the Size.
    /// </summary>
    public int Width {
        get; set;
    }
    /// <summary>
    /// The height of the Size.
    /// </summary>
    public int Height {
        get; set;
    }
    /// <summary>
    /// Whether the <see cref="Size"/> can be considered a valid <see cref="Size"/> compared to <see cref="Empty"/>.
    /// </summary>
    public bool Valid => this.Width > Empty.Width && this.Height > Empty.Height;

    public Size() {
        this = Empty;
    }

    public Size(int Width, int Height) {
        this.Width = Width;
        this.Height = Height;
    }

    /// <inheritdoc />
    public override bool Equals(object obj) => obj is Size size && this.Width == size.Width && this.Height == size.Height;

    /// <inheritdoc />
    public override int GetHashCode() {
        int hashCode = 859600377;
        hashCode = hashCode * -1521134295 + this.Width.GetHashCode();
        hashCode = hashCode * -1521134295 + this.Height.GetHashCode();
        return hashCode;
    }

    /// <summary>
    /// Equals-to operator.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool operator ==(Size a, Size b) => a.Width == b.Width && a.Height == b.Height;
    /// <summary>
    /// Not equals-to operator.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool operator !=(Size a, Size b) => a.Width != b.Width || a.Height != b.Height;

    /// <summary>
    /// Implicitly converts this Point structure to a System.Drawing.Point structure.
    /// </summary>
    /// <param name="p"></param>
    public static implicit operator System.Drawing.Size(Size s) => new(s.Width, s.Height);

    /// <summary>
    /// Implicity converts a System.Drawing.Point structure to this Point structure.
    /// </summary>
    /// <param name="p"></param>
    public static implicit operator Size(System.Drawing.Size s) => new(s.Width, s.Height);
}