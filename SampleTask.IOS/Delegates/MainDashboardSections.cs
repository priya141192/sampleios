using System;
using Foundation;

namespace SampleTask.IOS.Delegates
{
    public class MainDashboardSections : NSObject, IEquatable<MainDashboardSections>
    {
        public static MainDashboardSections Unknown { get; } = new MainDashboardSections(-1);
        public static MainDashboardSections CustomerList { get; } = new MainDashboardSections(0);
        public static MainDashboardSections DoctorList { get; } = new MainDashboardSections(1);

        public int EnumVal { get; private set; }

        public static MainDashboardSections[] AllMainDashboardSections { get; } = { CustomerList, DoctorList };
        MainDashboardSections(int enumValue) => EnumVal = enumValue;

        public static MainDashboardSections GetSection(nint sectionIndex)
        {
            if (CustomerList.EnumVal == sectionIndex) return CustomerList;
            if (DoctorList.EnumVal == sectionIndex) return DoctorList;
            return Unknown;
        }

        public int GetDashboardColumnCount()
        {
            if (CustomerList.EnumVal == EnumVal) return 1;
            if (DoctorList.EnumVal == EnumVal) return 1;
            return 0;
        }

        public static bool operator ==(MainDashboardSections left, MainDashboardSections right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (ReferenceEquals(left, null))
                return false;

            if (ReferenceEquals(right, null))
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(MainDashboardSections left, MainDashboardSections right) => !(left == right);
        public override bool Equals(object obj) => this == (MainDashboardSections)obj;
        public bool Equals(MainDashboardSections other) => EnumVal == other.EnumVal;
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), EnumVal);

    }

}
