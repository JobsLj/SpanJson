﻿using System;

namespace SpanJson
{
    public ref struct JsonReader
    {
        private ReadOnlySpan<char> _chars;
        private int _pos;

        public JsonReader(ReadOnlySpan<char> chars)
        {
            _chars = chars;
            _pos = 0;
        }

        internal sbyte ReadSByte()
        {
            throw new NotImplementedException();
        }

        internal short ReadInt16()
        {
            throw new NotImplementedException();
        }

        internal int ReadInt32()
        {
            throw new NotImplementedException();
        }

        internal long ReadInt64()
        {
            throw new NotImplementedException();
        }

        internal byte ReadByte()
        {
            throw new NotImplementedException();
        }

        internal ushort ReadUInt16()
        {
            throw new NotImplementedException();
        }

        internal uint ReadUInt32()
        {
            throw new NotImplementedException();
        }

        internal ulong ReadUInt64()
        {
            throw new NotImplementedException();
        }

        internal float ReadSingle()
        {
            throw new NotImplementedException();
        }

        internal double ReadDouble()
        {
            throw new NotImplementedException();
        }

        internal bool ReadBoolean()
        {
            throw new NotImplementedException();
        }

        public char ReadChar()
        {
            throw new NotImplementedException();
        }

        public DateTime ReadDateTime()
        {
            throw new NotImplementedException();
        }

        public DateTimeOffset ReadDateTimeOffset()
        {
            throw new NotImplementedException();
        }

        public TimeSpan ReadTimeSpan()
        {
            throw new NotImplementedException();
        }

        public Guid ReadGuid()
        {
            throw new NotImplementedException();
        }

        public string ReadString()
        {
            throw new NotImplementedException();
        }

        public decimal ReadDecimal()
        {
            throw new NotImplementedException();
        }

        public bool ReadIsNull()
        {
            throw new NotImplementedException();
        }

        public void ReadIsBeginArray()
        {
            throw new NotImplementedException();
        }

        public bool ReadIsEndArray(ref int count)
        {
            throw new NotImplementedException();
        }
    }
}