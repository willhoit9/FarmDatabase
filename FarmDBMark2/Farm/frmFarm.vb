Imports FarmBLL
Imports FarmDataTypes




Public Class frmFarm
    Private _owner As Boolean = False
    Private _admin As Boolean = False

    Public myField As Field
    Private _myFieldManager As FieldManager
    Private _showOnlyActiveFields As Boolean = True


    Private _myProductionManager As ProductionManager
    Private _showOnlyActiveProductions As Boolean = True

    Private _myProdChemManager As ProdChemManager
    Private _showOnlyActiveProductionChemicals As Boolean = True

    Private _mySeedManager As SeedManager
    Private _myBrandManager As BrandManager
    Private _myChemManager As ChemManager


    '///////////BEGIN OF "ROOT LEVEL" //////////////
    '///////////BEGIN OF "ROOT LEVEL" //////////////

    'ROOT LEVEL - FORM LOAD EVENTS
    Private Sub FarmForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _myFieldManager = New FieldManager
        _myProductionManager = New ProductionManager
        _myProdChemManager = New ProdChemManager
        _mySeedManager = New SeedManager
        _myBrandManager = New BrandManager
        _myChemManager = New ChemManager

        fauxLogin()

        'set up the layout for standard users
        standardLayout()
        detectClearance()



    End Sub

    Private Sub fauxLogin()
        Dim fauxLoginForm As New frmFauxLogin
        Dim selectedRole As DialogResult = fauxLoginForm.ShowDialog

        If selectedRole = Windows.Forms.DialogResult.Yes Then
            _owner = True
        ElseIf selectedRole = Windows.Forms.DialogResult.No Then
            _owner = False
        ElseIf selectedRole = Windows.Forms.DialogResult.Abort Then
            _owner = False
            Me.Close()
        End If


    End Sub

    'ROOT LEVEL - DETERMINES WHICH OPTIONS TO DISPLAY, BASED ON A USERS CLEARANCE 
    'TODO! - set up access token stuff if time allows. :(
    Private Sub detectClearance()
        If _owner = True Then
            ' show usability options available to farm owners
            showOwnerOptions()
        End If

        If _admin = True Then
            _owner = True
            showOwnerOptions()
            showAdminOptions()
        End If

    End Sub


    ' ROOT LEVEL - SETS THE LAYOUT FOR STANDARD USERS
    Private Sub standardLayout()


        'PRODUCTION MANAGER

        lvProduction.HideSelection = False
        lvcProdActive.Width = 0
        lvProduction.Width = 482
        btnRemoveProduction.Hide()
        btnReactivateProduction.Hide()
        chbxShowOnlyActiveProductions.Checked = True
        chbxShowOnlyActiveProductions.Hide()

        disableProductionButtons()


        'PRODUCTION CHEM

        lvProductionChem.Width = 361
        lvcCPActive.Width = 0
        btnRemoveChemFromProduction.Hide()
        btnReactivateChemFromProduction.Hide()
        chbxShowOnlyActiveChemProduciton.Checked = True
        chbxShowOnlyActiveChemProduciton.Hide()


        disableProductionChemButtons()


        'FIELD MANAGER
        btnRemoveField.Hide()
        btnReactivateField.Hide()
        chbxShowOnlyActiveFields.Checked = True
        chbxShowOnlyActiveFields.Hide()
        lvcActive.Width = 0
        lvField.Width = 340

        disableFieldButtons()

        'Hides the Seed Table, Brand Table, and Chemical Table from the plebeians
        Me.TabControlMain.TabPages.Remove(tpSeed)
        Me.TabControlMain.TabPages.Remove(tpChemical)

        'SEED MANAGER

        disableSeedButtons()

        'BRAND MANAGER

        disableBrandButtons()

        'CHEMICAL MANAGER

        disableChemButtons()

    End Sub



    ' ROOT LEVEL - SETS THE LAYOUT FOR OWNER USERS - BUILDS UPON THE STANDARD LAYOUT
    Private Sub showOwnerOptions()

        'PRODUCTION MANAGER

        lvProduction.Width = 530
        lvcProdActive.Width = 48
        btnRemoveField.Show()
        btnReactivateField.Show()
        chbxShowOnlyActiveProductions.Show()
        btnRemoveProduction.Show()
        btnReactivateProduction.Show()


        'PRODUCTION CHEM

        btnRemoveChemFromProduction.Show()
        btnReactivateChemFromProduction.Show()
        chbxShowOnlyActiveChemProduciton.Show()
        lvProductionChem.Width = 409
        lvcCPActive.Width = 48

        'FIELD MANAGER
        btnRemoveField.Show()
        btnReactivateField.Show()
        lvField.Width = 385
        lvcActive.Width = 46
        chbxShowOnlyActiveFields.Show()


        Me.TabControlMain.TabPages.Add(tpSeed)
        Me.TabControlMain.TabPages.Add(tpChemical)


    End Sub

    ' ROOT LEVEL - SETS THE LAYOUT FOR ADMIN USERS - BUILDS UPON STANDARD AND OWNER LAYOUTS
    Private Sub showAdminOptions()

    End Sub


    Private Sub disableProductionButtons()

        btnEditProduction.Enabled = False
        btnRemoveProduction.Enabled = False
        btnReactivateProduction.Enabled = False


    End Sub

    Private Sub disableProductionChemButtons()
        btnAddChemToProduction.Enabled = False
        btnEditChemInProduction.Enabled = False
        btnRemoveChemFromProduction.Enabled = False
        btnReactivateChemFromProduction.Enabled = False
    End Sub

    Private Sub disableProductionChemicalTandLV()
        Me.grpChemProduction.Text = "Chemicals Used In Production"
        Me.lvProductionChem.Items.Clear()
    End Sub

    'FIELD MANAGER - DISABLES BUTTONS NEEDING A GOOD DISABLING
    Private Sub disableFieldButtons()

        btnEditField.Enabled = False
        btnRemoveField.Enabled = False
        btnReactivateField.Enabled = False
    End Sub

    Private Sub disableSeedButtons()
        btnEditSeed.Enabled = False
        btnRemoveSeed.Enabled = False
        btnReactivateSeed.Enabled = False

        For Each item As ListViewItem In lvBrand.Items
            item.BackColor = Color.Transparent
        Next
    End Sub

    Private Sub disableBrandButtons()
        btnEditBrand.Enabled = False
        btnReactivateBrand.Enabled = False
        btnRemoveBrand.Enabled = False

        For Each item As ListViewItem In lvBrand.Items
            item.BackColor = Color.Transparent
        Next
    End Sub

    Private Sub disableChemButtons()
        btnEditChem.Enabled = False
        btnReactivateChem.Enabled = False
        btnRemoveChem.Enabled = False
    End Sub

    Private Sub btnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click

        Dim fauxLoginForm As New frmFauxLogin
        Dim selectedRole As DialogResult = fauxLoginForm.ShowDialog

        If selectedRole = Windows.Forms.DialogResult.Yes Then
            _owner = True
        ElseIf selectedRole = Windows.Forms.DialogResult.No Then
            _owner = False
        ElseIf selectedRole = Windows.Forms.DialogResult.Abort Then
            Me.Close()
        Else
            Me.Close()
        End If
        standardLayout()
        detectClearance()
    End Sub



    '///////////END OF "ROOT LEVEL" //////////////
    '///////////END OF "ROOT LEVEL" //////////////









    '///////////BEGIN OF FIELD SECTION//////////////
    '///////////BEGIN OF FIELD SECTION//////////////

    'FIELD MANAGER - WHEN ENTERING THE FIELD MANAGER TAB, POPULATE THE LISTVIEW
    Private Sub tpField_Enter(sender As Object, e As System.EventArgs) Handles tpField.Enter
        populateFieldListview(lvField, 0, True)
        txtFieldSearch.Clear()

    End Sub

    ' FIELD MANAGER - ADD A FIELD BUTTON
    Private Sub btnAddField2_Click(sender As System.Object, e As System.EventArgs) Handles btnAddField2.Click
        addField()
    End Sub

    ' FIELD MANAGER - SEARCH FOR FIELD BUTTON
    Private Sub btnSearchField_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchField.Click
        searchField()
    End Sub

    ' FIELD MANAGER - REMOVE A FIELD BUTTON
    Private Sub btnRemoveField_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveField.Click
        ' remove, don't reactivate
        swapFieldActive(True)
    End Sub

    ' FIELD MANAGER - REACTIVATE A REMOVED FIELD BUTTON
    Private Sub btnReactivateField_Click(sender As System.Object, e As System.EventArgs) Handles btnReactivateField.Click
        ' reactivate, dont remove
        swapFieldActive(False)
    End Sub

    'FIELD MANAGER - WHEN SELECTING A HEADER COLUMN, RESORT, ORDERED BY THAT COLUMN
    Private Sub lvField_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvField.ColumnClick
        Dim selectedColumn As Integer = e.Column
        populateFieldListview(lvField, selectedColumn, False)
    End Sub

    'FIELD MANAGER - WHEN SELECTING A ROW, DISPLAY MODIFICATION BUTTONS
    Private Sub lvField_Click(sender As Object, e As System.EventArgs) Handles lvField.Click
        btnEditField.Enabled = True
        btnRemoveField.Enabled = True
        btnReactivateField.Enabled = True
    End Sub




    'FIELD MANAGER - POPULATE THE LISTVIEW
    Private Sub populateFieldListview(ByRef lvA As ListView, Optional ByVal plSelectedIndex As Integer = 0, Optional ByVal plForcedAscension As Boolean = False)
        Dim listOfFields As List(Of Field)

        listOfFields = _myFieldManager.getFieldList(plSelectedIndex, _showOnlyActiveFields, plForcedAscension)

        lvA.Items.Clear()

        'Dim fld As Field
        For i As Integer = 0 To listOfFields.Count - 1

            lvA.Items.Add(listOfFields(i).FieldID)
            lvA.Items(i).SubItems.Add(listOfFields(i).FieldName)
            lvA.Items(i).SubItems.Add(listOfFields(i).Acres)
            lvA.Items(i).SubItems.Add(listOfFields(i).Owner)
            If _owner Then
                lvA.Items(i).SubItems.Add(listOfFields(i).Active)
            End If

        Next
        disableFieldButtons()

    End Sub


    ' FIELD MANAGER - SEARCH FOR FIELD BY ID
    Private Sub searchField()
        If fieldSearchIsValid() Then
            Dim searchID As Integer = CInt(txtFieldSearch.Text)
            Dim fieldSearchForm As New frmFieldSearch
            fieldSearchForm.txtSearchFieldID.Text = searchID
            Dim selectedSearchButton As DialogResult = fieldSearchForm.ShowDialog

            If selectedSearchButton = Windows.Forms.DialogResult.OK Then
                MsgBox(fieldSearchForm.Tag.ToString)
            End If
            populateFieldListview(lvField, 0, True)
        End If
        '  Me.myField = Nothing
    End Sub

    Private Function fieldSearchIsValid() As Boolean
        If valid.IsPresent(txtFieldSearch) AndAlso
            valid.IsInt(txtFieldSearch) AndAlso
            valid.isGreaterThan(0, txtFieldSearch) AndAlso
            valid.isLessThan(_myFieldManager.maxID, txtFieldSearch) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' FIELD MANAGER - ADD A FIELD
    Private Sub addField()
        Dim addFieldForm As New frmFieldAdd
        Dim selectedAddFormButton As DialogResult = addFieldForm.ShowDialog

        If selectedAddFormButton = DialogResult.OK Then
            MsgBox(addFieldForm.Tag.ToString)
            populateFieldListview(lvField, 0, True)
        Else
            disableFieldButtons()
        End If
    End Sub


    ' FIELD MANAGER - EDIT A FIELD BUTTON
    Private Sub btnEditField_Click(sender As System.Object, e As System.EventArgs) Handles btnEditField.Click

        Dim selectedField = Me.lvField.SelectedItems
        Dim editFieldForm As New frmFieldEdit
        ' editFieldForm.fromSearch = False
        If selectedField.Count Then
            'MsgBox(selectedID & " " & selectedFieldName & " " & selectedAcres & " " & selectedOwner)

            myField = New Field

            myField.FieldID = CInt(selectedField(0).SubItems(0).Text)
            myField.FieldName = selectedField(0).SubItems(1).Text
            myField.Acres = CInt(selectedField(0).SubItems(2).Text)
            myField.Owner = selectedField(0).SubItems(3).Text

            Dim selectedEditButton As DialogResult = editFieldForm.ShowDialog

            If selectedEditButton = DialogResult.OK Then
                MsgBox(editFieldForm.Tag.ToString)

                populateFieldListview(lvField, 0, True)

            End If
            disableFieldButtons()
            Me.myField = Nothing
        Else
            MsgBox("Please choose a Field to edit")
        End If

    End Sub





    ' FIELD MANAGER - METHOD THAT ACTIVATES A FIELD OR DEACTIVATES A FIELD
    Private Sub swapFieldActive(ByVal remove As Boolean)

        Dim selectedField = Me.lvField.SelectedItems
        Dim swapActiveFieldForm As New frmFieldSwapActive

        If selectedField.Count Then
            myField = New Field

            myField.FieldID = CInt(selectedField(0).SubItems(0).Text)
            myField.FieldName = selectedField(0).SubItems(1).Text
            myField.Acres = CInt(selectedField(0).SubItems(2).Text)
            myField.Owner = selectedField(0).SubItems(3).Text
            myField.Active = CBool(selectedField(0).SubItems(4).Text)

            If myField.Active = False And remove = True Then
                MsgBox("This field is already inactive!")
            ElseIf myField.Active = True And remove = False Then
                MsgBox("This field is already active!")
            Else

                Dim selectedRemoveButton As DialogResult = swapActiveFieldForm.ShowDialog

                If selectedRemoveButton = DialogResult.OK Then
                    MsgBox(swapActiveFieldForm.Tag.ToString)

                    populateFieldListview(lvField, 0, True)

                End If
            End If 'end redunancy check

            disableFieldButtons()
            Me.myField = Nothing
        End If

    End Sub


    ' FIELD MANAGER - CHECKBOX TO CHOOSE WHETHER TO DISPLAY ACTIVE FIELDS OR NOT
    Private Sub chbxShowOnlyActiveFields_Click(sender As Object, e As System.EventArgs) Handles chbxShowOnlyActiveFields.Click

        If chbxShowOnlyActiveFields.Checked = True Then

            _showOnlyActiveFields = True
            populateFieldListview(lvField, 0, True)
        Else

            _showOnlyActiveFields = False
            populateFieldListview(lvField, 0, True)
        End If
    End Sub




    '///////////END OF FIELD SECTION//////////////
    '///////////END OF FIELD SECTION//////////////



    '///////////BEGIN OF PRODUCTION SECTION//////////////
    '///////////BEGIN OF PRODUCTION SECTION//////////////


    'PRODUCTION MANAGER - ENTER THE PRODUCTION TAB
    Private Sub tpProduction_Enter(sender As Object, e As System.EventArgs) Handles tpProduction.Enter
        populateProductionListview(lvProduction, 0, True)
        lvProductionChem.Items.Clear()

    End Sub

    'PRODUCTION MANAGER - LEAVE THE PRODUCTION TAB
    Private Sub tpProduction_Leave(sender As Object, e As System.EventArgs) Handles tpProduction.Leave

    End Sub


    ' PRODUCTION MANAGER - ADD A PRODUCTION TO THE TABLE
    Private Sub btnAddProdution_Click(sender As System.Object, e As System.EventArgs) Handles btnAddProdution.Click
        addProduction()
    End Sub

    Private Sub btnSearchProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchProduction.Click
        productionSearch()
    End Sub

    Private Sub btnEditProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnEditProduction.Click

        editProduction()
        disableProductionButtons()
    End Sub

    Private Sub btnRemoveProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveProduction.Click
        swapActiveProduction(True)
    End Sub

    Private Sub btnReactivateProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnReactivateProduction.Click
        swapActiveProduction(False)
    End Sub

    'PRODUCTION MANAGER - WHEN SELECTING A HEADER COLUMN, RESORT, ORDERED BY THAT COLUMN
    Private Sub lvProduction_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvProduction.ColumnClick
        Dim selectedColumn As Integer = e.Column
        populateProductionListview(lvProduction, selectedColumn, False)
    End Sub

    Private Sub addProduction()
        Dim productionAddProduction As New frmProductionAdd
        Dim selectedAddButton As DialogResult = productionAddProduction.ShowDialog

        If selectedAddButton = DialogResult.OK Then
            MsgBox(productionAddProduction.Tag.ToString)
            populateProductionListview(lvProduction, 0, True)
        End If
        disableProductionChemicalTandLV()

    End Sub

    Private Sub editProduction()
        Dim selectedProduction = Me.lvProduction.SelectedItems

        If selectedProduction.Count Then
            Dim selectedFieldID As Integer

            selectedFieldID = CInt(selectedProduction(0).SubItems(0).Text)

            Try
                Dim editProductionForm As New frmProductionEditSearch(selectedFieldID, False)

                Dim selectedEditButton As DialogResult = editProductionForm.ShowDialog


                If selectedEditButton = DialogResult.OK Then
                    MsgBox(editProductionForm.Tag.ToString)

                    populateProductionListview(lvProduction, 0, True)

                End If

            Catch ex As ApplicationException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please choose a Production to edit")
        End If
        disableProductionChemicalTandLV()

    End Sub



    Private Sub productionSearch()
        If productionSearchIsValid() Then
            Dim searchID As Integer = CInt(txtProductionID.Text)

            Try
                Dim searchProductionForm As New frmProductionEditSearch(searchID, True)

                Dim selectedButton As DialogResult = searchProductionForm.ShowDialog

                If selectedButton = DialogResult.OK Then
                    MsgBox(searchProductionForm.Tag.ToString)
                    populateProductionListview(lvProduction, 0, True)
                End If
                If selectedButton = DialogResult.Abort Then
                    MsgBox(searchProductionForm.Tag.ToString)
                End If
            Catch ex As ApplicationException
                MsgBox(ex.Message)
            End Try


            disableProductionButtons()
            Me.txtProductionID.Clear()
        End If

    End Sub

    Private Function productionSearchIsValid() As Boolean
        If valid.IsPresent(txtProductionID) AndAlso
            valid.IsInt(txtProductionID) AndAlso
            valid.isGreaterThan(0, txtProductionID) AndAlso
            valid.isLessThan(_myProductionManager.maxID, txtProductionID) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub swapActiveProduction(ByVal remove As Boolean)
        Dim selectedProduction = Me.lvProduction.SelectedItems

        If selectedProduction.Count Then
            Dim selectedFieldID As Integer
            selectedFieldID = CInt(selectedProduction(0).SubItems(0).Text)

            If _myProductionManager.isActive(selectedFieldID) And remove = False Then
                MsgBox("This Production is already active")
                Exit Sub
            End If
            If _myProductionManager.isActive(selectedFieldID) = False And remove = True Then
                MsgBox("This Production has already been removed")
                Exit Sub
            End If

            Dim swapActiveProdctionForm As New frmProductionSwapActive(selectedFieldID, remove)

            Dim selectedSwapButton As DialogResult = swapActiveProdctionForm.ShowDialog

            If selectedSwapButton = Windows.Forms.DialogResult.OK Then

                MsgBox(swapActiveProdctionForm.Tag.ToString)
                populateProductionListview(lvProduction, 0, True)
            End If
        Else
            If remove Then
                MsgBox("Please select a production to remove")
            Else
                MsgBox("Please select a production to reactivate")
            End If
        End If

        disableProductionChemicalTandLV()
        disableProductionButtons()
    End Sub


    Private Sub populateProductionListview(ByRef lvA As ListView, Optional ByVal plSelectedIndex As Integer = 0, Optional ByVal plForcedAscension As Boolean = False)

        Dim ListOfProductions As List(Of ProductionVB)
        ListOfProductions = _myProductionManager.getProductionList(plSelectedIndex, _showOnlyActiveProductions, plForcedAscension)

        lvA.Items.Clear()

        For i As Integer = 0 To ListOfProductions.Count - 1
            lvA.Items.Add(ListOfProductions(i).ID)
            lvA.Items(i).SubItems.Add(ListOfProductions(i).Year)
            lvA.Items(i).SubItems.Add(ListOfProductions(i).FieldName)
            lvA.Items(i).SubItems.Add(ListOfProductions(i).SeedBrand)
            lvA.Items(i).SubItems.Add(ListOfProductions(i).SeedVariety)
            lvA.Items(i).SubItems.Add(ListOfProductions(i).PlantDate)
            lvA.Items(i).SubItems.Add(ListOfProductions(i).HarvestDate)
            lvA.Items(i).SubItems.Add(ListOfProductions(i).Yield)
            If _owner Then
                lvA.Items(i).SubItems.Add(ListOfProductions(i).Active)
            End If
        Next

        disableProductionButtons()
        disableProductionChemButtons()
        disableProductionChemicalTandLV()
    End Sub


    'PRODUCTION MANAGER - CLICK ON A PRODUCTION ROW - SHOW MODIFICATION BUTTONS AND SHOW LINKED CHEMICALS
    Private Sub lvProduction_Click(sender As Object, e As System.EventArgs) Handles lvProduction.Click

        Dim selectedProduction = Me.lvProduction.SelectedItems
        If selectedProduction.Count Then
            Dim productionID As Integer = CInt(selectedProduction(0).SubItems(0).Text)
            populateProductionChemListView(productionID)
            Me.grpChemProduction.Text = " Chemicals used in Production" & productionID
        End If

        disableProductionChemButtons()
        btnEditProduction.Enabled = True
        btnRemoveProduction.Enabled = True
        btnReactivateProduction.Enabled = True
        btnAddChemToProduction.Enabled = True

        '    chbxShowOnlyActiveChemProduciton.Visible = True

    End Sub

    'PRODUCTION MANAGER - ARROW UP OR DOWN PRODUCTION ROWS - CHANGE TO CORRESPONDING CHEMICALS
    Private Sub lvProduction_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lvProduction.SelectedIndexChanged

        Dim selectedProduction = Me.lvProduction.SelectedItems
        If selectedProduction.Count Then
            Dim productionID As Integer = CInt(selectedProduction(0).SubItems(0).Text)
            populateProductionChemListView(productionID)
            Me.grpChemProduction.Text = " Chemicals used in Production" & productionID
        End If

    End Sub





    'PRODUCTION MANAGER - CHECKBOX CLICK - SHOW ALL OR ONLY ACTIVE PRODUCTIONS
    Private Sub chbxShowOnlyActiveProductions_Click(sender As Object, e As System.EventArgs) Handles chbxShowOnlyActiveProductions.Click

        If chbxShowOnlyActiveProductions.Checked = True Then
            _showOnlyActiveProductions = True
            populateProductionListview(lvProduction, 0, True)
        Else
            _showOnlyActiveProductions = False
            populateProductionListview(lvProduction, 0, True)
        End If

    End Sub




    '///////////END OF PRODUCTION SECTION//////////////
    '///////////END OF PRODUCTION SECTION//////////////





    '///////////BEGIN OF PRODUCTION/CHEMICAL SECTION//////////////
    '///////////BEGIN OF PRODUCTION/CHEMICAL SECTION//////////////


    'PRODUCTION/CHEMICAL - SELECT A PRODUCTION/CHEMICAL ON THE LIST VIEW - ENABLE MODIFER BUTTONS
    Private Sub lvProductionChem_Click(sender As Object, e As System.EventArgs) Handles lvProductionChem.Click
        btnEditChemInProduction.Enabled = True
        btnRemoveChemFromProduction.Enabled = True
        btnReactivateChemFromProduction.Enabled = True

        disableProductionButtons()
    End Sub

    Private Sub btnAddChemToProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnAddChemToProduction.Click
        addChemToProduction()
    End Sub

    Private Sub btnRemoveChemFromProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveChemFromProduction.Click
        swapActiveProdChem(True)
    End Sub

    Private Sub btnReactivateChemFromProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnReactivateChemFromProduction.Click
        swapActiveProdChem(False)
    End Sub

    Private Sub btnEditChemInProduction_Click(sender As System.Object, e As System.EventArgs) Handles btnEditChemInProduction.Click
        editProdChem()
    End Sub

    Private Sub chbxShowOnlyActiveChemProduciton_Click(sender As Object, e As System.EventArgs) Handles chbxShowOnlyActiveChemProduciton.Click

        If chbxShowOnlyActiveChemProduciton.Checked = True Then

            _showOnlyActiveProductionChemicals = True
            If Me.lvProduction.SelectedItems.Count Then
                populateProductionChemListView(CInt(Me.lvProduction.SelectedItems(0).SubItems(0).Text))
            End If

        Else

            _showOnlyActiveProductionChemicals = False
            If Me.lvProduction.SelectedItems.Count Then
                populateProductionChemListView(CInt(Me.lvProduction.SelectedItems(0).SubItems(0).Text))
            End If
        End If


    End Sub

    Private Sub populateProductionChemListView(ByVal productionID As Integer)

        Dim listOfChemicalsForProduction As List(Of ProdChemVB)

        listOfChemicalsForProduction = _myProdChemManager.getProdChemList(productionID, _showOnlyActiveProductionChemicals)

        lvProductionChem.Items.Clear()
        For i As Integer = 0 To listOfChemicalsForProduction.Count - 1

            lvProductionChem.Items.Add(listOfChemicalsForProduction(i).ChemicalType)
            lvProductionChem.Items(i).SubItems.Add(listOfChemicalsForProduction(i).ChemicalBrand)
            lvProductionChem.Items(i).SubItems.Add(listOfChemicalsForProduction(i).ChemicalName)
            lvProductionChem.Items(i).SubItems.Add(listOfChemicalsForProduction(i).ChemicalID)
            lvProductionChem.Items(i).SubItems.Add(listOfChemicalsForProduction(i).ApplicationDate)
            If _owner Then
                lvProductionChem.Items(i).SubItems.Add(listOfChemicalsForProduction(i).Active)
            End If
        Next

    End Sub


    Private Sub addChemToProduction()
        If Me.lvProduction.SelectedItems.Count Then
            Dim ProductionID As Integer = CInt(Me.lvProduction.SelectedItems(0).SubItems(0).Text)
            Dim addProdChemForm As New frmProdChemAdd
            addProdChemForm.txtProdChemAddID.Text = ProductionID

            Dim selectedAddFormButton As DialogResult = addProdChemForm.ShowDialog

            If selectedAddFormButton = DialogResult.OK Then
                MsgBox(addProdChemForm.Tag.ToString)

                populateProductionChemListView(ProductionID)
            Else

            End If
        Else
            MsgBox("You must select a Production from the list before adding a chemical to it")
        End If
    End Sub

    Private Sub swapActiveProdChem(ByVal remove As Boolean)

        Dim selectedProdChem = Me.lvProductionChem.SelectedItems
        Dim myProdChem As ProdChemVB

        If selectedProdChem.Count Then
            myProdChem = New ProdChemVB

            myProdChem.ProductionID = CInt(Me.lvProduction.SelectedItems(0).SubItems(0).Text)
            myProdChem.ChemicalName = selectedProdChem(0).SubItems(2).Text
            myProdChem.ChemicalID = CInt(selectedProdChem(0).SubItems(3).Text)
            myProdChem.ApplicationDate = CDate(selectedProdChem(0).SubItems(4).Text)
            myProdChem.Active = CBool(selectedProdChem(0).SubItems(5).Text)

            If myProdChem.Active = False And remove = True Then
                MsgBox("This Chemical is already inactive in this production!")
            ElseIf myProdChem.Active = True And remove = False Then

                MsgBox("This Chemical is already active in this production!")
            Else
                Dim swapProdChemForm As New frmProdChemSwapActive(myProdChem)

                Dim selectedActiveSwapButton As DialogResult = swapProdChemForm.ShowDialog


                If selectedActiveSwapButton = Windows.Forms.DialogResult.OK Then
                    MsgBox(swapProdChemForm.Tag.ToString)

                End If

                populateProductionChemListView(myProdChem.ProductionID)

            End If 'end of redunancy check

            myProdChem = Nothing
        Else
            MsgBox("A Chemical must be selected. ")
        End If

    End Sub


    Private Sub editProdChem()
        Dim selectedProdChem = Me.lvProductionChem.SelectedItems
        Dim myProdChem As ProdChemVB

        If selectedProdChem.Count Then
            myProdChem = New ProdChemVB

            myProdChem.ProductionID = CInt(Me.lvProduction.SelectedItems(0).SubItems(0).Text)
            myProdChem.ChemicalName = selectedProdChem(0).SubItems(2).Text
            myProdChem.ChemicalID = CInt(selectedProdChem(0).SubItems(3).Text)
            myProdChem.ApplicationDate = CDate(selectedProdChem(0).SubItems(4).Text)
            ' myProdChem.Active = CBool(selectedProdChem(0).SubItems(5).Text)

            Dim editProdChemForm As New frmProdChemEdit(myProdChem)

            Dim selectedEditButton As DialogResult = editProdChemForm.ShowDialog

            If selectedEditButton = Windows.Forms.DialogResult.OK Then
                MsgBox(editProdChemForm.Tag.ToString)

                populateProductionChemListView(myProdChem.ProductionID)
            End If

            myProdChem = Nothing
        Else
            MsgBox("A Chemical must be selected to edit. ")
        End If

    End Sub
    '///////////END OF PRODUCTION/CHEMICAL SECTION//////////////
    '///////////END OF PRODUCTION/CHEMICAL SECTION//////////////


    '///////////BEGIN OF CHEMICAL SECTION//////////////
    '///////////BEGIN OF CHEMICAL SECTION//////////////


    Private Sub tpChemical_Enter(sender As Object, e As System.EventArgs) Handles tpChemical.Enter
        populateChemListview(lvChem, 0, True)
    End Sub

    Private Sub lvChem_Click(sender As Object, e As System.EventArgs) Handles lvChem.Click
        btnEditChem.Enabled = True
        btnRemoveChem.Enabled = True
        btnReactivateChem.Enabled = True
    End Sub

    Private Sub btnAddChem_Click(sender As System.Object, e As System.EventArgs) Handles btnAddChem.Click
        addChem()
    End Sub

    Private Sub btnSearchChem_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchChem.Click
        searchChem()
    End Sub

    Private Sub btnEditChem_Click(sender As System.Object, e As System.EventArgs) Handles btnEditChem.Click
        editChem()
    End Sub

    Private Sub btnRemoveChem_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveChem.Click
        swapActiveChem(True)
    End Sub

    Private Sub btnReactivateChem_Click(sender As System.Object, e As System.EventArgs) Handles btnReactivateChem.Click
        swapActiveChem(False)
    End Sub


    Private Sub populateChemListview(ByRef lvA As ListView, Optional ByVal selectedIndex As Integer = 0, Optional ByVal forcedAscension As Boolean = False)
        Dim listOfChem As New List(Of Chemical)
        listOfChem = _myChemManager.getChemList(selectedIndex, False, forcedAscension)

        lvA.Items.Clear()

        'Dim fld As Field
        For i As Integer = 0 To listOfChem.Count - 1

            lvA.Items.Add(listOfChem(i).ChemicalID)
            lvA.Items(i).SubItems.Add(listOfChem(i).ChemicalBrand)
            lvA.Items(i).SubItems.Add(listOfChem(i).ChemicalName)
            lvA.Items(i).SubItems.Add(listOfChem(i).ChemicalType)
            If _owner Then
                lvA.Items(i).SubItems.Add(listOfChem(i).Active)
            End If

        Next
        disableChemButtons()
    End Sub


    Public Sub addChem()
        Dim chemAddForm As New frmChemAdd
        Dim selectedButton As DialogResult = chemAddForm.ShowDialog

        If selectedButton = Windows.Forms.DialogResult.OK Then
            MsgBox(chemAddForm.Tag.ToString)
            populateChemListview(lvChem, 0, True)
        End If
        disableChemButtons()
    End Sub

    Private Sub searchChem()
        If chemSearchIsValid() Then
            Dim chemID As Integer = CInt(txtSearchChemical.Text)
            Dim searchChemForm As New frmChemEditSearch(chemID, True)
            Dim selectedButton As DialogResult = searchChemForm.ShowDialog

            If selectedButton = DialogResult.OK Then
                MsgBox(searchChemForm.Tag.ToString)
                populateChemListview(lvChem, 0, True)
            End If
            If selectedButton = DialogResult.Abort Then
                MsgBox(searchChemForm.Tag.ToString)
            End If
        End If
        disableChemButtons()
    End Sub

    Private Function chemSearchIsValid() As Boolean
        If valid.IsPresent(txtSearchChemical) AndAlso
            valid.IsInt(txtSearchChemical) AndAlso
            valid.isGreaterThan(0, txtSearchChemical) AndAlso
            valid.isLessThan(_myChemManager.maxID, txtSearchChemical) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub editChem()
        Dim selectedChem = Me.lvChem.SelectedItems

        If selectedChem.Count Then
            Dim selectedChemID As Integer
            selectedChemID = CInt(selectedChem(0).SubItems(0).Text)

            Try
                Dim editChemForm As New frmChemEditSearch(selectedChemID, False)
                Dim selectedButton As DialogResult = editChemForm.ShowDialog

                If selectedButton = DialogResult.OK Then
                    MsgBox(editChemForm.Tag.ToString)
                    populateChemListview(lvChem, 0, True)
                End If

            Catch ex As ApplicationException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please choose a Chemical to edit")
        End If
        disableChemButtons()
    End Sub


    Private Sub swapActiveChem(ByVal remove As Boolean)
        Dim selectedChem = Me.lvChem.SelectedItems

        If selectedChem.Count Then
            Dim selectedChemID As Integer
            selectedChemID = CInt(selectedChem(0).SubItems(0).Text)

            If _myChemManager.isActive(selectedChemID) And remove = False Then
                MsgBox("This Chemical is already active")
                Exit Sub
            End If
            If _myChemManager.isActive(selectedChemID) = False And remove = True Then
                MsgBox("This Chemical has already been removed")
                Exit Sub
            End If

            Dim swapActiveChemForm As New frmChemSwapActive(selectedChemID, remove)

            Dim selectedButton As DialogResult = swapActiveChemForm.ShowDialog

            If selectedButton = Windows.Forms.DialogResult.OK Then

                MsgBox(swapActiveChemForm.Tag.ToString)
                populateChemListview(lvChem, 0, True)
            End If
        Else
            If remove Then
                MsgBox("Please choose a Chemical to Delete")
            Else
                MsgBox("Please choose a Chemical to Reactivate")
            End If
        End If
        disableChemButtons()
    End Sub



    '///////////END OF CHEMICAL SECTION//////////////
    '///////////END OF CHEMICAL SECTION//////////////




    '///////////BEGIN OF SEED SECTION//////////////
    '///////////BEGIN OF SEED SECTION//////////////

    Private Sub tpSeed_Enter(sender As Object, e As System.EventArgs) Handles tpSeed.Enter
        populateSeedListview(lvSeed, 0, True)
        populateBrandListview(lvBrand, 0, True)
    End Sub

    Private Sub btnAddSeed_Click(sender As System.Object, e As System.EventArgs) Handles btnAddSeed.Click
        addSeed()
    End Sub

    Private Sub btnSearchSeed_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchSeed.Click
        searchSeed()
    End Sub

    Private Sub btnEditSeed_Click(sender As System.Object, e As System.EventArgs) Handles btnEditSeed.Click
        editSeed()
    End Sub

    Private Sub btnRemoveSeed_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveSeed.Click
        swapActiveSeed(True)
    End Sub

    Private Sub btnReactivateSeed_Click(sender As System.Object, e As System.EventArgs) Handles btnReactivateSeed.Click
        swapActiveSeed(False)
    End Sub

    Private Sub lvSeed_Click(sender As Object, e As System.EventArgs) Handles lvSeed.Click

        btnEditSeed.Enabled = True
        btnRemoveSeed.Enabled = True
        btnReactivateSeed.Enabled = True
        disableBrandButtons()

        For Each item As ListViewItem In lvBrand.Items
            item.BackColor = Color.Transparent
        Next

        Dim brand As String = Me.lvSeed.SelectedItems(0).SubItems(1).Text
        For Each item As ListViewItem In lvBrand.Items
            If item.SubItems(1).Text.Contains(brand) Then
                item.BackColor = Color.LightSteelBlue
            End If
        Next
    End Sub



    Private Sub populateSeedListview(ByRef lvA As ListView, Optional ByVal selectedIndex As Integer = 0, Optional ByVal forcedAscension As Boolean = False)
        Dim listOfSeed As New List(Of Seed)
        listOfSeed = _mySeedManager.getSeedList(selectedIndex, False, forcedAscension)

        lvA.Items.Clear()

        'Dim fld As Field
        For i As Integer = 0 To listOfSeed.Count - 1

            lvA.Items.Add(listOfSeed(i).SeedID)
            lvA.Items(i).SubItems.Add(listOfSeed(i).BrandName)
            lvA.Items(i).SubItems.Add(listOfSeed(i).SeedName)
            lvA.Items(i).SubItems.Add(listOfSeed(i).Variety)
            lvA.Items(i).SubItems.Add(listOfSeed(i).Crop)
            lvA.Items(i).SubItems.Add(listOfSeed(i).Active)

        Next
        disableSeedButtons()
    End Sub

    Public Sub addSeed()
        Dim seedAddForm As New frmSeedAdd
        Dim selectedButton As DialogResult = seedAddForm.ShowDialog

        If selectedButton = Windows.Forms.DialogResult.OK Then
            MsgBox(seedAddForm.Tag.ToString)
            populateSeedListview(lvSeed, 0, True)
        End If
        disableSeedButtons()
    End Sub

    Private Sub searchSeed()
        If seedSearchIsValid() Then
            Dim seedID As Integer = CInt(txtSearchSeed.Text)
            Dim searchSeedForm As New frmSeedEditSearch(seedID, True)
            Dim selectedButton As DialogResult = searchSeedForm.ShowDialog

            If selectedButton = DialogResult.OK Then
                MsgBox(searchSeedForm.Tag.ToString)
                populateSeedListview(lvSeed, 0, True)
            End If
            If selectedButton = DialogResult.Abort Then
                MsgBox(searchSeedForm.Tag.ToString)
            End If
        End If
        disableSeedButtons()
    End Sub

    Private Function seedSearchIsValid() As Boolean
        If valid.IsPresent(txtSearchSeed) AndAlso
            valid.IsInt(txtSearchSeed) AndAlso
            valid.isGreaterThan(0, txtSearchSeed) AndAlso
            valid.isLessThan(_mySeedManager.maxID, txtSearchSeed) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub editSeed()
        Dim selectedSeed = Me.lvSeed.SelectedItems

        If selectedSeed.Count Then
            Dim selectedSeedID As Integer

            selectedSeedID = CInt(selectedSeed(0).SubItems(0).Text)

            Try
                Dim editSeedForm As New frmSeedEditSearch(selectedSeedID, False)

                Dim selectedButton As DialogResult = editSeedForm.ShowDialog


                If selectedButton = DialogResult.OK Then
                    MsgBox(editSeedForm.Tag.ToString)

                    populateSeedListview(lvSeed, 0, True)

                End If

            Catch ex As ApplicationException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please choose a Seed to edit")
        End If
        disableSeedButtons()
    End Sub

    Private Sub swapActiveSeed(ByVal remove As Boolean)
        Dim selectedSeed = Me.lvSeed.SelectedItems

        If selectedSeed.Count Then
            Dim selectedSeedID As Integer
            selectedSeedID = CInt(selectedSeed(0).SubItems(0).Text)

            If _mySeedManager.isActive(selectedSeedID) And remove = False Then
                MsgBox("This Seed is already active")
                Exit Sub
            End If
            If _mySeedManager.isActive(selectedSeedID) = False And remove = True Then
                MsgBox("This Seed has already been removed")
                Exit Sub
            End If

            Dim swapActiveSeedForm As New frmSeedSwapActive(selectedSeedID, remove)

            Dim selectedButton As DialogResult = swapActiveSeedForm.ShowDialog

            If selectedButton = Windows.Forms.DialogResult.OK Then

                MsgBox(swapActiveSeedForm.Tag.ToString)
                populateSeedListview(lvSeed, 0, True)
            End If
        Else
            If remove Then
                MsgBox("Please choose a Seed to Delete")
            Else
                MsgBox("Please choose a Seed to Reactivate")
            End If
        End If
        disableSeedButtons()
    End Sub
    '///////////END OF SEED SECTION//////////////
    '///////////END OF SEED SECTION//////////////




    '///////////BEGIN OF BRAND SECTION//////////////
    '///////////BEGIN OF BRAND SECTION//////////////

    Private Sub tpBrand_Enter(sender As Object, e As System.EventArgs)
        populateBrandListview(lvBrand, 0, True)
    End Sub

    Private Sub lvBrand_Click(sender As Object, e As System.EventArgs) Handles lvBrand.Click
        For Each item As ListViewItem In lvBrand.Items
            item.BackColor = Color.Transparent
        Next
        disableSeedButtons()
        btnEditBrand.Enabled = True
        btnRemoveBrand.Enabled = True
        btnReactivateBrand.Enabled = True
    End Sub

    Private Sub btnAddBrand_Click(sender As System.Object, e As System.EventArgs) Handles btnAddBrand.Click
        addBrand()
    End Sub

    Private Sub btnSearchBrand_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchBrand.Click
        SearchBrand()
    End Sub

    Private Sub btnEditBrand_Click(sender As System.Object, e As System.EventArgs) Handles btnEditBrand.Click
        editBrand()
    End Sub

    Private Sub btnRemoveBrand_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveBrand.Click
        swapActiveBrand(True)
    End Sub

    Private Sub btnReactivateBrand_Click(sender As System.Object, e As System.EventArgs) Handles btnReactivateBrand.Click
        swapActiveBrand(False)
    End Sub


    Private Sub populateBrandListview(ByRef lvA As ListView, Optional ByVal selectedIndex As Integer = 0, Optional ByVal forcedAscension As Boolean = False)
        Dim listOfBrand As New List(Of Brand)
        listOfBrand = _myBrandManager.getBrands(selectedIndex)

        lvA.Items.Clear()

        'Dim fld As Field
        For i As Integer = 0 To listOfBrand.Count - 1

            lvA.Items.Add(listOfBrand(i).BrandID)
            lvA.Items(i).SubItems.Add(listOfBrand(i).BrandName)
            lvA.Items(i).SubItems.Add(listOfBrand(i).BrandDealerName)
            lvA.Items(i).SubItems.Add(listOfBrand(i).Active)


        Next
        disableBrandButtons()
    End Sub

    Public Sub addBrand()
        Dim brandAddForm As New frmBrandAdd
        Dim selectedButton As DialogResult = brandAddForm.ShowDialog

        If selectedButton = Windows.Forms.DialogResult.OK Then
            MsgBox(brandAddForm.Tag.ToString)
            populateBrandListview(lvBrand, 0, True)
        End If
        disableBrandButtons()
    End Sub

    Private Sub searchBrand()
        If brandSearchIsValid() Then
            Dim brandID As Integer = CInt(txtSearchBrand.Text)
            Dim searchBrandForm As New frmBrandEditSearch(brandID, True)
            Dim selectedButton As DialogResult = searchBrandForm.ShowDialog

            If selectedButton = DialogResult.OK Then
                MsgBox(searchBrandForm.Tag.ToString)
                populateBrandListview(lvBrand, 0, True)
                populateSeedListview(lvSeed, 0, True)
            End If
            If selectedButton = DialogResult.Abort Then
                MsgBox(searchBrandForm.Tag.ToString)
            End If
        End If
        disableBrandButtons()
    End Sub

    Private Function brandSearchIsValid() As Boolean
        If valid.IsPresent(txtSearchBrand) AndAlso
            valid.IsInt(txtSearchBrand) AndAlso
            valid.isGreaterThan(0, txtSearchBrand) AndAlso
            valid.isLessThan(_myBrandManager.maxID, txtSearchBrand) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub editBrand()
        Dim selectedBrand = Me.lvBrand.SelectedItems

        If selectedBrand.Count Then
            Dim selectedBrandID As Integer

            selectedBrandID = CInt(selectedBrand(0).SubItems(0).Text)

            Try
                Dim editBrandForm As New frmBrandEditSearch(selectedBrandID, False)
                Dim selectedButton As DialogResult = editBrandForm.ShowDialog

                If selectedButton = DialogResult.OK Then
                    MsgBox(editBrandForm.Tag.ToString)

                    populateBrandListview(lvBrand, 0, True)
                    populateSeedListview(lvSeed, 0, True)
                End If

            Catch ex As ApplicationException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please choose a Brand to edit")
        End If
        disableBrandButtons()
    End Sub


    Private Sub swapActiveBrand(ByVal remove As Boolean)
        Dim selectedBrand = Me.lvBrand.SelectedItems

        If selectedBrand.Count Then
            Dim selectedBrandID As Integer
            selectedBrandID = CInt(selectedBrand(0).SubItems(0).Text)

            If _myBrandManager.isActive(selectedBrandID) And remove = False Then
                MsgBox("This Brand is already active")
                Exit Sub
            End If
            If _myBrandManager.isActive(selectedBrandID) = False And remove = True Then
                MsgBox("This Brand has already been removed")
                Exit Sub
            End If

            Dim swapActiveBrandForm As New frmBrandSwapActive(selectedBrandID, remove)

            Dim selectedButton As DialogResult = swapActiveBrandForm.ShowDialog

            If selectedButton = Windows.Forms.DialogResult.OK Then

                MsgBox(swapActiveBrandForm.Tag.ToString)
                populateBrandListview(lvBrand, 0, True)
            End If
        Else
            If remove Then
                MsgBox("Please choose a Brand to Delete")
            Else
                MsgBox("Please choose a Brand to Reactivate")
            End If

        End If
        disableBrandButtons()
    End Sub

    '///////////END OF BRAND SECTION//////////////
    '///////////END OF BRAND SECTION//////////////



    'ABANDONED GHOST TOWN AHEAD... (RAN OUT OF TIME)

    '///////////BEGIN OF EMPLOYEE SECTION//////////////
    '///////////BEGIN OF EMPLOYEE SECTION//////////////

    'Private Sub tpEmployee_Enter(sender As Object, e As System.EventArgs) Handles tpEmployee.Enter

    'End Sub

    'Private Sub lvEmployee_Click(sender As Object, e As System.EventArgs) Handles lvEmployee.Click

    'End Sub

    'Private Sub populateEmployeeListview(ByRef lvA As ListView, Optional ByVal selectedIndex As Integer = 0, Optional ByVal forcedAscension As Boolean = False)
    '    Dim listOfEmp As New List(Of Chemical)
    '    listOfEmp = _myEmpManager.getEmpList(selectedIndex, False, forcedAscension)

    '    lvA.Items.Clear()

    '    'Dim fld As Field
    '    For i As Integer = 0 To listOfEmp.Count - 1

    '        lvA.Items.Add(listOfEmp(i).ChemicalID)
    '        lvA.Items(i).SubItems.Add(listOfEmp(i).ChemicalBrand)
    '        lvA.Items(i).SubItems.Add(listOfEmp(i).ChemicalName)
    '        lvA.Items(i).SubItems.Add(listOfEmp(i).ChemicalType)
    '        lvA.Items(i).SubItems.Add(listOfEmp(i).Active)


    '    Next

    'End Sub


    '///////////END OF EMPLOYEE SECTION//////////////
    '///////////END OF EMPLOYEE SECTION//////////////



End Class  '////////////END OF frmFarm//////////////
