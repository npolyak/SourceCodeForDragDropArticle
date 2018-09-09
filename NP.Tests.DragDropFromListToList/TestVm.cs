using NP.Concepts;
using System.Collections.ObjectModel;

namespace NP.Tests.DragDropFromListToList
{
    public class TestVm 
    {
        public ObservableCollection<NumberVm> SourceList { get; }
        public ObservableCollection<NumberVm> TargetList { get; }

        public TestVm()
        {
            SourceList = new ObservableCollection<NumberVm>();

            SourceList.Add(new NumberVm(1, "One"));
            SourceList.Add(new NumberVm(2, "Two"));
            SourceList.Add(new NumberVm(3, "Three"));
            SourceList.Add(new NumberVm(4, "Four"));
            SourceList.Add(new NumberVm(5, "Five"));

            TargetList = new ObservableCollection<NumberVm>();
        }
    }
}
