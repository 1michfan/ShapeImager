<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShapeListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Radius1Label As System.Windows.Forms.Label
        Dim Radius2Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gvShape = New System.Windows.Forms.DataGridView()
        Me.ShapeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrientation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDegrees = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerimeterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsShape = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnImportCsv = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ucShapePainter = New ShapeImager.UI.ShapePainter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flpShapeProps = New System.Windows.Forms.FlowLayoutPanel()
        Me.tlpCenter = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCenterX = New System.Windows.Forms.Label()
        Me.tbX = New System.Windows.Forms.NumericUpDown()
        Me.BsCenter = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbY = New System.Windows.Forms.NumericUpDown()
        Me.tlpRadius1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbRadius1 = New System.Windows.Forms.NumericUpDown()
        Me.BsEllipse = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlpRadius2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbRadius2 = New System.Windows.Forms.NumericUpDown()
        Me.tlpEquil = New System.Windows.Forms.TableLayoutPanel()
        Me.tbSideLength = New System.Windows.Forms.NumericUpDown()
        Me.BsEquilateral = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvVertice = New System.Windows.Forms.DataGridView()
        Me.BsVertice = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalArea = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPerimeter = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAvgArea = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAvgPerim = New System.Windows.Forms.Label()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolygonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Radius1Label = New System.Windows.Forms.Label()
        Radius2Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout()
        CType(Me.gvShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsShape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.flpShapeProps.SuspendLayout()
        Me.tlpCenter.SuspendLayout()
        CType(Me.tbX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRadius1.SuspendLayout()
        CType(Me.tbRadius1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsEllipse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRadius2.SuspendLayout()
        CType(Me.tbRadius2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEquil.SuspendLayout()
        CType(Me.tbSideLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsEquilateral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVertice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsVertice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Radius1Label
        '
        Radius1Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Radius1Label.Location = New System.Drawing.Point(3, 0)
        Radius1Label.Name = "Radius1Label"
        Radius1Label.Size = New System.Drawing.Size(49, 27)
        Radius1Label.TabIndex = 6
        Radius1Label.Text = "Radius1:"
        Radius1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Radius2Label
        '
        Radius2Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Radius2Label.AutoSize = True
        Radius2Label.Location = New System.Drawing.Point(3, 0)
        Radius2Label.Name = "Radius2Label"
        Radius2Label.Size = New System.Drawing.Size(49, 27)
        Radius2Label.TabIndex = 7
        Radius2Label.Text = "Radius2:"
        Radius2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label1.Location = New System.Drawing.Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 27)
        Label1.TabIndex = 9
        Label1.Text = "Side Length:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.gvShape, 0, 1)
        Me.tlpMain.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.tlpMain.Controls.Add(Me.ucShapePainter, 1, 1)
        Me.tlpMain.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.tlpMain.Controls.Add(Me.FlowLayoutPanel2, 1, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1018, 559)
        Me.tlpMain.TabIndex = 0
        '
        'gvShape
        '
        Me.gvShape.AllowUserToAddRows = False
        Me.gvShape.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvShape.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gvShape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvShape.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShapeType, Me.IdDataGridViewTextBoxColumn, Me.colColor, Me.colOrientation, Me.colDegrees, Me.AreaDataGridViewTextBoxColumn, Me.PerimeterDataGridViewTextBoxColumn})
        Me.gvShape.DataSource = Me.BsShape
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvShape.DefaultCellStyle = DataGridViewCellStyle5
        Me.gvShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvShape.Location = New System.Drawing.Point(3, 51)
        Me.gvShape.Name = "gvShape"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvShape.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gvShape.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvShape.Size = New System.Drawing.Size(503, 249)
        Me.gvShape.TabIndex = 0
        '
        'ShapeType
        '
        Me.ShapeType.DataPropertyName = "ShapeTypeName"
        Me.ShapeType.Frozen = True
        Me.ShapeType.HeaderText = "ShapeType"
        Me.ShapeType.Name = "ShapeType"
        Me.ShapeType.ReadOnly = True
        Me.ShapeType.Width = 75
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.Frozen = True
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'colColor
        '
        Me.colColor.DataPropertyName = "Color"
        Me.colColor.HeaderText = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Width = 50
        '
        'colOrientation
        '
        Me.colOrientation.DataPropertyName = "Orientation"
        Me.colOrientation.HeaderText = "Orientation"
        Me.colOrientation.Name = "colOrientation"
        Me.colOrientation.Width = 75
        '
        'colDegrees
        '
        Me.colDegrees.DataPropertyName = "Degrees"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDegrees.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDegrees.HeaderText = "Degrees"
        Me.colDegrees.Name = "colDegrees"
        Me.colDegrees.Width = 75
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "Area"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.AreaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "Area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        Me.AreaDataGridViewTextBoxColumn.ReadOnly = True
        Me.AreaDataGridViewTextBoxColumn.Width = 75
        '
        'PerimeterDataGridViewTextBoxColumn
        '
        Me.PerimeterDataGridViewTextBoxColumn.DataPropertyName = "Perimeter"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PerimeterDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PerimeterDataGridViewTextBoxColumn.HeaderText = "Perimeter"
        Me.PerimeterDataGridViewTextBoxColumn.Name = "PerimeterDataGridViewTextBoxColumn"
        Me.PerimeterDataGridViewTextBoxColumn.ReadOnly = True
        Me.PerimeterDataGridViewTextBoxColumn.Width = 75
        '
        'BsShape
        '
        Me.BsShape.DataSource = GetType(ShapeImager.Data.Shape)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnImportCsv)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSaveChanges)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(503, 42)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnImportCsv
        '
        Me.btnImportCsv.Location = New System.Drawing.Point(3, 3)
        Me.btnImportCsv.Name = "btnImportCsv"
        Me.btnImportCsv.Size = New System.Drawing.Size(88, 23)
        Me.btnImportCsv.TabIndex = 0
        Me.btnImportCsv.Text = "Import CSV"
        Me.btnImportCsv.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.AutoSize = True
        Me.btnSaveChanges.Location = New System.Drawing.Point(97, 3)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveChanges.TabIndex = 1
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(191, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(290, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ucShapePainter
        '
        Me.ucShapePainter.Location = New System.Drawing.Point(512, 51)
        Me.ucShapePainter.Name = "ucShapePainter"
        Me.tlpMain.SetRowSpan(Me.ucShapePainter, 2)
        Me.ucShapePainter.Size = New System.Drawing.Size(501, 501)
        Me.ucShapePainter.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.flpShapeProps, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gvVertice, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 306)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 250)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'flpShapeProps
        '
        Me.flpShapeProps.Controls.Add(Me.tlpCenter)
        Me.flpShapeProps.Controls.Add(Me.tlpRadius1)
        Me.flpShapeProps.Controls.Add(Me.tlpRadius2)
        Me.flpShapeProps.Controls.Add(Me.tlpEquil)
        Me.flpShapeProps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpShapeProps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpShapeProps.Location = New System.Drawing.Point(3, 3)
        Me.flpShapeProps.Name = "flpShapeProps"
        Me.flpShapeProps.Size = New System.Drawing.Size(245, 244)
        Me.flpShapeProps.TabIndex = 1
        '
        'tlpCenter
        '
        Me.tlpCenter.ColumnCount = 2
        Me.tlpCenter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCenter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCenter.Controls.Add(Me.lblCenterX, 0, 0)
        Me.tlpCenter.Controls.Add(Me.tbX, 1, 0)
        Me.tlpCenter.Controls.Add(Me.Label2, 0, 1)
        Me.tlpCenter.Controls.Add(Me.tbY, 1, 1)
        Me.tlpCenter.Location = New System.Drawing.Point(0, 0)
        Me.tlpCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCenter.Name = "tlpCenter"
        Me.tlpCenter.RowCount = 2
        Me.tlpCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpCenter.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpCenter.Size = New System.Drawing.Size(245, 53)
        Me.tlpCenter.TabIndex = 0
        '
        'lblCenterX
        '
        Me.lblCenterX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCenterX.Location = New System.Drawing.Point(3, 0)
        Me.lblCenterX.Name = "lblCenterX"
        Me.lblCenterX.Size = New System.Drawing.Size(51, 26)
        Me.lblCenterX.TabIndex = 0
        Me.lblCenterX.Text = "Center X:"
        Me.lblCenterX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbX
        '
        Me.tbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbX.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsCenter, "X", True))
        Me.tbX.DecimalPlaces = 4
        Me.tbX.Location = New System.Drawing.Point(125, 3)
        Me.tbX.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(117, 20)
        Me.tbX.TabIndex = 0
        '
        'BsCenter
        '
        Me.BsCenter.DataSource = GetType(ShapeImager.Data.Vertex)
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Center Y:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbY
        '
        Me.tbY.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbY.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsCenter, "Y", True))
        Me.tbY.DecimalPlaces = 4
        Me.tbY.Location = New System.Drawing.Point(125, 29)
        Me.tbY.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(117, 20)
        Me.tbY.TabIndex = 1
        '
        'tlpRadius1
        '
        Me.tlpRadius1.ColumnCount = 2
        Me.tlpRadius1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRadius1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRadius1.Controls.Add(Radius1Label, 0, 0)
        Me.tlpRadius1.Controls.Add(Me.tbRadius1, 1, 0)
        Me.tlpRadius1.Location = New System.Drawing.Point(0, 53)
        Me.tlpRadius1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRadius1.Name = "tlpRadius1"
        Me.tlpRadius1.RowCount = 1
        Me.tlpRadius1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRadius1.Size = New System.Drawing.Size(245, 27)
        Me.tlpRadius1.TabIndex = 1
        '
        'tbRadius1
        '
        Me.tbRadius1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRadius1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsEllipse, "Radius1", True))
        Me.tbRadius1.DecimalPlaces = 4
        Me.tbRadius1.Location = New System.Drawing.Point(125, 3)
        Me.tbRadius1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.tbRadius1.Name = "tbRadius1"
        Me.tbRadius1.Size = New System.Drawing.Size(117, 20)
        Me.tbRadius1.TabIndex = 0
        '
        'BsEllipse
        '
        Me.BsEllipse.DataSource = GetType(ShapeImager.Data.Ellipse)
        '
        'tlpRadius2
        '
        Me.tlpRadius2.ColumnCount = 2
        Me.tlpRadius2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRadius2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRadius2.Controls.Add(Radius2Label, 0, 0)
        Me.tlpRadius2.Controls.Add(Me.tbRadius2, 1, 0)
        Me.tlpRadius2.Location = New System.Drawing.Point(0, 80)
        Me.tlpRadius2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRadius2.Name = "tlpRadius2"
        Me.tlpRadius2.RowCount = 1
        Me.tlpRadius2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRadius2.Size = New System.Drawing.Size(245, 27)
        Me.tlpRadius2.TabIndex = 2
        '
        'tbRadius2
        '
        Me.tbRadius2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRadius2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsEllipse, "Radius2", True))
        Me.tbRadius2.DecimalPlaces = 4
        Me.tbRadius2.Location = New System.Drawing.Point(125, 3)
        Me.tbRadius2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.tbRadius2.Name = "tbRadius2"
        Me.tbRadius2.Size = New System.Drawing.Size(117, 20)
        Me.tbRadius2.TabIndex = 0
        '
        'tlpEquil
        '
        Me.tlpEquil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEquil.AutoScroll = True
        Me.tlpEquil.ColumnCount = 2
        Me.tlpEquil.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEquil.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEquil.Controls.Add(Me.tbSideLength, 1, 0)
        Me.tlpEquil.Controls.Add(Label1, 0, 0)
        Me.tlpEquil.Location = New System.Drawing.Point(0, 107)
        Me.tlpEquil.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquil.Name = "tlpEquil"
        Me.tlpEquil.RowCount = 1
        Me.tlpEquil.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEquil.Size = New System.Drawing.Size(245, 27)
        Me.tlpEquil.TabIndex = 0
        '
        'tbSideLength
        '
        Me.tbSideLength.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSideLength.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsEquilateral, "SideLength", True))
        Me.tbSideLength.DecimalPlaces = 4
        Me.tbSideLength.Location = New System.Drawing.Point(125, 3)
        Me.tbSideLength.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.tbSideLength.Name = "tbSideLength"
        Me.tbSideLength.Size = New System.Drawing.Size(117, 20)
        Me.tbSideLength.TabIndex = 0
        '
        'BsEquilateral
        '
        Me.BsEquilateral.DataSource = GetType(ShapeImager.Data.Equilateral)
        '
        'gvVertice
        '
        Me.gvVertice.AutoGenerateColumns = False
        Me.gvVertice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvVertice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.XDataGridViewTextBoxColumn, Me.YDataGridViewTextBoxColumn, Me.PolygonDataGridViewTextBoxColumn})
        Me.gvVertice.DataSource = Me.BsVertice
        Me.gvVertice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvVertice.Location = New System.Drawing.Point(254, 3)
        Me.gvVertice.Name = "gvVertice"
        Me.gvVertice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvVertice.Size = New System.Drawing.Size(246, 244)
        Me.gvVertice.TabIndex = 0
        '
        'BsVertice
        '
        Me.BsVertice.DataSource = GetType(ShapeImager.Data.Vertex)
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblTotalArea)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblTotalPerimeter)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblRowCount)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblAvgArea)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblAvgPerim)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(512, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(503, 42)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Area:"
        '
        'lblTotalArea
        '
        Me.lblTotalArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalArea.AutoSize = True
        Me.lblTotalArea.Location = New System.Drawing.Point(79, 8)
        Me.lblTotalArea.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.lblTotalArea.Name = "lblTotalArea"
        Me.lblTotalArea.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalArea.TabIndex = 3
        Me.lblTotalArea.Text = "0"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(98, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "    Total Perimeter:"
        '
        'lblTotalPerimeter
        '
        Me.lblTotalPerimeter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPerimeter.AutoSize = True
        Me.lblTotalPerimeter.Location = New System.Drawing.Point(217, 8)
        Me.lblTotalPerimeter.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.lblTotalPerimeter.Name = "lblTotalPerimeter"
        Me.lblTotalPerimeter.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalPerimeter.TabIndex = 5
        Me.lblTotalPerimeter.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(236, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "    Shape Count:"
        '
        'lblRowCount
        '
        Me.lblRowCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRowCount.AutoSize = True
        Me.FlowLayoutPanel2.SetFlowBreak(Me.lblRowCount, True)
        Me.lblRowCount.Location = New System.Drawing.Point(342, 8)
        Me.lblRowCount.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(13, 13)
        Me.lblRowCount.TabIndex = 7
        Me.lblRowCount.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Avg. Area:"
        '
        'lblAvgArea
        '
        Me.lblAvgArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAvgArea.AutoSize = True
        Me.lblAvgArea.Location = New System.Drawing.Point(78, 29)
        Me.lblAvgArea.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.lblAvgArea.Name = "lblAvgArea"
        Me.lblAvgArea.Size = New System.Drawing.Size(13, 13)
        Me.lblAvgArea.TabIndex = 9
        Me.lblAvgArea.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 8, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "    Avg. Perimeter:"
        '
        'lblAvgPerim
        '
        Me.lblAvgPerim.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAvgPerim.AutoSize = True
        Me.lblAvgPerim.Location = New System.Drawing.Point(216, 29)
        Me.lblAvgPerim.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.lblAvgPerim.Name = "lblAvgPerim"
        Me.lblAvgPerim.Size = New System.Drawing.Size(13, 13)
        Me.lblAvgPerim.TabIndex = 11
        Me.lblAvgPerim.Text = "0"
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        Me.IdDataGridViewTextBoxColumn1.Width = 50
        '
        'XDataGridViewTextBoxColumn
        '
        Me.XDataGridViewTextBoxColumn.DataPropertyName = "X"
        Me.XDataGridViewTextBoxColumn.HeaderText = "X"
        Me.XDataGridViewTextBoxColumn.Name = "XDataGridViewTextBoxColumn"
        '
        'YDataGridViewTextBoxColumn
        '
        Me.YDataGridViewTextBoxColumn.DataPropertyName = "Y"
        Me.YDataGridViewTextBoxColumn.HeaderText = "Y"
        Me.YDataGridViewTextBoxColumn.Name = "YDataGridViewTextBoxColumn"
        '
        'PolygonDataGridViewTextBoxColumn
        '
        Me.PolygonDataGridViewTextBoxColumn.DataPropertyName = "Polygon"
        Me.PolygonDataGridViewTextBoxColumn.HeaderText = "Polygon"
        Me.PolygonDataGridViewTextBoxColumn.Name = "PolygonDataGridViewTextBoxColumn"
        Me.PolygonDataGridViewTextBoxColumn.Visible = False
        '
        'ShapeListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 559)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "ShapeListForm"
        Me.Text = "Shape List Form"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        CType(Me.gvShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsShape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.flpShapeProps.ResumeLayout(False)
        Me.tlpCenter.ResumeLayout(False)
        CType(Me.tbX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpRadius1.ResumeLayout(False)
        CType(Me.tbRadius1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsEllipse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpRadius2.ResumeLayout(False)
        Me.tlpRadius2.PerformLayout()
        CType(Me.tbRadius2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEquil.ResumeLayout(False)
        CType(Me.tbSideLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsEquilateral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVertice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsVertice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnImportCsv As Button
    Friend WithEvents gvShape As DataGridView
    Friend WithEvents BsShape As BindingSource
    Friend WithEvents ucShapePainter As ShapePainter
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tlpEquil As TableLayoutPanel
    Friend WithEvents lblCenterX As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbX As NumericUpDown
    Friend WithEvents BsCenter As BindingSource
    Friend WithEvents tbY As NumericUpDown
    Friend WithEvents tbRadius2 As NumericUpDown
    Friend WithEvents BsEllipse As BindingSource
    Friend WithEvents tbRadius1 As NumericUpDown
    Friend WithEvents tbSideLength As NumericUpDown
    Friend WithEvents BsEquilateral As BindingSource
    Friend WithEvents flpShapeProps As FlowLayoutPanel
    Friend WithEvents tlpCenter As TableLayoutPanel
    Friend WithEvents tlpRadius1 As TableLayoutPanel
    Friend WithEvents tlpRadius2 As TableLayoutPanel
    Friend WithEvents gvVertice As DataGridView
    Friend WithEvents BsVertice As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalArea As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalPerimeter As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ShapeType As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colColor As DataGridViewTextBoxColumn
    Friend WithEvents colOrientation As DataGridViewTextBoxColumn
    Friend WithEvents colDegrees As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerimeterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRowCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAvgArea As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAvgPerim As Label
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents XDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PolygonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
