<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShapeSelectForm
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
        Me.FlowLayoutPanelButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelButtons
        '
        Me.FlowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelButtons.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanelButtons.Name = "FlowLayoutPanelButtons"
        Me.FlowLayoutPanelButtons.Size = New System.Drawing.Size(412, 30)
        Me.FlowLayoutPanelButtons.TabIndex = 0
        '
        'ShapeSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 30)
        Me.Controls.Add(Me.FlowLayoutPanelButtons)
        Me.Name = "ShapeSelectForm"
        Me.Text = "Select a Shape"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanelButtons As FlowLayoutPanel
End Class
