using System;

namespace FractionTraining
{
    public class FractionService
    {
        private readonly Random _random = new Random();
        private readonly FractionGeneratorConfig _config = new FractionGeneratorConfig();

        public FractionService() : this(new FractionGeneratorConfig()) { }

        public FractionService(FractionGeneratorConfig config)
        {
            _random = new Random();
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public Fraction GenerateFraction()
        {
            var numerator = _random.Next(_config.MinNumerator, _config.MaxNumerator);
            var denominator = GetValidDenomerator(numerator);
            var multiplier = _random.Next(_config.MinMultiplier, _config.MaxMultiplier);

            var originalNumerator = numerator * multiplier;
            var originalDenominator = denominator * multiplier;
            var gcd = GetGreatestCommonDivisor(originalNumerator, originalDenominator);

            return new Fraction 
            { 
                Numerator = originalNumerator,
                Denomerator = originalDenominator,
                SimplifiedNumerator = originalNumerator / gcd,
                SimplifiedDenomerator = originalDenominator / gcd
            };
        }

        private int GetValidDenomerator(int numerator)
        {
            var denominator = _random.Next(_config.MinDenominator, _config.MaxDenominator);
            return numerator == denominator ? denominator + 1 : denominator;
        }

        private int GetGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
