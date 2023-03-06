namespace Lab1_updated.View
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            DoctorsListView = new System.Windows.Forms.ListView();
            doctorsImageList = new System.Windows.Forms.ImageList(components);
            doctorPictureBox = new System.Windows.Forms.PictureBox();
            doctorTextBox = new System.Windows.Forms.RichTextBox();
            companionsImageList = new System.Windows.Forms.ImageList(components);
            companionsListView = new System.Windows.Forms.ListView();
            infoLabel = new System.Windows.Forms.Label();
            companionLebel = new System.Windows.Forms.Label();
            docAddButton = new System.Windows.Forms.Button();
            actorTextBox = new System.Windows.Forms.TextBox();
            nameTextBox = new System.Windows.Forms.TextBox();
            seasonsTextBox = new System.Windows.Forms.TextBox();
            numberTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            actorLabel = new System.Windows.Forms.Label();
            seasonsLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            deleteButton = new System.Windows.Forms.Button();
            wayTextBox = new System.Windows.Forms.TextBox();
            wayLabel = new System.Windows.Forms.Label();
            allSortButton = new System.Windows.Forms.Button();
            companionsSortButton = new System.Windows.Forms.Button();
            searchTextButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            wayButton = new System.Windows.Forms.Button();
            wayOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)doctorPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DoctorsListView
            // 
            DoctorsListView.HideSelection = false;
            DoctorsListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            DoctorsListView.LargeImageList = doctorsImageList;
            DoctorsListView.Location = new System.Drawing.Point(497, 42);
            DoctorsListView.Name = "DoctorsListView";
            DoctorsListView.Size = new System.Drawing.Size(235, 369);
            DoctorsListView.SmallImageList = doctorsImageList;
            DoctorsListView.TabIndex = 0;
            DoctorsListView.UseCompatibleStateImageBehavior = false;
            DoctorsListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // doctorsImageList
            // 
            doctorsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            doctorsImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("doctorsImageList.ImageStream");
            doctorsImageList.TransparentColor = System.Drawing.Color.Transparent;
            doctorsImageList.Images.SetKeyName(0, "9");
            doctorsImageList.Images.SetKeyName(1, "10");
            doctorsImageList.Images.SetKeyName(2, "11");
            doctorsImageList.Images.SetKeyName(3, "12");
            doctorsImageList.Images.SetKeyName(4, "13");
            doctorsImageList.Images.SetKeyName(5, "14");
            doctorsImageList.Images.SetKeyName(6, "15");
            // 
            // doctorPictureBox
            // 
            doctorPictureBox.BackColor = System.Drawing.SystemColors.Window;
            doctorPictureBox.Location = new System.Drawing.Point(279, 12);
            doctorPictureBox.Name = "doctorPictureBox";
            doctorPictureBox.Size = new System.Drawing.Size(191, 205);
            doctorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            doctorPictureBox.TabIndex = 1;
            doctorPictureBox.TabStop = false;
            // 
            // doctorTextBox
            // 
            doctorTextBox.Location = new System.Drawing.Point(279, 238);
            doctorTextBox.Name = "doctorTextBox";
            doctorTextBox.Size = new System.Drawing.Size(191, 75);
            doctorTextBox.TabIndex = 2;
            doctorTextBox.Text = "";
            // 
            // companionsImageList
            // 
            companionsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            companionsImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("companionsImageList.ImageStream");
            companionsImageList.TransparentColor = System.Drawing.Color.Transparent;
            companionsImageList.Images.SetKeyName(0, "Rose.jpg");
            companionsImageList.Images.SetKeyName(1, "Martha.jpg");
            companionsImageList.Images.SetKeyName(2, "Amy.jpg");
            companionsImageList.Images.SetKeyName(3, "Clara.jpg");
            companionsImageList.Images.SetKeyName(4, "Bill.jpg");
            companionsImageList.Images.SetKeyName(5, "Yasmin.jpg");
            // 
            // companionsListView
            // 
            companionsListView.BackColor = System.Drawing.SystemColors.Window;
            companionsListView.HideSelection = false;
            companionsListView.LargeImageList = companionsImageList;
            companionsListView.Location = new System.Drawing.Point(279, 335);
            companionsListView.Name = "companionsListView";
            companionsListView.Size = new System.Drawing.Size(191, 109);
            companionsListView.SmallImageList = companionsImageList;
            companionsListView.TabIndex = 3;
            companionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new System.Drawing.Point(279, 220);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(84, 15);
            infoLabel.TabIndex = 4;
            infoLabel.Text = "Информация:";
            // 
            // companionLebel
            // 
            companionLebel.AutoSize = true;
            companionLebel.Location = new System.Drawing.Point(280, 316);
            companionLebel.Name = "companionLebel";
            companionLebel.Size = new System.Drawing.Size(63, 15);
            companionLebel.TabIndex = 5;
            companionLebel.Text = "Спутники:";
            // 
            // docAddButton
            // 
            docAddButton.Location = new System.Drawing.Point(89, 167);
            docAddButton.Name = "docAddButton";
            docAddButton.Size = new System.Drawing.Size(75, 23);
            docAddButton.TabIndex = 6;
            docAddButton.Text = "Добавить";
            docAddButton.UseVisualStyleBackColor = true;
            docAddButton.Click += DocAddButton_Click;
            // 
            // actorTextBox
            // 
            actorTextBox.Location = new System.Drawing.Point(71, 51);
            actorTextBox.Name = "actorTextBox";
            actorTextBox.Size = new System.Drawing.Size(152, 23);
            actorTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(71, 22);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(152, 23);
            nameTextBox.TabIndex = 8;
            // 
            // seasonsTextBox
            // 
            seasonsTextBox.Location = new System.Drawing.Point(71, 80);
            seasonsTextBox.Name = "seasonsTextBox";
            seasonsTextBox.Size = new System.Drawing.Size(93, 23);
            seasonsTextBox.TabIndex = 9;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new System.Drawing.Point(196, 80);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new System.Drawing.Size(27, 23);
            numberTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(34, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(31, 15);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Имя";
            // 
            // actorLabel
            // 
            actorLabel.AutoSize = true;
            actorLabel.Location = new System.Drawing.Point(26, 54);
            actorLabel.Name = "actorLabel";
            actorLabel.Size = new System.Drawing.Size(39, 15);
            actorLabel.TabIndex = 12;
            actorLabel.Text = "Актёр";
            // 
            // seasonsLabel
            // 
            seasonsLabel.AutoSize = true;
            seasonsLabel.Location = new System.Drawing.Point(16, 83);
            seasonsLabel.Name = "seasonsLabel";
            seasonsLabel.Size = new System.Drawing.Size(49, 15);
            seasonsLabel.TabIndex = 13;
            seasonsLabel.Text = "Сезоны";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(170, 83);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(20, 15);
            numberLabel.TabIndex = 14;
            numberLabel.Text = "№";
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(579, 417);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(75, 23);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // wayTextBox
            // 
            wayTextBox.Enabled = false;
            wayTextBox.Location = new System.Drawing.Point(16, 138);
            wayTextBox.Name = "wayTextBox";
            wayTextBox.Size = new System.Drawing.Size(207, 23);
            wayTextBox.TabIndex = 16;
            // 
            // wayLabel
            // 
            wayLabel.AutoSize = true;
            wayLabel.Location = new System.Drawing.Point(32, 112);
            wayLabel.Name = "wayLabel";
            wayLabel.Size = new System.Drawing.Size(33, 15);
            wayLabel.TabIndex = 17;
            wayLabel.Text = "Путь";
            // 
            // allSortButton
            // 
            allSortButton.Location = new System.Drawing.Point(497, 13);
            allSortButton.Name = "allSortButton";
            allSortButton.Size = new System.Drawing.Size(111, 23);
            allSortButton.TabIndex = 18;
            allSortButton.Text = "Все";
            allSortButton.UseVisualStyleBackColor = true;
            allSortButton.Click += AllSortButton_Click;
            // 
            // companionsSortButton
            // 
            companionsSortButton.Location = new System.Drawing.Point(621, 12);
            companionsSortButton.Name = "companionsSortButton";
            companionsSortButton.Size = new System.Drawing.Size(111, 23);
            companionsSortButton.TabIndex = 19;
            companionsSortButton.Text = "Со спутниками";
            companionsSortButton.UseVisualStyleBackColor = true;
            companionsSortButton.Click += CompanionsSortButton_Click;
            // 
            // searchTextButton
            // 
            searchTextButton.Location = new System.Drawing.Point(92, 42);
            searchTextButton.Name = "searchTextButton";
            searchTextButton.Size = new System.Drawing.Size(75, 23);
            searchTextButton.TabIndex = 20;
            searchTextButton.Text = "Поиск";
            searchTextButton.UseVisualStyleBackColor = true;
            searchTextButton.Click += searchTextButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(wayButton);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(docAddButton);
            groupBox1.Controls.Add(actorTextBox);
            groupBox1.Controls.Add(seasonsTextBox);
            groupBox1.Controls.Add(wayLabel);
            groupBox1.Controls.Add(numberTextBox);
            groupBox1.Controls.Add(wayTextBox);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(actorLabel);
            groupBox1.Controls.Add(numberLabel);
            groupBox1.Controls.Add(seasonsLabel);
            groupBox1.Location = new System.Drawing.Point(12, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(242, 199);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление доктора";
            // 
            // wayButton
            // 
            wayButton.Location = new System.Drawing.Point(71, 109);
            wayButton.Name = "wayButton";
            wayButton.Size = new System.Drawing.Size(152, 23);
            wayButton.TabIndex = 22;
            wayButton.Text = "Выбрать путь";
            wayButton.UseVisualStyleBackColor = true;
            wayButton.Click += wayButton_Click;
            // 
            // wayOpenFileDialog
            // 
            wayOpenFileDialog.FileName = "openFileDialog1";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new System.Drawing.Point(12, 13);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(242, 23);
            searchTextBox.TabIndex = 22;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(758, 462);
            Controls.Add(searchTextBox);
            Controls.Add(groupBox1);
            Controls.Add(searchTextButton);
            Controls.Add(companionsSortButton);
            Controls.Add(allSortButton);
            Controls.Add(deleteButton);
            Controls.Add(companionLebel);
            Controls.Add(infoLabel);
            Controls.Add(companionsListView);
            Controls.Add(doctorTextBox);
            Controls.Add(doctorPictureBox);
            Controls.Add(DoctorsListView);
            Name = "ViewForm";
            Text = "УзнайДоктора";
            ((System.ComponentModel.ISupportInitialize)doctorPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView DoctorsListView;
        private System.Windows.Forms.ImageList doctorsImageList;
        private System.Windows.Forms.PictureBox doctorPictureBox;
        private System.Windows.Forms.RichTextBox doctorTextBox;
        private System.Windows.Forms.ImageList companionsImageList;
        public System.Windows.Forms.ListView companionsListView;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label companionLebel;
        private System.Windows.Forms.Button docAddButton;
        private System.Windows.Forms.TextBox actorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox seasonsTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.Label seasonsLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox wayTextBox;
        private System.Windows.Forms.Label wayLabel;
        private System.Windows.Forms.Button allSortButton;
        private System.Windows.Forms.Button companionsSortButton;
        private System.Windows.Forms.Button searchTextButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog wayOpenFileDialog;
        private System.Windows.Forms.Button wayButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}