﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gvShape = New System.Windows.Forms.DataGridView()
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
        Me.ucShapePainter = New ShapeImager.UI.ShapePainter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCenterX = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbX = New System.Windows.Forms.NumericUpDown()
        Me.BsCenter = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbY = New System.Windows.Forms.NumericUpDown()
        Me.tlpMain.SuspendLayout()
        CType(Me.gvShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsShape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TbX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BsCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'gvShape
        '
        Me.gvShape.AutoGenerateColumns = False
        Me.gvShape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvShape.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShapeType, Me.IdDataGridViewTextBoxColumn, Me.colColor, Me.colOrientation, Me.AreaDataGridViewTextBoxColumn, Me.PerimeterDataGridViewTextBoxColumn, Me.colDegrees})
        Me.gvShape.DataSource = Me.BsShape
        Me.gvShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvShape.Location = New System.Drawing.Point(3, 38)
        Me.gvShape.Name = "gvShape"
        Me.gvShape.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvShape.Size = New System.Drawing.Size(503, 249)
        Me.gvShape.TabIndex = 1
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
        Me.FlowLayoutPanel1.AutoSize = True
        Me.tlpMain.SetColumnSpan(Me.FlowLayoutPanel1, 2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnImportCsv)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSaveChanges)
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
        Me.btnSaveChanges.Location = New System.Drawing.Point(97, 3)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveChanges.TabIndex = 1
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'ucShapePainter
        '
        Me.ucShapePainter.Location = New System.Drawing.Point(512, 38)
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
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 293)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 333.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 333)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblCenterX, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TbX, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TbY, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(245, 129)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lblCenterX
        '
        Me.lblCenterX.AutoSize = True
        Me.lblCenterX.Location = New System.Drawing.Point(3, 0)
        Me.lblCenterX.Name = "lblCenterX"
        Me.lblCenterX.Size = New System.Drawing.Size(48, 13)
        Me.lblCenterX.TabIndex = 0
        Me.lblCenterX.Text = "Center X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Center Y"
        '
        'TbX
        '
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
        'TbY
        '
        Me.TbY.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BsCenter, "Y", True))
        Me.TbY.DecimalPlaces = 4
        Me.TbY.Location = New System.Drawing.Point(125, 37)
        Me.TbY.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.TbY.Name = "TbY"
        Me.TbY.Size = New System.Drawing.Size(117, 20)
        Me.TbY.TabIndex = 6
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
        Me.tlpMain.PerformLayout()
        CType(Me.gvShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsShape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TbX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BsCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbY, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
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
End Class
