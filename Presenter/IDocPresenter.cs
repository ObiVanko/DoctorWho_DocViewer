using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Lab1_updated
{
    internal interface IDocPresenter
    {
        public void DocViewItemListInit();
        public void DocViewItemListRemove(ListViewItem item);
        public void ShowInfo(ListViewItem item);
        public void ShowImage(ListViewItem item);
        public void ShowCompanions(ListViewItem item);
        public void DeleteDoctor(ListViewItem item);
        public void AddDoctor(string name, string actor, string seasons, int number, List<Companion> companions, string way);
        public void SortDoctors();
        public void DoctosSearch(string text);
        public void GetWay();
        public void BoxesClear();
        public void DoctorListView_Reload();
    }
}
