using Lab1_updated.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab1_updated
{
    internal class Presenter : IDocPresenter
    {
        public Lab1Model model;
        public IDocView view;

        internal List<ListViewItem> DocViewItemList = new List<ListViewItem>() { new ListViewItem("Девятый доктор", 9), new ListViewItem("Десятый доктор", 10), new ListViewItem("Одиннадцатый доктор", 11), new ListViewItem("Двенадцатый доктор", 12), new ListViewItem("Тринадцатый доктор", 13), new ListViewItem("Четырнадцатый доктор", 14), new ListViewItem("Пятнадцатый доктор", 15) };
        internal ListViewItemSelectionChangedEventArgs docNowSelected;

        public Presenter(ViewForm view)
        {
            this.view = view;
            model = new Lab1Model();
        }

        public void DocViewItemListInit()
        {
            for (int i = 0; i < DocViewItemList.Count; i++)
            {
                DocViewItemList[i].Tag = i + 9;
                DocViewItemList[i].ImageKey = (i + 9).ToString();
            }

            view.DoctorsListView_AddRange(DocViewItemList.ToArray());

        }

        public void DocViewItemListRemove(ListViewItem item)
        {
            DocViewItemList.Remove(item);
        }

        public void ShowInfo(ListViewItem item)
        {
            string text = model.DocInfo(int.Parse(item.Tag.ToString()));
            view.DoctorTextBox_SetText(text);
        }

        public void ShowImage(ListViewItem item)
        {
            string text = model.TheWay(int.Parse(item.Tag.ToString()));
            view.DoctorPictureBox_SetImage(text);
        }

        public void ShowCompanions(ListViewItem item)
        {
            List<Companion> companions = model.CompanionsList(int.Parse(item.Tag.ToString()));
            if (companions != null)
            {
                foreach (Companion companion in companions)
                {
                    ListViewItem backitem = new ListViewItem(companion.Name, companion.ID);
                    view.CompanionsViewForm_SetCompanions(backitem);
                }
            }
        }

        public void DeleteDoctor(ListViewItem item)
        {
            model.DocDel(int.Parse(item.Tag.ToString()));
            DocViewItemList.Remove(item);
            view.DoctorsImageList_Remove(item);
            BoxesClear();
            DoctorListView_Reload();

        }

        public void AddDoctor(string name, string actor, string seasons, int number, List<Companion> companions, string way)
        {
            List<int> seasonsList = new List<int>();
            string[] seasonsOut = seasons.Split(',');
            foreach (string season in seasonsOut)
            {
                seasonsList.Add(int.Parse(season));
            }

            model.DocAdd(name, actor, seasonsList, number, companions, way);

            view.DoctorsImageListAdd(way, number.ToString());

            DocViewItemList.Add(new ListViewItem(name, number));
            DocViewItemList[^1].Tag = number;
            DocViewItemList[^1].ImageKey = number.ToString();

            view.DoctorsListView_Clear();

            view.DoctorsListViewAddRange(DocViewItemList.ToArray());


        }

        public void SortDoctors()
        {
            view.DoctorsListView_Clear();

            foreach (ListViewItem item in DocViewItemList)
            {
                if (model.IsDocHasCompanion(int.Parse(item.Tag.ToString())) == true)
                {
                    view.DoctorsListView_Add(item);
                }
            }
        }

        public void DoctosSearch(string text)
        {
            view.DoctorsListView_Clear();

            foreach (ListViewItem item in DocViewItemList)
            {
                if (item.Text.Contains(text))
                {
                    view.DoctorsListView_Add(item);
                }
            }
        }


        public void GetWay()
        {
            view.WayOpenFileDialog_ShowDialog();
            view.WayTextBox_GetText();

        }
        public void BoxesClear()
        {
            view.CompanionsListView_Clear();
            view.DoctorPictureBox_Clear();
            view.DoctorTextBox_Clear();
        }

        public void DoctorListView_Reload()
        {
            view.DoctorsListView_Clear();
            view.DoctorsListView_AddRange(DocViewItemList.ToArray());
        }
    }


}
