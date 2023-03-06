using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lab1_updated.View
{
    internal interface IDocView
    {
        public void DoctorsListView_Add(ListViewItem item);
        public void DoctorsListView_AddRange(ListViewItem[] item);
        public void WayOpenFileDialog_ShowDialog();
        public void WayTextBox_GetText();
        public void DoctorsImageList_Remove(ListViewItem item);
        public void DoctorTextBox_SetText(string text);
        public void DoctorPictureBox_SetImage(string way);
        public void CompanionsViewForm_SetCompanions(ListViewItem listViewItem);
        public void DoctorTextBox_Clear();
        public void DoctorPictureBox_Clear();
        public void CompanionsListView_Clear();
        public void DoctorsListView_Clear();
        public void DoctorsImageListAdd(string image, string key);
        public void DoctorsListViewAddRange(ListViewItem[] listViewItems);

    }
}
