﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellConsole.Ch7
{
    public class MyEnumerator<T> : IEnumerator<T>
    {
        private T[] _data;
        private int _position = -1;

        public MyEnumerator(T[] data)
        {
            _data = data;
        }

        public T Current
        {
            get => _data[_position];
        }

        object IEnumerator.Current
        {
            get => Current;
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            _position = _position + 1;
            return _position < _data.Length;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
