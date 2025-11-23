using System;
using System.Collections.Generic;
using System.Text;

namespace MauiExercises.Models
{
    public class PrimeBatch
    {
        public const int BatchSize = 1000000;
        public int NrPrimes { get; set; }
        public int BatchStart { get; set; }
        public int BatchEnd => BatchStart + BatchSize - 2;
        public override string ToString() => $"{NrPrimes:N0} primes between {BatchStart:N0} and {BatchEnd:N0}";
    }
}
