<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXML
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtfilename = New System.Windows.Forms.TextBox
        Me.btncancel = New System.Windows.Forms.Button
        Me.btndownload = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filename"
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(65, 27)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(180, 20)
        Me.txtfilename.TabIndex = 1
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Image = Global.XML_Download.My.Resources.Resources.Cancel
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancel.Location = New System.Drawing.Point(150, 70)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 37)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btndownload
        '
        Me.btndownload.Enabled = False
        Me.btndownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndownload.Image = Global.XML_Download.My.Resources.Resources.Download
        Me.btndownload.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndownload.Location = New System.Drawing.Point(75, 70)
        Me.btndownload.Name = "btndownload"
        Me.btndownload.Size = New System.Drawing.Size(75, 37)
        Me.btndownload.TabIndex = 2
        Me.btndownload.Text = "Download"
        Me.btndownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndownload.UseVisualStyleBackColor = True
        '
        'frmXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 119)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndownload)
        Me.Controls.Add(Me.txtfilename)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(320, 151)
        Me.Name = "frmXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Download"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents btndownload As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
