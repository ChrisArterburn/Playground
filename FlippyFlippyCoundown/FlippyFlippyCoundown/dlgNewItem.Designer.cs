namespace FlippyFlippyCoundown
{
    partial class dlgNewItem
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            dteSelectedDate = new DateTimePicker();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 60);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 143);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 1;
            label2.Text = "Event Date";
            // 
            // txtName
            // 
            txtName.Location = new Point(204, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(331, 35);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // dteSelectedDate
            // 
            dteSelectedDate.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
            dteSelectedDate.Format = DateTimePickerFormat.Custom;
            dteSelectedDate.Location = new Point(195, 148);
            dteSelectedDate.Name = "dteSelectedDate";
            dteSelectedDate.Size = new Size(350, 35);
            dteSelectedDate.TabIndex = 3;
            dteSelectedDate.ValueChanged += dteSelectedDate_ValueChanged;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(85, 237);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(131, 40);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(295, 237);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dlgNewItem
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 353);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(dteSelectedDate);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "dlgNewItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "dlgNewItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private DateTimePicker dteSelectedDate;
        private Button btnOK;
        private Button btnCancel;
    }
}