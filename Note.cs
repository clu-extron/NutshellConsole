using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellConsole
{
    public struct Note : IComparable<Note>, IEquatable<Note>, IComparable
    {
        private int _semitonesFromA;
        public int SemitonesFromA
        {
            get { return _semitonesFromA; }
        }

        public Note(int semitonesFromA)
        {
            _semitonesFromA = semitonesFromA;
        }

        public int CompareTo(Note other) // Generic IComparable<T>
        {
            if (Equals(other)) return 0; // Fail-safe check
            return _semitonesFromA.CompareTo(other._semitonesFromA);
        }

        int IComparable.CompareTo(object other) // Nongeneric IComparable
        {
            if (!(other is Note))
                throw new InvalidOperationException("CompareTo: Not a note");
            return CompareTo((Note) other);
        }

        public static bool operator < (Note n1, Note n2)
            => n1.CompareTo(n2) < 0;

        public static bool operator >(Note n1, Note n2)
            => n1.CompareTo(n2) > 0;

        public bool Equals (Note other) // for IEquatable<Note>
            => _semitonesFromA == other._semitonesFromA;

        public override bool Equals(object other)
        {
            if (!(other is Note)) return false;
            return Equals((Note) other);
        }

        public override int GetHashCode() => _semitonesFromA.GetHashCode();

        public static bool operator == (Note n1, Note n2) => n1.Equals(n2);
        public static bool operator !=(Note n1, Note n2) => !(n1 == n2);
    }
}
