﻿using System.Collections.Generic;
using System.Drawing;

namespace Manina.Windows.Forms
{
    /// <summary>
    /// Represents details of keyboard and mouse navigation events.
    /// </summary>
    internal class NavInfo
    {
        #region Properties
        public bool DraggingSeperator { get; set; }
        public bool Dragging { get; set; }
        public int DragIndex { get; set; }
        public bool DragCaretOnRight { get; set; }
        public bool ShiftDown { get; set; }
        public bool ControlDown { get; set; }
        public ColumnType SelSeperator { get; set; }
        public int SelStartKey { get; set; }
        public int SelEndKey { get; set; }
        public Point SelStart { get; set; }
        public Point SelEnd { get; set; }
        public Dictionary<ImageListViewItem, bool> Highlight { get; private set; }
        public ColumnType HoveredColumn { get; set; }
        public ImageListViewItem ClickedItem { get; set; }
        public ImageListViewItem HoveredItem { get; set; }
        public bool SelfDragging { get; set; }
        public ColumnType HoveredSeparator { get; set; }
        public bool MouseInColumnArea { get; set; }
        public bool MouseInItemArea { get; set; }
        public bool MouseClicked { get; set; }
        #endregion

        #region Constructor
        public NavInfo()
        {
            ShiftDown = false;
            ControlDown = false;
            DragIndex = -1;
            SelStartKey = -1;
            SelEndKey = -1;
            Highlight = new Dictionary<ImageListViewItem, bool>();
            HoveredColumn = (ColumnType)(-1);
            ClickedItem = null;
            HoveredItem = null;
            SelfDragging = false;
            HoveredSeparator = (ColumnType)(-1);
            MouseInColumnArea = false;
            MouseInItemArea = false;
            MouseClicked = false;
        }
        #endregion
    }
}
