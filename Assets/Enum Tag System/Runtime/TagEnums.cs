using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTagSystem
{
    [Flags]
    public enum TagEnums
    {
        //todo custom inspector for int64 version
        //preset values to work with the enum up to 64 values total
        //any more will need a completely custom type, most likely using biginteger or bitarrays
        Untagged = 0,
        //value = 1,
        //value = 2,
        //value = 4,
        //value = 8,
        //value = 16,
        //value = 32,
        //value = 64,
        //value = 128,
        //value = 256,
        //value = 512,
        //value = 1024,
        //value = 2048,
        //value = 4096,
        //value = 8192,
        //value = 16384,
        //value = 32768,
        //value = 65536,
        //value = 131072,
        //value = 262144,
        //value = 524288,
        //value = 1048576,
        //value = 2097152,
        //value = 4194304,
        //value = 8388608,
        //value = 16777216,
        //value = 33554432,
        //value = 67108864,
        //value = 134217728,
        //value = 268435456,
        //value = 536870912,
        //value = 1073741824,
        //int32 limit
        //value = 2147483648,
        //value = 4294967296,
        //value = 8589934592,
        //value = 17179869184,
        //value = 34359738368,
        //value = 68719476736,
        //value = 137438953472,
        //value = 274877906944,
        //value = 549755813888,
        //value = 1099511627776,
        //value = 2199023255552,
        //value = 4398046511104,
        //value = 8796093022208,
        //value = 17592186044416,
        //value = 35184372088832,
        //value = 70368744177664,
        //value = 140737488355328,
        //value = 281474976710656,
        //value = 562949953421312,
        //value = 1125899906842624,
        //value = 2251799813685248,
        //value = 4503599627370496,
        //value = 9007199254740992,
        //value = 18014398509481984,
        //value = 36028797018963968,
        //value = 72057594037927936,
        //value = 144115188075855872,
        //value = 288230376151711744,
        //value = 576460752303423488,
        //value = 1152921504606846976,
        //value = 2305843009213693952,
        //value = 4611686018427387904,
        //int64 limit
    }
}
