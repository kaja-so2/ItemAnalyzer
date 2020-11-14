namespace ItemAnalyzer
{
	partial class MainWindow
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LblFilePath = new System.Windows.Forms.Label();
            this.LblItemInfo = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.BtnAnalyze = new System.Windows.Forms.Button();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_OverSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_NamedSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_NewInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Conversion = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_ConvertToCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenu_ConvertToJson = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_AddInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_CopyAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_EditShopInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Visual = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Previous = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Next = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_ChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Analyze = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Analyze = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu_Manager = new System.Windows.Forms.ToolStripMenuItem();
            this.LblAmount = new System.Windows.Forms.Label();
            this.LblMaterial = new System.Windows.Forms.Label();
            this.LblRoyality = new System.Windows.Forms.Label();
            this.LblItemName = new System.Windows.Forms.Label();
            this.LblAnalyzeInfo = new System.Windows.Forms.Label();
            this.DgvMaterial = new System.Windows.Forms.DataGridView();
            this.ClmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LblHdr_Profit = new System.Windows.Forms.Label();
            this.LblHdr_ProfitPer = new System.Windows.Forms.Label();
            this.LblHdr_CostPer = new System.Windows.Forms.Label();
            this.LblHdr_Cost = new System.Windows.Forms.Label();
            this.LblHdr_ProfitPerItem = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.TSBtn_Open = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_NewInfo = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_NamedSave = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_OverSave = new System.Windows.Forms.ToolStripButton();
            this.TSSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecord = new System.Windows.Forms.Label();
            this.TBItemName = new System.Windows.Forms.TextBox();
            this.BtnShopInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBProfit = new System.Windows.Forms.TextBox();
            this.TBProfitPer = new System.Windows.Forms.TextBox();
            this.TBCost = new System.Windows.Forms.TextBox();
            this.TBCostPer = new System.Windows.Forms.TextBox();
            this.TBProfitPerItem = new System.Windows.Forms.TextBox();
            this.TBCostPerItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAddCopy = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.ToolTipFullPath = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TBPerTime = new System.Windows.Forms.TextBox();
            this.LblPerTime = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.TBAmount = new System.Windows.Forms.TextBox();
            this.TBProductSpeed = new System.Windows.Forms.TextBox();
            this.TBProductTime = new System.Windows.Forms.TextBox();
            this.TBRoyality = new System.Windows.Forms.TextBox();
            this.TopMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterial)).BeginInit();
            this.TopToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFilePath
            // 
            this.LblFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFilePath.Location = new System.Drawing.Point(170, 645);
            this.LblFilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblFilePath.Name = "LblFilePath";
            this.LblFilePath.Size = new System.Drawing.Size(500, 19);
            this.LblFilePath.TabIndex = 0;
            this.LblFilePath.Text = "ファイル名";
            this.LblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblItemInfo
            // 
            this.LblItemInfo.AutoSize = true;
            this.LblItemInfo.Location = new System.Drawing.Point(15, 65);
            this.LblItemInfo.Name = "LblItemInfo";
            this.LblItemInfo.Size = new System.Drawing.Size(53, 12);
            this.LblItemInfo.TabIndex = 1;
            this.LblItemInfo.Text = "商品情報";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(45, 130);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(47, 12);
            this.LblPrice.TabIndex = 2;
            this.LblPrice.Text = "売値(G)";
            // 
            // BtnAnalyze
            // 
            this.BtnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAnalyze.BackColor = System.Drawing.Color.LightCyan;
            this.BtnAnalyze.Enabled = false;
            this.BtnAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnalyze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAnalyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyze.Location = new System.Drawing.Point(20, 585);
            this.BtnAnalyze.Name = "BtnAnalyze";
            this.BtnAnalyze.Size = new System.Drawing.Size(115, 40);
            this.BtnAnalyze.TabIndex = 7;
            this.BtnAnalyze.Text = "解析";
            this.BtnAnalyze.UseVisualStyleBackColor = false;
            this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Visual,
            this.ToolStripMenuItem_Analyze,
            this.ToolStripMenuItem_Help});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Size = new System.Drawing.Size(834, 24);
            this.TopMenuStrip.TabIndex = 4;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_Open,
            this.TSMenu_OverSave,
            this.TSMenu_NamedSave,
            this.TSMenu_NewInfo,
            this.TSMenu_Conversion});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItem_File.Text = "ファイル(&F)";
            // 
            // TSMenu_Open
            // 
            this.TSMenu_Open.Name = "TSMenu_Open";
            this.TSMenu_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMenu_Open.Size = new System.Drawing.Size(248, 22);
            this.TSMenu_Open.Text = "開く(&O)";
            this.TSMenu_Open.Click += new System.EventHandler(this.TSBtn_Open_Click);
            // 
            // TSMenu_OverSave
            // 
            this.TSMenu_OverSave.Name = "TSMenu_OverSave";
            this.TSMenu_OverSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMenu_OverSave.Size = new System.Drawing.Size(248, 22);
            this.TSMenu_OverSave.Text = "上書き保存(&S)";
            this.TSMenu_OverSave.Click += new System.EventHandler(this.TSBtn_OverSave_Click);
            // 
            // TSMenu_NamedSave
            // 
            this.TSMenu_NamedSave.Name = "TSMenu_NamedSave";
            this.TSMenu_NamedSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMenu_NamedSave.Size = new System.Drawing.Size(248, 22);
            this.TSMenu_NamedSave.Text = "名前を付けて保存(&A)";
            this.TSMenu_NamedSave.Click += new System.EventHandler(this.TSBtn_NamedSave_Click);
            // 
            // TSMenu_NewInfo
            // 
            this.TSMenu_NewInfo.Name = "TSMenu_NewInfo";
            this.TSMenu_NewInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMenu_NewInfo.Size = new System.Drawing.Size(248, 22);
            this.TSMenu_NewInfo.Text = "新規作成(&N)";
            this.TSMenu_NewInfo.Click += new System.EventHandler(this.TSBtn_NewInfo_Click);
            // 
            // TSMenu_Conversion
            // 
            this.TSMenu_Conversion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_ConvertToCsv,
            this.TsMenu_ConvertToJson});
            this.TSMenu_Conversion.Name = "TSMenu_Conversion";
            this.TSMenu_Conversion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.TSMenu_Conversion.Size = new System.Drawing.Size(248, 22);
            this.TSMenu_Conversion.Text = "ファイル変換(&C)";
            // 
            // TSMenu_ConvertToCsv
            // 
            this.TSMenu_ConvertToCsv.Name = "TSMenu_ConvertToCsv";
            this.TSMenu_ConvertToCsv.Size = new System.Drawing.Size(177, 22);
            this.TSMenu_ConvertToCsv.Text = "CSVファイルへ変換(&C)";
            this.TSMenu_ConvertToCsv.Click += new System.EventHandler(this.TSMenu_ConvertToCsv_Click);
            // 
            // TsMenu_ConvertToJson
            // 
            this.TsMenu_ConvertToJson.Name = "TsMenu_ConvertToJson";
            this.TsMenu_ConvertToJson.Size = new System.Drawing.Size(177, 22);
            this.TsMenu_ConvertToJson.Text = "Jsonファイルへ変換(&J)";
            this.TsMenu_ConvertToJson.Click += new System.EventHandler(this.TsMenu_ConvertToJson_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_AddInfo,
            this.TSMenu_CopyAdd,
            this.TSMenu_Delete,
            this.TSMenu_EditShopInfo});
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(57, 20);
            this.ToolStripMenuItem_Edit.Text = "編集(&E)";
            // 
            // TSMenu_AddInfo
            // 
            this.TSMenu_AddInfo.Name = "TSMenu_AddInfo";
            this.TSMenu_AddInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.TSMenu_AddInfo.Size = new System.Drawing.Size(228, 22);
            this.TSMenu_AddInfo.Text = "追加(&A)";
            this.TSMenu_AddInfo.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TSMenu_CopyAdd
            // 
            this.TSMenu_CopyAdd.Name = "TSMenu_CopyAdd";
            this.TSMenu_CopyAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.TSMenu_CopyAdd.Size = new System.Drawing.Size(228, 22);
            this.TSMenu_CopyAdd.Text = "コピーして追加(&C)";
            this.TSMenu_CopyAdd.Click += new System.EventHandler(this.BtnAddCopy_Click);
            // 
            // TSMenu_Delete
            // 
            this.TSMenu_Delete.Name = "TSMenu_Delete";
            this.TSMenu_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.TSMenu_Delete.Size = new System.Drawing.Size(228, 22);
            this.TSMenu_Delete.Text = "削除(&D)";
            this.TSMenu_Delete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TSMenu_EditShopInfo
            // 
            this.TSMenu_EditShopInfo.Name = "TSMenu_EditShopInfo";
            this.TSMenu_EditShopInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.TSMenu_EditShopInfo.Size = new System.Drawing.Size(228, 22);
            this.TSMenu_EditShopInfo.Text = "店舗情報の編集(&S)";
            this.TSMenu_EditShopInfo.Click += new System.EventHandler(this.BtnShopInfo_Click);
            // 
            // ToolStripMenuItem_Visual
            // 
            this.ToolStripMenuItem_Visual.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_Previous,
            this.TSMenu_Next,
            this.TSMenu_ChangeColor});
            this.ToolStripMenuItem_Visual.Name = "ToolStripMenuItem_Visual";
            this.ToolStripMenuItem_Visual.Size = new System.Drawing.Size(58, 20);
            this.ToolStripMenuItem_Visual.Text = "表示(&V)";
            // 
            // TSMenu_Previous
            // 
            this.TSMenu_Previous.Name = "TSMenu_Previous";
            this.TSMenu_Previous.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.TSMenu_Previous.Size = new System.Drawing.Size(229, 22);
            this.TSMenu_Previous.Text = "前の情報を表示する(&A)";
            this.TSMenu_Previous.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // TSMenu_Next
            // 
            this.TSMenu_Next.Name = "TSMenu_Next";
            this.TSMenu_Next.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.TSMenu_Next.Size = new System.Drawing.Size(229, 22);
            this.TSMenu_Next.Text = "次の情報を表示する(&D)";
            this.TSMenu_Next.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TSMenu_ChangeColor
            // 
            this.TSMenu_ChangeColor.Name = "TSMenu_ChangeColor";
            this.TSMenu_ChangeColor.Size = new System.Drawing.Size(229, 22);
            this.TSMenu_ChangeColor.Text = "色の変更(&C)";
            this.TSMenu_ChangeColor.Click += new System.EventHandler(this.TSMenu_ChangeColor_Click);
            // 
            // ToolStripMenuItem_Analyze
            // 
            this.ToolStripMenuItem_Analyze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_Analyze});
            this.ToolStripMenuItem_Analyze.Name = "ToolStripMenuItem_Analyze";
            this.ToolStripMenuItem_Analyze.Size = new System.Drawing.Size(59, 20);
            this.ToolStripMenuItem_Analyze.Text = "解析(&A)";
            // 
            // TSMenu_Analyze
            // 
            this.TSMenu_Analyze.Name = "TSMenu_Analyze";
            this.TSMenu_Analyze.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.TSMenu_Analyze.Size = new System.Drawing.Size(154, 22);
            this.TSMenu_Analyze.Text = "解析(&A)";
            this.TSMenu_Analyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenu_Help,
            this.TSMenu_Manager});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(63, 20);
            this.ToolStripMenuItem_Help.Text = "ヘルプ(&P)";
            // 
            // TSMenu_Help
            // 
            this.TSMenu_Help.Name = "TSMenu_Help";
            this.TSMenu_Help.Size = new System.Drawing.Size(158, 22);
            this.TSMenu_Help.Text = "ヘルプ(&P)";
            this.TSMenu_Help.Click += new System.EventHandler(this.TSMenu_Help_Click);
            // 
            // TSMenu_Manager
            // 
            this.TSMenu_Manager.Name = "TSMenu_Manager";
            this.TSMenu_Manager.Size = new System.Drawing.Size(158, 22);
            this.TSMenu_Manager.Text = "バージョン情報(&A)";
            this.TSMenu_Manager.Click += new System.EventHandler(this.TSMenu_Manager_Click);
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(45, 165);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(59, 12);
            this.LblAmount.TabIndex = 5;
            this.LblAmount.Text = "生産量(h)";
            // 
            // LblMaterial
            // 
            this.LblMaterial.AutoSize = true;
            this.LblMaterial.Location = new System.Drawing.Point(45, 359);
            this.LblMaterial.Name = "LblMaterial";
            this.LblMaterial.Size = new System.Drawing.Size(29, 12);
            this.LblMaterial.TabIndex = 9;
            this.LblMaterial.Text = "材料";
            // 
            // LblRoyality
            // 
            this.LblRoyality.AutoSize = true;
            this.LblRoyality.Location = new System.Drawing.Point(45, 270);
            this.LblRoyality.Name = "LblRoyality";
            this.LblRoyality.Size = new System.Drawing.Size(107, 12);
            this.LblRoyality.TabIndex = 8;
            this.LblRoyality.Text = "ロイヤリティ(1回)";
            // 
            // LblItemName
            // 
            this.LblItemName.AutoSize = true;
            this.LblItemName.Location = new System.Drawing.Point(45, 95);
            this.LblItemName.Name = "LblItemName";
            this.LblItemName.Size = new System.Drawing.Size(41, 12);
            this.LblItemName.TabIndex = 10;
            this.LblItemName.Text = "商品名";
            // 
            // LblAnalyzeInfo
            // 
            this.LblAnalyzeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAnalyzeInfo.AutoSize = true;
            this.LblAnalyzeInfo.Location = new System.Drawing.Point(450, 65);
            this.LblAnalyzeInfo.Name = "LblAnalyzeInfo";
            this.LblAnalyzeInfo.Size = new System.Drawing.Size(53, 12);
            this.LblAnalyzeInfo.TabIndex = 11;
            this.LblAnalyzeInfo.Text = "解析情報";
            // 
            // DgvMaterial
            // 
            this.DgvMaterial.AllowUserToResizeColumns = false;
            this.DgvMaterial.AllowUserToResizeRows = false;
            this.DgvMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmItem,
            this.ClmPrice,
            this.ClmAmount,
            this.MaterialType});
            this.DgvMaterial.Enabled = false;
            this.DgvMaterial.Location = new System.Drawing.Point(90, 359);
            this.DgvMaterial.Name = "DgvMaterial";
            this.DgvMaterial.RowHeadersVisible = false;
            this.DgvMaterial.RowTemplate.Height = 24;
            this.DgvMaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvMaterial.Size = new System.Drawing.Size(435, 201);
            this.DgvMaterial.TabIndex = 6;
            this.DgvMaterial.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaterial_CellEndEdit);
            this.DgvMaterial.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvMaterial_EditingControlShowing);
            // 
            // ClmItem
            // 
            this.ClmItem.Frozen = true;
            this.ClmItem.HeaderText = "材料名";
            this.ClmItem.MaxInputLength = 50;
            this.ClmItem.Name = "ClmItem";
            this.ClmItem.Width = 140;
            // 
            // ClmPrice
            // 
            this.ClmPrice.Frozen = true;
            this.ClmPrice.HeaderText = "単価";
            this.ClmPrice.MaxInputLength = 9;
            this.ClmPrice.Name = "ClmPrice";
            // 
            // ClmAmount
            // 
            this.ClmAmount.Frozen = true;
            this.ClmAmount.HeaderText = "必要量(1回)";
            this.ClmAmount.MaxInputLength = 4;
            this.ClmAmount.Name = "ClmAmount";
            this.ClmAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClmAmount.Width = 120;
            // 
            // MaterialType
            // 
            this.MaterialType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.MaterialType.HeaderText = "材料/道具";
            this.MaterialType.Items.AddRange(new object[] {
            "材料",
            "道具"});
            this.MaterialType.Name = "MaterialType";
            this.MaterialType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialType.Width = 75;
            // 
            // LblHdr_Profit
            // 
            this.LblHdr_Profit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHdr_Profit.AutoSize = true;
            this.LblHdr_Profit.Location = new System.Drawing.Point(475, 95);
            this.LblHdr_Profit.Name = "LblHdr_Profit";
            this.LblHdr_Profit.Size = new System.Drawing.Size(29, 12);
            this.LblHdr_Profit.TabIndex = 17;
            this.LblHdr_Profit.Text = "利益";
            // 
            // LblHdr_ProfitPer
            // 
            this.LblHdr_ProfitPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHdr_ProfitPer.AutoSize = true;
            this.LblHdr_ProfitPer.Location = new System.Drawing.Point(475, 130);
            this.LblHdr_ProfitPer.Name = "LblHdr_ProfitPer";
            this.LblHdr_ProfitPer.Size = new System.Drawing.Size(41, 12);
            this.LblHdr_ProfitPer.TabIndex = 18;
            this.LblHdr_ProfitPer.Text = "利益率";
            // 
            // LblHdr_CostPer
            // 
            this.LblHdr_CostPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHdr_CostPer.AutoSize = true;
            this.LblHdr_CostPer.Location = new System.Drawing.Point(475, 200);
            this.LblHdr_CostPer.Name = "LblHdr_CostPer";
            this.LblHdr_CostPer.Size = new System.Drawing.Size(41, 12);
            this.LblHdr_CostPer.TabIndex = 20;
            this.LblHdr_CostPer.Text = "原価率";
            // 
            // LblHdr_Cost
            // 
            this.LblHdr_Cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHdr_Cost.AutoSize = true;
            this.LblHdr_Cost.Location = new System.Drawing.Point(475, 165);
            this.LblHdr_Cost.Name = "LblHdr_Cost";
            this.LblHdr_Cost.Size = new System.Drawing.Size(29, 12);
            this.LblHdr_Cost.TabIndex = 19;
            this.LblHdr_Cost.Text = "原価";
            // 
            // LblHdr_ProfitPerItem
            // 
            this.LblHdr_ProfitPerItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHdr_ProfitPerItem.AutoSize = true;
            this.LblHdr_ProfitPerItem.Location = new System.Drawing.Point(475, 235);
            this.LblHdr_ProfitPerItem.Name = "LblHdr_ProfitPerItem";
            this.LblHdr_ProfitPerItem.Size = new System.Drawing.Size(119, 12);
            this.LblHdr_ProfitPerItem.TabIndex = 28;
            this.LblHdr_ProfitPerItem.Text = "商品1個当たりの利益";
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.BackColor = System.Drawing.Color.LightCyan;
            this.BtnNext.Enabled = false;
            this.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Location = new System.Drawing.Point(692, 585);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(115, 40);
            this.BtnNext.TabIndex = 20;
            this.BtnNext.Text = "次＞";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevious.BackColor = System.Drawing.Color.LightCyan;
            this.BtnPrevious.Enabled = false;
            this.BtnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevious.Location = new System.Drawing.Point(570, 585);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(115, 40);
            this.BtnPrevious.TabIndex = 19;
            this.BtnPrevious.Text = "＜前";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtn_Open,
            this.TSBtn_NewInfo,
            this.TSBtn_NamedSave,
            this.TSBtn_OverSave,
            this.TSSeparator1});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 24);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(834, 25);
            this.TopToolStrip.TabIndex = 33;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // TSBtn_Open
            // 
            this.TSBtn_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Open.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_Open.Image")));
            this.TSBtn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Open.Name = "TSBtn_Open";
            this.TSBtn_Open.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Open.Text = "ファイルを開く";
            this.TSBtn_Open.Click += new System.EventHandler(this.TSBtn_Open_Click);
            // 
            // TSBtn_NewInfo
            // 
            this.TSBtn_NewInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_NewInfo.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_NewInfo.Image")));
            this.TSBtn_NewInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_NewInfo.Name = "TSBtn_NewInfo";
            this.TSBtn_NewInfo.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_NewInfo.Text = "新規作成";
            this.TSBtn_NewInfo.Click += new System.EventHandler(this.TSBtn_NewInfo_Click);
            // 
            // TSBtn_NamedSave
            // 
            this.TSBtn_NamedSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_NamedSave.Enabled = false;
            this.TSBtn_NamedSave.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_NamedSave.Image")));
            this.TSBtn_NamedSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_NamedSave.Name = "TSBtn_NamedSave";
            this.TSBtn_NamedSave.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_NamedSave.Text = "名前を指定して保存";
            this.TSBtn_NamedSave.Click += new System.EventHandler(this.TSBtn_NamedSave_Click);
            // 
            // TSBtn_OverSave
            // 
            this.TSBtn_OverSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_OverSave.Enabled = false;
            this.TSBtn_OverSave.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_OverSave.Image")));
            this.TSBtn_OverSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_OverSave.Name = "TSBtn_OverSave";
            this.TSBtn_OverSave.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_OverSave.Text = "上書き保存";
            this.TSBtn_OverSave.Click += new System.EventHandler(this.TSBtn_OverSave_Click);
            // 
            // TSSeparator1
            // 
            this.TSSeparator1.Name = "TSSeparator1";
            this.TSSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LblRecord
            // 
            this.LblRecord.Location = new System.Drawing.Point(700, 59);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(100, 15);
            this.LblRecord.TabIndex = 34;
            this.LblRecord.Text = "/";
            this.LblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBItemName
            // 
            this.TBItemName.Enabled = false;
            this.TBItemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TBItemName.Location = new System.Drawing.Point(187, 92);
            this.TBItemName.MaxLength = 30;
            this.TBItemName.Name = "TBItemName";
            this.TBItemName.Size = new System.Drawing.Size(240, 19);
            this.TBItemName.TabIndex = 0;
            this.TBItemName.TextChanged += new System.EventHandler(this.TBItemName_TextChanged);
            this.TBItemName.Leave += new System.EventHandler(this.TBItemName_TextChanged);
            // 
            // BtnShopInfo
            // 
            this.BtnShopInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnShopInfo.BackColor = System.Drawing.Color.LightCyan;
            this.BtnShopInfo.Enabled = false;
            this.BtnShopInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnShopInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnShopInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShopInfo.Location = new System.Drawing.Point(141, 585);
            this.BtnShopInfo.Name = "BtnShopInfo";
            this.BtnShopInfo.Size = new System.Drawing.Size(115, 40);
            this.BtnShopInfo.TabIndex = 8;
            this.BtnShopInfo.Text = "店舗情報の編集";
            this.BtnShopInfo.UseVisualStyleBackColor = false;
            this.BtnShopInfo.Click += new System.EventHandler(this.BtnShopInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "生産スピード(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "製作時間(h)";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Location = new System.Drawing.Point(184, 65);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(53, 12);
            this.LblTax.TabIndex = 41;
            this.LblTax.Text = "税率(%):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 44;
            this.label4.Text = "商品1個当たりの原価";
            // 
            // TBProfit
            // 
            this.TBProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBProfit.Enabled = false;
            this.TBProfit.Location = new System.Drawing.Point(635, 92);
            this.TBProfit.MaxLength = 8;
            this.TBProfit.Name = "TBProfit";
            this.TBProfit.ReadOnly = true;
            this.TBProfit.Size = new System.Drawing.Size(145, 19);
            this.TBProfit.TabIndex = 9;
            // 
            // TBProfitPer
            // 
            this.TBProfitPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBProfitPer.Enabled = false;
            this.TBProfitPer.Location = new System.Drawing.Point(707, 127);
            this.TBProfitPer.MaxLength = 8;
            this.TBProfitPer.Name = "TBProfitPer";
            this.TBProfitPer.ReadOnly = true;
            this.TBProfitPer.Size = new System.Drawing.Size(73, 19);
            this.TBProfitPer.TabIndex = 10;
            // 
            // TBCost
            // 
            this.TBCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCost.Enabled = false;
            this.TBCost.Location = new System.Drawing.Point(634, 162);
            this.TBCost.MaxLength = 8;
            this.TBCost.Name = "TBCost";
            this.TBCost.ReadOnly = true;
            this.TBCost.Size = new System.Drawing.Size(146, 19);
            this.TBCost.TabIndex = 11;
            // 
            // TBCostPer
            // 
            this.TBCostPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCostPer.Enabled = false;
            this.TBCostPer.Location = new System.Drawing.Point(707, 197);
            this.TBCostPer.MaxLength = 8;
            this.TBCostPer.Name = "TBCostPer";
            this.TBCostPer.ReadOnly = true;
            this.TBCostPer.Size = new System.Drawing.Size(74, 19);
            this.TBCostPer.TabIndex = 12;
            // 
            // TBProfitPerItem
            // 
            this.TBProfitPerItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBProfitPerItem.Enabled = false;
            this.TBProfitPerItem.Location = new System.Drawing.Point(662, 232);
            this.TBProfitPerItem.MaxLength = 8;
            this.TBProfitPerItem.Name = "TBProfitPerItem";
            this.TBProfitPerItem.ReadOnly = true;
            this.TBProfitPerItem.Size = new System.Drawing.Size(119, 19);
            this.TBProfitPerItem.TabIndex = 13;
            // 
            // TBCostPerItem
            // 
            this.TBCostPerItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCostPerItem.Enabled = false;
            this.TBCostPerItem.Location = new System.Drawing.Point(662, 267);
            this.TBCostPerItem.MaxLength = 8;
            this.TBCostPerItem.Name = "TBCostPerItem";
            this.TBCostPerItem.ReadOnly = true;
            this.TBCostPerItem.Size = new System.Drawing.Size(119, 19);
            this.TBCostPerItem.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(790, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 53;
            this.label6.Text = "G";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 54;
            this.label7.Text = "G";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(790, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "G";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(790, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 56;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(790, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 57;
            this.label10.Text = "%";
            // 
            // BtnAddCopy
            // 
            this.BtnAddCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddCopy.BackColor = System.Drawing.Color.LightCyan;
            this.BtnAddCopy.Enabled = false;
            this.BtnAddCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAddCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAddCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCopy.Location = new System.Drawing.Point(692, 465);
            this.BtnAddCopy.Name = "BtnAddCopy";
            this.BtnAddCopy.Size = new System.Drawing.Size(115, 40);
            this.BtnAddCopy.TabIndex = 17;
            this.BtnAddCopy.Text = "コピーして追加";
            this.BtnAddCopy.UseVisualStyleBackColor = false;
            this.BtnAddCopy.Click += new System.EventHandler(this.BtnAddCopy_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.LightCyan;
            this.BtnAdd.Enabled = false;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(570, 465);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(115, 40);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "追加";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.LightCyan;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(692, 525);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(115, 40);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "削除";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "G";
            // 
            // TBPerTime
            // 
            this.TBPerTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPerTime.Enabled = false;
            this.TBPerTime.Location = new System.Drawing.Point(662, 302);
            this.TBPerTime.MaxLength = 8;
            this.TBPerTime.Name = "TBPerTime";
            this.TBPerTime.ReadOnly = true;
            this.TBPerTime.Size = new System.Drawing.Size(119, 19);
            this.TBPerTime.TabIndex = 15;
            // 
            // LblPerTime
            // 
            this.LblPerTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPerTime.AutoSize = true;
            this.LblPerTime.Location = new System.Drawing.Point(475, 305);
            this.LblPerTime.Name = "LblPerTime";
            this.LblPerTime.Size = new System.Drawing.Size(29, 12);
            this.LblPerTime.TabIndex = 62;
            this.LblPerTime.Text = "時給";
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(187, 127);
            this.TBPrice.MaxLength = 10;
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(175, 19);
            this.TBPrice.TabIndex = 1;
            this.TBPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Number_KeyPress);
            // 
            // TBAmount
            // 
            this.TBAmount.Location = new System.Drawing.Point(187, 162);
            this.TBAmount.MaxLength = 4;
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Size = new System.Drawing.Size(175, 19);
            this.TBAmount.TabIndex = 2;
            this.TBAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Number_KeyPress);
            // 
            // TBProductSpeed
            // 
            this.TBProductSpeed.Location = new System.Drawing.Point(187, 197);
            this.TBProductSpeed.MaxLength = 3;
            this.TBProductSpeed.Name = "TBProductSpeed";
            this.TBProductSpeed.Size = new System.Drawing.Size(175, 19);
            this.TBProductSpeed.TabIndex = 3;
            this.TBProductSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Number_KeyPress);
            // 
            // TBProductTime
            // 
            this.TBProductTime.Location = new System.Drawing.Point(187, 232);
            this.TBProductTime.MaxLength = 3;
            this.TBProductTime.Name = "TBProductTime";
            this.TBProductTime.Size = new System.Drawing.Size(175, 19);
            this.TBProductTime.TabIndex = 4;
            this.TBProductTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Number_KeyPress);
            // 
            // TBRoyality
            // 
            this.TBRoyality.Location = new System.Drawing.Point(187, 267);
            this.TBRoyality.MaxLength = 6;
            this.TBRoyality.Name = "TBRoyality";
            this.TBRoyality.Size = new System.Drawing.Size(175, 19);
            this.TBRoyality.TabIndex = 70;
            this.TBRoyality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Number_KeyPress);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 671);
            this.Controls.Add(this.TBRoyality);
            this.Controls.Add(this.TBProductTime);
            this.Controls.Add(this.TBProductSpeed);
            this.Controls.Add(this.TBAmount);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPerTime);
            this.Controls.Add(this.LblPerTime);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAddCopy);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBCostPerItem);
            this.Controls.Add(this.TBProfitPerItem);
            this.Controls.Add(this.TBCostPer);
            this.Controls.Add(this.TBCost);
            this.Controls.Add(this.TBProfitPer);
            this.Controls.Add(this.TBProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnShopInfo);
            this.Controls.Add(this.TBItemName);
            this.Controls.Add(this.LblRecord);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.LblHdr_ProfitPerItem);
            this.Controls.Add(this.LblHdr_CostPer);
            this.Controls.Add(this.LblHdr_Cost);
            this.Controls.Add(this.LblHdr_ProfitPer);
            this.Controls.Add(this.LblHdr_Profit);
            this.Controls.Add(this.DgvMaterial);
            this.Controls.Add(this.LblAnalyzeInfo);
            this.Controls.Add(this.LblItemName);
            this.Controls.Add(this.LblMaterial);
            this.Controls.Add(this.LblRoyality);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.BtnAnalyze);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblItemInfo);
            this.Controls.Add(this.LblFilePath);
            this.Controls.Add(this.TopMenuStrip);
            this.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MinimumSize = new System.Drawing.Size(850, 710);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOLDOUT2 Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterial)).EndInit();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblFilePath;
		private System.Windows.Forms.Label LblItemInfo;
		private System.Windows.Forms.Label LblPrice;
		private System.Windows.Forms.Button BtnAnalyze;
		private System.Windows.Forms.MenuStrip TopMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Open;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_OverSave;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Analyze;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Analyze;
		private System.Windows.Forms.Label LblAmount;
		private System.Windows.Forms.Label LblMaterial;
		private System.Windows.Forms.Label LblRoyality;
		private System.Windows.Forms.Label LblItemName;
		private System.Windows.Forms.Label LblAnalyzeInfo;
		private System.Windows.Forms.DataGridView DgvMaterial;
		private System.Windows.Forms.Label LblHdr_Profit;
		private System.Windows.Forms.Label LblHdr_ProfitPer;
		private System.Windows.Forms.Label LblHdr_CostPer;
		private System.Windows.Forms.Label LblHdr_Cost;
		private System.Windows.Forms.Label LblHdr_ProfitPerItem;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_NewInfo;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_AddInfo;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_CopyAdd;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Delete;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Conversion;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.Button BtnPrevious;
		private System.Windows.Forms.ToolStrip TopToolStrip;
		private System.Windows.Forms.ToolStripButton TSBtn_Open;
		private System.Windows.Forms.ToolStripButton TSBtn_NamedSave;
		private System.Windows.Forms.ToolStripButton TSBtn_OverSave;
		private System.Windows.Forms.Label LblRecord;
		private System.Windows.Forms.TextBox TBItemName;
		private System.Windows.Forms.ToolStripButton TSBtn_NewInfo;
		private System.Windows.Forms.ToolStripSeparator TSSeparator1;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Manager;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_NamedSave;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_ConvertToCsv;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_EditShopInfo;
		private System.Windows.Forms.Button BtnShopInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LblTax;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TBProfit;
		private System.Windows.Forms.TextBox TBProfitPer;
		private System.Windows.Forms.TextBox TBCost;
		private System.Windows.Forms.TextBox TBCostPer;
		private System.Windows.Forms.TextBox TBProfitPerItem;
		private System.Windows.Forms.TextBox TBCostPerItem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button BtnAddCopy;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.ToolTip ToolTipFullPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TBPerTime;
		private System.Windows.Forms.Label LblPerTime;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Help;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClmAmount;
		private System.Windows.Forms.DataGridViewComboBoxColumn MaterialType;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Visual;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Previous;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_Next;
		private System.Windows.Forms.TextBox TBPrice;
		private System.Windows.Forms.TextBox TBAmount;
		private System.Windows.Forms.TextBox TBProductSpeed;
		private System.Windows.Forms.TextBox TBProductTime;
		private System.Windows.Forms.TextBox TBRoyality;
		private System.Windows.Forms.ToolStripMenuItem TSMenu_ChangeColor;
		private System.Windows.Forms.ToolStripMenuItem TsMenu_ConvertToJson;
	}
}

