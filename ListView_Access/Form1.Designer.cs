namespace ListView_Access
{
    partial class Form1
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
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            this.retrieveBtn = new MetroFramework.Controls.MetroButton();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.destinationTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.propellantTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nameTxt = new MetroFramework.Controls.MetroTextBox();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.mListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(715, 350);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(141, 23);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(570, 350);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 23);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseSelectable = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // retrieveBtn
            // 
            this.retrieveBtn.Location = new System.Drawing.Point(715, 295);
            this.retrieveBtn.Name = "retrieveBtn";
            this.retrieveBtn.Size = new System.Drawing.Size(141, 23);
            this.retrieveBtn.TabIndex = 18;
            this.retrieveBtn.Text = "Retrieve";
            this.retrieveBtn.UseSelectable = true;
            this.retrieveBtn.Click += new System.EventHandler(this.retrieveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(570, 295);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(109, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Add";
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(570, 227);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Destination";
            // 
            // destinationTxt
            // 
            // 
            // 
            // 
            this.destinationTxt.CustomButton.Image = null;
            this.destinationTxt.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.destinationTxt.CustomButton.Name = "";
            this.destinationTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.destinationTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.destinationTxt.CustomButton.TabIndex = 1;
            this.destinationTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.destinationTxt.CustomButton.UseSelectable = true;
            this.destinationTxt.CustomButton.Visible = false;
            this.destinationTxt.Lines = new string[0];
            this.destinationTxt.Location = new System.Drawing.Point(671, 227);
            this.destinationTxt.MaxLength = 32767;
            this.destinationTxt.Name = "destinationTxt";
            this.destinationTxt.PasswordChar = '\0';
            this.destinationTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.destinationTxt.SelectedText = "";
            this.destinationTxt.SelectionLength = 0;
            this.destinationTxt.SelectionStart = 0;
            this.destinationTxt.ShortcutsEnabled = true;
            this.destinationTxt.Size = new System.Drawing.Size(155, 23);
            this.destinationTxt.TabIndex = 15;
            this.destinationTxt.UseSelectable = true;
            this.destinationTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.destinationTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(570, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Propellant";
            // 
            // propellantTxt
            // 
            // 
            // 
            // 
            this.propellantTxt.CustomButton.Image = null;
            this.propellantTxt.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.propellantTxt.CustomButton.Name = "";
            this.propellantTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.propellantTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.propellantTxt.CustomButton.TabIndex = 1;
            this.propellantTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.propellantTxt.CustomButton.UseSelectable = true;
            this.propellantTxt.CustomButton.Visible = false;
            this.propellantTxt.Lines = new string[0];
            this.propellantTxt.Location = new System.Drawing.Point(671, 164);
            this.propellantTxt.MaxLength = 32767;
            this.propellantTxt.Name = "propellantTxt";
            this.propellantTxt.PasswordChar = '\0';
            this.propellantTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.propellantTxt.SelectedText = "";
            this.propellantTxt.SelectionLength = 0;
            this.propellantTxt.SelectionStart = 0;
            this.propellantTxt.ShortcutsEnabled = true;
            this.propellantTxt.Size = new System.Drawing.Size(155, 23);
            this.propellantTxt.TabIndex = 13;
            this.propellantTxt.UseSelectable = true;
            this.propellantTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.propellantTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(570, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Name";
            // 
            // nameTxt
            // 
            // 
            // 
            // 
            this.nameTxt.CustomButton.Image = null;
            this.nameTxt.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.nameTxt.CustomButton.Name = "";
            this.nameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTxt.CustomButton.TabIndex = 1;
            this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTxt.CustomButton.UseSelectable = true;
            this.nameTxt.CustomButton.Visible = false;
            this.nameTxt.Lines = new string[0];
            this.nameTxt.Location = new System.Drawing.Point(671, 95);
            this.nameTxt.MaxLength = 32767;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.ShortcutsEnabled = true;
            this.nameTxt.Size = new System.Drawing.Size(155, 23);
            this.nameTxt.TabIndex = 11;
            this.nameTxt.UseSelectable = true;
            this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(662, 401);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(119, 23);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // mListView
            // 
            this.mListView.Location = new System.Drawing.Point(23, 86);
            this.mListView.Name = "mListView";
            this.mListView.Size = new System.Drawing.Size(486, 338);
            this.mListView.TabIndex = 22;
            this.mListView.UseCompatibleStateImageBehavior = false;
            this.mListView.SelectedIndexChanged += new System.EventHandler(this.mListView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 457);
            this.Controls.Add(this.mListView);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.retrieveBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.destinationTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.propellantTxt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.nameTxt);
            this.Name = "Form1";
            this.Text = "ListView MS Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton updateBtn;
        private MetroFramework.Controls.MetroButton retrieveBtn;
        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox destinationTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox propellantTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nameTxt;
        private MetroFramework.Controls.MetroButton clearBtn;
        private System.Windows.Forms.ListView mListView;
    }
}

