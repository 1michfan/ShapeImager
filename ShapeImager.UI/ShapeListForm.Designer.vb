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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnImportCsv = New System.Windows.Forms.Button()
        Me.gvShape = New System.Windows.Forms.DataGridView()
        Me.ShapeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CenterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrientationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerimeterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShapeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ucShapePainter = New ShapeImager.UI.ShapePainter()
        Me.tlpMain.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.gvShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShapeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.36145!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.63855!))
        Me.tlpMain.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.tlpMain.Controls.Add(Me.gvShape, 0, 1)
        Me.tlpMain.Controls.Add(Me.ucShapePainter, 1, 2)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.88235!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.11765!))
        Me.tlpMain.Size = New System.Drawing.Size(1054, 715)
        Me.tlpMain.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoSize = True
        Me.tlpMain.SetColumnSpan(Me.FlowLayoutPanel1, 2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnImportCsv)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1048, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnImportCsv
        '
        Me.btnImportCsv.Location = New System.Drawing.Point(3, 3)
        Me.btnImportCsv.Name = "btnImportCsv"
        Me.btnImportCsv.Size = New System.Drawing.Size(75, 23)
        Me.btnImportCsv.TabIndex = 0
        Me.btnImportCsv.Text = "Import CSV"
        Me.btnImportCsv.UseVisualStyleBackColor = True
        '
        'gvShape
        '
        Me.gvShape.AutoGenerateColumns = False
        Me.gvShape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvShape.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShapeType, Me.IdDataGridViewTextBoxColumn, Me.CenterDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.OrientationDataGridViewTextBoxColumn, Me.AreaDataGridViewTextBoxColumn, Me.PerimeterDataGridViewTextBoxColumn})
        Me.gvShape.DataSource = Me.ShapeBindingSource
        Me.gvShape.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvShape.Location = New System.Drawing.Point(3, 38)
        Me.gvShape.Name = "gvShape"
        Me.tlpMain.SetRowSpan(Me.gvShape, 2)
        Me.gvShape.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvShape.Size = New System.Drawing.Size(419, 674)
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
        '
        'CenterDataGridViewTextBoxColumn
        '
        Me.CenterDataGridViewTextBoxColumn.DataPropertyName = "Center"
        Me.CenterDataGridViewTextBoxColumn.Frozen = True
        Me.CenterDataGridViewTextBoxColumn.HeaderText = "Center"
        Me.CenterDataGridViewTextBoxColumn.Name = "CenterDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.Frozen = True
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'OrientationDataGridViewTextBoxColumn
        '
        Me.OrientationDataGridViewTextBoxColumn.DataPropertyName = "Orientation"
        Me.OrientationDataGridViewTextBoxColumn.Frozen = True
        Me.OrientationDataGridViewTextBoxColumn.HeaderText = "Orientation"
        Me.OrientationDataGridViewTextBoxColumn.Name = "OrientationDataGridViewTextBoxColumn"
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
        'ShapeBindingSource
        '
        Me.ShapeBindingSource.DataSource = GetType(ShapeImager.Data.Shape)
        '
        'ucShapePainter
        '
        Me.ucShapePainter.Location = New System.Drawing.Point(428, 111)
        Me.ucShapePainter.Name = "ucShapePainter"
        Me.ucShapePainter.Size = New System.Drawing.Size(601, 601)
        Me.ucShapePainter.TabIndex = 2
        '
        'ShapeListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 715)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "ShapeListForm"
        Me.Text = "Shape List Form"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.gvShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShapeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnImportCsv As Button
    Friend WithEvents gvShape As DataGridView
    Friend WithEvents ShapeBindingSource As BindingSource
    Friend WithEvents ucShapePainter As ShapePainter
    Friend WithEvents ShapeType As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CenterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrientationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerimeterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
