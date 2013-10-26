<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOCR
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
		Me.lblFile = New System.Windows.Forms.Label()
		Me.tlpTextBoxAndImageBox = New System.Windows.Forms.TableLayoutPanel()
		Me.ibImage = New Emgu.CV.UI.ImageBox()
		Me.txtOCR = New System.Windows.Forms.TextBox()
		Me.txtFile = New System.Windows.Forms.TextBox()
		Me.btnFile = New System.Windows.Forms.Button()
		Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
		Me.tlpTextBoxAndImageBox.SuspendLayout
		CType(Me.ibImage,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblFile
		'
		Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblFile.Location = New System.Drawing.Point(0, 2)
		Me.lblFile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblFile.Name = "lblFile"
		Me.lblFile.Size = New System.Drawing.Size(96, 20)
		Me.lblFile.TabIndex = 0
		Me.lblFile.Text = "choose file:"
		Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'tlpTextBoxAndImageBox
		'
		Me.tlpTextBoxAndImageBox.ColumnCount = 1
		Me.tlpTextBoxAndImageBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
		Me.tlpTextBoxAndImageBox.Controls.Add(Me.ibImage, 0, 1)
		Me.tlpTextBoxAndImageBox.Controls.Add(Me.txtOCR, 0, 0)
		Me.tlpTextBoxAndImageBox.Location = New System.Drawing.Point(3, 23)
		Me.tlpTextBoxAndImageBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.tlpTextBoxAndImageBox.Name = "tlpTextBoxAndImageBox"
		Me.tlpTextBoxAndImageBox.RowCount = 2
		Me.tlpTextBoxAndImageBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35!))
		Me.tlpTextBoxAndImageBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65!))
		Me.tlpTextBoxAndImageBox.Size = New System.Drawing.Size(540, 410)
		Me.tlpTextBoxAndImageBox.TabIndex = 4
		'
		'ibImage
		'
		Me.ibImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibImage.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ibImage.Enabled = false
		Me.ibImage.Location = New System.Drawing.Point(2, 145)
		Me.ibImage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.ibImage.Name = "ibImage"
		Me.ibImage.Size = New System.Drawing.Size(536, 263)
		Me.ibImage.TabIndex = 2
		Me.ibImage.TabStop = false
		'
		'txtOCR
		'
		Me.txtOCR.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtOCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtOCR.Location = New System.Drawing.Point(2, 2)
		Me.txtOCR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtOCR.Multiline = true
		Me.txtOCR.Name = "txtOCR"
		Me.txtOCR.ReadOnly = true
		Me.txtOCR.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtOCR.Size = New System.Drawing.Size(536, 139)
		Me.txtOCR.TabIndex = 3
		'
		'txtFile
		'
		Me.txtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtFile.Location = New System.Drawing.Point(98, 0)
		Me.txtFile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtFile.Name = "txtFile"
		Me.txtFile.Size = New System.Drawing.Size(419, 25)
		Me.txtFile.TabIndex = 5
		'
		'btnFile
		'
		Me.btnFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnFile.Location = New System.Drawing.Point(518, 2)
		Me.btnFile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnFile.Name = "btnFile"
		Me.btnFile.Size = New System.Drawing.Size(24, 20)
		Me.btnFile.TabIndex = 6
		Me.btnFile.Text = "..."
		Me.btnFile.UseVisualStyleBackColor = true
		'
		'frmOCR
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(546, 435)
		Me.Controls.Add(Me.btnFile)
		Me.Controls.Add(Me.txtFile)
		Me.Controls.Add(Me.tlpTextBoxAndImageBox)
		Me.Controls.Add(Me.lblFile)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "frmOCR"
		Me.Text = "OCR Example"
		Me.tlpTextBoxAndImageBox.ResumeLayout(false)
		Me.tlpTextBoxAndImageBox.PerformLayout
		CType(Me.ibImage,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents tlpTextBoxAndImageBox As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ibImage As Emgu.CV.UI.ImageBox
    Friend WithEvents txtOCR As System.Windows.Forms.TextBox
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents ofdFile As System.Windows.Forms.OpenFileDialog

End Class
