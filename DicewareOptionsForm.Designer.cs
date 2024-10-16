using System.Windows.Forms;

namespace KeePassDiceware
{
	public partial class DicewareOptionsForm
	{
		private void InitializeComponent()
		{
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.wordSeparatorPromptedTextBox = new KeePass.UI.PromptedTextBox();
            this.wordCasingComboBox = new System.Windows.Forms.ComboBox();
            this.l33tSpeakComboBox = new System.Windows.Forms.ComboBox();
            this.saltComboBox = new System.Windows.Forms.ComboBox();
            this.activeWordListsListView = new System.Windows.Forms.ListView();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.wordSeparatorLabel = new System.Windows.Forms.Label();
            this.wordCasingsLabel = new System.Windows.Forms.Label();
            this.l33tSpeakLabel = new System.Windows.Forms.Label();
            this.saltsLabel = new System.Windows.Forms.Label();
            this.wordListsLabel = new System.Windows.Forms.Label();
            this.wordCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activeSaltSourcesListView = new System.Windows.Forms.ListView();
            this.editWordListsButton = new System.Windows.Forms.Button();
            this.editSaltSourcesButton = new System.Windows.Forms.Button();
            this.advancedStrategyLabel = new System.Windows.Forms.Label();
            this.saltSourcesLabel = new System.Windows.Forms.Label();
            this.advancedStrategyComboBox = new System.Windows.Forms.ComboBox();
            this.ExplanationGroupBox = new System.Windows.Forms.GroupBox();
            this.xkcdLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dicewareLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.minQualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.wordCountNumericUpDown)).BeginInit();
            this.ExplanationGroupBox.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minQualityNumericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(432, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(351, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // wordSeparatorPromptedTextBox
            // 
            this.wordSeparatorPromptedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wordSeparatorPromptedTextBox.Location = new System.Drawing.Point(138, 41);
            this.wordSeparatorPromptedTextBox.Name = "wordSeparatorPromptedTextBox";
            this.wordSeparatorPromptedTextBox.PromptText = "String to be placed between words";
            this.wordSeparatorPromptedTextBox.Size = new System.Drawing.Size(355, 20);
            this.wordSeparatorPromptedTextBox.TabIndex = 3;
            // 
            // wordCasingComboBox
            // 
            this.wordCasingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wordCasingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wordCasingComboBox.FormattingEnabled = true;
            this.wordCasingComboBox.Location = new System.Drawing.Point(138, 74);
            this.wordCasingComboBox.Name = "wordCasingComboBox";
            this.wordCasingComboBox.Size = new System.Drawing.Size(355, 21);
            this.wordCasingComboBox.TabIndex = 5;
            // 
            // l33tSpeakComboBox
            // 
            this.l33tSpeakComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.l33tSpeakComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.l33tSpeakComboBox.FormattingEnabled = true;
            this.l33tSpeakComboBox.Location = new System.Drawing.Point(138, 108);
            this.l33tSpeakComboBox.Name = "l33tSpeakComboBox";
            this.l33tSpeakComboBox.Size = new System.Drawing.Size(355, 21);
            this.l33tSpeakComboBox.TabIndex = 7;
            // 
            // saltComboBox
            // 
            this.saltComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saltComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saltComboBox.FormattingEnabled = true;
            this.saltComboBox.Location = new System.Drawing.Point(151, 3);
            this.saltComboBox.Name = "saltComboBox";
            this.saltComboBox.Size = new System.Drawing.Size(342, 21);
            this.saltComboBox.TabIndex = 12;
            // 
            // activeWordListsListView
            // 
            this.activeWordListsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeWordListsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.activeWordListsListView.HideSelection = false;
            this.activeWordListsListView.Location = new System.Drawing.Point(151, 3);
            this.activeWordListsListView.Name = "activeWordListsListView";
            this.activeWordListsListView.Size = new System.Drawing.Size(342, 219);
            this.activeWordListsListView.TabIndex = 18;
            this.activeWordListsListView.TabStop = false;
            this.activeWordListsListView.UseCompatibleStateImageBehavior = false;
            this.activeWordListsListView.View = System.Windows.Forms.View.Details;
            this.activeWordListsListView.SelectedIndexChanged += new System.EventHandler(this.WordListsListView_SelectedIndexChanged);
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Location = new System.Drawing.Point(3, 10);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(66, 13);
            this.wordCountLabel.TabIndex = 0;
            this.wordCountLabel.Text = "Word count:";
            // 
            // wordSeparatorLabel
            // 
            this.wordSeparatorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wordSeparatorLabel.AutoSize = true;
            this.wordSeparatorLabel.Location = new System.Drawing.Point(3, 44);
            this.wordSeparatorLabel.Name = "wordSeparatorLabel";
            this.wordSeparatorLabel.Size = new System.Drawing.Size(83, 13);
            this.wordSeparatorLabel.TabIndex = 2;
            this.wordSeparatorLabel.Text = "Word separator:";
            // 
            // wordCasingsLabel
            // 
            this.wordCasingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.wordCasingsLabel.AutoSize = true;
            this.wordCasingsLabel.Location = new System.Drawing.Point(3, 78);
            this.wordCasingsLabel.Name = "wordCasingsLabel";
            this.wordCasingsLabel.Size = new System.Drawing.Size(75, 13);
            this.wordCasingsLabel.TabIndex = 4;
            this.wordCasingsLabel.Text = "Word casings:";
            // 
            // l33tSpeakLabel
            // 
            this.l33tSpeakLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l33tSpeakLabel.AutoSize = true;
            this.l33tSpeakLabel.Location = new System.Drawing.Point(3, 112);
            this.l33tSpeakLabel.Name = "l33tSpeakLabel";
            this.l33tSpeakLabel.Size = new System.Drawing.Size(65, 13);
            this.l33tSpeakLabel.TabIndex = 6;
            this.l33tSpeakLabel.Text = "L33t Speak:";
            // 
            // saltsLabel
            // 
            this.saltsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saltsLabel.AutoSize = true;
            this.saltsLabel.Location = new System.Drawing.Point(3, 7);
            this.saltsLabel.Name = "saltsLabel";
            this.saltsLabel.Size = new System.Drawing.Size(142, 13);
            this.saltsLabel.TabIndex = 11;
            this.saltsLabel.Text = "Salt:";
            // 
            // wordListsLabel
            // 
            this.wordListsLabel.AutoSize = true;
            this.wordListsLabel.Location = new System.Drawing.Point(3, 3);
            this.wordListsLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.wordListsLabel.Name = "wordListsLabel";
            this.wordListsLabel.Size = new System.Drawing.Size(95, 13);
            this.wordListsLabel.TabIndex = 17;
            this.wordListsLabel.Text = "Enabled word lists:";
            // 
            // wordCountNumericUpDown
            // 
            this.wordCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wordCountNumericUpDown.AutoSize = true;
            this.wordCountNumericUpDown.Location = new System.Drawing.Point(138, 7);
            this.wordCountNumericUpDown.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.wordCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordCountNumericUpDown.Name = "wordCountNumericUpDown";
            this.wordCountNumericUpDown.Size = new System.Drawing.Size(355, 20);
            this.wordCountNumericUpDown.TabIndex = 1;
            this.wordCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // activeSaltSourcesListView
            // 
            this.activeSaltSourcesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeSaltSourcesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.activeSaltSourcesListView.HideSelection = false;
            this.activeSaltSourcesListView.Location = new System.Drawing.Point(151, 30);
            this.activeSaltSourcesListView.Name = "activeSaltSourcesListView";
            this.activeSaltSourcesListView.Size = new System.Drawing.Size(342, 192);
            this.activeSaltSourcesListView.TabIndex = 14;
            this.activeSaltSourcesListView.TabStop = false;
            this.activeSaltSourcesListView.UseCompatibleStateImageBehavior = false;
            this.activeSaltSourcesListView.View = System.Windows.Forms.View.Details;
            this.activeSaltSourcesListView.SelectedIndexChanged += new System.EventHandler(this.ActiveSaltSourcesListView_SelectedIndexChanged);
            // 
            // editWordListsButton
            // 
            this.editWordListsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editWordListsButton.Location = new System.Drawing.Point(151, 228);
            this.editWordListsButton.Name = "editWordListsButton";
            this.editWordListsButton.Size = new System.Drawing.Size(342, 23);
            this.editWordListsButton.TabIndex = 19;
            this.editWordListsButton.Text = "Edit Word Lists";
            this.editWordListsButton.UseVisualStyleBackColor = true;
            this.editWordListsButton.Click += new System.EventHandler(this.EditWordListsButton_Click);
            // 
            // editSaltSourcesButton
            // 
            this.editSaltSourcesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editSaltSourcesButton.Location = new System.Drawing.Point(151, 228);
            this.editSaltSourcesButton.Name = "editSaltSourcesButton";
            this.editSaltSourcesButton.Size = new System.Drawing.Size(342, 23);
            this.editSaltSourcesButton.TabIndex = 15;
            this.editSaltSourcesButton.Text = "Edit Salt Sources";
            this.editSaltSourcesButton.UseVisualStyleBackColor = true;
            this.editSaltSourcesButton.Click += new System.EventHandler(this.EditSaltSourcesButton_Click);
            // 
            // advancedStrategyLabel
            // 
            this.advancedStrategyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.advancedStrategyLabel.AutoSize = true;
            this.advancedStrategyLabel.Location = new System.Drawing.Point(3, 146);
            this.advancedStrategyLabel.Name = "advancedStrategyLabel";
            this.advancedStrategyLabel.Size = new System.Drawing.Size(101, 13);
            this.advancedStrategyLabel.TabIndex = 8;
            this.advancedStrategyLabel.Text = "Advanced Strategy:";
            // 
            // saltSourcesLabel
            // 
            this.saltSourcesLabel.AutoSize = true;
            this.saltSourcesLabel.Location = new System.Drawing.Point(3, 30);
            this.saltSourcesLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.saltSourcesLabel.Name = "saltSourcesLabel";
            this.saltSourcesLabel.Size = new System.Drawing.Size(108, 13);
            this.saltSourcesLabel.TabIndex = 13;
            this.saltSourcesLabel.Text = "Enabled salt sources:";
            // 
            // advancedStrategyComboBox
            // 
            this.advancedStrategyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedStrategyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advancedStrategyComboBox.FormattingEnabled = true;
            this.advancedStrategyComboBox.Location = new System.Drawing.Point(138, 142);
            this.advancedStrategyComboBox.Name = "advancedStrategyComboBox";
            this.advancedStrategyComboBox.Size = new System.Drawing.Size(355, 21);
            this.advancedStrategyComboBox.TabIndex = 9;
            // 
            // ExplanationGroupBox
            // 
            this.ExplanationGroupBox.Controls.Add(this.xkcdLinkLabel);
            this.ExplanationGroupBox.Controls.Add(this.dicewareLinkLabel);
            this.ExplanationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExplanationGroupBox.Location = new System.Drawing.Point(0, 286);
            this.ExplanationGroupBox.Name = "ExplanationGroupBox";
            this.ExplanationGroupBox.Size = new System.Drawing.Size(510, 50);
            this.ExplanationGroupBox.TabIndex = 1;
            this.ExplanationGroupBox.TabStop = false;
            this.ExplanationGroupBox.Text = "Explanation";
            // 
            // xkcdLinkLabel
            // 
            this.xkcdLinkLabel.AutoSize = true;
            this.xkcdLinkLabel.Location = new System.Drawing.Point(14, 29);
            this.xkcdLinkLabel.Name = "xkcdLinkLabel";
            this.xkcdLinkLabel.Size = new System.Drawing.Size(42, 13);
            this.xkcdLinkLabel.TabIndex = 1;
            this.xkcdLinkLabel.TabStop = true;
            this.xkcdLinkLabel.Tag = "https://xkcd.com/936/";
            this.xkcdLinkLabel.Text = "XKCD?";
            this.xkcdLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked_OpenTagAsLink);
            // 
            // dicewareLinkLabel
            // 
            this.dicewareLinkLabel.AutoSize = true;
            this.dicewareLinkLabel.Location = new System.Drawing.Point(14, 16);
            this.dicewareLinkLabel.Name = "dicewareLinkLabel";
            this.dicewareLinkLabel.Size = new System.Drawing.Size(153, 13);
            this.dicewareLinkLabel.TabIndex = 0;
            this.dicewareLinkLabel.TabStop = true;
            this.dicewareLinkLabel.Tag = "https://theworld.com/~reinhold/diceware.html";
            this.dicewareLinkLabel.Text = "What is the Diceware method?";
            this.dicewareLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked_OpenTagAsLink);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tabControl1);
            this.MainPanel.Controls.Add(this.ExplanationGroupBox);
            this.MainPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(10, 10);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(510, 368);
            this.MainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.Controls.Add(this.wordCountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.wordCountNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wordSeparatorLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.wordCasingsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l33tSpeakLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.wordSeparatorPromptedTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.wordCasingComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.l33tSpeakComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.advancedStrategyComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.advancedStrategyLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.minQualityNumericUpDown, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Minimum Quality (bits):";
            // 
            // minQualityNumericUpDown
            // 
            this.minQualityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minQualityNumericUpDown.Location = new System.Drawing.Point(138, 180);
            this.minQualityNumericUpDown.Name = "minQualityNumericUpDown";
            this.minQualityNumericUpDown.Size = new System.Drawing.Size(355, 20);
            this.minQualityNumericUpDown.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 286);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(502, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Word Lists";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.saltsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saltSourcesLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.activeSaltSourcesListView, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.editSaltSourcesButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.saltComboBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(496, 254);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.wordListsLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.activeWordListsListView, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.editWordListsButton, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(496, 254);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.okButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 336);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(510, 32);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // DicewareOptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(530, 388);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DicewareOptionsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diceware Password Generation Options";
            ((System.ComponentModel.ISupportInitialize)(this.wordCountNumericUpDown)).EndInit();
            this.ExplanationGroupBox.ResumeLayout(false);
            this.ExplanationGroupBox.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minQualityNumericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private Button okButton;
		private Button cancelButton;
		private KeePass.UI.PromptedTextBox wordSeparatorPromptedTextBox;
		private ComboBox wordCasingComboBox;
		private ComboBox l33tSpeakComboBox;
		private ComboBox saltComboBox;
		private ListView activeWordListsListView;
		private Label wordCountLabel;
		private Label wordSeparatorLabel;
		private Label wordCasingsLabel;
		private Label l33tSpeakLabel;
		private Label saltsLabel;
		private Label wordListsLabel;
		private NumericUpDown wordCountNumericUpDown;
		private GroupBox ExplanationGroupBox;
		private LinkLabel xkcdLinkLabel;
		private LinkLabel dicewareLinkLabel;
		private Label advancedStrategyLabel;
		private ComboBox advancedStrategyComboBox;
		private Label saltSourcesLabel;
		private Button editSaltSourcesButton;
		private Panel MainPanel;
		private Button editWordListsButton;
		private ListView activeSaltSourcesListView;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private NumericUpDown minQualityNumericUpDown;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TableLayoutPanel tableLayoutPanel2;
		private TabPage tabPage3;
		private TableLayoutPanel tableLayoutPanel3;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}
