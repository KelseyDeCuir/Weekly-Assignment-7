<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cboKaraoke = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(346, 25)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(373, 53)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Karaoke Music Night"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHours
        '
        Me.lblHours.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHours.Location = New System.Drawing.Point(396, 197)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(286, 25)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hourly Rental of Karaoke Room:"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(514, 268)
        Me.txtHours.Multiline = True
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(48, 28)
        Me.txtHours.TabIndex = 3
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTotalCost
        '
        Me.btnTotalCost.BackColor = System.Drawing.Color.White
        Me.btnTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnTotalCost.ForeColor = System.Drawing.Color.Black
        Me.btnTotalCost.Location = New System.Drawing.Point(373, 334)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(148, 36)
        Me.btnTotalCost.TabIndex = 4
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = False
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.White
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearForm.ForeColor = System.Drawing.Color.Black
        Me.btnClearForm.Location = New System.Drawing.Point(550, 334)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(148, 36)
        Me.btnClearForm.TabIndex = 5
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(346, 424)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(373, 23)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "XXXXXXXXXXXXXXXXXXX"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboKaraoke
        '
        Me.cboKaraoke.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKaraoke.FormattingEnabled = True
        Me.cboKaraoke.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboKaraoke.Location = New System.Drawing.Point(373, 106)
        Me.cboKaraoke.Name = "cboKaraoke"
        Me.cboKaraoke.Size = New System.Drawing.Size(337, 23)
        Me.cboKaraoke.TabIndex = 7
        Me.cboKaraoke.Text = "Customize your Night"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Weekly_Assignment_7.My.Resources.Resources.karaoke
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 496)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(722, 477)
        Me.Controls.Add(Me.cboKaraoke)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnTotalCost)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents cboKaraoke As ComboBox
End Class
