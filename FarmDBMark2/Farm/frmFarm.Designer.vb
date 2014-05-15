<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFarm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.tpProduction = New System.Windows.Forms.TabPage()
        Me.grpProduction = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductionID = New System.Windows.Forms.TextBox()
        Me.btnEditProduction = New System.Windows.Forms.Button()
        Me.btnAddProdution = New System.Windows.Forms.Button()
        Me.lvProduction = New System.Windows.Forms.ListView()
        Me.lvcProdID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdFieldName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdSeedBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdSeedVariety = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdPlantDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdHarvestDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdYeild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcProdActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chbxShowOnlyActiveProductions = New System.Windows.Forms.CheckBox()
        Me.btnRemoveProduction = New System.Windows.Forms.Button()
        Me.btnReactivateProduction = New System.Windows.Forms.Button()
        Me.btnSearchProduction = New System.Windows.Forms.Button()
        Me.grpChemProduction = New System.Windows.Forms.GroupBox()
        Me.lvProductionChem = New System.Windows.Forms.ListView()
        Me.lvcCPChemType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcCPChemBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcCPChemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcCPChemID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcCPApplicationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcCPActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddChemToProduction = New System.Windows.Forms.Button()
        Me.chbxShowOnlyActiveChemProduciton = New System.Windows.Forms.CheckBox()
        Me.btnEditChemInProduction = New System.Windows.Forms.Button()
        Me.btnReactivateChemFromProduction = New System.Windows.Forms.Button()
        Me.btnRemoveChemFromProduction = New System.Windows.Forms.Button()
        Me.tpField = New System.Windows.Forms.TabPage()
        Me.grpField = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditField = New System.Windows.Forms.Button()
        Me.lvField = New System.Windows.Forms.ListView()
        Me.lvcFieldID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcFieldName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcAcres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcOwner = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtFieldSearch = New System.Windows.Forms.TextBox()
        Me.btnAddField2 = New System.Windows.Forms.Button()
        Me.btnSearchField = New System.Windows.Forms.Button()
        Me.btnRemoveField = New System.Windows.Forms.Button()
        Me.btnReactivateField = New System.Windows.Forms.Button()
        Me.chbxShowOnlyActiveFields = New System.Windows.Forms.CheckBox()
        Me.tpSeed = New System.Windows.Forms.TabPage()
        Me.grpBrands = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchBrand = New System.Windows.Forms.TextBox()
        Me.btnEditBrand = New System.Windows.Forms.Button()
        Me.btnAddBrand = New System.Windows.Forms.Button()
        Me.btnRemoveBrand = New System.Windows.Forms.Button()
        Me.btnReactivateBrand = New System.Windows.Forms.Button()
        Me.btnSearchBrand = New System.Windows.Forms.Button()
        Me.lvBrand = New System.Windows.Forms.ListView()
        Me.lvcBrandID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcBrandName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcBrandDealer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcBrandActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpVarieties = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchSeed = New System.Windows.Forms.TextBox()
        Me.btnEditSeed = New System.Windows.Forms.Button()
        Me.btnAddSeed = New System.Windows.Forms.Button()
        Me.btnRemoveSeed = New System.Windows.Forms.Button()
        Me.btnReactivateSeed = New System.Windows.Forms.Button()
        Me.btnSearchSeed = New System.Windows.Forms.Button()
        Me.lvSeed = New System.Windows.Forms.ListView()
        Me.lvcSeedID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcSeedBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcSeedName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcSeedVariety = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcSeedCrop = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcSeedActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpChemical = New System.Windows.Forms.TabPage()
        Me.grpChemicals = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearchChemical = New System.Windows.Forms.TextBox()
        Me.btnEditChem = New System.Windows.Forms.Button()
        Me.btnAddChem = New System.Windows.Forms.Button()
        Me.btnRemoveChem = New System.Windows.Forms.Button()
        Me.btnReactivateChem = New System.Windows.Forms.Button()
        Me.btnSearchChem = New System.Windows.Forms.Button()
        Me.lvChem = New System.Windows.Forms.ListView()
        Me.lvcChemID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcChemBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcChemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcChemType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcChemActive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.TabControlMain.SuspendLayout()
        Me.tpProduction.SuspendLayout()
        Me.grpProduction.SuspendLayout()
        Me.grpChemProduction.SuspendLayout()
        Me.tpField.SuspendLayout()
        Me.grpField.SuspendLayout()
        Me.tpSeed.SuspendLayout()
        Me.grpBrands.SuspendLayout()
        Me.grpVarieties.SuspendLayout()
        Me.tpChemical.SuspendLayout()
        Me.grpChemicals.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.tpProduction)
        Me.TabControlMain.Controls.Add(Me.tpField)
        Me.TabControlMain.Controls.Add(Me.tpSeed)
        Me.TabControlMain.Controls.Add(Me.tpChemical)
        Me.TabControlMain.Location = New System.Drawing.Point(31, 25)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(737, 453)
        Me.TabControlMain.TabIndex = 0
        '
        'tpProduction
        '
        Me.tpProduction.Controls.Add(Me.grpProduction)
        Me.tpProduction.Controls.Add(Me.grpChemProduction)
        Me.tpProduction.Location = New System.Drawing.Point(4, 22)
        Me.tpProduction.Name = "tpProduction"
        Me.tpProduction.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProduction.Size = New System.Drawing.Size(729, 427)
        Me.tpProduction.TabIndex = 0
        Me.tpProduction.Text = "Harvest Manger"
        Me.tpProduction.UseVisualStyleBackColor = True
        '
        'grpProduction
        '
        Me.grpProduction.Controls.Add(Me.Label2)
        Me.grpProduction.Controls.Add(Me.txtProductionID)
        Me.grpProduction.Controls.Add(Me.btnEditProduction)
        Me.grpProduction.Controls.Add(Me.btnAddProdution)
        Me.grpProduction.Controls.Add(Me.lvProduction)
        Me.grpProduction.Controls.Add(Me.chbxShowOnlyActiveProductions)
        Me.grpProduction.Controls.Add(Me.btnRemoveProduction)
        Me.grpProduction.Controls.Add(Me.btnReactivateProduction)
        Me.grpProduction.Controls.Add(Me.btnSearchProduction)
        Me.grpProduction.Location = New System.Drawing.Point(17, 21)
        Me.grpProduction.Name = "grpProduction"
        Me.grpProduction.Size = New System.Drawing.Size(693, 207)
        Me.grpProduction.TabIndex = 15
        Me.grpProduction.TabStop = False
        Me.grpProduction.Text = "Production Years:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(542, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ID:"
        '
        'txtProductionID
        '
        Me.txtProductionID.Location = New System.Drawing.Point(567, 52)
        Me.txtProductionID.Name = "txtProductionID"
        Me.txtProductionID.Size = New System.Drawing.Size(35, 20)
        Me.txtProductionID.TabIndex = 14
        Me.txtProductionID.Tag = "Production Search ID"
        '
        'btnEditProduction
        '
        Me.btnEditProduction.Location = New System.Drawing.Point(608, 80)
        Me.btnEditProduction.Name = "btnEditProduction"
        Me.btnEditProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnEditProduction.TabIndex = 4
        Me.btnEditProduction.Text = "Edit"
        Me.btnEditProduction.UseVisualStyleBackColor = True
        '
        'btnAddProdution
        '
        Me.btnAddProdution.Location = New System.Drawing.Point(593, 21)
        Me.btnAddProdution.Name = "btnAddProdution"
        Me.btnAddProdution.Size = New System.Drawing.Size(90, 23)
        Me.btnAddProdution.TabIndex = 0
        Me.btnAddProdution.Text = "Add Production"
        Me.btnAddProdution.UseVisualStyleBackColor = True
        '
        'lvProduction
        '
        Me.lvProduction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcProdID, Me.lvcProdYear, Me.lvcProdFieldName, Me.lvcProdSeedBrand, Me.lvcProdSeedVariety, Me.lvcProdPlantDate, Me.lvcProdHarvestDate, Me.lvcProdYeild, Me.lvcProdActive})
        Me.lvProduction.FullRowSelect = True
        Me.lvProduction.GridLines = True
        Me.lvProduction.Location = New System.Drawing.Point(9, 21)
        Me.lvProduction.MultiSelect = False
        Me.lvProduction.Name = "lvProduction"
        Me.lvProduction.Size = New System.Drawing.Size(530, 163)
        Me.lvProduction.TabIndex = 2
        Me.lvProduction.UseCompatibleStateImageBehavior = False
        Me.lvProduction.View = System.Windows.Forms.View.Details
        '
        'lvcProdID
        '
        Me.lvcProdID.Text = "ID"
        Me.lvcProdID.Width = 24
        '
        'lvcProdYear
        '
        Me.lvcProdYear.Text = "Year"
        Me.lvcProdYear.Width = 40
        '
        'lvcProdFieldName
        '
        Me.lvcProdFieldName.Text = "Field"
        '
        'lvcProdSeedBrand
        '
        Me.lvcProdSeedBrand.Text = "Seed Brand"
        Me.lvcProdSeedBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvcProdSeedBrand.Width = 70
        '
        'lvcProdSeedVariety
        '
        Me.lvcProdSeedVariety.Text = "Variety"
        Me.lvcProdSeedVariety.Width = 70
        '
        'lvcProdPlantDate
        '
        Me.lvcProdPlantDate.Text = "Plant Date"
        Me.lvcProdPlantDate.Width = 74
        '
        'lvcProdHarvestDate
        '
        Me.lvcProdHarvestDate.Text = "Harvest Date"
        Me.lvcProdHarvestDate.Width = 83
        '
        'lvcProdYeild
        '
        Me.lvcProdYeild.Text = "Yeild"
        Me.lvcProdYeild.Width = 40
        '
        'lvcProdActive
        '
        Me.lvcProdActive.Text = "Active?"
        Me.lvcProdActive.Width = 48
        '
        'chbxShowOnlyActiveProductions
        '
        Me.chbxShowOnlyActiveProductions.AutoSize = True
        Me.chbxShowOnlyActiveProductions.Location = New System.Drawing.Point(573, 167)
        Me.chbxShowOnlyActiveProductions.Name = "chbxShowOnlyActiveProductions"
        Me.chbxShowOnlyActiveProductions.Size = New System.Drawing.Size(110, 17)
        Me.chbxShowOnlyActiveProductions.TabIndex = 13
        Me.chbxShowOnlyActiveProductions.Text = "Show Only Active"
        Me.chbxShowOnlyActiveProductions.UseVisualStyleBackColor = True
        '
        'btnRemoveProduction
        '
        Me.btnRemoveProduction.Location = New System.Drawing.Point(608, 109)
        Me.btnRemoveProduction.Name = "btnRemoveProduction"
        Me.btnRemoveProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveProduction.TabIndex = 5
        Me.btnRemoveProduction.Text = "Remove"
        Me.btnRemoveProduction.UseVisualStyleBackColor = True
        '
        'btnReactivateProduction
        '
        Me.btnReactivateProduction.Location = New System.Drawing.Point(608, 138)
        Me.btnReactivateProduction.Name = "btnReactivateProduction"
        Me.btnReactivateProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnReactivateProduction.TabIndex = 7
        Me.btnReactivateProduction.Text = "Reactivate"
        Me.btnReactivateProduction.UseVisualStyleBackColor = True
        '
        'btnSearchProduction
        '
        Me.btnSearchProduction.Location = New System.Drawing.Point(608, 50)
        Me.btnSearchProduction.Name = "btnSearchProduction"
        Me.btnSearchProduction.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchProduction.TabIndex = 6
        Me.btnSearchProduction.Text = "Search"
        Me.btnSearchProduction.UseVisualStyleBackColor = True
        '
        'grpChemProduction
        '
        Me.grpChemProduction.Controls.Add(Me.lvProductionChem)
        Me.grpChemProduction.Controls.Add(Me.btnAddChemToProduction)
        Me.grpChemProduction.Controls.Add(Me.chbxShowOnlyActiveChemProduciton)
        Me.grpChemProduction.Controls.Add(Me.btnEditChemInProduction)
        Me.grpChemProduction.Controls.Add(Me.btnReactivateChemFromProduction)
        Me.grpChemProduction.Controls.Add(Me.btnRemoveChemFromProduction)
        Me.grpChemProduction.Location = New System.Drawing.Point(66, 239)
        Me.grpChemProduction.Name = "grpChemProduction"
        Me.grpChemProduction.Size = New System.Drawing.Size(426, 167)
        Me.grpChemProduction.TabIndex = 14
        Me.grpChemProduction.TabStop = False
        Me.grpChemProduction.Text = "Chemicals Used In Production:"
        '
        'lvProductionChem
        '
        Me.lvProductionChem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcCPChemType, Me.lvcCPChemBrand, Me.lvcCPChemName, Me.lvcCPChemID, Me.lvcCPApplicationDate, Me.lvcCPActive})
        Me.lvProductionChem.FullRowSelect = True
        Me.lvProductionChem.Location = New System.Drawing.Point(8, 19)
        Me.lvProductionChem.MultiSelect = False
        Me.lvProductionChem.Name = "lvProductionChem"
        Me.lvProductionChem.Size = New System.Drawing.Size(409, 100)
        Me.lvProductionChem.TabIndex = 3
        Me.lvProductionChem.UseCompatibleStateImageBehavior = False
        Me.lvProductionChem.View = System.Windows.Forms.View.Details
        '
        'lvcCPChemType
        '
        Me.lvcCPChemType.Text = "Type"
        Me.lvcCPChemType.Width = 70
        '
        'lvcCPChemBrand
        '
        Me.lvcCPChemBrand.Text = "Brand"
        Me.lvcCPChemBrand.Width = 75
        '
        'lvcCPChemName
        '
        Me.lvcCPChemName.Text = "Name"
        Me.lvcCPChemName.Width = 80
        '
        'lvcCPChemID
        '
        Me.lvcCPChemID.Text = "ID"
        Me.lvcCPChemID.Width = 24
        '
        'lvcCPApplicationDate
        '
        Me.lvcCPApplicationDate.Text = "Application Date"
        Me.lvcCPApplicationDate.Width = 90
        '
        'lvcCPActive
        '
        Me.lvcCPActive.Text = "Active?"
        Me.lvcCPActive.Width = 48
        '
        'btnAddChemToProduction
        '
        Me.btnAddChemToProduction.Location = New System.Drawing.Point(24, 131)
        Me.btnAddChemToProduction.Name = "btnAddChemToProduction"
        Me.btnAddChemToProduction.Size = New System.Drawing.Size(40, 23)
        Me.btnAddChemToProduction.TabIndex = 8
        Me.btnAddChemToProduction.Text = "Add"
        Me.btnAddChemToProduction.UseVisualStyleBackColor = True
        '
        'chbxShowOnlyActiveChemProduciton
        '
        Me.chbxShowOnlyActiveChemProduciton.AutoSize = True
        Me.chbxShowOnlyActiveChemProduciton.Location = New System.Drawing.Point(265, 135)
        Me.chbxShowOnlyActiveChemProduciton.Name = "chbxShowOnlyActiveChemProduciton"
        Me.chbxShowOnlyActiveChemProduciton.Size = New System.Drawing.Size(110, 17)
        Me.chbxShowOnlyActiveChemProduciton.TabIndex = 12
        Me.chbxShowOnlyActiveChemProduciton.Text = "Show Only Active"
        Me.chbxShowOnlyActiveChemProduciton.UseVisualStyleBackColor = True
        '
        'btnEditChemInProduction
        '
        Me.btnEditChemInProduction.Location = New System.Drawing.Point(70, 131)
        Me.btnEditChemInProduction.Name = "btnEditChemInProduction"
        Me.btnEditChemInProduction.Size = New System.Drawing.Size(41, 23)
        Me.btnEditChemInProduction.TabIndex = 9
        Me.btnEditChemInProduction.Text = "Edit"
        Me.btnEditChemInProduction.UseVisualStyleBackColor = True
        '
        'btnReactivateChemFromProduction
        '
        Me.btnReactivateChemFromProduction.Location = New System.Drawing.Point(179, 131)
        Me.btnReactivateChemFromProduction.Name = "btnReactivateChemFromProduction"
        Me.btnReactivateChemFromProduction.Size = New System.Drawing.Size(69, 23)
        Me.btnReactivateChemFromProduction.TabIndex = 11
        Me.btnReactivateChemFromProduction.Text = "Reactivate"
        Me.btnReactivateChemFromProduction.UseVisualStyleBackColor = True
        '
        'btnRemoveChemFromProduction
        '
        Me.btnRemoveChemFromProduction.Location = New System.Drawing.Point(117, 131)
        Me.btnRemoveChemFromProduction.Name = "btnRemoveChemFromProduction"
        Me.btnRemoveChemFromProduction.Size = New System.Drawing.Size(56, 23)
        Me.btnRemoveChemFromProduction.TabIndex = 10
        Me.btnRemoveChemFromProduction.Text = "Remove"
        Me.btnRemoveChemFromProduction.UseVisualStyleBackColor = True
        '
        'tpField
        '
        Me.tpField.Controls.Add(Me.grpField)
        Me.tpField.Location = New System.Drawing.Point(4, 22)
        Me.tpField.Name = "tpField"
        Me.tpField.Padding = New System.Windows.Forms.Padding(3)
        Me.tpField.Size = New System.Drawing.Size(729, 427)
        Me.tpField.TabIndex = 1
        Me.tpField.Text = "Field Manager"
        Me.tpField.UseVisualStyleBackColor = True
        '
        'grpField
        '
        Me.grpField.Controls.Add(Me.Label1)
        Me.grpField.Controls.Add(Me.btnEditField)
        Me.grpField.Controls.Add(Me.lvField)
        Me.grpField.Controls.Add(Me.txtFieldSearch)
        Me.grpField.Controls.Add(Me.btnAddField2)
        Me.grpField.Controls.Add(Me.btnSearchField)
        Me.grpField.Controls.Add(Me.btnRemoveField)
        Me.grpField.Controls.Add(Me.btnReactivateField)
        Me.grpField.Controls.Add(Me.chbxShowOnlyActiveFields)
        Me.grpField.Location = New System.Drawing.Point(21, 24)
        Me.grpField.Name = "grpField"
        Me.grpField.Size = New System.Drawing.Size(634, 259)
        Me.grpField.TabIndex = 14
        Me.grpField.TabStop = False
        Me.grpField.Text = "Fields"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ID:"
        '
        'btnEditField
        '
        Me.btnEditField.Enabled = False
        Me.btnEditField.Location = New System.Drawing.Point(510, 79)
        Me.btnEditField.Name = "btnEditField"
        Me.btnEditField.Size = New System.Drawing.Size(95, 23)
        Me.btnEditField.TabIndex = 3
        Me.btnEditField.Text = "Edit Field"
        Me.btnEditField.UseVisualStyleBackColor = True
        '
        'lvField
        '
        Me.lvField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcFieldID, Me.lvcFieldName, Me.lvcAcres, Me.lvcOwner, Me.lvcActive})
        Me.lvField.FullRowSelect = True
        Me.lvField.GridLines = True
        Me.lvField.Location = New System.Drawing.Point(16, 21)
        Me.lvField.MultiSelect = False
        Me.lvField.Name = "lvField"
        Me.lvField.Size = New System.Drawing.Size(385, 219)
        Me.lvField.TabIndex = 0
        Me.lvField.UseCompatibleStateImageBehavior = False
        Me.lvField.View = System.Windows.Forms.View.Details
        '
        'lvcFieldID
        '
        Me.lvcFieldID.Text = "Field ID"
        Me.lvcFieldID.Width = 49
        '
        'lvcFieldName
        '
        Me.lvcFieldName.Text = "Field Name"
        Me.lvcFieldName.Width = 102
        '
        'lvcAcres
        '
        Me.lvcAcres.Text = "Acres"
        Me.lvcAcres.Width = 44
        '
        'lvcOwner
        '
        Me.lvcOwner.Text = "Owner"
        Me.lvcOwner.Width = 122
        '
        'lvcActive
        '
        Me.lvcActive.Text = "Active"
        Me.lvcActive.Width = 44
        '
        'txtFieldSearch
        '
        Me.txtFieldSearch.Location = New System.Drawing.Point(480, 53)
        Me.txtFieldSearch.Name = "txtFieldSearch"
        Me.txtFieldSearch.Size = New System.Drawing.Size(27, 20)
        Me.txtFieldSearch.TabIndex = 12
        Me.txtFieldSearch.Tag = "Field Search ID"
        '
        'btnAddField2
        '
        Me.btnAddField2.Location = New System.Drawing.Point(510, 21)
        Me.btnAddField2.Name = "btnAddField2"
        Me.btnAddField2.Size = New System.Drawing.Size(95, 23)
        Me.btnAddField2.TabIndex = 7
        Me.btnAddField2.Text = "Add Field"
        Me.btnAddField2.UseVisualStyleBackColor = True
        '
        'btnSearchField
        '
        Me.btnSearchField.Location = New System.Drawing.Point(510, 50)
        Me.btnSearchField.Name = "btnSearchField"
        Me.btnSearchField.Size = New System.Drawing.Size(95, 23)
        Me.btnSearchField.TabIndex = 11
        Me.btnSearchField.Text = "Search"
        Me.btnSearchField.UseVisualStyleBackColor = True
        '
        'btnRemoveField
        '
        Me.btnRemoveField.Location = New System.Drawing.Point(510, 108)
        Me.btnRemoveField.Name = "btnRemoveField"
        Me.btnRemoveField.Size = New System.Drawing.Size(95, 23)
        Me.btnRemoveField.TabIndex = 8
        Me.btnRemoveField.Text = "Remove Field"
        Me.btnRemoveField.UseVisualStyleBackColor = True
        '
        'btnReactivateField
        '
        Me.btnReactivateField.Location = New System.Drawing.Point(510, 137)
        Me.btnReactivateField.Name = "btnReactivateField"
        Me.btnReactivateField.Size = New System.Drawing.Size(95, 23)
        Me.btnReactivateField.TabIndex = 10
        Me.btnReactivateField.Text = "Reactivate Field"
        Me.btnReactivateField.UseVisualStyleBackColor = True
        '
        'chbxShowOnlyActiveFields
        '
        Me.chbxShowOnlyActiveFields.AutoSize = True
        Me.chbxShowOnlyActiveFields.Location = New System.Drawing.Point(495, 166)
        Me.chbxShowOnlyActiveFields.Name = "chbxShowOnlyActiveFields"
        Me.chbxShowOnlyActiveFields.Size = New System.Drawing.Size(110, 17)
        Me.chbxShowOnlyActiveFields.TabIndex = 9
        Me.chbxShowOnlyActiveFields.Text = "Show Only Active"
        Me.chbxShowOnlyActiveFields.UseVisualStyleBackColor = True
        '
        'tpSeed
        '
        Me.tpSeed.Controls.Add(Me.grpBrands)
        Me.tpSeed.Controls.Add(Me.grpVarieties)
        Me.tpSeed.Location = New System.Drawing.Point(4, 22)
        Me.tpSeed.Name = "tpSeed"
        Me.tpSeed.Size = New System.Drawing.Size(729, 427)
        Me.tpSeed.TabIndex = 4
        Me.tpSeed.Text = "Seed Manger"
        Me.tpSeed.UseVisualStyleBackColor = True
        '
        'grpBrands
        '
        Me.grpBrands.Controls.Add(Me.Label4)
        Me.grpBrands.Controls.Add(Me.txtSearchBrand)
        Me.grpBrands.Controls.Add(Me.btnEditBrand)
        Me.grpBrands.Controls.Add(Me.btnAddBrand)
        Me.grpBrands.Controls.Add(Me.btnRemoveBrand)
        Me.grpBrands.Controls.Add(Me.btnReactivateBrand)
        Me.grpBrands.Controls.Add(Me.btnSearchBrand)
        Me.grpBrands.Controls.Add(Me.lvBrand)
        Me.grpBrands.Location = New System.Drawing.Point(19, 240)
        Me.grpBrands.Name = "grpBrands"
        Me.grpBrands.Size = New System.Drawing.Size(518, 171)
        Me.grpBrands.TabIndex = 2
        Me.grpBrands.TabStop = False
        Me.grpBrands.Text = "Seed Brands"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ID:"
        '
        'txtSearchBrand
        '
        Me.txtSearchBrand.Location = New System.Drawing.Point(396, 45)
        Me.txtSearchBrand.Name = "txtSearchBrand"
        Me.txtSearchBrand.Size = New System.Drawing.Size(35, 20)
        Me.txtSearchBrand.TabIndex = 28
        Me.txtSearchBrand.Tag = "Seed Brand Search ID"
        '
        'btnEditBrand
        '
        Me.btnEditBrand.Location = New System.Drawing.Point(437, 73)
        Me.btnEditBrand.Name = "btnEditBrand"
        Me.btnEditBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnEditBrand.TabIndex = 24
        Me.btnEditBrand.Text = "Edit"
        Me.btnEditBrand.UseVisualStyleBackColor = True
        '
        'btnAddBrand
        '
        Me.btnAddBrand.Location = New System.Drawing.Point(437, 14)
        Me.btnAddBrand.Name = "btnAddBrand"
        Me.btnAddBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBrand.TabIndex = 23
        Me.btnAddBrand.Text = "Add Brand"
        Me.btnAddBrand.UseVisualStyleBackColor = True
        '
        'btnRemoveBrand
        '
        Me.btnRemoveBrand.Location = New System.Drawing.Point(437, 102)
        Me.btnRemoveBrand.Name = "btnRemoveBrand"
        Me.btnRemoveBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveBrand.TabIndex = 25
        Me.btnRemoveBrand.Text = "Remove"
        Me.btnRemoveBrand.UseVisualStyleBackColor = True
        '
        'btnReactivateBrand
        '
        Me.btnReactivateBrand.Location = New System.Drawing.Point(437, 131)
        Me.btnReactivateBrand.Name = "btnReactivateBrand"
        Me.btnReactivateBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnReactivateBrand.TabIndex = 27
        Me.btnReactivateBrand.Text = "Reactivate"
        Me.btnReactivateBrand.UseVisualStyleBackColor = True
        '
        'btnSearchBrand
        '
        Me.btnSearchBrand.Location = New System.Drawing.Point(437, 43)
        Me.btnSearchBrand.Name = "btnSearchBrand"
        Me.btnSearchBrand.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchBrand.TabIndex = 26
        Me.btnSearchBrand.Text = "Search"
        Me.btnSearchBrand.UseVisualStyleBackColor = True
        '
        'lvBrand
        '
        Me.lvBrand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcBrandID, Me.lvcBrandName, Me.lvcBrandDealer, Me.lvcBrandActive})
        Me.lvBrand.FullRowSelect = True
        Me.lvBrand.GridLines = True
        Me.lvBrand.Location = New System.Drawing.Point(29, 19)
        Me.lvBrand.Name = "lvBrand"
        Me.lvBrand.Size = New System.Drawing.Size(325, 136)
        Me.lvBrand.TabIndex = 1
        Me.lvBrand.UseCompatibleStateImageBehavior = False
        Me.lvBrand.View = System.Windows.Forms.View.Details
        '
        'lvcBrandID
        '
        Me.lvcBrandID.Text = "ID"
        Me.lvcBrandID.Width = 24
        '
        'lvcBrandName
        '
        Me.lvcBrandName.Text = "Brand Name"
        Me.lvcBrandName.Width = 78
        '
        'lvcBrandDealer
        '
        Me.lvcBrandDealer.Text = "Dealer Name"
        Me.lvcBrandDealer.Width = 158
        '
        'lvcBrandActive
        '
        Me.lvcBrandActive.Text = "Active"
        Me.lvcBrandActive.Width = 44
        '
        'grpVarieties
        '
        Me.grpVarieties.Controls.Add(Me.Label3)
        Me.grpVarieties.Controls.Add(Me.txtSearchSeed)
        Me.grpVarieties.Controls.Add(Me.btnEditSeed)
        Me.grpVarieties.Controls.Add(Me.btnAddSeed)
        Me.grpVarieties.Controls.Add(Me.btnRemoveSeed)
        Me.grpVarieties.Controls.Add(Me.btnReactivateSeed)
        Me.grpVarieties.Controls.Add(Me.btnSearchSeed)
        Me.grpVarieties.Controls.Add(Me.lvSeed)
        Me.grpVarieties.Location = New System.Drawing.Point(19, 23)
        Me.grpVarieties.Name = "grpVarieties"
        Me.grpVarieties.Size = New System.Drawing.Size(696, 199)
        Me.grpVarieties.TabIndex = 1
        Me.grpVarieties.TabStop = False
        Me.grpVarieties.Text = "Seed Varieties"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ID:"
        '
        'txtSearchSeed
        '
        Me.txtSearchSeed.Location = New System.Drawing.Point(564, 59)
        Me.txtSearchSeed.Name = "txtSearchSeed"
        Me.txtSearchSeed.Size = New System.Drawing.Size(35, 20)
        Me.txtSearchSeed.TabIndex = 21
        Me.txtSearchSeed.Tag = "Seed Search ID"
        '
        'btnEditSeed
        '
        Me.btnEditSeed.Location = New System.Drawing.Point(605, 87)
        Me.btnEditSeed.Name = "btnEditSeed"
        Me.btnEditSeed.Size = New System.Drawing.Size(75, 23)
        Me.btnEditSeed.TabIndex = 17
        Me.btnEditSeed.Text = "Edit"
        Me.btnEditSeed.UseVisualStyleBackColor = True
        '
        'btnAddSeed
        '
        Me.btnAddSeed.Location = New System.Drawing.Point(605, 28)
        Me.btnAddSeed.Name = "btnAddSeed"
        Me.btnAddSeed.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSeed.TabIndex = 16
        Me.btnAddSeed.Text = "Add Seed"
        Me.btnAddSeed.UseVisualStyleBackColor = True
        '
        'btnRemoveSeed
        '
        Me.btnRemoveSeed.Location = New System.Drawing.Point(605, 116)
        Me.btnRemoveSeed.Name = "btnRemoveSeed"
        Me.btnRemoveSeed.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveSeed.TabIndex = 18
        Me.btnRemoveSeed.Text = "Remove"
        Me.btnRemoveSeed.UseVisualStyleBackColor = True
        '
        'btnReactivateSeed
        '
        Me.btnReactivateSeed.Location = New System.Drawing.Point(605, 145)
        Me.btnReactivateSeed.Name = "btnReactivateSeed"
        Me.btnReactivateSeed.Size = New System.Drawing.Size(75, 23)
        Me.btnReactivateSeed.TabIndex = 20
        Me.btnReactivateSeed.Text = "Reactivate"
        Me.btnReactivateSeed.UseVisualStyleBackColor = True
        '
        'btnSearchSeed
        '
        Me.btnSearchSeed.Location = New System.Drawing.Point(605, 57)
        Me.btnSearchSeed.Name = "btnSearchSeed"
        Me.btnSearchSeed.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchSeed.TabIndex = 19
        Me.btnSearchSeed.Text = "Search"
        Me.btnSearchSeed.UseVisualStyleBackColor = True
        '
        'lvSeed
        '
        Me.lvSeed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcSeedID, Me.lvcSeedBrand, Me.lvcSeedName, Me.lvcSeedVariety, Me.lvcSeedCrop, Me.lvcSeedActive})
        Me.lvSeed.FullRowSelect = True
        Me.lvSeed.GridLines = True
        Me.lvSeed.Location = New System.Drawing.Point(20, 28)
        Me.lvSeed.Name = "lvSeed"
        Me.lvSeed.Size = New System.Drawing.Size(498, 150)
        Me.lvSeed.TabIndex = 0
        Me.lvSeed.UseCompatibleStateImageBehavior = False
        Me.lvSeed.View = System.Windows.Forms.View.Details
        '
        'lvcSeedID
        '
        Me.lvcSeedID.Text = "ID"
        Me.lvcSeedID.Width = 24
        '
        'lvcSeedBrand
        '
        Me.lvcSeedBrand.Text = "Brand"
        Me.lvcSeedBrand.Width = 74
        '
        'lvcSeedName
        '
        Me.lvcSeedName.Text = "Name"
        Me.lvcSeedName.Width = 183
        '
        'lvcSeedVariety
        '
        Me.lvcSeedVariety.Text = "Variety"
        Me.lvcSeedVariety.Width = 82
        '
        'lvcSeedCrop
        '
        Me.lvcSeedCrop.Text = "Crop"
        Me.lvcSeedCrop.Width = 70
        '
        'lvcSeedActive
        '
        Me.lvcSeedActive.Text = "Active"
        Me.lvcSeedActive.Width = 42
        '
        'tpChemical
        '
        Me.tpChemical.Controls.Add(Me.grpChemicals)
        Me.tpChemical.Location = New System.Drawing.Point(4, 22)
        Me.tpChemical.Name = "tpChemical"
        Me.tpChemical.Padding = New System.Windows.Forms.Padding(3)
        Me.tpChemical.Size = New System.Drawing.Size(729, 427)
        Me.tpChemical.TabIndex = 3
        Me.tpChemical.Text = "Chemical Manager"
        Me.tpChemical.UseVisualStyleBackColor = True
        '
        'grpChemicals
        '
        Me.grpChemicals.Controls.Add(Me.Label5)
        Me.grpChemicals.Controls.Add(Me.txtSearchChemical)
        Me.grpChemicals.Controls.Add(Me.btnEditChem)
        Me.grpChemicals.Controls.Add(Me.btnAddChem)
        Me.grpChemicals.Controls.Add(Me.btnRemoveChem)
        Me.grpChemicals.Controls.Add(Me.btnReactivateChem)
        Me.grpChemicals.Controls.Add(Me.btnSearchChem)
        Me.grpChemicals.Controls.Add(Me.lvChem)
        Me.grpChemicals.Location = New System.Drawing.Point(32, 27)
        Me.grpChemicals.Name = "grpChemicals"
        Me.grpChemicals.Size = New System.Drawing.Size(638, 254)
        Me.grpChemicals.TabIndex = 1
        Me.grpChemicals.TabStop = False
        Me.grpChemicals.Text = "Chemicals"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ID:"
        '
        'txtSearchChemical
        '
        Me.txtSearchChemical.Location = New System.Drawing.Point(489, 51)
        Me.txtSearchChemical.Name = "txtSearchChemical"
        Me.txtSearchChemical.Size = New System.Drawing.Size(35, 20)
        Me.txtSearchChemical.TabIndex = 28
        Me.txtSearchChemical.Tag = "Chemcial Search ID"
        '
        'btnEditChem
        '
        Me.btnEditChem.Location = New System.Drawing.Point(531, 78)
        Me.btnEditChem.Name = "btnEditChem"
        Me.btnEditChem.Size = New System.Drawing.Size(85, 23)
        Me.btnEditChem.TabIndex = 24
        Me.btnEditChem.Text = "Edit"
        Me.btnEditChem.UseVisualStyleBackColor = True
        '
        'btnAddChem
        '
        Me.btnAddChem.Location = New System.Drawing.Point(531, 19)
        Me.btnAddChem.Name = "btnAddChem"
        Me.btnAddChem.Size = New System.Drawing.Size(85, 23)
        Me.btnAddChem.TabIndex = 23
        Me.btnAddChem.Text = "Add Chemical"
        Me.btnAddChem.UseVisualStyleBackColor = True
        '
        'btnRemoveChem
        '
        Me.btnRemoveChem.Location = New System.Drawing.Point(531, 107)
        Me.btnRemoveChem.Name = "btnRemoveChem"
        Me.btnRemoveChem.Size = New System.Drawing.Size(85, 23)
        Me.btnRemoveChem.TabIndex = 25
        Me.btnRemoveChem.Text = "Remove"
        Me.btnRemoveChem.UseVisualStyleBackColor = True
        '
        'btnReactivateChem
        '
        Me.btnReactivateChem.Location = New System.Drawing.Point(531, 136)
        Me.btnReactivateChem.Name = "btnReactivateChem"
        Me.btnReactivateChem.Size = New System.Drawing.Size(85, 23)
        Me.btnReactivateChem.TabIndex = 27
        Me.btnReactivateChem.Text = "Reactivate"
        Me.btnReactivateChem.UseVisualStyleBackColor = True
        '
        'btnSearchChem
        '
        Me.btnSearchChem.Location = New System.Drawing.Point(531, 48)
        Me.btnSearchChem.Name = "btnSearchChem"
        Me.btnSearchChem.Size = New System.Drawing.Size(85, 23)
        Me.btnSearchChem.TabIndex = 26
        Me.btnSearchChem.Text = "Search"
        Me.btnSearchChem.UseVisualStyleBackColor = True
        '
        'lvChem
        '
        Me.lvChem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcChemID, Me.lvcChemBrand, Me.lvcChemName, Me.lvcChemType, Me.lvcChemActive})
        Me.lvChem.FullRowSelect = True
        Me.lvChem.GridLines = True
        Me.lvChem.Location = New System.Drawing.Point(16, 19)
        Me.lvChem.MultiSelect = False
        Me.lvChem.Name = "lvChem"
        Me.lvChem.Size = New System.Drawing.Size(381, 214)
        Me.lvChem.TabIndex = 0
        Me.lvChem.UseCompatibleStateImageBehavior = False
        Me.lvChem.View = System.Windows.Forms.View.Details
        '
        'lvcChemID
        '
        Me.lvcChemID.Text = "ID"
        Me.lvcChemID.Width = 24
        '
        'lvcChemBrand
        '
        Me.lvcChemBrand.Text = "Brand"
        Me.lvcChemBrand.Width = 80
        '
        'lvcChemName
        '
        Me.lvcChemName.Text = "Name"
        Me.lvcChemName.Width = 116
        '
        'lvcChemType
        '
        Me.lvcChemType.Text = "Type"
        Me.lvcChemType.Width = 90
        '
        'lvcChemActive
        '
        Me.lvcChemActive.Text = "Active"
        Me.lvcChemActive.Width = 46
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(689, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'frmFarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 492)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.TabControlMain)
        Me.Name = "frmFarm"
        Me.Text = "Farm Pro"
        Me.TabControlMain.ResumeLayout(False)
        Me.tpProduction.ResumeLayout(False)
        Me.grpProduction.ResumeLayout(False)
        Me.grpProduction.PerformLayout()
        Me.grpChemProduction.ResumeLayout(False)
        Me.grpChemProduction.PerformLayout()
        Me.tpField.ResumeLayout(False)
        Me.grpField.ResumeLayout(False)
        Me.grpField.PerformLayout()
        Me.tpSeed.ResumeLayout(False)
        Me.grpBrands.ResumeLayout(False)
        Me.grpBrands.PerformLayout()
        Me.grpVarieties.ResumeLayout(False)
        Me.grpVarieties.PerformLayout()
        Me.tpChemical.ResumeLayout(False)
        Me.grpChemicals.ResumeLayout(False)
        Me.grpChemicals.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
    Friend WithEvents tpProduction As System.Windows.Forms.TabPage
    Friend WithEvents tpField As System.Windows.Forms.TabPage
    Friend WithEvents lvField As System.Windows.Forms.ListView
    Friend WithEvents lvcFieldID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcFieldName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcAcres As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcOwner As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEditField As System.Windows.Forms.Button
    Friend WithEvents btnAddField2 As System.Windows.Forms.Button
    Friend WithEvents btnRemoveField As System.Windows.Forms.Button
    Friend WithEvents lvcActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents chbxShowOnlyActiveFields As System.Windows.Forms.CheckBox
    Friend WithEvents btnReactivateField As System.Windows.Forms.Button
    Friend WithEvents btnSearchField As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFieldSearch As System.Windows.Forms.TextBox
    Friend WithEvents tpChemical As System.Windows.Forms.TabPage
    Friend WithEvents tpSeed As System.Windows.Forms.TabPage
    Friend WithEvents btnAddProdution As System.Windows.Forms.Button
    Friend WithEvents lvProduction As System.Windows.Forms.ListView
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents lvcProdID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdYear As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdFieldName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdSeedBrand As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdSeedVariety As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdPlantDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdHarvestDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdYeild As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProdActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvProductionChem As System.Windows.Forms.ListView
    Friend WithEvents lvcCPChemType As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcCPChemBrand As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcCPChemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcCPApplicationDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcCPActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveProduction As System.Windows.Forms.Button
    Friend WithEvents btnEditProduction As System.Windows.Forms.Button
    Friend WithEvents btnSearchProduction As System.Windows.Forms.Button
    Friend WithEvents chbxShowOnlyActiveChemProduciton As System.Windows.Forms.CheckBox
    Friend WithEvents btnReactivateChemFromProduction As System.Windows.Forms.Button
    Friend WithEvents btnRemoveChemFromProduction As System.Windows.Forms.Button
    Friend WithEvents btnEditChemInProduction As System.Windows.Forms.Button
    Friend WithEvents btnAddChemToProduction As System.Windows.Forms.Button
    Friend WithEvents btnReactivateProduction As System.Windows.Forms.Button
    Friend WithEvents grpProduction As System.Windows.Forms.GroupBox
    Friend WithEvents chbxShowOnlyActiveProductions As System.Windows.Forms.CheckBox
    Friend WithEvents grpChemProduction As System.Windows.Forms.GroupBox
    Friend WithEvents lvcCPID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvChem As System.Windows.Forms.ListView
    Friend WithEvents lvcChemID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcChemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcChemBrand As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcChemType As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcChemActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcCPChemID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProductionID As System.Windows.Forms.TextBox
    Friend WithEvents lvSeed As System.Windows.Forms.ListView
    Friend WithEvents lvcSeedID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcSeedBrand As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcSeedName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcSeedVariety As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcSeedCrop As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcSeedActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvBrand As System.Windows.Forms.ListView
    Friend WithEvents lvcBrandID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcBrandName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcBrandDealer As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcBrandActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpVarieties As System.Windows.Forms.GroupBox
    Friend WithEvents grpBrands As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearchBrand As System.Windows.Forms.TextBox
    Friend WithEvents btnEditBrand As System.Windows.Forms.Button
    Friend WithEvents btnAddBrand As System.Windows.Forms.Button
    Friend WithEvents btnRemoveBrand As System.Windows.Forms.Button
    Friend WithEvents btnReactivateBrand As System.Windows.Forms.Button
    Friend WithEvents btnSearchBrand As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchSeed As System.Windows.Forms.TextBox
    Friend WithEvents btnEditSeed As System.Windows.Forms.Button
    Friend WithEvents btnAddSeed As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSeed As System.Windows.Forms.Button
    Friend WithEvents btnReactivateSeed As System.Windows.Forms.Button
    Friend WithEvents btnSearchSeed As System.Windows.Forms.Button
    Friend WithEvents grpChemicals As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearchChemical As System.Windows.Forms.TextBox
    Friend WithEvents btnEditChem As System.Windows.Forms.Button
    Friend WithEvents btnAddChem As System.Windows.Forms.Button
    Friend WithEvents btnRemoveChem As System.Windows.Forms.Button
    Friend WithEvents btnReactivateChem As System.Windows.Forms.Button
    Friend WithEvents btnSearchChem As System.Windows.Forms.Button
    Friend WithEvents grpField As System.Windows.Forms.GroupBox

End Class
