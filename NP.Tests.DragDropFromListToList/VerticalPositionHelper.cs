using NP.Paradigms.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NP.Tests.DragDropFromListToList
{
    public static class VerticalPositionHelper
    {
        private const double InitialVerticalOffset = 2d;

        public static (double, int) GetVerticalOffsetAndInsertIdx(this FrameworkElement dropContainer, double mouseVerticalOffset)
        {
            ItemsPresenter itemPresenter =
                dropContainer.VisualDescendants<ItemsPresenter>().FirstOrDefault();

            Panel itemsPanel = itemPresenter.VisualDescendants<Panel>().FirstOrDefault();

            List<ContentPresenter> items = itemsPanel.Children.Cast<object>().Where(item => item is ContentPresenter).Cast<ContentPresenter>().ToList();

            double verticalOffset = InitialVerticalOffset;
            int insertIdx = 0;

            if (items.Count == 0)
            {
                return (verticalOffset, insertIdx);
            }

            double totalVerticalOffset = verticalOffset;
            foreach (FrameworkElement item in items)
            {
                double itemHeight = item.ActualHeight;
                verticalOffset = totalVerticalOffset + itemHeight;

                if (mouseVerticalOffset < verticalOffset)
                {
                    if ((mouseVerticalOffset - totalVerticalOffset) <= itemHeight / 2d)
                    {
                        verticalOffset = totalVerticalOffset;
                    }
                    else
                    {
                        insertIdx++;
                    }
                    break;
                }
                insertIdx++;
                totalVerticalOffset = verticalOffset;
            }

            return (verticalOffset, insertIdx);
        }

    }
}
