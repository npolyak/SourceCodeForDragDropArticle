using NP.Visuals.Behaviors.DragDrop;
using System.Windows;
using NP.Paradigms.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Collections.Generic;
using NP.Visuals.Utils;

namespace NP.Tests.DragDropFromListToList
{
    public class VerticalItemsPanelPositionChooser : IDropPositionChooser
    {
        // used for easy XAML reference
        public static VerticalItemsPanelPositionChooser Instance { get; } = 
            new VerticalItemsPanelPositionChooser();

        public Point GetPositionWithinDropDontainer
        (
            FrameworkElement droppedElement, 
            FrameworkElement dropContainer, 
            Point mousePositionWithRespectToContainer)
        {
            // get the vertical offset
            (double verticalOffset, _) = dropContainer.GetVerticalOffsetAndInsertIdx(mousePositionWithRespectToContainer.Y);

            // return the position corresponding to the vertical offset.
            return new Point(0, verticalOffset);
        }
    }
}
