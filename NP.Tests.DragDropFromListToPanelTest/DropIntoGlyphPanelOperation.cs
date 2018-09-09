using System.Windows;
using NP.Visuals.Behaviors.DragDrop;
using NP.Visuals.Utils;

namespace NP.Tests.DragDropFromListToPanelTest
{
    public class DropIntoGlyphPanelOperation : IDropOperation
    {
        // static instance created to be easily accessible from XAML
        public static DropIntoGlyphPanelOperation Instance { get; } =
            new DropIntoGlyphPanelOperation();

        // drop method
        public void Drop
        (
            FrameworkElement draggedAndDroppedElement, 
            FrameworkElement dropContainer, 
            Point mousePositionWithRespectToContainer)
        {
            // get the dragged/dropped element's view model
            NumberVm droppedVm = 
                draggedAndDroppedElement.DataContext as NumberVm;

            // get the drop container's view model
            TestVm testVm = 
                dropContainer.DataContext as TestVm;

            // create the inserted glyph's view model
            // note that the last constructor argument
            // specifies the glyph's position within 
            // the drop container. 
            NumberVmWithPostion newGlyphVm = new NumberVmWithPostion
            (
                droppedVm.Number,
                droppedVm.NumStr,
                mousePositionWithRespectToContainer.ToPoint2D());

            // insert the new glyph into the Glyphs collection
            // of the view model 
            testVm.Glyphs.Add(newGlyphVm);
        }
    }
}
