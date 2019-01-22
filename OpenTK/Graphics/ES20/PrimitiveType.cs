using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics.ES20
{
    public enum PrimitiveType
    {
        Lines = 0x0001,
        LINES_ADJACENCY = 0x000A,
        LINES_ADJACENCY_ARB = 0x000A,
        LINES_ADJACENCY_EXT = 0x000A,
        LINE_LOOP = 0x0002,
        LINE_STRIP = 0x0003,
        LINE_STRIP_ADJACENCY = 0x000B,
        LINE_STRIP_ADJACENCY_ARB = 0x000B,
        LINE_STRIP_ADJACENCY_EXT = 0x000B,
        PATCHES = 0x000E,
        PATCHES_EXT = 0x000E,
        POINTS = 0x0000,
        POLYGON = 0x0009,
        QUADS = 0x0007,
        QUADS_EXT = 0x0007,
        QUAD_STRIP = 0x0008,
        Triangles = 0x0004,
        TRIANGLES_ADJACENCY = 0x000C,
        TRIANGLES_ADJACENCY_ARB = 0x000C,
        TRIANGLES_ADJACENCY_EXT = 0x000C,
        TriangleFan = 0x0006,
        TriangleStrip = 0x0005,
        TRIANGLE_STRIP_ADJACENCY = 0x000D,
        TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D,
        TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D,
    }
}
