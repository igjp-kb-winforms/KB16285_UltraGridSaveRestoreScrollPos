namespace KB16285_WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)ultraGrid1).BeginInit();
            SuspendLayout();
            // 
            // ultraGrid1
            // 
            ultraGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appearance19.BackColor = SystemColors.Window;
            appearance19.BorderColor = SystemColors.InactiveCaption;
            ultraGrid1.DisplayLayout.Appearance = appearance19;
            ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance111.BackColor = SystemColors.ActiveBorder;
            appearance111.BackColor2 = SystemColors.ControlDark;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance111.BorderColor = SystemColors.Window;
            ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance111;
            appearance112.ForeColor = SystemColors.GrayText;
            ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance112;
            ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance110.BackColor = SystemColors.ControlLightLight;
            appearance110.BackColor2 = SystemColors.Control;
            appearance110.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance110.ForeColor = SystemColors.GrayText;
            ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance110;
            ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance18.BackColor = SystemColors.Window;
            appearance18.ForeColor = SystemColors.ControlText;
            ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance18;
            appearance17.BackColor = SystemColors.Highlight;
            appearance17.ForeColor = SystemColors.HighlightText;
            ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance17;
            ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance16.BackColor = SystemColors.Window;
            ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance16;
            appearance15.BorderColor = Color.Silver;
            appearance15.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            ultraGrid1.DisplayLayout.Override.CellAppearance = appearance15;
            ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance11.BackColor = SystemColors.Control;
            appearance11.BackColor2 = SystemColors.ControlDark;
            appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance11.BorderColor = SystemColors.Window;
            ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance11;
            appearance12.TextHAlignAsString = "Left";
            ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance12;
            ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance13.BackColor = SystemColors.Window;
            appearance13.BorderColor = Color.Silver;
            ultraGrid1.DisplayLayout.Override.RowAppearance = appearance13;
            ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = SystemColors.ControlLight;
            ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance14;
            ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ultraGrid1.Font = new Font("Yu Gothic UI", 9F);
            ultraGrid1.Location = new Point(12, 94);
            ultraGrid1.Name = "ultraGrid1";
            ultraGrid1.Size = new Size(776, 344);
            ultraGrid1.TabIndex = 2;
            ultraGrid1.Text = "ultraGrid1";
            ultraGrid1.InitializeLayout += ultraGrid1_InitializeLayout;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(246, 49);
            button1.TabIndex = 0;
            button1.Text = "スクロール位置の保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 12);
            button2.Name = "button2";
            button2.Size = new Size(246, 49);
            button2.TabIndex = 1;
            button2.Text = "スクロール位置の復元";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ultraGrid1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ultraGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Button button1;
        private Button button2;
    }
}
