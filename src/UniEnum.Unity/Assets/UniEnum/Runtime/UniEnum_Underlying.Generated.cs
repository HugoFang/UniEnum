﻿// <auto-generated>
// This file generated from UniEnum.
// </auto-generated>
using System;
using System.Runtime.CompilerServices;

namespace UniEnumUtils
{
    public partial class UniEnum
    {
        #region 'IsDefined' methods for each UnderlyingTypes

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(sbyte value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.SByte)
                return SByteEnum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and sbyte comparing not supported");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(byte value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.Byte)
                return ByteEnum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and byte comparing not supported");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(short value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.Int16)
                return Int16Enum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and short comparing not supported");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(ushort value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.UInt16)
                return UInt16Enum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and ushort comparing not supported");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(int value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.Int32)
                return Int32Enum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and int comparing not supported");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(uint value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.UInt32)
                return UInt32Enum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and uint comparing not supported");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(long value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.Int64)
                return Int64Enum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and long comparing not supported");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(ulong value) where T : unmanaged, Enum
        {
            if (UnderlyingTypeInfo<T>.UnderlyingTypeCode == TypeCode.UInt64)
                return UInt64Enum<T>.Operation.IsDefined(value);
            throw new NotSupportedException($"{typeof(T).Name} and ulong comparing not supported");
        }

        #endregion
    }

    #region SByteEnum

    internal sealed class SByteEnum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly sbyte MinValue; 
        public static readonly sbyte MaxValue;

        public static Base Operation;

        static SByteEnum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (sbyte min, sbyte max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            sbyte min, max, previous;
            min = max = previous = Unsafe.As<T, sbyte>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, sbyte>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (sbyte.TryParse(text, out var v))
                {
                    result = Unsafe.As<sbyte, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, sbyte>(value));
            }
            
            public abstract bool IsDefined(sbyte value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(sbyte value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly HashTable<sbyte, ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new HashTable<sbyte, ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, sbyte>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(sbyte value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion

    #region ByteEnum

    internal sealed class ByteEnum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly byte MinValue; 
        public static readonly byte MaxValue;

        public static Base Operation;

        static ByteEnum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (byte min, byte max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            byte min, max, previous;
            min = max = previous = Unsafe.As<T, byte>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, byte>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (byte.TryParse(text, out var v))
                {
                    result = Unsafe.As<byte, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, byte>(value));
            }
            
            public abstract bool IsDefined(byte value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(byte value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly HashTable<byte, ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new HashTable<byte, ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, byte>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(byte value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion

    #region Int16Enum

    internal sealed class Int16Enum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly short MinValue; 
        public static readonly short MaxValue;

        public static Base Operation;

        static Int16Enum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (short min, short max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            short min, max, previous;
            min = max = previous = Unsafe.As<T, short>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, short>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (short.TryParse(text, out var v))
                {
                    result = Unsafe.As<short, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, short>(value));
            }
            
            public abstract bool IsDefined(short value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(short value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly HashTable<short, ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new HashTable<short, ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, short>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(short value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion

    #region UInt16Enum

    internal sealed class UInt16Enum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly ushort MinValue; 
        public static readonly ushort MaxValue;

        public static Base Operation;

        static UInt16Enum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (ushort min, ushort max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            ushort min, max, previous;
            min = max = previous = Unsafe.As<T, ushort>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, ushort>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (ushort.TryParse(text, out var v))
                {
                    result = Unsafe.As<ushort, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, ushort>(value));
            }
            
            public abstract bool IsDefined(ushort value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(ushort value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly HashTable<ushort, ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new HashTable<ushort, ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, ushort>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(ushort value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion

    #region Int32Enum

    internal sealed class Int32Enum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly int MinValue; 
        public static readonly int MaxValue;

        public static Base Operation;

        static Int32Enum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (int min, int max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            int min, max, previous;
            min = max = previous = Unsafe.As<T, int>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, int>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (int.TryParse(text, out var v))
                {
                    result = Unsafe.As<int, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, int>(value));
            }
            
            public abstract bool IsDefined(int value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(int value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly Int32HashTable<ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new Int32HashTable<ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, int>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(int value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion

    #region UInt32Enum

    internal sealed class UInt32Enum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly uint MinValue; 
        public static readonly uint MaxValue;

        public static Base Operation;

        static UInt32Enum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (uint min, uint max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            uint min, max, previous;
            min = max = previous = Unsafe.As<T, uint>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, uint>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (uint.TryParse(text, out var v))
                {
                    result = Unsafe.As<uint, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, uint>(value));
            }
            
            public abstract bool IsDefined(uint value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(uint value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly HashTable<uint, ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new HashTable<uint, ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, uint>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(uint value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion

    #region Int64Enum

    internal sealed class Int64Enum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly long MinValue; 
        public static readonly long MaxValue;

        public static Base Operation;

        static Int64Enum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (long min, long max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            long min, max, previous;
            min = max = previous = Unsafe.As<T, long>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, long>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (long.TryParse(text, out var v))
                {
                    result = Unsafe.As<long, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, long>(value));
            }
            
            public abstract bool IsDefined(long value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(long value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly HashTable<long, ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new HashTable<long, ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, long>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(long value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion

    #region UInt64Enum

    internal sealed class UInt64Enum<T> where T : unmanaged, Enum
    {
        public static readonly bool IsContinuous;

        public static readonly ulong MinValue; 
        public static readonly ulong MaxValue;

        public static Base Operation;

        static UInt64Enum()
        {
            (MinValue, MaxValue, IsContinuous) = CheckValues();
            Operation = IsContinuous ? (Base) new Continuous() : new Discontinuous();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static (ulong min, ulong max, bool isContinuous) CheckValues()
        {
            bool continuous = true;
            ulong min, max, previous;
            min = max = previous = Unsafe.As<T, ulong>(default(T));
            var values = ValueCache<T>.Values;
            for (int i = 0; i < values.Length; i++)
            {
                var v = Unsafe.As<T, ulong>(values[i]);

                if (i != 0 && previous != v - 1)
                    continuous = false;  

                if (v < min)
                    min = v;

                if (v > max)
                    max = v;

                previous = v;
            }
            return (min, max, continuous);
        }

        internal abstract class Base : IUnderlyingOperation<T>
        {
            public bool TryParse(string text, out T result)
            {
                if (ulong.TryParse(text, out var v))
                {
                    result = Unsafe.As<ulong, T>(v);
                    return true;
                }
                result = default;
                return false;
            }
        
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsDefined(T value)
            {
                return IsDefined(Unsafe.As<T, ulong>(value));
            }
            
            public abstract bool IsDefined(ulong value);
        }

        private sealed class Continuous : Base
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(ulong value)
            {
                return MinValue <= value && value <= MaxValue;
            }
        }

        private sealed class Discontinuous : Base
        {
     　　　　　private readonly HashTable<ulong, ValueInfo<T>> _hashTable;

            public Discontinuous() 
            {
                _hashTable = new HashTable<ulong, ValueInfo<T>>(
                    ValueInfoCache<T>.ValueInfos,
                    (in ValueInfo<T> info) => Unsafe.As<T, ulong>(info.EnumValue));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool IsDefined(ulong value)
            {
                return _hashTable.TryGetValue(value, out var _);
            }
        }

    }

    #endregion


}
