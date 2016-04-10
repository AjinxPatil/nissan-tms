<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EmpEntryButton1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpDisButton1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.EmpEntryButton1)
        Me.Panel2.Location = New System.Drawing.Point(48, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 294)
        Me.Panel2.TabIndex = 1
        '
        'EmpEntryButton1
        '
        Me.EmpEntryButton1.BackColor = System.Drawing.Color.White
        Me.EmpEntryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpEntryButton1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEntryButton1.Location = New System.Drawing.Point(28, 23)
        Me.EmpEntryButton1.Name = "EmpEntryButton1"
        Me.EmpEntryButton1.Size = New System.Drawing.Size(142, 245)
        Me.EmpEntryButton1.TabIndex = 1
        Me.EmpEntryButton1.Text = "Add Employee"
        Me.EmpEntryButton1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.EmpDisButton1)
        Me.Panel1.Location = New System.Drawing.Point(361, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 294)
        Me.Panel1.TabIndex = 2
        '
        'EmpDisButton1
        '
        Me.EmpDisButton1.BackColor = System.Drawing.Color.White
        Me.EmpDisButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpDisButton1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDisButton1.Location = New System.Drawing.Point(17, 23)
        Me.EmpDisButton1.Name = "EmpDisButton1"
        Me.EmpDisButton1.Size = New System.Drawing.Size(161, 245)
        Me.EmpDisButton1.TabIndex = 0
        Me.EmpDisButton1.Text = "View Employee"
        Me.EmpDisButton1.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 334)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EmpEntryButton1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EmpDisButton1 As System.Windows.Forms.Button
End Class
