using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Unit : SemanticType<decimal>
    {
        public IEnumerable<UnitDimenison> Dimensions { get; }
        public double Scale { get; }

        internal Unit(decimal value, double scale, params UnitDimenison[] dimensions) : base((val) => true, value)
        {
            Scale = scale;
            Dimensions = dimensions;
        }

        internal Unit(decimal value, SiPrefix scale, params UnitDimenison[] dimensions) : this(value, (int)scale, dimensions)
        {

        }

        protected static UnitDimenison GetInverse(UnitDimenison dimension)
        {
            return (UnitDimenison)((int)dimension*-1);
        }

        protected static Unit Invert(Unit unit)
        {
            return new Unit(unit.Value, -1 * unit.Scale, unit.Dimensions.Select(GetInverse).ToArray());
        }

        public static Unit operator +(Unit a, Unit b)
        {
            if (!CompareDims(a, b))
            {
                throw new InvalidDimensionsException();
            }

            if (a.Scale == b.Scale)
            {
                return new Unit(a.Value + b.Value, a.Scale, a.Dimensions.ToArray());
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static Unit operator -(Unit a, Unit b)
        {
            if (!CompareDims(a, b))
            {
                throw new InvalidDimensionsException();
            }

            if (a.Scale == b.Scale)
            {
                return new Unit(a.Value - b.Value, a.Scale, a.Dimensions.ToArray());
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static Unit operator *(Unit a, Unit b)
        {
            return new Unit(a.Value * b.Value, a.Scale + b.Scale, Mult(a.Dimensions, b.Dimensions).ToArray());
        }

        public static Unit operator /(Unit a, Unit b)
        {
            return new Unit(a.Value / b.Value, a.Scale - b.Scale, Div(a.Dimensions, b.Dimensions).ToArray());
        }

        private static bool CompareDims(Unit a, Unit b)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<UnitDimenison> Mult(IEnumerable<UnitDimenison> a, IEnumerable<UnitDimenison> b)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<UnitDimenison> Div(IEnumerable<UnitDimenison> a, IEnumerable<UnitDimenison> b)
        {
            throw new NotImplementedException();
        }
    }

    public class InvalidDimensionsException : Exception
    {
    }

    public static class Length
    {
        public static Unit FromMeters(decimal quantity, int tenPower)
        {

        }

        public static Unit FromFeet(decimal quantity, int tenPower)
        {

        }

        public static Unit FromMiles(decimal quantity, int tenPower)
        {

        }

        public static Unit FromInches(decimal quantity, int tenPower)
        {

        }
    }

    public static class Mass
    {
        public static Unit FromPounds(decimal quantity, int tenPower)
        {

        }

        public static Unit FromGrams(decimal quantity, int tenPower)
        {

        }

        public static Unit FromKilograms(decimal quantity, int tenPower)
        {

        }

        public static Unit FromStone(decimal quantity, int tenPower)
        {

        }

        public static Unit FromTons(decimal quantity, int tenPower)
        {

        }

        public static Unit FromMetricTonnes(decimal quantity, int tenPower)
        {

        }
    }

    public static class Time
    {
        
    }

    public static class Current
    {
        
    }

    public class Temperature
    {
        
    }

    public static class Quantity
    {
        
    }

    public static class Intensity
    {
        
    }

    public static class Constant
    {
        public const decimal AvogadrosNumber = 6.02214199e23M;

    }

    public enum UnitDimenison
    {
        Scalar = 0,
        Length = 1,
        Mass = 2,
        Time = 3,
        Current = 4,
        Temperature = 5,
        Quantity = 6,
        Intensity = 7,
        InverseLength = -1,
        InverseMass = -2,
        InverseTime = -3,
        InverseCurrent = -4,
        InverseTemperature = -5,
        InverseQuantity = -6,
        InverseIntensity = -7
    }

    public enum SiPrefix
    {
        yocto = -24,
        zepto = -21,
        atto = -18,
        femto = -15,
        pico = -12,
        nano = -9,
        micro = -6,
        milli = -3,
        centi = -2,
        deci = -1,
        _ = 1,
        deca = 2,
        kilo = 3,
        mega = 6,
        giga = 9,
        tera = 12,
        peta = 15,
        exa = 18,
        zetta = 21,
        yotta = 24
    }
}
