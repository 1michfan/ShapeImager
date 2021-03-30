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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.GvShape = New System.Windows.Forms.DataGridView()
        Me.ShapeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrientation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerimeterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDegrees = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsShape = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnImportCsv = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalArea = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPerimeter = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flpShapeProps = New System.Windows.Forms.FlowLayoutPanel()
        Me.tlpCenter = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCenterX = New System.Windows.Forms.Label()
        Me.TbX = New System.Windows.Forms.NumericUpDown()
        Me.BsCenter = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbY = New System.Windows.Forms.NumericUpDown()
        Me.tlpRadius1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TbRadius1 = New System.Windows.Forms.NumericUpDown()
        Me.BsEllipse = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlpRadius2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TbRadius2 = New System.Windows.Forms.NumericUpDown()
        Me.tlpEquil = New System.Windows.Forms.TableLayoutPanel()
        Me.TbSideLength = New System.Windows.Forms.NumericUpDown()
        Me.BsEquilateral = New System.Windows.Forms.BindingSource(Me.components)
        Me.GvVertice = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolygonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BsVertice = New System.Windows.Forms.BindingSource(Me.components)
        Me.ucShapePainter = New ShapeImager.UI.ShapePainter()
        Radius1Label = New System.Windows.Forms.Label()
        Radius2Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout()
        CType(Me.GvShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsShape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.flpShapeProps.SuspendLayout()
        Me.tlpCenter.SuspendLayout()
        CType(Me.TbX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRadius1.SuspendLayout()
        CType(Me.TbRadius1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsEllipse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRadius2.SuspendLayout()
        CType(Me.TbRadius2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEquil.SuspendLayout()
        CType(Me.TbSideLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsEquilateral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvVertice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsVertice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpMain.Controls.Add(Me.GvShape, 0, 1)
        Me.tlpMain.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.tlpMain.Controls.Add(Me.ucShapePainter, 1, 1)
        Me.tlpMain.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 339.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1018, 701)
        Me.tlpMain.TabIndex = 0
        '
        'GvShape
        '
        Me.GvShape.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GvShape.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GvShape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GvShape.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShapeType, Me.IdDataGridViewTextBoxColumn, Me.colColor, Me.colOrientation, Me.AreaDataGridViewTextBoxColumn, Me.PerimeterDataGridViewTextBoxColumn, Me.colDegrees})
        Me.GvShape.DataSource = Me.BsShape
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GvShape.DefaultCellStyle = DataGridViewCellStyle2
        Me.GvShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GvShape.Location = New System.Drawing.Point(3, 38)
        Me.GvShape.Name = "GvShape"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GvShape.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GvShape.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GvShape.Size = New System.Drawing.Size(503, 249)
        Me.GvShape.TabIndex = 1
        '
        'ShapeType
        '
        Me.ShapeType.DataPropertyName = "ShapeTypeName"
        Me.ShapeType.Frozen = True
        Me.ShapeType.HeaderText = "ShapeType"
        Me.ShapeType.Name = "ShapeType"
        Me.ShapeType.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.Frozen = True
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'colColor
        '
        Me.colColor.DataPropertyName = "Color"
        Me.colColor.Frozen = True
        Me.colColor.HeaderText = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Width = 75
        '
        'colOrientation
        '
        Me.colOrientation.DataPropertyName = "Orientation"
        Me.colOrientation.Frozen = True
        Me.colOrientation.HeaderText = "Orientation"
        Me.colOrientation.Name = "colOrientation"
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "Area"
        Me.AreaDataGridViewTextBoxColumn.Frozen = True
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "Area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        Me.AreaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PerimeterDataGridViewTextBoxColumn
        '
        Me.PerimeterDataGridViewTextBoxColumn.DataPropertyName = "Perimeter"
        Me.PerimeterDataGridViewTextBoxColumn.Frozen = True
        Me.PerimeterDataGridViewTextBoxColumn.HeaderText = "Perimeter"
        Me.PerimeterDataGridViewTextBoxColumn.Name = "PerimeterDataGridViewTextBoxColumn"
        Me.PerimeterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colDegrees
        '
        Me.colDegrees.DataPropertyName = "Degrees"
        Me.colDegrees.HeaderText = "Degrees"
        Me.colDegrees.Name = "colDegrees"
        '
        'BsShape
        '
        Me.BsShape.DataSource = GetType(ShapeImager.Data.Shape)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMain.SetColumnSpan(Me.FlowLayoutPanel1, 2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnImportCsv)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSaveChanges)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblTotalArea)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblTotalPerimeter)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1012, 29)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Area: "
        '
        'lblTotalArea
        '
        Me.lblTotalArea.AutoSize = True
        Me.lblTotalArea.Location = New System.Drawing.Point(259, 0)
        Me.lblTotalArea.Name = "lblTotalArea"
        Me.lblTotalArea.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalArea.TabIndex = 3
        Me.lblTotalArea.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(278, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Perimeter:"
        '
        'lblTotalPerimeter
        '
        Me.lblTotalPerimeter.AutoSize = True
        Me.lblTotalPerimeter.Location = New System.Drawing.Point(365, 0)
        Me.lblTotalPerimeter.Name = "lblTotalPerimeter"
        Me.lblTotalPerimeter.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalPerimeter.TabIndex = 5
        Me.lblTotalPerimeter.Text = "0"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(384, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.flpShapeProps, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GvVertice, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 293)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 333.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 333)
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
        Me.flpShapeProps.Size = New System.Drawing.Size(245, 327)
        Me.flpShapeProps.TabIndex = 1
        '
        'tlpCenter
        '
        Me.tlpCenter.ColumnCount = 2
        Me.tlpCenter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCenter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCenter.Controls.Add(Me.lblCenterX, 0, 0)
        Me.tlpCenter.Controls.Add(Me.TbX, 1, 0)
        Me.tlpCenter.Controls.Add(Me.Label2, 0, 1)
        Me.tlpCenter.Controls.Add(Me.TbY, 1, 1)
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
        'TbX
        '
        Me.TbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbX.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsCenter, "X", True))
        Me.TbX.DecimalPlaces = 4
        Me.TbX.Location = New System.Drawing.Point(125, 3)
        Me.TbX.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.TbX.Name = "TbX"
        Me.TbX.Size = New System.Drawing.Size(117, 20)
        Me.TbX.TabIndex = 5
        '
        'BsCenter
        '
        Me.BsCenter.DataSource = GetType(ShapeImager.Data.Vertice)
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
        'TbY
        '
        Me.TbY.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbY.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsCenter, "Y", True))
        Me.TbY.DecimalPlaces = 4
        Me.TbY.Location = New System.Drawing.Point(125, 29)
        Me.TbY.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.TbY.Name = "TbY"
        Me.TbY.Size = New System.Drawing.Size(117, 20)
        Me.TbY.TabIndex = 6
        '
        'tlpRadius1
        '
        Me.tlpRadius1.ColumnCount = 2
        Me.tlpRadius1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRadius1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRadius1.Controls.Add(Radius1Label, 0, 0)
        Me.tlpRadius1.Controls.Add(Me.TbRadius1, 1, 0)
        Me.tlpRadius1.Location = New System.Drawing.Point(0, 53)
        Me.tlpRadius1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRadius1.Name = "tlpRadius1"
        Me.tlpRadius1.RowCount = 1
        Me.tlpRadius1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRadius1.Size = New System.Drawing.Size(245, 27)
        Me.tlpRadius1.TabIndex = 1
        '
        'TbRadius1
        '
        Me.TbRadius1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbRadius1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsEllipse, "Radius1", True))
        Me.TbRadius1.DecimalPlaces = 4
        Me.TbRadius1.Location = New System.Drawing.Point(125, 3)
        Me.TbRadius1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.TbRadius1.Name = "TbRadius1"
        Me.TbRadius1.Size = New System.Drawing.Size(117, 20)
        Me.TbRadius1.TabIndex = 7
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
        Me.tlpRadius2.Controls.Add(Me.TbRadius2, 1, 0)
        Me.tlpRadius2.Location = New System.Drawing.Point(0, 80)
        Me.tlpRadius2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRadius2.Name = "tlpRadius2"
        Me.tlpRadius2.RowCount = 1
        Me.tlpRadius2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRadius2.Size = New System.Drawing.Size(245, 27)
        Me.tlpRadius2.TabIndex = 2
        '
        'TbRadius2
        '
        Me.TbRadius2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbRadius2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsEllipse, "Radius2", True))
        Me.TbRadius2.DecimalPlaces = 4
        Me.TbRadius2.Location = New System.Drawing.Point(125, 3)
        Me.TbRadius2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.TbRadius2.Name = "TbRadius2"
        Me.TbRadius2.Size = New System.Drawing.Size(117, 20)
        Me.TbRadius2.TabIndex = 8
        '
        'tlpEquil
        '
        Me.tlpEquil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpEquil.AutoScroll = True
        Me.tlpEquil.ColumnCount = 2
        Me.tlpEquil.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEquil.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEquil.Controls.Add(Me.TbSideLength, 1, 0)
        Me.tlpEquil.Controls.Add(Label1, 0, 0)
        Me.tlpEquil.Location = New System.Drawing.Point(0, 107)
        Me.tlpEquil.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpEquil.Name = "tlpEquil"
        Me.tlpEquil.RowCount = 1
        Me.tlpEquil.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEquil.Size = New System.Drawing.Size(245, 27)
        Me.tlpEquil.TabIndex = 0
        '
        'TbSideLength
        '
        Me.TbSideLength.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbSideLength.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsEquilateral, "SideLength", True))
        Me.TbSideLength.DecimalPlaces = 4
        Me.TbSideLength.Location = New System.Drawing.Point(125, 3)
        Me.TbSideLength.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.TbSideLength.Name = "TbSideLength"
        Me.TbSideLength.Size = New System.Drawing.Size(117, 20)
        Me.TbSideLength.TabIndex = 10
        '
        'BsEquilateral
        '
        Me.BsEquilateral.DataSource = GetType(ShapeImager.Data.Equilateral)
        '
        'GvVertice
        '
        Me.GvVertice.AutoGenerateColumns = False
        Me.GvVertice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GvVertice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.XDataGridViewTextBoxColumn, Me.YDataGridViewTextBoxColumn, Me.PolygonDataGridViewTextBoxColumn})
        Me.GvVertice.DataSource = Me.BsVertice
        Me.GvVertice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GvVertice.Location = New System.Drawing.Point(254, 3)
        Me.GvVertice.Name = "GvVertice"
        Me.GvVertice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GvVertice.Size = New System.Drawing.Size(246, 327)
        Me.GvVertice.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
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
        '
        'BsVertice
        '
        Me.BsVertice.DataSource = GetType(ShapeImager.Data.Vertice)
        '
        'ucShapePainter
        '
        Me.ucShapePainter.Location = New System.Drawing.Point(512, 38)
        Me.ucShapePainter.Name = "ucShapePainter"
        Me.tlpMain.SetRowSpan(Me.ucShapePainter, 2)
        Me.ucShapePainter.Size = New System.Drawing.Size(501, 501)
        Me.ucShapePainter.TabIndex = 2
        '
        'ShapeListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 701)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "ShapeListForm"
        Me.Text = "Shape List Form"
        Me.tlpMain.ResumeLayout(False)
        CType(Me.GvShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsShape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.flpShapeProps.ResumeLayout(False)
        Me.tlpCenter.ResumeLayout(False)
        CType(Me.TbX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpRadius1.ResumeLayout(False)
        CType(Me.TbRadius1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsEllipse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpRadius2.ResumeLayout(False)
        Me.tlpRadius2.PerformLayout()
        CType(Me.TbRadius2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEquil.ResumeLayout(False)
        CType(Me.TbSideLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsEquilateral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvVertice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsVertice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnImportCsv As Button
    Friend WithEvents GvShape As DataGridView
    Friend WithEvents BsShape As BindingSource
    Friend WithEvents ucShapePainter As ShapePainter
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tlpEquil As TableLayoutPanel
    Friend WithEvents lblCenterX As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbX As NumericUpDown
    Friend WithEvents BsCenter As BindingSource
    Friend WithEvents TbY As NumericUpDown
    Friend WithEvents ShapeType As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colColor As DataGridViewTextBoxColumn
    Friend WithEvents colOrientation As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerimeterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colDegrees As DataGridViewTextBoxColumn
    Friend WithEvents TbRadius2 As NumericUpDown
    Friend WithEvents BsEllipse As BindingSource
    Friend WithEvents TbRadius1 As NumericUpDown
    Friend WithEvents TbSideLength As NumericUpDown
    Friend WithEvents BsEquilateral As BindingSource
    Friend WithEvents flpShapeProps As FlowLayoutPanel
    Friend WithEvents tlpCenter As TableLayoutPanel
    Friend WithEvents tlpRadius1 As TableLayoutPanel
    Friend WithEvents tlpRadius2 As TableLayoutPanel
    Friend WithEvents GvVertice As DataGridView
    Friend WithEvents BsVertice As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents XDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PolygonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalArea As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalPerimeter As Label
    Friend WithEvents btnDelete As Button
End Class
