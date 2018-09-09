using NP.Concepts;
using System.Collections.ObjectModel;

namespace NP.Tests.DragDropFromListToPanelTest
{
    public class TestVm 
    {
        public ObservableCollection<NumberVm> ListItems { get; }
        public ObservableCollection<NumberVmWithPostion> Glyphs { get; }

        public TestVm()
        {
            ListItems = new ObservableCollection<NumberVm>();

            ListItems.Add(new NumberVm(1, "One"));
            ListItems.Add(new NumberVm(2, "Two"));
            ListItems.Add(new NumberVm(3, "Three"));
            ListItems.Add(new NumberVm(4, "Four"));
            ListItems.Add(new NumberVm(5, "Five"));

            Glyphs = new ObservableCollection<NumberVmWithPostion>();
        }
    }
}
