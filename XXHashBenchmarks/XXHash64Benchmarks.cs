﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XXHash;

namespace XXHashBenchmarks
{
    public class XXHash64Benchmarks
    {
        public unsafe static void Run()
        {
            //HashRandomBytes();
            HashStringTest();
        }

        public unsafe static void HashRandomBytes()
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            byte[] bytes = new byte[1024];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = (byte)rd.Next(0, byte.MaxValue);

            ulong hash1 = 0;
            ulong hash2 = 0;
            ulong hash3 = 0;
            ulong hash4 = 0;

            //Stopwatch w = Stopwatch.StartNew();
            //fixed (Byte* @in = &bytes[0])
            //{
            //    for (int i = 0; i < 10000000; i++)
            //    {
            //        //hash1 = XXHash64.Hash(@in, bytes.Length, 0);
            //        //XXHash64.Hash(@in, bytes.Length, ref hash1,ref hash2,0,0);
            //        //XXHash64.Hash(@in, bytes.Length, ref hash1, ref hash2,ref hash3, 0, 0,0);
            //        XXHash64.Hash(@in, bytes.Length, ref hash1, ref hash2, ref hash3,ref hash4, 0, 0, 0,0);
            //    }
            //}

            Stopwatch w = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)
            {
                hash1 = XXHash64.Hash(bytes);
                //hash2 = XXHash32.Hash(bytes);
            }

            w.Stop();
            Console.WriteLine($"cost:{w.ElapsedMilliseconds}");
            Console.WriteLine(hash1 == hash2);
        }

        public unsafe static void HashStringTest()
        {
            ulong hash1 = 0;
            ulong hash2 = 0;
            string s = "e000153353779d0d3d0ec78bd0321c7d";
            Stopwatch w = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)
            {
                //hash1 = XXHash64.Hash(s);
                //hash2 = XXHash32.Hash(bytes);
                hash1 = FNVHash(s);
            }
            w.Stop();
            Console.WriteLine($"cost:{w.ElapsedMilliseconds}");

        }

        public static ulong FNVHash(String str)
        {
            ulong fnv_prime = 0x811C9DC5;
            ulong hash = 0;

            for (int i = 0; i < str.Length; i++)
            {
                hash *= fnv_prime;
                hash ^= str[i];
            }

            return hash;
        }


    }
}
