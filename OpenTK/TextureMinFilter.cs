using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    public enum TextureMinFilter
    {
        FILTER4_SGIS = 0x8146,
        Linear = 0x2601,
        LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170,
        LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F,
        LINEAR_MIPMAP_LINEAR = 0x2703,
        LINEAR_MIPMAP_NEAREST = 0x2701,
        Nearest = 0x2600,
        NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E,
        NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D,
        NEAREST_MIPMAP_LINEAR = 0x2702,
        NEAREST_MIPMAP_NEAREST = 0x2700,
        PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184,
        PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186,
        PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185,
    }
}
