using System.ComponentModel;

namespace Sorting.enums
{
    enum Sortings
    {
        [Description("BUBBLESORT")]
        BUBBLESORT = 1,

        [Description("SELECTION")]
        SELECTIONSORT = 2,

        [Description("INSERTION")]
        INSERTIONSORT = 3,

        [Description("BUCKETSORT")]
        BUCKETSORT = 4,

        [Description("COUNTINGSORT")]
        COUNTINGSORT = 5,

        [Description("RADIXSORT")]
        RADIXSORT = 6,

        [Description("SHELLSORT")]
        SHELLSORT = 7,

        [Description("QUICKSORT")]
        QUICKSORT = 8,

        [Description("MERGESORT")]
        MERGESORT = 9,

        [Description("HEAPSORT")]
        HEAPSORT = 10,
    }
}
