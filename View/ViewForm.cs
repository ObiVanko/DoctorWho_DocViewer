
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_updated.View
{
    public partial class ViewForm : Form, IDocView
    {
        Presenter presenter;

        internal ListViewItemSelectionChangedEventArgs docNowSelected;
        public ViewForm()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            DoctorsListView.ItemSelectionChanged += DoctorsListView_ItemSelectionChanged;
            presenter.DocViewItemListInit();
        }

        private void DoctorsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            presenter.BoxesClear();
            presenter.ShowInfo(e.Item);
            presenter.ShowImage(e.Item);
            presenter.ShowCompanions(e.Item);
            docNowSelected = e;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteDoctor(docNowSelected.Item);
        }

        private void DocAddButton_Click(object sender, EventArgs e)
        {
            presenter.AddDoctor(nameTextBox.Text, actorTextBox.Text, seasonsTextBox.Text, int.Parse(numberTextBox.Text), null, wayTextBox.Text);
        }

        private void AllSortButton_Click(object sender, EventArgs e)
        {
            presenter.DoctorListView_Reload();
        }

        private void CompanionsSortButton_Click(object sender, EventArgs e)
        {
            presenter.SortDoctors();
        }
        private void searchTextButton_Click(object sender, EventArgs e)
        {
            presenter.DoctosSearch(searchTextBox.Text.ToString());
        }

        private void wayButton_Click(object sender, EventArgs e)
        {
            presenter.GetWay();
        }
        public void DoctorsListView_Add(ListViewItem item)
        {
            DoctorsListView.Items.Add(item);
        }

        public void DoctorsListView_AddRange(ListViewItem[] item)
        {
            DoctorsListView.Items.AddRange(item);
        }
        public void WayOpenFileDialog_ShowDialog() 
        {
            wayOpenFileDialog.ShowDialog();
        }
        public void WayTextBox_GetText()
        {
            wayTextBox.Text = wayOpenFileDialog.FileName;
        }
        public void DoctorsImageList_Remove(ListViewItem item)
        {
            doctorsImageList.Images.RemoveByKey(item.ImageKey);
        }
        public void DoctorTextBox_SetText(string text)
        {
            doctorTextBox.Text = text;
        }

        public void DoctorPictureBox_SetImage(string way)
        {
            doctorPictureBox.Image = System.Drawing.Image.FromFile(way);
        }

        public void CompanionsViewForm_SetCompanions (ListViewItem listViewItem)
        {
            companionsListView.Items.Add(listViewItem);
        }
        public void DoctorTextBox_Clear()
        {
            doctorTextBox.Text = "";
        }

        public void DoctorPictureBox_Clear()
        {
            doctorPictureBox.Image = null;
        }

        public void CompanionsListView_Clear()
        {
            companionsListView.Clear();
        }

        public void DoctorsListView_Clear()
        {
            DoctorsListView.Items.Clear();
        }
        public void DoctorsImageListAdd(string image, string key)
        {
            doctorsImageList.Images.Add(key, System.Drawing.Image.FromFile(image));
        }

        public void DoctorsListViewAddRange(ListViewItem[] listViewItems)
        {
            DoctorsListView.Items.AddRange(listViewItems);
        }

    }

}
