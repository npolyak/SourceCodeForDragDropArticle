using NP.Visuals.Behaviors.DragDrop;
using System.Windows;

namespace NP.Tests.DragDropFromListToList
{
    public class DropIntoItemsPanelOperation : IDropOperation
    {
        // used for easy XAML reference
        public static DropIntoItemsPanelOperation Instance { get; } = 
            new DropIntoItemsPanelOperation();

        public void Drop(FrameworkElement droppedElement, FrameworkElement dropContainer, Point mousePositionWithRespectToContainer)
        {
            // get the view model for the items that's being dropped. 
            NumberVm droppedVm = droppedElement.DataContext as NumberVm;

            // get the view model into which we insert the dropped item.
            TestVm testVm = dropContainer.DataContext as TestVm;

            // get the insertion index
            (_, int insertIdx) = dropContainer.GetVerticalOffsetAndInsertIdx(mousePositionWithRespectToContainer.Y);

            // insert the item into the target view model. 
            testVm.TargetList.Insert(insertIdx, droppedVm);
        }
    }
}
