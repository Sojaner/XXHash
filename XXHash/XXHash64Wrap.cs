// Create By Shibox 


namespace XXHash
{
    public static partial class XXHash64
    {
        public static unsafe ulong Hash(this byte[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (byte* @in = &input[offset])
            {
                return Hash(@in, count * sizeof(byte), seed);
            }
        }

        public static unsafe ulong Hash(this byte[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (byte* @in = &input[0])
            {
                return Hash(@in, input.Length * sizeof(byte), seed);
            }
        }

        public static unsafe ulong Hash(this sbyte[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (sbyte* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(sbyte), seed);
            }
        }

        public static unsafe ulong Hash(this sbyte[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (sbyte* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(sbyte), seed);
            }
        }

        public static unsafe ulong Hash(this ushort[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (ushort* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(ushort), seed);
            }
        }

        public static unsafe ulong Hash(this ushort[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (ushort* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(ushort), seed);
            }
        }

        public static unsafe ulong Hash(this short[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (short* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(short), seed);
            }
        }

        public static unsafe ulong Hash(this short[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (short* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(short), seed);
            }
        }

        public static unsafe ulong Hash(this uint[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (uint* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(uint), seed);
            }
        }

        public static unsafe ulong Hash(this uint[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (uint* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(uint), seed);
            }
        }

        public static unsafe ulong Hash(this int[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (int* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(int), seed);
            }
        }

        public static unsafe ulong Hash(this int[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (int* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(int), seed);
            }
        }

        public static unsafe ulong Hash(this ulong[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (ulong* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(ulong), seed);
            }
        }

        public static unsafe ulong Hash(this ulong[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (ulong* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(ulong), seed);
            }
        }

        public static unsafe ulong Hash(this long[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (long* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(long), seed);
            }
        }

        public static unsafe ulong Hash(this long[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (long* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(long), seed);
            }
        }

        public static unsafe ulong Hash(this float[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (float* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(float), seed);
            }
        }

        public static unsafe ulong Hash(this float[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (float* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(float), seed);
            }
        }

        public static unsafe ulong Hash(this double[] input, int offset, int count, ulong seed = 0)
        {
            if (input == null || input.Length == 0 || count == 0)
                return 0;
            fixed (double* @in = &input[offset])
            {
                return Hash((byte*)@in, count * sizeof(double), seed);
            }
        }

        public static unsafe ulong Hash(this double[] input, ulong seed = 0)
        {
            if (input == null || input.Length == 0)
                return 0;
            fixed (double* @in = &input[0])
            {
                return Hash((byte*)@in, input.Length * sizeof(double), seed);
            }
        }

    }
}